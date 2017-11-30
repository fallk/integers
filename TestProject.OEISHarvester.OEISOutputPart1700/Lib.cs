using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277871
{
public static readonly long[] Value={ 1L,4L,16L,66L,279L,1203L,5275L,23474L,105853L,483108L,2229253L,10390691L,48879588L,231879456L,1108473015L,5335987930L,25849521109L,125945214309L,616833862018L,3035286848660L,14999774773110L,74413424196360L,370463714276625L,1850251796668899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277871Inst : IEnumerable<long>
{
public static readonly long[] Value=A277871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277871.Bytes);
public long this[int i]=>Value[i];

public static A277871Inst Instance=new A277871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277870
{
public static readonly long[] Value={ 32L,52L,72L,84L,92L,112L,116L,132L,135L,148L,152L,160L,172L,180L,186L,192L,204L,212L,216L,232L,237L,244L,248L,252L,256L,260L,272L,276L,288L,292L,297L,308L,312L,316L,326L,332L,336L,339L,340L,352L,372L,378L,380L,384L,390L,392L,396L,404L,408L,412L,415L,424L,428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277870Inst : IEnumerable<long>
{
public static readonly long[] Value=A277870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277870.Bytes);
public long this[int i]=>Value[i];

public static A277870Inst Instance=new A277870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277869
{
public static readonly BigInteger[] Value={ 1L,1L,4L,38L,596L,13072L,368488L,12693536L,516718112L,24268858144L,1291777104256L,76845808729472L,5052555752407424L,363835557152535808L,BigInteger.Parse("28477850136037146112") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277869Inst Instance=new A277869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277868
{
public static readonly long[] Value={ 1L,1L,4L,35L,361L,4482L,68027L,1238841L,26416474L,646139853L,17837851021L,548713086352L,18612963869397L,690271321306101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277868Inst : IEnumerable<long>
{
public static readonly long[] Value=A277868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277868.Bytes);
public long this[int i]=>Value[i];

public static A277868Inst Instance=new A277868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277867
{
public static readonly long[] Value={ 1L,2L,4L,11L,16L,47L,64L,191L,256L,767L,1024L,3071L,4096L,12287L,16384L,49151L,65536L,196607L,262144L,786431L,1048576L,3145727L,4194304L,12582911L,16777216L,50331647L,67108864L,201326591L,268435456L,805306367L,1073741824L,3221225471L,4294967296L,12884901887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277867Inst : IEnumerable<long>
{
public static readonly long[] Value=A277867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277867.Bytes);
public long this[int i]=>Value[i];

public static A277867Inst Instance=new A277867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277866
{
public static readonly long[] Value={ 1L,1L,1L,13L,1L,61L,1L,253L,1L,1021L,1L,4093L,1L,16381L,1L,65533L,1L,262141L,1L,1048573L,1L,4194301L,1L,16777213L,1L,67108861L,1L,268435453L,1L,1073741821L,1L,4294967293L,1L,17179869181L,1L,68719476733L,1L,274877906941L,1L,1099511627773L,1L,4398046511101L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277866Inst : IEnumerable<long>
{
public static readonly long[] Value=A277866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277866.Bytes);
public long this[int i]=>Value[i];

public static A277866Inst Instance=new A277866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277865
{
public static readonly ulong[] Value={ 1L,10L,100L,1011L,10000L,101111L,1000000L,10111111L,100000000L,1011111111L,10000000000L,101111111111L,1000000000000L,10111111111111L,100000000000000L,1011111111111111L,10000000000000000L,101111111111111111L,1000000000000000000L,10111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277865Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A277865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277865.Bytes);
public ulong this[int i]=>Value[i];

public static A277865Inst Instance=new A277865Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277864
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1101L,1L,111101L,1L,11111101L,1L,1111111101L,1L,111111111101L,1L,11111111111101L,1L,1111111111111101L,1L,111111111111111101L,1L,11111111111111111101UL,1L,BigInteger.Parse("1111111111111111111101"),1L,BigInteger.Parse("111111111111111111111101"),1L,BigInteger.Parse("11111111111111111111111101"),1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277864Inst Instance=new A277864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277863
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,32L,82L,227L,629L,1840L,5456L,16701L,51939L,164688L,529070L,1722271L,5664786L,18813360L,62996841L,212533216L,721792751L,2466135364L,8471967927L,29249059281L,101440962284L,353289339914L,1235154230047L,4333718587339L,15255879756019L,53870521140911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277863Inst : IEnumerable<long>
{
public static readonly long[] Value=A277863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277863.Bytes);
public long this[int i]=>Value[i];

public static A277863Inst Instance=new A277863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277862
{
public static readonly long[] Value={ 1L,1L,2L,6L,18L,73L,308L,1484L,7492L,40010L,220676L,1253940L,7282316L,43096792L,259019070L,1577653196L,9720170360L,60492629435L,379820431422L,2403679290621L,15319255038074L,98255642978084L,633833391637128L,4110221883283079L,26781322507739916L,175268504233782739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277862Inst : IEnumerable<long>
{
public static readonly long[] Value=A277862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277862.Bytes);
public long this[int i]=>Value[i];

public static A277862Inst Instance=new A277862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277861
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,13L,32L,33L,34L,35L,36L,37L,38L,39L,40L,14L,15L,16L,42L,43L,44L,45L,46L,47L,48L,49L,50L,17L,18L,19L,21L,52L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277861Inst : IEnumerable<long>
{
public static readonly long[] Value=A277861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277861.Bytes);
public long this[int i]=>Value[i];

public static A277861Inst Instance=new A277861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277860
{
public static readonly BigInteger[] Value={ 0L,8L,720L,50400L,3220000L,196885920L,11756961216L,692835631488L,40536961717824L,2363784447147552L,137716866109432896L,8030173585594013568L,BigInteger.Parse("469162781054378536320"),BigInteger.Parse("27486632292027996114560"),BigInteger.Parse("1615617140290621588826880"),BigInteger.Parse("95302760085090826490672640") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277860Inst Instance=new A277860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277843
{
public static readonly BigInteger[] Value={ 1L,81L,9875766L,9508729532667775L,BigInteger.Parse("51400728418762283743166947873"),BigInteger.Parse("2412787002750586428934439397030434799264061139"),BigInteger.Parse("1497241493787657622590696899117249253525915361372369634716838093562"),BigInteger.Parse("17442838191172723332310678848004599133452884005515399679140805741625547114446168989072880538") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277843Inst Instance=new A277843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277842
{
public static readonly BigInteger[] Value={ 1L,81L,6064606L,1334647986999812L,BigInteger.Parse("970906913413864886205472630"),BigInteger.Parse("3914970565374711299589044295533654728633307"),BigInteger.Parse("133558404360787903168869516536280931557107488047811301767090944"),BigInteger.Parse("54745234941096457415294245370001308972451724232455240696557887565208148810995582605398") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277842Inst Instance=new A277842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277841
{
public static readonly BigInteger[] Value={ 1L,74L,1804128L,53512221536494L,BigInteger.Parse("2922627429145967591227933"),BigInteger.Parse("497730359833453928180319002991414602093"),BigInteger.Parse("403397426941463986598664115278880491308873007636372427413"),BigInteger.Parse("2209668743041973325985756217800328983151637526070225333484395817216844313778044") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277841Inst Instance=new A277841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277840
{
public static readonly BigInteger[] Value={ 1L,44L,142336L,244698934716L,BigInteger.Parse("347256965617453111707"),BigInteger.Parse("683647218221456315461840833799588"),BigInteger.Parse("2846969183281612697167894035560332610102537605107"),BigInteger.Parse("35612941825082950044316879351953518880328546726186269125209259942000"),BigInteger.Parse("1805164781998352977708541832242375664226097624365740577986086562708182817353463604362494621") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277840Inst Instance=new A277840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277839
{
public static readonly BigInteger[] Value={ 1L,7L,638L,7643021L,20762461502595L,BigInteger.Parse("19903050866658120066632"),BigInteger.Parse("10114722264843500593900485682759058"),BigInteger.Parse("3861169308385212945415179151162048048461447621051"),BigInteger.Parse("1493197448612892660867776325903488655508569676879420405667824079327") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277839Inst Instance=new A277839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277838
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4664L,58985L,713306L,8367628L,96021959L,1083676380L,12071331701L,133058996022L,1454046750343L,15775035404664L,170096033058985L,1824417120713306L,19478739108367627L,207133070096021958L,2194787491083676380L,BigInteger.Parse("23182442812071331701") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277838Inst Instance=new A277838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277837
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4664L,58985L,713307L,8367637L,96022049L,1083677281L,12071340713L,133059086145L,1454047651577L,15775044417009L,170096123182441L,1824418021947873L,19478748120713314L,207133160219478837L,2194788392318245180L,BigInteger.Parse("23182451824417019723") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277837Inst Instance=new A277837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277836
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4664L,58986L,713315L,8367717L,96022849L,1083685281L,12071420713L,133059886145L,1454055651577L,15775124417009L,170096923182441L,1824426021947881L,19478828120713394L,207133960219479637L,2194796392318253180L,BigInteger.Parse("23182531824417099723") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277836Inst Instance=new A277836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277835
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4665L,58993L,713385L,8368417L,96029849L,1083755281L,12072120713L,133066886145L,1454125651577L,15775824417009L,170103923182448L,1824496021947951L,19479528120714094L,207140960219486637L,2194866392318323180L,BigInteger.Parse("23183231824417799723") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277835Inst Instance=new A277835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277834
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,344L,4671L,59053L,713985L,8374417L,96089849L,1084355281L,12078120713L,133126886145L,1454725651577L,15781824417015L,170163923182508L,1825096021948551L,19485528120720094L,207200960219546637L,2195466392318923180L,BigInteger.Parse("23189231824423799723") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277834Inst Instance=new A277834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277833
{
public static readonly BigInteger[] Value={ 0L,0L,1L,23L,349L,4721L,59553L,718985L,8424417L,96589849L,1089355281L,12128120713L,133626886145L,1459725651582L,15831824417065L,170663923183008L,1830096021953551L,19535528120770094L,207700960220046637L,2200466392323923180L,BigInteger.Parse("23239231824473799723") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277833Inst Instance=new A277833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277832
{
public static readonly BigInteger[] Value={ 0L,0L,2L,27L,389L,5121L,63553L,758985L,8824417L,100589849L,1129355281L,12528120713L,137626886149L,1499725651622L,16231824417465L,174663923187008L,1870096021993551L,19935528121170094L,211700960224046637L,2240466392363923180L,BigInteger.Parse("23639231824873799723") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277832Inst Instance=new A277832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277831
{
public static readonly BigInteger[] Value={ 0L,1L,5L,57L,689L,8121L,93553L,1058985L,11824417L,130589849L,1429355281L,15528120716L,167626886179L,1799725651922L,19231824420465L,204663923217008L,2170096022293551L,22935528124170094L,241700960254046637L,2540466392663923180L,BigInteger.Parse("26639231827873799724") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277831Inst Instance=new A277831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277830
{
public static readonly BigInteger[] Value={ 1L,1L,2L,23L,344L,4665L,58986L,713307L,8367628L,96021949L,1083676270L,12071330591L,133058984912L,1454046639233L,15775034293554L,170096021947875L,1824417009602196L,19478737997256517L,207133058984910838L,2194787379972565159L,BigInteger.Parse("23182441700960219480") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277830Inst Instance=new A277830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277829
{
public static readonly BigInteger[] Value={ 1L,1L,9L,1035L,1686931L,40768984675L,14961837668926225L,BigInteger.Parse("84566159505295329041875"),BigInteger.Parse("7428544024130633312561150929275"),BigInteger.Parse("10204389867956705680354458767618278532475"),BigInteger.Parse("220168039594282987862502167563496178988004727093379"),BigInteger.Parse("74853381374809235976722939648065921771360016655877341808897465") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277829Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277829.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277829Inst Instance=new A277829Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277828
{
public static readonly long[] Value={ 1L,2L,5L,11L,23L,45L,90L,179L,357L,712L,1422L,2842L,5681L,11360L,22716L,45430L,90856L,181709L,363413L,726822L,1453640L,2907276L,5814546L,11629086L,23258166L,46516327L,93032647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277828Inst : IEnumerable<long>
{
public static readonly long[] Value=A277828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277828.Bytes);
public long this[int i]=>Value[i];

public static A277828Inst Instance=new A277828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277715
{
public static readonly long[] Value={ 9L,21L,45L,93L,189L,381L,657L,765L,873L,1317L,1533L,1749L,2457L,2637L,3069L,3501L,4329L,4917L,5241L,5277L,5745L,6141L,6345L,7005L,8661L,9561L,9837L,10017L,10485L,10557L,11493L,12285L,12693L,14013L,15129L,17325L,17985L,19125L,19677L,20037L,20973L,21117L,21969L,22989L,24573L,25389L,26793L,28029L,30261L,31545L,34653L,35973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277715Inst : IEnumerable<long>
{
public static readonly long[] Value=A277715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277715.Bytes);
public long this[int i]=>Value[i];

public static A277715Inst Instance=new A277715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277714
{
public static readonly long[] Value={ 1L,13L,25L,49L,69L,97L,137L,193L,273L,309L,385L,545L,617L,769L,829L,861L,973L,1089L,1233L,1301L,1537L,1657L,1721L,1945L,2177L,2465L,2601L,3073L,3313L,3441L,3613L,3889L,4353L,4929L,5201L,5333L,5965L,6145L,6625L,6765L,6881L,7225L,7777L,8705L,9857L,10401L,10665L,11109L,11461L,11929L,12289L,13249L,13529L,13761L,14449L,14749L,15553L,17197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277714Inst : IEnumerable<long>
{
public static readonly long[] Value=A277714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277714.Bytes);
public long this[int i]=>Value[i];

public static A277714Inst Instance=new A277714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277713
{
public static readonly long[] Value={ 3L,39L,75L,147L,207L,291L,411L,579L,819L,927L,1155L,1635L,1851L,2307L,2487L,2583L,2919L,3267L,3699L,3903L,4611L,4971L,5163L,5835L,6531L,7395L,7803L,9219L,9939L,10323L,10839L,11667L,13059L,14787L,15603L,15999L,17895L,18435L,19875L,20295L,20643L,21675L,23331L,26115L,29571L,31203L,31995L,33327L,34383L,35787L,36867L,39747L,40587L,41283L,43347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277713Inst : IEnumerable<long>
{
public static readonly long[] Value=A277713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277713.Bytes);
public long this[int i]=>Value[i];

public static A277713Inst Instance=new A277713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277712
{
public static readonly long[] Value={ 2L,10L,26L,58L,82L,122L,170L,250L,346L,418L,506L,562L,626L,698L,842L,1018L,1130L,1258L,1402L,1690L,1858L,2042L,2266L,2522L,2810L,3386L,3722L,4090L,4538L,5050L,5330L,5626L,6242L,6626L,6778L,7450L,7810L,8186L,9082L,9682L,10106L,10418L,10514L,10666L,11258L,11986L,12490L,13258L,13562L,14906L,15626L,16378L,17074L,18170L,19186L,19370L,19810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277712Inst : IEnumerable<long>
{
public static readonly long[] Value=A277712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277712.Bytes);
public long this[int i]=>Value[i];

public static A277712Inst Instance=new A277712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277711
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,6L,7L,8L,81L,18L,23L,12L,17L,14L,15L,16L,153L,162L,47L,36L,49L,46L,87L,24L,73L,34L,159L,28L,33L,30L,31L,32L,177L,306L,95L,324L,97L,94L,303L,72L,137L,98L,111L,92L,297L,174L,175L,48L,145L,146L,135L,68L,1257L,318L,295L,56L,321L,66L,143L,60L,65L,62L,63L,64L,273L,354L,191L,612L,193L,190L,1119L,648L,265L,194L,1335L,188L,1233L,606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277711Inst : IEnumerable<long>
{
public static readonly long[] Value=A277711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277711.Bytes);
public long this[int i]=>Value[i];

public static A277711Inst Instance=new A277711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277710
{
public static readonly long[] Value={ 1L,5L,2L,13L,10L,3L,29L,26L,39L,4L,41L,58L,75L,20L,9L,61L,82L,147L,52L,21L,6L,85L,122L,207L,116L,45L,78L,7L,125L,170L,291L,164L,93L,150L,11L,8L,173L,250L,411L,244L,189L,294L,19L,40L,81L,209L,346L,579L,340L,381L,414L,35L,104L,105L,18L,253L,418L,819L,500L,657L,582L,67L,232L,165L,42L,23L,281L,506L,927L,692L,765L,822L,131L,328L,213L,90L,43L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277710Inst : IEnumerable<long>
{
public static readonly long[] Value=A277710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277710.Bytes);
public long this[int i]=>Value[i];

public static A277710Inst Instance=new A277710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277709
{
public static readonly long[] Value={ 1L,2L,5L,3L,10L,13L,4L,39L,26L,29L,9L,20L,75L,58L,41L,6L,21L,52L,147L,82L,61L,7L,78L,45L,116L,207L,122L,85L,8L,11L,150L,93L,164L,291L,170L,125L,81L,40L,19L,294L,189L,244L,411L,250L,173L,18L,105L,104L,35L,414L,381L,340L,579L,346L,209L,23L,42L,165L,232L,67L,582L,657L,500L,819L,418L,253L,12L,43L,90L,213L,328L,131L,822L,765L,692L,927L,506L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277709Inst : IEnumerable<long>
{
public static readonly long[] Value=A277709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277709.Bytes);
public long this[int i]=>Value[i];

public static A277709Inst Instance=new A277709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277708
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,2L,7L,2L,1L,2L,11L,3L,13L,2L,3L,1L,17L,2L,19L,5L,3L,2L,23L,2L,1L,2L,3L,7L,29L,2L,31L,2L,3L,2L,5L,1L,37L,2L,3L,2L,41L,2L,43L,11L,5L,2L,47L,3L,1L,2L,3L,13L,53L,2L,5L,2L,3L,2L,59L,3L,61L,2L,7L,1L,5L,2L,67L,17L,3L,2L,71L,2L,73L,2L,3L,19L,7L,2L,79L,5L,1L,2L,83L,3L,5L,2L,3L,2L,89L,2L,7L,23L,3L,2L,5L,2L,97L,2L,11L,1L,101L,2L,103L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277708Inst : IEnumerable<long>
{
public static readonly long[] Value=A277708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277708.Bytes);
public long this[int i]=>Value[i];

public static A277708Inst Instance=new A277708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277707
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,1L,0L,1L,5L,2L,6L,1L,2L,0L,7L,1L,8L,3L,2L,1L,9L,1L,0L,1L,2L,4L,10L,1L,11L,1L,2L,1L,3L,0L,12L,1L,2L,1L,13L,1L,14L,5L,3L,1L,15L,2L,0L,1L,2L,6L,16L,1L,3L,1L,2L,1L,17L,2L,18L,1L,4L,0L,3L,1L,19L,7L,2L,1L,20L,1L,21L,1L,2L,8L,4L,1L,22L,3L,0L,1L,23L,2L,3L,1L,2L,1L,24L,1L,4L,9L,2L,1L,3L,1L,25L,1L,5L,0L,26L,1L,27L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277707Inst : IEnumerable<long>
{
public static readonly long[] Value=A277707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277707.Bytes);
public long this[int i]=>Value[i];

public static A277707Inst Instance=new A277707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277706
{
public static readonly long[] Value={ 5L,9L,10L,11L,13L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,29L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,61L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277706Inst : IEnumerable<long>
{
public static readonly long[] Value=A277706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277706.Bytes);
public long this[int i]=>Value[i];

public static A277706Inst Instance=new A277706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277705
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,4L,8L,2L,12L,6L,16L,4L,18L,8L,16L,2L,24L,12L,32L,6L,40L,16L,48L,4L,48L,18L,64L,8L,54L,16L,32L,2L,48L,24L,96L,12L,120L,32L,120L,6L,150L,40L,168L,16L,180L,48L,144L,4L,144L,48L,192L,18L,240L,64L,240L,8L,192L,54L,256L,16L,162L,32L,64L,2L,96L,48L,288L,24L,480L,96L,400L,12L,560L,120L,540L,32L,480L,120L,480L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277705Inst : IEnumerable<long>
{
public static readonly long[] Value=A277705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277705.Bytes);
public long this[int i]=>Value[i];

public static A277705Inst Instance=new A277705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277704
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,14L,15L,16L,24L,28L,30L,31L,32L,48L,56L,60L,62L,63L,64L,83L,96L,112L,120L,124L,126L,127L,128L,166L,192L,224L,240L,248L,252L,254L,255L,256L,332L,365L,384L,448L,480L,496L,504L,508L,510L,511L,512L,664L,730L,768L,896L,960L,992L,1008L,1016L,1020L,1022L,1023L,1024L,1328L,1460L,1536L,1792L,1920L,1984L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277704Inst : IEnumerable<long>
{
public static readonly long[] Value=A277704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277704.Bytes);
public long this[int i]=>Value[i];

public static A277704Inst Instance=new A277704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277703
{
public static readonly BigInteger[] Value={ 1L,2L,3L,6L,18L,30L,90L,270L,450L,630L,6750L,20250L,47250L,330750L,3543750L,4961250L,53156250L,57881250L,173643750L,1910081250L,9550406250L,455814843750L,3190703906250L,34186113281250L,245684200781250L,29727788294531250L,3310594605527343750L,BigInteger.Parse("158005651627441406250"),BigInteger.Parse("1738062167901855468750"),BigInteger.Parse("414764835522033691406250") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277703Inst Instance=new A277703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277702
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,9L,11L,13L,17L,19L,21L,27L,35L,37L,41L,43L,51L,53L,69L,73L,75L,83L,85L,107L,139L,147L,149L,165L,171L,213L,275L,277L,293L,299L,331L,339L,341L,427L,555L,587L,595L,597L,661L,677L,683L,853L,1107L,1109L,1171L,1173L,1189L,1195L,1323L,1355L,1363L,1365L,1707L,2213L,2219L,2347L,2379L,2387L,2389L,2645L,2709L,2731L,3413L,4427L,4435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277702Inst : IEnumerable<long>
{
public static readonly long[] Value=A277702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277702.Bytes);
public long this[int i]=>Value[i];

public static A277702Inst Instance=new A277702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277701
{
public static readonly long[] Value={ 1L,5L,13L,29L,41L,61L,85L,125L,173L,209L,253L,281L,313L,349L,421L,509L,565L,629L,701L,845L,929L,1021L,1133L,1261L,1405L,1693L,1861L,2045L,2269L,2525L,2665L,2813L,3121L,3313L,3389L,3725L,3905L,4093L,4541L,4841L,5053L,5209L,5257L,5333L,5629L,5993L,6245L,6629L,6781L,7453L,7813L,8189L,8537L,9085L,9593L,9685L,9905L,10109L,10421L,10517L,10669L,10921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277701Inst : IEnumerable<long>
{
public static readonly long[] Value=A277701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277701.Bytes);
public long this[int i]=>Value[i];

public static A277701Inst Instance=new A277701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277700
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,3L,2L,1L,3L,4L,1L,3L,2L,3L,1L,2L,3L,3L,2L,3L,1L,4L,3L,1L,4L,5L,1L,4L,3L,3L,2L,3L,3L,2L,1L,1L,2L,3L,3L,2L,3L,3L,2L,3L,3L,4L,1L,3L,4L,3L,3L,4L,1L,5L,4L,1L,5L,6L,1L,5L,4L,3L,3L,4L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,1L,2L,1L,3L,2L,1L,3L,4L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,4L,3L,3L,4L,3L,1L,2L,3L,3L,4L,3L,3L,4L,3L,3L,4L,5L,1L,4L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277700Inst : IEnumerable<long>
{
public static readonly long[] Value=A277700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277700.Bytes);
public long this[int i]=>Value[i];

public static A277700Inst Instance=new A277700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277683
{
public static readonly long[] Value={ 7L,8L,6L,3L,8L,6L,1L,1L,7L,6L,0L,9L,4L,2L,3L,2L,6L,6L,8L,8L,4L,2L,5L,7L,3L,6L,2L,3L,4L,8L,7L,3L,8L,2L,3L,2L,1L,4L,6L,8L,3L,2L,0L,2L,0L,7L,7L,7L,9L,8L,9L,3L,4L,6L,0L,2L,9L,4L,1L,4L,4L,5L,3L,0L,5L,7L,4L,5L,8L,5L,9L,2L,4L,3L,3L,2L,5L,2L,0L,4L,5L,8L,8L,8L,0L,1L,1L,0L,4L,5L,8L,7L,4L,9L,0L,6L,6L,4L,4L,6L,4L,0L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277683Inst : IEnumerable<long>
{
public static readonly long[] Value=A277683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277683.Bytes);
public long this[int i]=>Value[i];

public static A277683Inst Instance=new A277683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277682
{
public static readonly long[] Value={ 7L,5L,8L,8L,6L,3L,1L,1L,7L,8L,4L,7L,2L,5L,1L,2L,6L,2L,2L,5L,6L,8L,9L,2L,3L,9L,5L,4L,1L,0L,7L,5L,8L,4L,3L,8L,3L,0L,1L,3L,4L,7L,3L,6L,7L,1L,9L,9L,2L,8L,5L,6L,3L,6L,0L,4L,0L,9L,4L,3L,7L,4L,3L,7L,3L,6L,4L,3L,2L,2L,7L,5L,6L,0L,2L,3L,4L,0L,4L,8L,7L,2L,5L,0L,4L,7L,3L,3L,2L,7L,1L,5L,4L,7L,0L,5L,0L,1L,9L,3L,0L,5L,0L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277682Inst : IEnumerable<long>
{
public static readonly long[] Value=A277682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277682.Bytes);
public long this[int i]=>Value[i];

public static A277682Inst Instance=new A277682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277681
{
public static readonly long[] Value={ 2L,0L,6L,2L,2L,7L,7L,7L,2L,9L,5L,9L,8L,2L,8L,3L,8L,8L,4L,9L,7L,8L,4L,8L,6L,7L,2L,0L,0L,0L,8L,0L,4L,5L,9L,5L,1L,2L,8L,3L,5L,9L,2L,3L,0L,6L,7L,0L,4L,5L,9L,1L,6L,1L,3L,1L,0L,0L,9L,8L,4L,2L,0L,0L,0L,0L,4L,9L,4L,9L,8L,8L,0L,5L,3L,4L,8L,5L,2L,9L,5L,4L,7L,3L,7L,8L,9L,2L,4L,9L,9L,0L,0L,4L,2L,5L,3L,8L,6L,3L,3L,6L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277681Inst : IEnumerable<long>
{
public static readonly long[] Value=A277681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277681.Bytes);
public long this[int i]=>Value[i];

public static A277681Inst Instance=new A277681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277680
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,8L,4L,10L,9L,12L,13L,19L,7L,14L,15L,17L,11L,21L,18L,25L,26L,32L,16L,27L,20L,23L,24L,34L,33L,40L,28L,30L,22L,36L,35L,38L,41L,51L,31L,42L,43L,49L,39L,53L,50L,61L,62L,72L,29L,44L,45L,47L,37L,55L,48L,63L,64L,70L,46L,65L,52L,59L,60L,74L,73L,84L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277680Inst : IEnumerable<long>
{
public static readonly long[] Value=A277680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277680.Bytes);
public long this[int i]=>Value[i];

public static A277680Inst Instance=new A277680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277679
{
public static readonly long[] Value={ 1L,3L,2L,7L,4L,5L,13L,6L,9L,8L,17L,10L,11L,14L,15L,23L,16L,19L,12L,25L,18L,33L,26L,27L,20L,21L,24L,31L,49L,32L,39L,22L,29L,28L,35L,34L,53L,36L,43L,30L,37L,40L,41L,50L,51L,59L,52L,55L,42L,45L,38L,61L,44L,67L,54L,85L,68L,69L,62L,63L,46L,47L,56L,57L,60L,77L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277679Inst : IEnumerable<long>
{
public static readonly long[] Value=A277679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277679.Bytes);
public long this[int i]=>Value[i];

public static A277679Inst Instance=new A277679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277678
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,31L,1L,60L,4L,116L,12L,225L,30L,1L,437L,70L,5L,849L,158L,17L,1649L,351L,47L,1L,3202L,770L,118L,6L,6217L,1669L,283L,23L,12071L,3578L,664L,70L,1L,23438L,7599L,1535L,189L,7L,45510L,16016L,3500L,480L,30L,88368L,33545L,7876L,1182L,100L,1L,171586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277678Inst : IEnumerable<long>
{
public static readonly long[] Value=A277678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277678.Bytes);
public long this[int i]=>Value[i];

public static A277678Inst Instance=new A277678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277677
{
public static readonly long[] Value={ 0L,2L,1L,3L,4L,5L,7L,9L,121L,10L,21L,123L,125L,127L,129L,141L,11L,143L,13L,145L,1110L,23L,147L,15L,149L,17L,161L,19L,31L,163L,33L,35L,165L,37L,39L,167L,51L,53L,169L,55L,57L,181L,59L,71L,73L,183L,75L,77L,79L,185L,91L,93L,95L,187L,97L,99L,111L,25L,189L,113L,115L,321L,323L,325L,327L,329L,341L,117L,27L,343L,119L,29L,345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277677Inst : IEnumerable<long>
{
public static readonly long[] Value=A277677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277677.Bytes);
public long this[int i]=>Value[i];

public static A277677Inst Instance=new A277677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277676
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,60L,61L,62L,63L,65L,66L,67L,68L,69L,71L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277676Inst : IEnumerable<long>
{
public static readonly long[] Value=A277676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277676.Bytes);
public long this[int i]=>Value[i];

public static A277676Inst Instance=new A277676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277675
{
public static readonly long[] Value={ 1L,3L,7L,11L,15L,19L,24L,28L,33L,38L,43L,48L,54L,59L,64L,70L,75L,81L,87L,93L,98L,104L,110L,116L,122L,128L,135L,141L,147L,153L,159L,166L,172L,179L,185L,192L,198L,205L,211L,218L,224L,231L,238L,244L,251L,258L,265L,271L,278L,285L,292L,299L,306L,313L,320L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277675Inst : IEnumerable<long>
{
public static readonly long[] Value=A277675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277675.Bytes);
public long this[int i]=>Value[i];

public static A277675Inst Instance=new A277675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277674
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277674Inst : IEnumerable<long>
{
public static readonly long[] Value=A277674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277674.Bytes);
public long this[int i]=>Value[i];

public static A277674Inst Instance=new A277674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277673
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,136L,1547L,22012L,375231L,7445184L,168412696L,4275561136L,120338946469L,3718175865856L,125094920949797L,4551798150123456L,178094082550301368L,7455514741874966528L,BigInteger.Parse("332495821030327545527"),BigInteger.Parse("15737024371475868676864"),BigInteger.Parse("787813565550480151088691") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277673Inst Instance=new A277673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277672
{
public static readonly long[] Value={ 1L,9L,73L,592L,4801L,38935L,315754L,2560693L,20766637L,168412696L,1365788605L,11076234500L,89825738954L,728466283251L,5907695633935L,47910065991605L,388539722685585L,3150968653039294L,25553638078006016L,207234184444162395L,1680622033979603605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277672Inst : IEnumerable<long>
{
public static readonly long[] Value=A277672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277672.Bytes);
public long this[int i]=>Value[i];

public static A277672Inst Instance=new A277672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277671
{
public static readonly long[] Value={ 1L,8L,57L,406L,2892L,20600L,146736L,1045216L,7445184L,53032832L,377758463L,2690813426L,19166948203L,136528196220L,972504760052L,6927254109472L,49343562590512L,351479407373632L,2503624937520704L,17833584831080448L,127030508108889857L,904851724611169300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277671Inst : IEnumerable<long>
{
public static readonly long[] Value=A277671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277671.Bytes);
public long this[int i]=>Value[i];

public static A277671Inst Instance=new A277671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277670
{
public static readonly long[] Value={ 1L,7L,43L,264L,1621L,9953L,61112L,375231L,2303939L,14146313L,86859145L,533319959L,3274614074L,20106311704L,123453866991L,758013577995L,4654245334143L,28577324020619L,175466351588409L,1077373112945523L,6615130559166437L,40617267861064920L,249392273325801363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277670Inst : IEnumerable<long>
{
public static readonly long[] Value=A277670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277670.Bytes);
public long this[int i]=>Value[i];

public static A277670Inst Instance=new A277670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277669
{
public static readonly long[] Value={ 1L,6L,31L,160L,826L,4264L,22012L,113632L,586599L,3028182L,15632291L,80698096L,416585304L,2150525528L,11101591924L,57309407232L,295846593873L,1527239790702L,7884023093755L,40699450421136L,210101523661770L,1084600646648368L,5599000626972168L,28903549078371648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277669Inst : IEnumerable<long>
{
public static readonly long[] Value=A277669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277669.Bytes);
public long this[int i]=>Value[i];

public static A277669Inst Instance=new A277669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277668
{
public static readonly long[] Value={ 1L,5L,21L,88L,369L,1547L,6486L,27194L,114017L,478042L,2004299L,8403476L,35233470L,147724276L,619367372L,2596837513L,10887827441L,45649674187L,191396563242L,802473294131L,3364550422879L,14106637106664L,59145260271900L,247979854176461L,1039711513563070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277668Inst : IEnumerable<long>
{
public static readonly long[] Value=A277668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277668.Bytes);
public long this[int i]=>Value[i];

public static A277668Inst Instance=new A277668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277635
{
public static readonly long[] Value={ 0L,1L,22L,343L,4664L,58985L,713307L,8367637L,96022049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277635Inst : IEnumerable<long>
{
public static readonly long[] Value=A277635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277635.Bytes);
public long this[int i]=>Value[i];

public static A277635Inst Instance=new A277635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277634
{
public static readonly BigInteger[] Value={ 7L,127L,2147483647L,BigInteger.Parse("170141183460469231731687303715884105727") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277634Inst Instance=new A277634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277633
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,6L,9L,18L,30L,56L,98L,180L,311L,546L,915L,1520L,2440L,3855L,5916L,8935L,13178L,19138L,27264L,38303L,52950L,72311L,97419L,129839L,171066L,223260L,288498L,369708L,469708L,592363L,741433L,921933L,1138761L,1398343L,1706956L,2072696L,2503513L,3009482L,3600515L,4289032L,5087253L,6010305L,7073122L,8293962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277633Inst : IEnumerable<long>
{
public static readonly long[] Value=A277633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277633.Bytes);
public long this[int i]=>Value[i];

public static A277633Inst Instance=new A277633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277632
{
public static readonly long[] Value={ 1381L,2931L,5156L,58658L,70135L,79012L,89680L,106966L,152084L,171416L,197522L,212885L,266098L,295306L,400078L,434790L,675720L,789403L,863969L,866606L,917338L,936413L,1085618L,1149892L,1242687L,1432297L,1628115L,2116668L,2241911L,2250397L,2418925L,2694694L,2699343L,3022126L,3036895L,3059130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277632Inst : IEnumerable<long>
{
public static readonly long[] Value=A277632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277632.Bytes);
public long this[int i]=>Value[i];

public static A277632Inst Instance=new A277632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277631
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,6L,9L,18L,29L,51L,82L,135L,205L,315L,458L,662L,925L,1281L,1724L,2305L,3014L,3911L,4992L,6326L,7905L,9820L,12059L,14724L,17811L,21435L,25586L,30408L,35885L,42175L,49273L,57352L,66401L,76627L,88012L,100781L,114928L,130697L,148074L,167343L,188483L,211798L,237282L,265260L,295717L,329025L,365160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277631Inst : IEnumerable<long>
{
public static readonly long[] Value=A277631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277631.Bytes);
public long this[int i]=>Value[i];

public static A277631Inst Instance=new A277631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277630
{
public static readonly long[] Value={ 1L,5L,2352527L,193841707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277630Inst : IEnumerable<long>
{
public static readonly long[] Value=A277630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277630.Bytes);
public long this[int i]=>Value[i];

public static A277630Inst Instance=new A277630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277629
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,6L,9L,17L,26L,42L,62L,93L,130L,183L,246L,329L,428L,553L,698L,877L,1082L,1328L,1608L,1937L,2307L,2736L,3215L,3762L,4369L,5055L,5810L,6657L,7584L,8614L,9737L,10976L,12320L,13795L,15388L,17126L,18997L,21029L,23208L,25565L,28085L,30799L,33694L,36801L,40105L,43641L,47392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277629Inst : IEnumerable<long>
{
public static readonly long[] Value=A277629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277629.Bytes);
public long this[int i]=>Value[i];

public static A277629Inst Instance=new A277629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277628
{
public static readonly long[] Value={ 1L,3L,21L,936340943L,10460353197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277628Inst : IEnumerable<long>
{
public static readonly long[] Value=A277628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277628.Bytes);
public long this[int i]=>Value[i];

public static A277628Inst Instance=new A277628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277627
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,3L,1L,0L,0L,0L,0L,0L,1L,4L,1L,0L,0L,0L,0L,0L,0L,3L,5L,1L,0L,0L,0L,0L,0L,0L,0L,6L,6L,1L,0L,0L,0L,0L,0L,0L,0L,1L,10L,7L,1L,0L,0L,0L,0L,0L,0L,0L,0L,4L,15L,8L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,21L,9L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,20L,28L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277627Inst : IEnumerable<long>
{
public static readonly long[] Value=A277627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277627.Bytes);
public long this[int i]=>Value[i];

public static A277627Inst Instance=new A277627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277626
{
public static readonly long[] Value={ 1L,3L,15L,255L,65535L,4139059L,15734689L,66322477L,83623935L,4294967295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277626Inst : IEnumerable<long>
{
public static readonly long[] Value=A277626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277626.Bytes);
public long this[int i]=>Value[i];

public static A277626Inst Instance=new A277626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277625
{
public static readonly long[] Value={ 2L,3L,5L,8L,10L,12L,13L,17L,21L,26L,29L,33L,34L,37L,50L,55L,65L,70L,72L,82L,89L,101L,109L,122L,135L,144L,145L,169L,170L,197L,226L,228L,233L,257L,290L,305L,325L,357L,360L,362L,377L,401L,408L,442L,485L,528L,530L,577L,610L,626L,677L,701L,730L,747L,785L,842L,901L,962L,985L,987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277625Inst : IEnumerable<long>
{
public static readonly long[] Value=A277625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277625.Bytes);
public long this[int i]=>Value[i];

public static A277625Inst Instance=new A277625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277624
{
public static readonly long[] Value={ 22L,26L,34L,38L,46L,51L,57L,58L,62L,69L,74L,82L,86L,87L,93L,94L,106L,111L,116L,118L,122L,123L,124L,129L,134L,141L,142L,146L,148L,158L,159L,164L,166L,172L,177L,178L,183L,185L,188L,194L,201L,202L,205L,206L,212L,213L,214L,215L,218L,219L,226L,235L,236L,237L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277624Inst : IEnumerable<long>
{
public static readonly long[] Value=A277624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277624.Bytes);
public long this[int i]=>Value[i];

public static A277624Inst Instance=new A277624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277623
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,20L,22L,210L,10L,12L,7L,24L,26L,28L,212L,14L,16L,18L,9L,40L,42L,44L,46L,214L,30L,48L,32L,60L,101L,216L,34L,62L,36L,64L,38L,66L,50L,68L,80L,52L,82L,84L,54L,86L,88L,56L,200L,218L,58L,202L,230L,2010L,70L,204L,206L,72L,208L,220L,74L,222L,224L,76L,226L,228L,78L,240L,242L,90L,244L,246L,2012L,92L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277623Inst : IEnumerable<long>
{
public static readonly long[] Value=A277623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277623.Bytes);
public long this[int i]=>Value[i];

public static A277623Inst Instance=new A277623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277622
{
public static readonly long[] Value={ 110L,121L,131L,141L,151L,161L,171L,181L,191L,210L,220L,232L,242L,252L,262L,272L,282L,292L,310L,321L,330L,343L,353L,363L,373L,383L,393L,410L,420L,431L,440L,454L,464L,474L,484L,494L,510L,521L,532L,541L,550L,565L,575L,585L,595L,610L,620L,630L,642L,651L,660L,676L,686L,696L,710L,721L,731L,743L,752L,761L,770L,787L,797L,810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277622Inst : IEnumerable<long>
{
public static readonly long[] Value=A277622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277622.Bytes);
public long this[int i]=>Value[i];

public static A277622Inst Instance=new A277622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277621
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,1L,0L,5L,3L,5L,5L,13L,11L,11L,11L,13L,45L,105L,136L,105L,165L,332L,492L,501L,482L,684L,720L,1095L,1656L,3273L,3136L,3901L,4948L,6674L,7641L,15047L,12879L,17217L,38901L,75540L,37743L,73594L,84249L,88592L,207324L,403493L,710536L,922853L,662019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277621Inst : IEnumerable<long>
{
public static readonly long[] Value=A277621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277621.Bytes);
public long this[int i]=>Value[i];

public static A277621Inst Instance=new A277621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277620
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,15L,16L,18L,20L,22L,24L,25L,27L,30L,32L,33L,36L,40L,44L,45L,48L,50L,54L,55L,60L,64L,66L,72L,75L,80L,81L,88L,90L,96L,99L,100L,108L,110L,120L,121L,125L,128L,132L,135L,144L,150L,160L,162L,165L,176L,180L,192L,198L,200L,216L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277620Inst : IEnumerable<long>
{
public static readonly long[] Value=A277620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277620.Bytes);
public long this[int i]=>Value[i];

public static A277620Inst Instance=new A277620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277587
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,9L,7L,3L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277587Inst : IEnumerable<long>
{
public static readonly long[] Value=A277587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277587.Bytes);
public long this[int i]=>Value[i];

public static A277587Inst Instance=new A277587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277586
{
public static readonly long[] Value={ 1L,4L,22L,32L,488L,5408L,70544L,23552L,1202048L,22846976L,22850816L,40431616L,2628156416L,1576923136L,228655904768L,416962576384L,2362792902656L,7088385949696L,262270410489856L,52454094798848L,2150618140770304L,92476585387491328L,462382939977023488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277586Inst : IEnumerable<long>
{
public static readonly long[] Value=A277586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277586.Bytes);
public long this[int i]=>Value[i];

public static A277586Inst Instance=new A277586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277585
{
public static readonly long[] Value={ 1L,3L,15L,21L,315L,3465L,45045L,15015L,765765L,14549535L,14549535L,25741485L,1673196525L,1003917915L,145568097675L,265447707525L,1504203675975L,4512611027925L,166966608033225L,33393321606645L,1369126185872445L,58872425992515135L,294362129962575675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277585Inst : IEnumerable<long>
{
public static readonly long[] Value=A277585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277585.Bytes);
public long this[int i]=>Value[i];

public static A277585Inst Instance=new A277585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277584
{
public static readonly BigInteger[] Value={ 0L,1L,25L,784L,27225L,1002001L,38291344L,1502337600L,60101954649L,2440703175625L,100300325150025L,4161829109817600L,174077451630810000L,7330421677037621904L,BigInteger.Parse("310467090932230849600"),BigInteger.Parse("13214837914326197526784"),BigInteger.Parse("564927069263895118093401") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277584Inst Instance=new A277584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277583
{
public static readonly long[] Value={ 1L,4L,1L,10L,5L,2L,4L,14L,1L,12L,3L,2L,3L,9L,1L,31L,2L,1L,15L,7L,5L,6L,2L,3L,12L,20L,1L,19L,11L,2L,2L,5L,3L,4L,9L,1L,1L,15L,1L,54L,1L,1L,20L,4L,3L,12L,1L,6L,7L,3L,4L,11L,1L,2L,16L,10L,1L,22L,6L,2L,1L,3L,2L,3L,14L,1L,1L,9L,1L,2L,13L,1L,1L,2L,2L,17L,5L,1L,11L,28L,2L,7L,1L,10L,4L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277583Inst : IEnumerable<long>
{
public static readonly long[] Value=A277583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277583.Bytes);
public long this[int i]=>Value[i];

public static A277583Inst Instance=new A277583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277582
{
public static readonly long[] Value={ 1L,-1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,-1L,0L,1L,1L,-1L,0L,1L,1L,0L,1L,0L,0L,0L,-1L,1L,1L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,2L,2L,-1L,-1L,-1L,-1L,2L,-1L,1L,0L,-1L,0L,0L,-1L,0L,0L,-1L,-1L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,-1L,-1L,2L,-1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277582Inst : IEnumerable<long>
{
public static readonly long[] Value=A277582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277582.Bytes);
public long this[int i]=>Value[i];

public static A277582Inst Instance=new A277582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277581
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,5L,2L,4L,0L,1L,0L,3L,2L,3L,0L,1L,0L,2L,1L,15L,0L,5L,6L,2L,3L,12L,0L,1L,0L,11L,2L,2L,5L,3L,0L,9L,1L,1L,0L,1L,0L,1L,1L,20L,0L,3L,12L,1L,6L,7L,0L,4L,11L,1L,2L,16L,0L,1L,0L,6L,2L,1L,3L,2L,0L,14L,1L,1L,0L,1L,0L,13L,1L,1L,2L,2L,0L,5L,1L,11L,0L,2L,7L,1L,10L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277581Inst : IEnumerable<long>
{
public static readonly long[] Value=A277581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277581.Bytes);
public long this[int i]=>Value[i];

public static A277581Inst Instance=new A277581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277580
{
public static readonly long[] Value={ 8164079L,8421335L,21408695L,30071327L,47324639L,77350559L,103727519L,121538879L,134151479L,202767551L,239875559L,287432495L,306871487L,466861199L,560974259L,566019167L,574342145L,592557119L,594633599L,602758079L,677913599L,832477799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277580Inst : IEnumerable<long>
{
public static readonly long[] Value=A277580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277580.Bytes);
public long this[int i]=>Value[i];

public static A277580Inst Instance=new A277580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277579
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,3L,3L,4L,6L,7L,9L,13L,15L,19L,25L,31L,38L,48L,59L,74L,90L,111L,136L,166L,201L,246L,297L,357L,431L,522L,621L,745L,892L,1063L,1263L,1503L,1780L,2109L,2491L,2941L,3463L,4077L,4783L,5616L,6576L,7689L,8981L,10486L,12207L,14209L,16516L,19178L,22231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277579Inst : IEnumerable<long>
{
public static readonly long[] Value=A277579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277579.Bytes);
public long this[int i]=>Value[i];

public static A277579Inst Instance=new A277579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277578
{
public static readonly long[] Value={ 0L,1L,4L,2L,1750L,8771L,3L,5L,16L,14L,12L,10L,8L,6L,8765L,25L,1746L,1744L,23L,26353L,7L,9L,11L,13L,15L,17L,52L,50L,48L,46L,44L,42L,40L,38L,36L,34L,32L,30L,28L,26L,24L,22L,20L,18L,8745L,77L,1732L,5246L,75L,15800L,8741L,73L,26331L,8739L,71L,1728L,5242L,69L,15796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277578Inst : IEnumerable<long>
{
public static readonly long[] Value=A277578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277578.Bytes);
public long this[int i]=>Value[i];

public static A277578Inst Instance=new A277578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277577
{
public static readonly long[] Value={ 4L,7L,7L,6L,6L,6L,9L,8L,8L,8L,9L,8L,8L,7L,6L,9L,8L,8L,5L,8L,9L,8L,10L,9L,10L,9L,9L,9L,8L,10L,11L,8L,10L,7L,6L,8L,8L,11L,9L,7L,8L,9L,8L,10L,9L,10L,8L,7L,5L,8L,10L,6L,10L,5L,5L,10L,7L,9L,9L,9L,8L,12L,10L,8L,11L,10L,9L,10L,10L,9L,11L,11L,12L,8L,8L,11L,10L,9L,9L,10L,10L,10L,8L,7L,12L,10L,8L,8L,8L,7L,9L,6L,9L,11L,10L,11L,8L,11L,10L,11L,9L,10L,10L,9L,8L,10L,11L,11L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277577Inst : IEnumerable<long>
{
public static readonly long[] Value=A277577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277577.Bytes);
public long this[int i]=>Value[i];

public static A277577Inst Instance=new A277577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277576
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,15L,20L,26L,34L,43L,53L,63L,74L,86L,98L,111L,126L,142L,159L,177L,195L,214L,235L,258L,281L,305L,330L,356L,383L,411L,439L,468L,498L,530L,562L,595L,629L,663L,698L,734L,770L,807L,845L,883L,922L,962L,1003L,1045L,1087L,1130L,1174L,1218L,1263L,1309L,1356L,1404L,1453L,1502L,1552L,1603L,1654L,1706L,1759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277576Inst : IEnumerable<long>
{
public static readonly long[] Value=A277576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277576.Bytes);
public long this[int i]=>Value[i];

public static A277576Inst Instance=new A277576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277575
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,83L,97L,12161L,13681L,36467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277575Inst : IEnumerable<long>
{
public static readonly long[] Value=A277575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277575.Bytes);
public long this[int i]=>Value[i];

public static A277575Inst Instance=new A277575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277574
{
public static readonly long[] Value={ 2L,5L,8L,11L,12L,14L,17L,20L,23L,26L,29L,30L,32L,35L,38L,41L,44L,47L,48L,50L,53L,56L,59L,62L,65L,66L,68L,71L,72L,74L,77L,80L,83L,84L,86L,89L,92L,95L,98L,101L,102L,104L,107L,110L,113L,116L,119L,120L,122L,125L,128L,131L,134L,137L,138L,140L,143L,146L,149L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277574Inst : IEnumerable<long>
{
public static readonly long[] Value=A277574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277574.Bytes);
public long this[int i]=>Value[i];

public static A277574Inst Instance=new A277574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277573
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,11L,13L,15L,17L,18L,19L,21L,23L,25L,27L,29L,30L,31L,33L,35L,36L,37L,39L,41L,42L,43L,45L,47L,49L,51L,53L,54L,55L,57L,59L,61L,63L,65L,66L,67L,69L,71L,73L,75L,77L,78L,79L,81L,83L,85L,87L,89L,90L,91L,93L,95L,97L,99L,101L,102L,103L,105L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277573Inst : IEnumerable<long>
{
public static readonly long[] Value=A277573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277573.Bytes);
public long this[int i]=>Value[i];

public static A277573Inst Instance=new A277573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277572
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,13L,16L,19L,22L,24L,25L,28L,31L,34L,36L,37L,40L,42L,43L,46L,49L,52L,55L,58L,60L,61L,64L,67L,70L,73L,76L,78L,79L,82L,85L,88L,91L,94L,96L,97L,100L,103L,106L,109L,112L,114L,115L,118L,121L,124L,127L,130L,132L,133L,136L,139L,142L,144L,145L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277572Inst : IEnumerable<long>
{
public static readonly long[] Value=A277572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277572.Bytes);
public long this[int i]=>Value[i];

public static A277572Inst Instance=new A277572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277523
{
public static readonly long[] Value={ 2L,2L,2L,1L,4L,0L,2L,1L,3L,6L,0L,1L,2L,2L,2L,1L,2L,6L,5L,5L,1L,5L,5L,3L,7L,3L,8L,5L,9L,6L,8L,0L,0L,3L,0L,8L,9L,5L,9L,1L,0L,8L,9L,7L,2L,6L,8L,6L,2L,8L,1L,5L,1L,7L,3L,8L,4L,7L,4L,4L,7L,7L,9L,8L,7L,0L,2L,1L,3L,9L,6L,9L,1L,7L,4L,7L,8L,5L,5L,1L,9L,0L,3L,9L,7L,5L,7L,2L,6L,5L,4L,2L,4L,2L,7L,1L,7L,8L,8L,4L,5L,2L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277523Inst : IEnumerable<long>
{
public static readonly long[] Value=A277523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277523.Bytes);
public long this[int i]=>Value[i];

public static A277523Inst Instance=new A277523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277522
{
public static readonly long[] Value={ 5L,6L,9L,2L,4L,5L,2L,0L,4L,4L,2L,6L,3L,4L,8L,0L,6L,1L,0L,6L,5L,3L,3L,0L,4L,7L,7L,8L,4L,1L,9L,6L,6L,9L,0L,5L,2L,6L,3L,8L,6L,5L,9L,7L,3L,1L,4L,6L,3L,0L,2L,7L,6L,4L,5L,4L,9L,8L,0L,1L,1L,6L,7L,9L,1L,8L,3L,1L,1L,5L,4L,2L,1L,1L,3L,4L,6L,7L,0L,8L,7L,6L,2L,3L,2L,4L,0L,6L,7L,4L,8L,7L,9L,2L,6L,3L,5L,0L,2L,4L,5L,1L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277522Inst : IEnumerable<long>
{
public static readonly long[] Value=A277522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277522.Bytes);
public long this[int i]=>Value[i];

public static A277522Inst Instance=new A277522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277521
{
public static readonly long[] Value={ 1L,6L,30L,66L,102L,210L,270L,318L,330L,420L,462L,510L,546L,570L,642L,672L,690L,714L,840L,870L,924L,930L,966L,1122L,1320L,1410L,1428L,1518L,1590L,1638L,1722L,1770L,1890L,1932L,2130L,2226L,2280L,2310L,2346L,2370L,2670L,2730L,2760L,2838L,2970L,2982L,3102L,3162L,3210L,3360L,3444L,3486L,3498L,3570L,3720L,3780L,3948L,3990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277521Inst : IEnumerable<long>
{
public static readonly long[] Value=A277521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277521.Bytes);
public long this[int i]=>Value[i];

public static A277521Inst Instance=new A277521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277520
{
public static readonly long[] Value={ 1L,3L,25L,147L,1089L,20449L,48841L,312987L,55190041L,14322675L,100100025L,32065374675L,4546130625L,29873533563L,1859904071089L,4089135109921L,9399479144449L,22568149425822049L,1293753708921104809L,2835106739783283L,3289668853728536041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277520Inst : IEnumerable<long>
{
public static readonly long[] Value=A277520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277520.Bytes);
public long this[int i]=>Value[i];

public static A277520Inst Instance=new A277520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277519
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,20L,22L,21L,23L,24L,25L,26L,28L,27L,40L,42L,44L,29L,46L,48L,60L,62L,41L,43L,64L,45L,66L,68L,47L,80L,82L,84L,49L,86L,88L,200L,201L,61L,63L,202L,7L,204L,206L,65L,208L,203L,220L,9L,222L,224L,226L,10L,12L,14L,16L,18L,30L,205L,228L,207L,240L,242L,67L,244L,246L,69L,248L,260L,262L,32L,209L,264L,266L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277519Inst : IEnumerable<long>
{
public static readonly long[] Value=A277519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277519.Bytes);
public long this[int i]=>Value[i];

public static A277519Inst Instance=new A277519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277518
{
public static readonly long[] Value={ 0L,2L,1L,3L,4L,5L,7L,9L,10L,6L,11L,13L,15L,8L,17L,19L,31L,33L,21L,12L,35L,23L,14L,37L,39L,25L,16L,51L,53L,55L,27L,18L,57L,59L,71L,73L,29L,30L,41L,75L,32L,77L,43L,79L,34L,91L,93L,45L,95L,36L,97L,99L,110L,47L,111L,49L,113L,61L,115L,112L,114L,117L,38L,119L,131L,116L,133L,135L,63L,137L,118L,139L,151L,130L,65L,153L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277518Inst : IEnumerable<long>
{
public static readonly long[] Value=A277518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277518.Bytes);
public long this[int i]=>Value[i];

public static A277518Inst Instance=new A277518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277517
{
public static readonly long[] Value={ 2L,4L,3L,8L,6L,5L,4L,4L,4L,16L,12L,10L,8L,8L,8L,7L,6L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,32L,24L,20L,16L,16L,16L,14L,12L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,9L,8L,7L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277517Inst : IEnumerable<long>
{
public static readonly long[] Value=A277517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277517.Bytes);
public long this[int i]=>Value[i];

public static A277517Inst Instance=new A277517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277516
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,5L,4L,2L,6L,0L,4L,2L,1L,5L,4L,3L,0L,2L,4L,4L,3L,6L,5L,3L,1L,0L,2L,6L,4L,6L,4L,2L,3L,5L,4L,5L,0L,5L,4L,3L,1L,7L,6L,4L,7L,5L,4L,2L,4L,0L,7L,6L,7L,6L,4L,3L,7L,6L,5L,3L,1L,5L,4L,4L,0L,8L,7L,8L,7L,6L,4L,2L,5L,4L,2L,8L,7L,6L,4L,4L,9L,0L,5L,3L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277516Inst : IEnumerable<long>
{
public static readonly long[] Value=A277516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277516.Bytes);
public long this[int i]=>Value[i];

public static A277516Inst Instance=new A277516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}