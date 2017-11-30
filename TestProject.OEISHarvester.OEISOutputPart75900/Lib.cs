using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277328
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,2L,0L,0L,2L,2L,1L,1L,2L,3L,0L,0L,3L,3L,1L,1L,4L,4L,1L,1L,4L,4L,2L,2L,3L,4L,0L,0L,4L,4L,3L,2L,5L,6L,1L,1L,7L,6L,2L,3L,6L,6L,1L,1L,6L,6L,3L,3L,7L,7L,2L,2L,6L,6L,3L,3L,4L,5L,0L,0L,5L,5L,4L,4L,8L,8L,2L,2L,9L,9L,4L,4L,8L,9L,1L,1L,10L,9L,5L,5L,10L,11L,2L,2L,11L,10L,5L,6L,8L,8L,1L,1L,8L,8L,5L,4L,10L,11L,3L,3L,12L };
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
public class A277328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277328Inst : IEnumerable<long>
{
public static readonly long[] Value=A277328.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277328.Bytes);
public long this[int i]=>Value[i];

public static A277328Inst Instance=new A277328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277329
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,2L,3L,3L,4L,3L,3L,3L,4L,3L,4L,4L,5L,4L,4L,3L,4L,3L,4L,4L,5L,4L,4L,4L,5L,4L,5L,5L,6L,5L,5L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,5L,5L,6L,5L,5L,4L,5L,4L,5L,5L,6L,5L,5L,5L,6L,5L,6L,6L,7L,6L,6L,5L,6L,5L,5L,5L,6L,5L,5L,4L,5L,4L,5L,5L,6L,5L,5L,4L,5L,4L,5L,5L,6L,5L,5L,5L,6L,5L,6L,6L,7L,6L,6L,5L,6L,5L,5L,5L,6L,5L,5L,5L,6L,5L,6L,6L,7L,6L,6L,5L,6L,5L,6L,6L,7L };
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
public class A277329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277329Inst : IEnumerable<long>
{
public static readonly long[] Value=A277329.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277329.Bytes);
public long this[int i]=>Value[i];

public static A277329Inst Instance=new A277329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277330
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,2L,15L,30L,7L,10L,3L,30L,35L,2L,105L,210L,11L,70L,21L,30L,5L,10L,105L,42L,77L,70L,3L,210L,385L,2L,1155L,2310L,13L,770L,231L,30L,55L,70L,105L,6L,7L,2L,21L,42L,385L,10L,165L,66L,143L,110L,231L,210L,5L,70L,1155L,66L,1001L,770L,3L,2310L,5005L,2L,15015L,30030L,17L,10010L,3003L,30L,715L,770L,105L,66L,91L,154L,231L,6L,385L,70L,15L,42L,11L,14L,3L,42L,55L,2L };
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
public class A277330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277330Inst : IEnumerable<long>
{
public static readonly long[] Value=A277330.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277330.Bytes);
public long this[int i]=>Value[i];

public static A277330Inst Instance=new A277330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277331
{
public static readonly long[] Value={ 1L,2L,4L,8L,6L,16L,12L,18L,32L,24L,36L,54L,30L,64L,48L,72L,108L,60L,162L,90L,150L,128L,96L,144L,216L,120L,324L,180L,300L,486L,270L,450L,750L,210L,256L,192L,288L,432L,240L,648L,360L,600L,972L,540L,900L,1500L,420L,1458L,810L,1350L,2250L,630L,3750L,1050L,1470L,512L,384L,576L,864L,480L,1296L,720L,1200L,1944L,1080L,1800L,3000L,840L };
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
public class A277331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277331Inst : IEnumerable<long>
{
public static readonly long[] Value=A277331.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277331.Bytes);
public long this[int i]=>Value[i];

public static A277331Inst Instance=new A277331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277396
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,31L,163L,979L,6556L,48150L,383219L,3275121L,29841176L,288196506L,2936030427L,31425237185L,352166075233L,4119800015129L,50180781755797L,634948818421481L,8329111076372852L,113065244341635514L,1585699911447149109L,BigInteger.Parse("22942071009006046159") };
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
public class A277396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277396Inst Instance=new A277396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277397
{
public static readonly long[] Value={ 0L,1L,1000L,11110L,14638L,15628L,17170L,18217L,19305L,19999L,21649L,22320L,25234L,29041L,30195L,31428L };
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
public class A277397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277397Inst : IEnumerable<long>
{
public static readonly long[] Value=A277397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277397.Bytes);
public long this[int i]=>Value[i];

public static A277397Inst Instance=new A277397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277398
{
public static readonly long[] Value={ 1L,10000L,73440L,95120L,218510L,221220L,222220L,242900L,245610L,289970L,344070L };
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
public class A277398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277398Inst : IEnumerable<long>
{
public static readonly long[] Value=A277398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277398.Bytes);
public long this[int i]=>Value[i];

public static A277398Inst Instance=new A277398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277399
{
public static readonly long[] Value={ 0L,1L,100000L,1705330L,1818180L,1941030L,2046807L,2227770L,2285010L,2414880L,2598400L,2694600L,2727270L,2728270L,2758239L,2760940L,2857140L,2890810L,2979315L,3040660L,3085911L,3317050L,3541014L,3636460L,4543174L };
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
public class A277399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277399Inst : IEnumerable<long>
{
public static readonly long[] Value=A277399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277399.Bytes);
public long this[int i]=>Value[i];

public static A277399Inst Instance=new A277399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277400
{
public static readonly long[] Value={ 0L,1L,1000000L,20585070L,25104356L,25975583L,27483737L,27940490L,27941490L,28133416L,29069509L,32345773L,32482961L,32581773L,33332330L,34310934L,34676272L,35530163L,35707886L,36067139L,41716867L,42163087L,42568703L,44444440L,47745130L };
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
public class A277400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277400Inst : IEnumerable<long>
{
public static readonly long[] Value=A277400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277400.Bytes);
public long this[int i]=>Value[i];

public static A277400Inst Instance=new A277400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277401
{
public static readonly long[] Value={ 1L,5L,143L,1133L,2171L,8567L,16805L,208091L,1887043L,517295383L,878436591673L };
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
public class A277401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277401Inst : IEnumerable<long>
{
public static readonly long[] Value=A277401.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277401.Bytes);
public long this[int i]=>Value[i];

public static A277401Inst Instance=new A277401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277402
{
public static readonly long[] Value={ 1L,6L,19L,30L,61L,78L,127L,150L,217L,234L,331L,366L,469L,510L,631L,678L,817L,870L,1027L,1074L,1261L,1326L,1519L,1590L,1801L,1878L,2107L,2190L,2437L,2514L,2791L,2886L,3169L,3270L,3571L,3678L,3997L,4110L,4447L,4554L,4921L,5046L,5419L,5550L,5941L,6078L,6487L,6630L,7057L,7194L };
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
public class A277402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277402Inst : IEnumerable<long>
{
public static readonly long[] Value=A277402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277402.Bytes);
public long this[int i]=>Value[i];

public static A277402Inst Instance=new A277402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277403
{
public static readonly BigInteger[] Value={ 1L,2L,10L,90L,1190L,20930L,462070L,12326790L,386855630L,14000898310L,575440398330L,26532920708070L,1358954912773010L,76682330257445570L,4734315243483414890L,BigInteger.Parse("317932511564758225170"),BigInteger.Parse("23106045191162625194230"),BigInteger.Parse("1809303767549542227341490"),BigInteger.Parse("152057767850058496005946030"),BigInteger.Parse("13668688227104664304597942910"),BigInteger.Parse("1310201986290043690952261887230"),BigInteger.Parse("133552478071366935949713096470670"),BigInteger.Parse("14440878313638992240490923468851610") };
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
public class A277403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277403Inst Instance=new A277403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277404
{
public static readonly BigInteger[] Value={ 1L,4L,36L,508L,10020L,253804L,7853076L,287078908L,12106864260L,578586544204L,30901130685876L,1823983173981148L,117911755067635620L,8284976875099852204L,BigInteger.Parse("628692318063511556436"),BigInteger.Parse("51240154266491883376828"),BigInteger.Parse("4464155216699369664399300"),BigInteger.Parse("414013560595951627772296204"),BigInteger.Parse("40722939746084736801890208756") };
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
public class A277404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277404Inst Instance=new A277404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277405
{
public static readonly BigInteger[] Value={ 1L,5L,40L,524L,10776L,327732L,13920096L,788050944L,57348311040L,5215111879680L,579420628853760L,77220215372770560L,12157472554474222080UL,BigInteger.Parse("2232192933566250681600"),BigInteger.Parse("472721150641130889523200"),BigInteger.Parse("114371049117960857921126400"),BigInteger.Parse("31350167446592485414541721600"),BigInteger.Parse("9664519305841281076219121664000"),BigInteger.Parse("3328880054333616589332111409152000"),BigInteger.Parse("1273663039174670323519439513960448000") };
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
public class A277405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277405Inst Instance=new A277405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277406
{
public static readonly BigInteger[] Value={ 1L,2L,9L,76L,1100L,25176L,846132L,39321696L,2413753344L,189030205440L,18383301319680L,2172771551093760L,306662748175330560L,BigInteger.Parse("50933260598106862080"),BigInteger.Parse("9832247390118248121600"),BigInteger.Parse("2182733403365330313523200"),BigInteger.Parse("552134185815355910465126400"),BigInteger.Parse("157863713952139655599757721600"),BigInteger.Parse("50654908373638564216229105664000") };
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
public class A277406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277406Inst Instance=new A277406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277407
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,220L,4196L,120876L,4915212L,268194816L,18903020544L,1671209210880L,181064295924480L,23589442167333120L,3638090042721918720L,BigInteger.Parse("655483159341216541440"),BigInteger.Parse("136420837710333144595200"),BigInteger.Parse("32478481518550347674419200"),BigInteger.Parse("8770206330674425311097651200"),BigInteger.Parse("2666047809138871800854163456000"),BigInteger.Parse("906320525390421790143785781657600"),BigInteger.Parse("342508343836409428996994343026688000") };
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
public class A277407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277407Inst Instance=new A277407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277408
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,12L,22L,36L,24L,60L,140L,300L,576L,120L,360L,1020L,2700L,6576L,14400L,720L,2520L,8400L,26460L,77952L,211680L,518400L,5040L,20160L,77280L,282240L,974736L,3151680L,9408960L,25401600L,40320L,181440L,786240L,3265920L,12930624L,48444480L,170098560L,552303360L,1625702400L,362880L,1814400L,8769600L,40824000L,182226240L,775656000L,3126297600L,11820816000L,41391544320L,131681894400L,3628800L,19958400L,106444800L,548856000L,2726317440L,12989592000L,59044550400L,254303280000L,1028448368640L,3856920883200L,13168189440000L,39916800L,239500800L,1397088000L,7903526400L,43233886080L,227885011200L,1152535824000L,5563643500800L,25464033745920L,109530230261760L,437429486592000L,1593350922240000L };
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
public class A277408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277408Inst : IEnumerable<long>
{
public static readonly long[] Value=A277408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277408.Bytes);
public long this[int i]=>Value[i];

public static A277408Inst Instance=new A277408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277409
{
public static readonly BigInteger[] Value={ 1L,1L,2L,37L,13921L,207504608L,193499235977786L,BigInteger.Parse("16390183551007874514674"),BigInteger.Parse("173238206541606827885872411575542"),BigInteger.Parse("300679807333480520851459179939426369369129736"),BigInteger.Parse("109110688416565628491410454990885244124132946665282604804584"),BigInteger.Parse("10269686361506102165964632192322962717141565478713927846953403915348531319392"),BigInteger.Parse("304583662721691547994723721287871614789227410136168948343531184046989057630321931742841867554016") };
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
public class A277409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277409Inst Instance=new A277409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277410
{
public static readonly long[] Value={ 1L,1L,0L,1L,3L,0L,1L,13L,15L,0L,1L,38L,165L,105L,0L,1L,94L,1033L,2310L,945L,0L,1L,213L,4953L,26229L,36330L,10395L,0L,1L,459L,20370L,213511L,674520L,640710L,135135L,0L,1L,960L,76056L,1421225L,8559675L,18127935L,12588345L,2027025L,0L,1L,1972L,266334L,8283234L,85654979L,337805535L,515903850L,273544425L,34459425L,0L,1L,4007L,892542L,44013478L,729292193L,4822487682L,13506364410L,15631793100L,6529047525L,654729075L,0L };
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
public class A277410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277410Inst : IEnumerable<long>
{
public static readonly long[] Value=A277410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277410.Bytes);
public long this[int i]=>Value[i];

public static A277410Inst Instance=new A277410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277411
{
public static readonly long[] Value={ 0L,3L,13L,38L,94L,213L,459L,960L,1972L,4007L,8089L,16266L,32634L,65385L,130903L,261956L,524080L,1048347L,2096901L,4194030L,8388310L,16776893L,33554083L,67108488L,134217324L,268435023L,536870449L,1073741330L,2147483122L,4294966737L,8589933999L,17179868556L,34359737704L,68719476035L,137438952733L,274877906166L,549755813070L,1099511626917L,2199023254651L,4398046510160L };
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
public class A277411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277411Inst : IEnumerable<long>
{
public static readonly long[] Value=A277411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277411.Bytes);
public long this[int i]=>Value[i];

public static A277411Inst Instance=new A277411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277476
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,40L,340L,3936L,56714L,976704L,19535688L,444743680L,11349643822L,320813048832L,9947821243100L,335700998830848L,12246806941654770L,480247532548624384L,BigInteger.Parse("20144008859005187344"),BigInteger.Parse("899923326921333301248"),BigInteger.Parse("42658767419625168409814"),BigInteger.Parse("2138475182252830504796160") };
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
public class A277476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277476Inst Instance=new A277476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277477
{
public static readonly BigInteger[] Value={ 0L,1L,2L,6L,52L,540L,6846L,104832L,1883848L,38889360L,907247770L,23608391840L,678039307452L,21305543325248L,727095737061526L,26781816978470400L,1059020025979194128L,BigInteger.Parse("44746083421419997440"),BigInteger.Parse("2011929587198990154162"),BigInteger.Parse("95918808101232854969856") };
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
public class A277477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277477Inst Instance=new A277477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277478
{
public static readonly BigInteger[] Value={ 0L,1L,2L,12L,76L,720L,8766L,131096L,2319416L,47361600L,1096018330L,28344108672L,810053677764L,25352185339520L,862335856149782L,31674845755622400L,1249527587684729584L,BigInteger.Parse("52687201308036059136"),BigInteger.Parse("2364751154207006978994"),BigInteger.Parse("112562199977955164819456") };
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
public class A277478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277478Inst Instance=new A277478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277479
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,44L,360L,4206L,59584L,1021432L,20329344L,461596090L,11756157952L,331835099364L,10278341179392L,346555737301606L,12633922368061440L,495139124241620080L,BigInteger.Parse("20758413862397509632"),BigInteger.Parse("926980786260912379122"),BigInteger.Parse("43925328338613823078400"),BigInteger.Parse("2201264843743619567644700") };
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
public class A277479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277479Inst Instance=new A277479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277480
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,28L,280L,3486L,50624L,877080L,17677440L,404537050L,10360548352L,293676213876L,9126971869184L,308568877413174L,11274243944693760L,442681525701106096L,BigInteger.Parse("18588860836606935040"),BigInteger.Parse("831243363178769061426"),BigInteger.Parse("39436124829328468606976"),BigInteger.Parse("1978382154057910059275340") };
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
public class A277480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277480Inst Instance=new A277480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277481
{
public static readonly BigInteger[] Value={ 0L,0L,2L,3L,32L,240L,3114L,44065L,777720L,15582168L,357427770L,9151281293L,259607392164L,8070381333872L,272960010908662L,9976300661919345L,391837137436921072L,16458193396472517328UL,BigInteger.Parse("736145006794621566642"),BigInteger.Parse("34932117830021859779517"),BigInteger.Parse("1752782822664497750549660") };
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
public class A277481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277481.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277481Inst Instance=new A277481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277482
{
public static readonly BigInteger[] Value={ 0L,0L,2L,9L,56L,480L,5394L,75775L,1280376L,25270056L,569899770L,14444562803L,406204015524L,12545427045008L,422007399953398L,15354968442741135L,600807449737710832L,BigInteger.Parse("25153741340051795248"),BigInteger.Parse("1121917008608064151218"),BigInteger.Parse("53107023489332468636739"),BigInteger.Parse("2658946993059795072656540") };
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
public class A277482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277482Inst Instance=new A277482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277483
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,40L,340L,3984L,57050L,982528L,19616328L,446355840L,11384327438L,321701896704L,9973046260060L,336499112011776L,12274383608508450L,481282311712489472L,BigInteger.Parse("20185816487436968208"),BigInteger.Parse("901732370496365076480"),BigInteger.Parse("42742176871086712813974"),BigInteger.Parse("2142556308913381810012160") };
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
public class A277483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277483.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277483Inst Instance=new A277483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277484
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,32L,300L,3624L,52570L,908928L,18277560L,417634080L,10682763278L,302517156864L,9394763009060L,317429118686848L,11592017133950370L,454961391572119552L,BigInteger.Parse("19097430979664893168"),BigInteger.Parse("853711115246721262080"),BigInteger.Parse("40490675416206345889686"),BigInteger.Parse("2030782746261324446228480") };
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
public class A277484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277484Inst Instance=new A277484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277485
{
public static readonly BigInteger[] Value={ 0L,1L,6L,33L,216L,1865L,21228L,303765L,5222864L,104540337L,2383558740L,60933722069L,1725392415288L,53590463856345L,1811281159509500L,66172416761172885L,2598298697830360992L,BigInteger.Parse("109116931783034360801"),BigInteger.Parse("4880122696811960470692"),BigInteger.Parse("231565260558289051906965") };
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
public class A277485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277485Inst Instance=new A277485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277486
{
public static readonly long[] Value={ 1L,2L,0L,2L,2L,2L,0L,2L,1L,2L,1L,3L,1L,3L,1L,3L,3L,2L,3L,3L,5L,4L,1L,4L,3L,4L,2L,4L,4L,2L,4L,4L,4L,3L,3L,4L,3L,4L,5L,5L,5L,4L,4L,6L,6L,3L,3L,9L,4L,5L,6L,9L,4L,6L,4L,4L,8L,6L,5L,7L,5L,9L,5L,5L,7L,8L,6L,11L,5L,9L,4L,7L,9L,9L,6L,10L,5L,5L,17L,4L,10L,9L,10L,7L,3L,3L,10L,8L,7L,10L,6L,9L,5L,10L,10L,10L,8L,11L,6L,9L,10L,7L,7L,7L,7L,12L,9L,11L,13L,9L,12L,6L,10L,9L,6L };
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
public class A277486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277486Inst : IEnumerable<long>
{
public static readonly long[] Value=A277486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277486.Bytes);
public long this[int i]=>Value[i];

public static A277486Inst Instance=new A277486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277487
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,2L,1L,1L,0L,2L,1L,2L,0L,3L,2L,0L,3L,0L,2L,0L,1L,4L,2L,3L,2L,4L,2L,0L,3L,3L,2L,5L,3L,4L,3L,3L,3L,2L,4L,2L,2L,4L,3L,3L,3L,6L,3L,1L,3L,4L,2L,6L,3L,3L,2L,5L,5L,5L,5L,4L,3L,7L,4L,4L,6L,4L,2L,4L,6L,5L,5L,5L,4L,7L,4L,4L,7L,4L,0L,5L,6L,7L,4L,4L,9L,4L,5L,2L,6L,6L,7L,11L,3L,6L,4L,9L,5L,7L,7L,7L,6L,8L,8L,7L,6L,4L,6L,5L,7L,8L,5L,9L,8L,8L,5L,12L,7L,5L,6L };
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
public class A277487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277487Inst : IEnumerable<long>
{
public static readonly long[] Value=A277487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277487.Bytes);
public long this[int i]=>Value[i];

public static A277487Inst Instance=new A277487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277488
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,1L,0L,3L,2L,3L,2L,1L,1L,2L,1L,3L,2L,3L,1L,2L,4L,4L,1L,2L,3L,2L,2L,3L,4L,3L,3L,4L,3L,4L,3L,2L,4L,5L,5L,4L,4L,3L,4L,5L,4L,4L,3L,4L,6L,4L,6L,8L,4L,4L,3L,5L,7L,3L,7L,2L,6L,6L,4L,7L,7L,4L,5L,7L,4L,8L,6L,4L,4L,3L,6L,11L,4L,5L,5L,9L,6L,3L,6L,7L,6L,9L,9L,8L,11L,6L,5L,5L,7L,8L,7L,7L,5L,8L,9L,5L,7L,6L,5L,6L,7L,6L,8L,9L,6L,9L,6L,15L,8L,10L,9L,7L,10L,6L,6L,10L };
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
public class A277488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277488Inst : IEnumerable<long>
{
public static readonly long[] Value=A277488.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277488.Bytes);
public long this[int i]=>Value[i];

public static A277488Inst Instance=new A277488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277489
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,26L,224L,2244L,28496L,417976L,7122384L,136770960L,2937770472L,69626588976L,1806936836184L,50936933449752L,1550292926398680L,50661309325357824L,1769286989373994752L,BigInteger.Parse("65762170385201959680"),BigInteger.Parse("2591979585702305271552"),BigInteger.Parse("107982615297265761991680") };
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
public class A277489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277489Inst Instance=new A277489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277490
{
public static readonly BigInteger[] Value={ -1L,0L,2L,12L,72L,520L,5040L,67284L,1156736L,23655888L,549676800L,14216252380L,405068387328L,12624364306008L,427599019108352L,15646376279614500L,615155126821355520L,BigInteger.Parse("25861820048469628576"),BigInteger.Parse("1157706908035331457024"),BigInteger.Parse("54977324662490442177708"),BigInteger.Parse("2760439046217459138560000") };
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
public class A277490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277490Inst Instance=new A277490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277491
{
public static readonly BigInteger[] Value={ 1L,12L,120L,1128L,10344L,93864L,847848L,7642920L,68835432L,619715496L,5578225896L,50207178792L,451877192040L,4066945060008L,36602706866664L,329425167106344L,2964829725182568L,26683480411545000L,240151375243512552L,2161362583350043176L,BigInteger.Parse("19452264074784109416") };
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
public class A277491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277491Inst Instance=new A277491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277540
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,480L,5094L,65534L,984808L,16992144L,327038880L,6951172272L,160900135032L,4030551570864L,108477114581640L,3122444423175240L,95686679702270784L,3110711057099693568L,BigInteger.Parse("106921473349790826432"),BigInteger.Parse("3874480434910990168128"),BigInteger.Parse("147622208056015906586880") };
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
public class A277540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277540Inst Instance=new A277540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277541
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,480L,5094L,65534L,984808L,16992144L,330667680L,7130797872L,168564160632L,4321664793264L,119356965323400L,3528831476247240L,111173720474673984L,3716755785886791168L,BigInteger.Parse("131414199676568655552"),BigInteger.Parse("4899052003032070987968"),BigInteger.Parse("192050612714621129114880") };
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
public class A277541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277541Inst Instance=new A277541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277542
{
public static readonly long[] Value={ 1L,2L,27L,32L,125L,27L,343L,256L,729L,250L,1331L,864L,2197L,343L,3375L,2048L,4913L,1458L,6859L,4000L,9261L,1331L,12167L,6912L,15625L,4394L,19683L,10976L,24389L,3375L,29791L,16384L,35937L,9826L,42875L,23328L,50653L,6859L,59319L,32000L,68921L,18522L,79507L };
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
public class A277542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277542Inst : IEnumerable<long>
{
public static readonly long[] Value=A277542.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277542.Bytes);
public long this[int i]=>Value[i];

public static A277542Inst Instance=new A277542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277543
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,1L,2L,3L,4L,3L,1L,2L,3L,4L,4L,1L,2L,3L,4L,1L,1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,1L,2L,3L,4L,3L,1L,2L,3L,4L,4L,1L,2L,3L,4L,2L,1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,1L,2L,3L,4L,3L,1L,2L,3L,4L,4L,1L,2L,3L,4L,3L,1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,1L };
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
public class A277543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277543Inst : IEnumerable<long>
{
public static readonly long[] Value=A277543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277543.Bytes);
public long this[int i]=>Value[i];

public static A277543Inst Instance=new A277543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277544
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,2L,1L,2L,3L,4L,5L,3L,1L,2L,3L,4L,5L,4L,1L,2L,3L,4L,5L,5L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,2L,1L,2L,3L,4L,5L,3L,1L,2L,3L,4L,5L,4L,1L,2L,3L,4L,5L,5L,1L,2L,3L,4L,5L,2L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,2L,1L,2L };
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
public class A277544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277544Inst : IEnumerable<long>
{
public static readonly long[] Value=A277544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277544.Bytes);
public long this[int i]=>Value[i];

public static A277544Inst Instance=new A277544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277545
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,2L,1L,2L,3L,4L,5L,6L,3L,1L,2L,3L,4L,5L,6L,4L,1L,2L,3L,4L,5L,6L,5L,1L,2L,3L,4L,5L,6L,6L,1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,2L,1L,2L,3L,4L,5L,6L,3L,1L,2L,3L,4L,5L,6L,4L,1L,2L,3L,4L,5L,6L,5L,1L,2L };
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
public class A277545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277545Inst : IEnumerable<long>
{
public static readonly long[] Value=A277545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277545.Bytes);
public long this[int i]=>Value[i];

public static A277545Inst Instance=new A277545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277546
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,2L,1L,2L,3L,4L,5L,6L,7L,3L,1L,2L,3L,4L,5L,6L,7L,4L,1L,2L,3L,4L,5L,6L,7L,5L,1L,2L,3L,4L,5L,6L,7L,6L,1L,2L,3L,4L,5L,6L,7L,7L,1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,2L,1L,2L,3L,4L,5L,6L };
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
public class A277546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277546Inst : IEnumerable<long>
{
public static readonly long[] Value=A277546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277546.Bytes);
public long this[int i]=>Value[i];

public static A277546Inst Instance=new A277546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277547
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,1L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,2L,3L,4L,5L,6L,7L,8L,3L,1L,2L,3L,4L,5L,6L,7L,8L,4L,1L,2L,3L,4L,5L,6L,7L,8L,5L,1L,2L,3L,4L,5L,6L,7L,8L,6L,1L,2L,3L,4L,5L,6L,7L,8L,7L,1L,2L,3L,4L,5L,6L,7L,8L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,1L,2L,3L,4L,5L };
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
public class A277547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277547Inst : IEnumerable<long>
{
public static readonly long[] Value=A277547.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277547.Bytes);
public long this[int i]=>Value[i];

public static A277547Inst Instance=new A277547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277548
{
public static readonly long[] Value={ 4L,9L,14L,19L,20L,24L,29L,34L,39L,44L,45L,49L,54L,59L,64L,69L,70L,74L,79L,84L,89L,94L,95L,99L,100L,104L,109L,114L,119L,120L,124L,129L,134L,139L,144L,145L,149L,154L,159L,164L,169L,170L,174L,179L,184L,189L,194L,195L,199L,204L,209L,214L,219L,220L,224L,225L,229L };
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
public class A277548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277548Inst : IEnumerable<long>
{
public static readonly long[] Value=A277548.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277548.Bytes);
public long this[int i]=>Value[i];

public static A277548Inst Instance=new A277548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277549
{
public static readonly long[] Value={ 1L,4L,5L,9L,13L,16L,17L,20L,21L,25L,29L,33L,36L,37L,41L,45L,49L,52L,53L,57L,61L,64L,65L,68L,69L,73L,77L,80L,81L,84L,85L,89L,93L,97L,100L,101L,105L,109L,113L,116L,117L,121L,125L,129L,132L,133L,137L,141L,144L,145L,148L,149L,153L,157L,161L,164L,165L,169L,173L };
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
public class A277549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277549Inst : IEnumerable<long>
{
public static readonly long[] Value=A277549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277549.Bytes);
public long this[int i]=>Value[i];

public static A277549Inst Instance=new A277549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277550
{
public static readonly long[] Value={ 1L,5L,6L,11L,16L,21L,25L,26L,30L,31L,36L,41L,46L,51L,55L,56L,61L,66L,71L,76L,80L,81L,86L,91L,96L,101L,105L,106L,111L,116L,121L,125L,126L,130L,131L,136L,141L,146L,150L,151L,155L,156L,161L,166L,171L,176L,180L,181L,186L,191L,196L,201L,205L,206L,211L,216L,221L };
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
public class A277550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277550Inst : IEnumerable<long>
{
public static readonly long[] Value=A277550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277550.Bytes);
public long this[int i]=>Value[i];

public static A277550Inst Instance=new A277550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277551
{
public static readonly long[] Value={ 2L,7L,10L,12L,17L,22L,27L,32L,35L,37L,42L,47L,50L,52L,57L,60L,62L,67L,72L,77L,82L,85L,87L,92L,97L,102L,107L,110L,112L,117L,122L,127L,132L,135L,137L,142L,147L,152L,157L,160L,162L,167L,172L,175L,177L,182L,185L,187L,192L,197L,202L,207L,210L,212L,217L,222L,227L };
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
public class A277551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277551Inst : IEnumerable<long>
{
public static readonly long[] Value=A277551.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277551.Bytes);
public long this[int i]=>Value[i];

public static A277551Inst Instance=new A277551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277552
{
public static readonly long[] Value={ 3L,5L,11L,127L,1151L,1361L,19661L,31469L,156007L,360749L,370373L,1357333L,2010881L,17051887L,20831533L,191913031L,436273291L,2300942869L,3842611109L,4302407713L,10726905041L,25056082543L,304599509051L,461690510543L,1346294311331L,1408695494197L,1968188557063L,2614941711251L,13829048560417L,19581334193189L };
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
public class A277552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277552Inst : IEnumerable<long>
{
public static readonly long[] Value=A277552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277552.Bytes);
public long this[int i]=>Value[i];

public static A277552Inst Instance=new A277552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277553
{
public static readonly long[] Value={ 1L,20L,49L,169L,361L,500L,605L,961L,980L,1025L,1369L,1445L,1700L,1849L,2645L,3380L,3721L,4205L,4352L,4489L,4693L,5329L,6241L,7220L,8228L,8281L,8405L,9409L,9425L,10609L,11045L,11849L,11881L,12493L,12500L,14045L,14580L,14641L,15125L,16129L,17405L,17689L,18785L };
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
public class A277553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277553Inst : IEnumerable<long>
{
public static readonly long[] Value=A277553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277553.Bytes);
public long this[int i]=>Value[i];

public static A277553Inst Instance=new A277553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277554
{
public static readonly long[] Value={ 1L,2L,46L,2227L,6684830083L,12827743861L,151652531182L,155657642297L,3102126273955L,11006109076099L,50473807426174L,172794904196354L };
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
public class A277554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277554Inst : IEnumerable<long>
{
public static readonly long[] Value=A277554.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277554.Bytes);
public long this[int i]=>Value[i];

public static A277554Inst Instance=new A277554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277555
{
public static readonly long[] Value={ 3L,8L,13L,15L,18L,23L,28L,33L,38L,40L,43L,48L,53L,58L,63L,65L,68L,73L,75L,78L,83L,88L,90L,93L,98L,103L,108L,113L,115L,118L,123L,128L,133L,138L,140L,143L,148L,153L,158L,163L,165L,168L,173L,178L,183L,188L,190L,193L,198L,200L,203L,208L,213L,215L,218L,223L,228L };
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
public class A277555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277555Inst : IEnumerable<long>
{
public static readonly long[] Value=A277555.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277555.Bytes);
public long this[int i]=>Value[i];

public static A277555Inst Instance=new A277555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279108
{
public static readonly long[] Value={ 18L,27L,50L,70L,72L,81L,110L,132L,198L,220L,231L,264L,297L,330L,396L,440L,462L,495L,500L,528L,540L,550L,594L,660L,693L,700L,770L,792L,825L,880L,891L,990L,1010L,1066L,1089L,1100L,1107L,1110L,1210L,1212L,1310L,1313L,1320L,1332L,1410L,1414L,1443L,1452L,1510L,1515L,1572L,1584L,1610L,1616L,1665L,1692L,1710L,1717L,1810L,1818L,1910L,1919L,1980L,1998L };
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
public class A279108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279108Inst : IEnumerable<long>
{
public static readonly long[] Value=A279108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279108.Bytes);
public long this[int i]=>Value[i];

public static A279108Inst Instance=new A279108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279109
{
public static readonly BigInteger[] Value={ 2L,8L,48L,5760L,80640L,14515200L,958003200L,1394852659200L,41845579776000L,25609494822912000L,4865804016353280000L,BigInteger.Parse("528941518954168320000"),BigInteger.Parse("1240896803466478878720000"),BigInteger.Parse("1613165844506422542336000000"),BigInteger.Parse("609776689223427721003008000000") };
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
public class A279109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279109Inst Instance=new A279109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279110
{
public static readonly BigInteger[] Value={ 1L,4L,24L,2880L,40320L,7257600L,479001600L,697426329600L,20922789888000L,12804747411456000L,2432902008176640000L,BigInteger.Parse("264470759477084160000"),BigInteger.Parse("620448401733239439360000"),BigInteger.Parse("806582922253211271168000000"),BigInteger.Parse("304888344611713860501504000000"),BigInteger.Parse("4244045756995056938180935680000000") };
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
public class A279110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279110Inst Instance=new A279110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279111
{
public static readonly long[] Value={ 0L,0L,4L,13L,37L,75L,147L,246L,406L,610L,910L,1275L,1779L,2373L,3157L,4060L,5212L,6516L,8136L,9945L,12145L,14575L,17479L,20658L,24402L,28470L,33202L,38311L,44191L,50505L,57705L,65400L,74104L,83368L,93772L,104805L,117117L,130131L,144571L,159790L,176590L,194250L,213654L };
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
public class A279111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279111Inst : IEnumerable<long>
{
public static readonly long[] Value=A279111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279111.Bytes);
public long this[int i]=>Value[i];

public static A279111Inst Instance=new A279111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279112
{
public static readonly long[] Value={ 0L,0L,2L,20L,138L,505L,1547L,3759L,8313L,16350L,30344L,52470L,87212L,138255L,212953L,317065L,461827L,655724L,915038L,1251720L,1688414L,2241365L,2941047L,3808915L,4884893L,6196650L,7795332L,9715914L,12022688L,14759115L,18004709L,21812685L,26280007L,31471000L,37502458L };
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
public class A279112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279112Inst : IEnumerable<long>
{
public static readonly long[] Value=A279112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279112.Bytes);
public long this[int i]=>Value[i];

public static A279112Inst Instance=new A279112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279113
{
public static readonly long[] Value={ 0L,0L,1L,14L,277L,2154L,10855L,39926L,120961L,315150L,737089L,1577406L,3150841L,5934034L,10651567L,18332614L,30452605L,49011606L,76753681L,117268590L,175315789L,256949306L,369978631L,524114454L,731604457L,1007394974L,1369985905L,1841600286L,2449309201L,3225197730L };
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
public class A279113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279113Inst : IEnumerable<long>
{
public static readonly long[] Value=A279113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279113.Bytes);
public long this[int i]=>Value[i];

public static A279113Inst Instance=new A279113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279114
{
public static readonly long[] Value={ 0L,0L,0L,0L,273L,5335L,50021L,291171L,1263125L,4434783L,13355477L,35672426L,86686721L,194886975L,410820269L,819819261L,1561128613L,2853802623L,5033838173L,8602315716L,14291999441L,23150803815L,36654054741L,56841404455L,86496828245L,129363299967L,190419751685L,276205278030L };
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
public class A279114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279114Inst : IEnumerable<long>
{
public static readonly long[] Value=A279114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279114.Bytes);
public long this[int i]=>Value[i];

public static A279114Inst Instance=new A279114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279115
{
public static readonly long[] Value={ 0L,0L,0L,0L,143L,7855L,153311L,1505465L,9729830L,47235703L,186615092L,630338668L,1882894541L,5092130575L,12686490993L,29498296651L,64664954532L,134715649055L,268438970166L,514318521438L,951646716171L,1706721390223L,2976056379875L,5058962536429L,8402677784738L,13663807273607L };
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
public class A279115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279115Inst : IEnumerable<long>
{
public static readonly long[] Value=A279115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279115.Bytes);
public long this[int i]=>Value[i];

public static A279115Inst Instance=new A279115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279116
{
public static readonly long[] Value={ 0L,0L,0L,0L,39L,6472L,311552L,5576682L,56289710L,389130774L,2059061646L,8924241327L,33134160010L,108698226956L,322211640480L };
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
public class A279116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279116Inst : IEnumerable<long>
{
public static readonly long[] Value=A279116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279116.Bytes);
public long this[int i]=>Value[i];

public static A279116Inst Instance=new A279116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279117
{
public static readonly long[] Value={ 1L,0L,2L,14L,273L,7855L,311552L,14895797L,831959075L,52959962415L };
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
public class A279117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279117Inst : IEnumerable<long>
{
public static readonly long[] Value=A279117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279117.Bytes);
public long this[int i]=>Value[i];

public static A279117Inst Instance=new A279117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279118
{
public static readonly BigInteger[] Value={ 1L,0L,111L,0L,11111L,0L,1111111L,0L,111111111L,0L,11111111111L,0L,1111111111111L,0L,111111111111111L,0L,11111111111111111L,0L,1111111111111111111L,0L,BigInteger.Parse("111111111111111111111"),0L,BigInteger.Parse("11111111111111111111111"),0L,BigInteger.Parse("1111111111111111111111111"),0L };
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
public class A279118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279118Inst Instance=new A279118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279119
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,3L,1L,4L,0L,5L,0L,6L,3L,7L,0L,8L,0L,9L,4L,10L,0L,11L,1L,12L,6L,13L,0L,14L,0L,15L,7L,16L,2L,17L,0L,18L,9L,19L,0L,20L,0L,21L,10L,22L,0L,23L,1L,24L,12L,25L,0L,26L,5L,27L,13L,28L,0L,29L,0L,30L,15L,31L,6L,32L,0L,33L,16L,34L,0L,35L,0L,36L,18L,37L };
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
public class A279119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279119Inst : IEnumerable<long>
{
public static readonly long[] Value=A279119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279119.Bytes);
public long this[int i]=>Value[i];

public static A279119Inst Instance=new A279119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279120
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,809L,1847L,7943L,6921461L,126235201L,1258024561L,2288629046003L,80348736972167L,111111638337011L,BigInteger.Parse("40453941942593304589"),BigInteger.Parse("258227002122139705201"),BigInteger.Parse("7316538113501035554721"),BigInteger.Parse("34747165199239302488636803"),BigInteger.Parse("2962605017328303351107945687") };
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
public class A279120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279120Inst Instance=new A279120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279121
{
public static readonly BigInteger[] Value={ 3L,9L,36L,1080L,544320L,5443200L,102643200L,392302310400L,31384184832000L,1371937222656000L,10948059036794880000UL,BigInteger.Parse("1686001091666411520000"),BigInteger.Parse("10227171457141309440000"),BigInteger.Parse("16333304175627528241152000000"),BigInteger.Parse("457332516917570790752256000000"),BigInteger.Parse("56839898531183798279208960000000") };
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
public class A279121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279121Inst Instance=new A279121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279122
{
public static readonly BigInteger[] Value={ 1L,3L,12L,360L,181440L,1814400L,34214400L,130767436800L,10461394944000L,457312407552000L,3649353012264960000L,BigInteger.Parse("562000363888803840000"),BigInteger.Parse("3409057152380436480000"),BigInteger.Parse("5444434725209176080384000000"),BigInteger.Parse("152444172305856930250752000000"),BigInteger.Parse("18946632843727932759736320000000") };
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
public class A279122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279122Inst Instance=new A279122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279123
{
public static readonly ulong[] Value={ 1L,10L,101L,1110L,101L,101110L,1010101L,10111110L,101000101L,1111101110L,1010101L,111010111110L,10001000101L,10101111101110L,101010001010101L,1010101010111110L,10100010001000101L,101011101111101110L,1000101010001010101L,10101011101010111110UL };
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
public class A279123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279123Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279123.Bytes);
public ulong this[int i]=>Value[i];

public static A279123Inst Instance=new A279123Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279685
{
public static readonly long[] Value={ 1L,1L,3L,6L,16L,39L,91L,216L,499L,1144L,2651L,6152L,14227L,32904L,76187L,176376L,408179L,944728L,2186779L,5061544L,11715219L,27116008L,62762971L,145270808L,336242675L,778266424L,1801373403L,4169451080L,9650594451L,22337231432L,51701672731L };
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
public class A279685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279685Inst : IEnumerable<long>
{
public static readonly long[] Value=A279685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279685.Bytes);
public long this[int i]=>Value[i];

public static A279685Inst Instance=new A279685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279686
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,30L,36L,40L,48L,60L,64L,72L,81L,90L,108L,144L,162L,180L,192L,200L,210L,225L,240L,256L,280L,320L,324L,360L,405L,420L,432L,450L,500L,512L,540L,576L,600L,630L,648L,720L,768L,810L,900L,960L,1260L,1280L,1296L,1350L,1400L,1536L,1575L,1600L };
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
public class A279686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279686Inst : IEnumerable<long>
{
public static readonly long[] Value=A279686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279686.Bytes);
public long this[int i]=>Value[i];

public static A279686Inst Instance=new A279686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279687
{
public static readonly long[] Value={ 1L,2L,5L,13L,17L,29L,421L,401L,37L,1877L,41L };
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
public class A279687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279687Inst : IEnumerable<long>
{
public static readonly long[] Value=A279687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279687.Bytes);
public long this[int i]=>Value[i];

public static A279687Inst Instance=new A279687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279688
{
public static readonly long[] Value={ 0L,8L,18L,21L,27L,32L,40L,48L,65L,66L,72L,78L,86L,96L,98L,99L,104L,108L,111L,114L,123L,133L,168L,176L,189L,190L,200L,208L,225L,240L,248L,258L,260L,264L,266L,270L,280L,288L,294L,296L,297L,312L,314L,318L,320L,330L,341L,350L,363L,380L,387L,396L,399L,408L,429L,432L };
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
public class A279688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279688Inst : IEnumerable<long>
{
public static readonly long[] Value=A279688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279688.Bytes);
public long this[int i]=>Value[i];

public static A279688Inst Instance=new A279688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279689
{
public static readonly long[] Value={ 0L,40L,96L,104L,208L,248L,258L,288L,312L,480L,752L,833L,936L,960L,968L,1170L,1248L,1728L,1755L,2090L,2232L,2400L,2608L,2768L,2808L,2832L,2904L,4224L,4464L,5208L,5280L,5418L,6075L,6584L,6696L,6714L,6720L,6768L,6800L,6966L,7020L,7182L,7200L,7714L,7728L,7776L };
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
public class A279689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279689Inst : IEnumerable<long>
{
public static readonly long[] Value=A279689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279689.Bytes);
public long this[int i]=>Value[i];

public static A279689Inst Instance=new A279689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279690
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,8L,6L,2L,12L,2L,6L,6L,16L,2L,18L,2L,12L,6L,6L,2L,18L,8L,6L,4L,12L,2L,30L,2L,8L,6L,6L,6L,36L,2L,6L,6L,40L,2L,30L,2L,12L,40L,6L,2L,48L,8L,18L,6L,12L,2L,12L,6L,40L,6L,6L,2L,60L,2L,6L,40L,64L,6L,30L,2L,12L,6L,30L,2L,72L,2L,6L,40L,12L,6L,30L };
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
public class A279690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279690Inst : IEnumerable<long>
{
public static readonly long[] Value=A279690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279690.Bytes);
public long this[int i]=>Value[i];

public static A279690Inst Instance=new A279690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279691
{
public static readonly long[] Value={ 2L,20L,2029L,5319934L,534759300182L,2815323435872410905L };
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
public class A279691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279691Inst : IEnumerable<long>
{
public static readonly long[] Value=A279691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279691.Bytes);
public long this[int i]=>Value[i];

public static A279691Inst Instance=new A279691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279692
{
public static readonly long[] Value={ 2L,8L,31L,9878L,37202840L,5431010366322L };
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
public class A279692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279692Inst : IEnumerable<long>
{
public static readonly long[] Value=A279692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279692.Bytes);
public long this[int i]=>Value[i];

public static A279692Inst Instance=new A279692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279693
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L };
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
public class A279693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279693Inst : IEnumerable<long>
{
public static readonly long[] Value=A279693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279693.Bytes);
public long this[int i]=>Value[i];

public static A279693Inst Instance=new A279693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279694
{
public static readonly ulong[] Value={ 1L,11L,100L,1100L,10100L,110100L,1011100L,11000000L,101000010L,1101010010L,10111010010L,110000110010L,1010001011010L,11010111101110L,101110100011010L,1100001111111110L,10100010000100010L,110101110100101110L,1011101010100100010L,11000011010101110010UL };
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
public class A279694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279694Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279694.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279694.Bytes);
public ulong this[int i]=>Value[i];

public static A279694Inst Instance=new A279694Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279695
{
public static readonly ulong[] Value={ 1L,11L,1L,11L,101L,1011L,11101L,11L,10000101L,100101011L,1001011101L,10011000011L,101101000101L,1110111101011L,10110001011101L,111111111000011L,1000100001000101L,11101001011101011L,100010010101011101L,1001110101011000011L,11010111011101000101UL };
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
public class A279695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279695Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279695.Bytes);
public ulong this[int i]=>Value[i];

public static A279695Inst Instance=new A279695Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279696
{
public static readonly long[] Value={ 1L,3L,4L,12L,20L,52L,92L,192L,322L,850L,1490L,3122L,5210L,13806L,23834L,50174L,82978L,220462L,382242L,800114L,1334742L,3530878L,6101600L,12843980L,21242476L,56440776L,97845358L,204811086L,341687150L,903923790L,1562078446L,3288017550L,5438140046L,14448668558L };
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
public class A279696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279696Inst : IEnumerable<long>
{
public static readonly long[] Value=A279696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279696.Bytes);
public long this[int i]=>Value[i];

public static A279696Inst Instance=new A279696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279697
{
public static readonly long[] Value={ 1L,3L,1L,3L,5L,11L,29L,3L,133L,299L,605L,1219L,2885L,7659L,11357L,32707L,34885L,119531L,140637L,322243L,882501L,2064875L,207965L,3399619L,7112773L,5223147L,61867357L,120408771L,249280325L,478462443L,1000041565L,1901387715L,3807217733L,7647441643L,15463810397L };
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
public class A279697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279697Inst : IEnumerable<long>
{
public static readonly long[] Value=A279697.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279697.Bytes);
public long this[int i]=>Value[i];

public static A279697Inst Instance=new A279697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279698
{
public static readonly BigInteger[] Value={ 1L,0L,101L,0L,10111L,100L,1010101L,10100L,101000001L,1011100L,10101010101L,101001000L,1010001001011L,10101000010L,101010001011000L,1010101011011L,10100010101011110L,101010101011110L,1010100010101010110L,10101010101010110L,BigInteger.Parse("101000100010101010110") };
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
public class A279698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279698Inst Instance=new A279698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279699
{
public static readonly ulong[] Value={ 1L,0L,101L,0L,11101L,1000L,1010101L,101000L,100000101L,11101000L,10101010101L,100101000L,1101001000101L,1000010101000L,110100010101L,1101101010101000L,1111010101000101L,11110101010101000L,110101010100010101L,1101010101010101000L,11010101010001000101UL };
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
public class A279699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279699Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279699.Bytes);
public ulong this[int i]=>Value[i];

public static A279699Inst Instance=new A279699Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279700
{
public static readonly long[] Value={ 1L,0L,5L,0L,23L,4L,85L,20L,321L,92L,1365L,328L,5195L,1346L,21592L,5467L,83294L,21854L,345430L,87382L,1328470L,349526L,5522774L,1398102L,21316950L,5592406L,88425814L,22369622L,340084054L,89478486L,1413825878L,357913942L,5457134934L,1431655766L,22637004118L };
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
public class A279700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279700Inst : IEnumerable<long>
{
public static readonly long[] Value=A279700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279700.Bytes);
public long this[int i]=>Value[i];

public static A279700Inst Instance=new A279700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279781
{
public static readonly long[] Value={ 1L,-3L,4L,-4L,4L,-3L,-1L,8L,-16L,24L,-30L,28L,-12L,-20L,68L,-128L,184L,-208L,168L,-32L,-224L,592L,-1008L,1344L,-1408L,960L,224L,-2240L,4928L,-7744L,9664L,-9216L,4736L,5120L,-20608L,39936L,-58368L,67840L,-57600L,16384L,63488L,-180224L,315904L,-431104L,463872L };
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
public class A279781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279781Inst : IEnumerable<long>
{
public static readonly long[] Value=A279781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279781.Bytes);
public long this[int i]=>Value[i];

public static A279781Inst Instance=new A279781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279782
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,1L,2L,3L,1L,4L,1L,2L,3L,5L,4L,1L,3L,5L,1L,6L,2L,5L,4L,1L,5L,3L,7L,1L,2L,7L,3L,4L,8L,1L,5L,7L,6L,5L,7L,1L,2L,3L,9L,8L,4L,7L,5L,1L,9L,6L,3L,7L,10L,5L,1L,2L,8L,4L,9L,1L,11L,3L,10L,7L,9L,5L,8L,11L,1L,2L,3L,7L,4L,12L,5L,11L,6L,1L,9L,7L,11L,5L,8L };
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
public class A279782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279782Inst : IEnumerable<long>
{
public static readonly long[] Value=A279782.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279782.Bytes);
public long this[int i]=>Value[i];

public static A279782Inst Instance=new A279782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279783
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,5L,7L,7L,7L,6L,7L,8L,8L,7L,9L,7L,9L,8L,9L,10L,9L,10L,8L,11L,11L,9L,11L,11L,9L,12L,11L,10L,11L,12L,11L,13L,13L,13L,10L,11L,13L,12L,13L,14L,11L,13L,14L,13L,11L,14L,15L,15L,13L,15L,13L,16L,12L,16L,13L,15L,14L,16L,15L,13L,17L,17L,17L,16L,17L,13L,17L,14L,17L,18L,16L };
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
public class A279783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279783Inst : IEnumerable<long>
{
public static readonly long[] Value=A279783.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279783.Bytes);
public long this[int i]=>Value[i];

public static A279783Inst Instance=new A279783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279784
{
public static readonly long[] Value={ 1L,1L,3L,5L,12L,18L,40L,60L,121L,186L,344L,524L,955L,1432L,2484L,3756L,6352L,9493L,15750L,23414L,38128L,56513L,90406L,133312L,211194L,309657L,484214L,708267L,1097159L,1597290L,2454245L,3560444L,5430091L,7854174L,11894335L,17151394L,25838413L,37145198L,55648059L };
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
public class A279784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279784Inst : IEnumerable<long>
{
public static readonly long[] Value=A279784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279784.Bytes);
public long this[int i]=>Value[i];

public static A279784Inst Instance=new A279784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279785
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,7L,11L,18L,28L,47L,71L,108L,166L,252L,382L,587L,869L,1282L,1938L,2832L,4153L,6148L,8962L,12965L,18913L,27301L,39380L,56747L,81226L,115907L,166358L,236000L,334647L,475517L,671806L,947552L,1335679L,1875175L,2630584L,3687589L,5150585L,7183548L };
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
public class A279785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279785Inst : IEnumerable<long>
{
public static readonly long[] Value=A279785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279785.Bytes);
public long this[int i]=>Value[i];

public static A279785Inst Instance=new A279785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279786
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,9L,16L,22L,28L,49L,69L,94L,138L,187L,257L,374L,479L,639L,886L,1146L,1577L,2103L,2676L,3534L,4620L,5910L,7542L,9816L,12650L,15986L,20538L,25740L,32632L,41442L,51383L,64771L,81281L,100729L,125041L,155557L,192641L,236810L,293593L,359880L,441276L };
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
public class A279786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279786Inst : IEnumerable<long>
{
public static readonly long[] Value=A279786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279786.Bytes);
public long this[int i]=>Value[i];

public static A279786Inst Instance=new A279786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279787
{
public static readonly long[] Value={ 1L,1L,3L,4L,10L,8L,29L,16L,64L,58L,124L,57L,469L,102L,489L,763L,1597L,298L,3858L,491L,8942L,6355L,6187L,1256L,59076L,18766L,20830L,49694L,167078L,4566L,481186L,6843L,752128L,362907L,231592L,1597802L,5951007L,21638L,790404L,2655810L,25274798L,44584L,40898731L };
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
public class A279787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279787Inst : IEnumerable<long>
{
public static readonly long[] Value=A279787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279787.Bytes);
public long this[int i]=>Value[i];

public static A279787Inst Instance=new A279787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279788
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,10L,6L,12L,17L,21L,13L,57L,19L,49L,87L,86L,39L,240L,55L,279L,330L,235L,105L,1141L,386L,491L,1217L,1461L,257L,4804L,341L,2968L,4225L,1958L,5898L,18961L,761L,3782L,15007L,30572L,1261L,66245L,1611L,32523L,106951L,13122L,2591L,283013L,81390L,182873L };
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
public class A279788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279788Inst : IEnumerable<long>
{
public static readonly long[] Value=A279788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279788.Bytes);
public long this[int i]=>Value[i];

public static A279788Inst Instance=new A279788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279789
{
public static readonly long[] Value={ 1L,1L,3L,3L,8L,3L,17L,3L,30L,12L,41L,3L,130L,3L,137L,45L,359L,3L,656L,3L,1306L,141L,2057L,3L,5446L,36L,8201L,544L,18610L,3L,34969L,3L,72385L,2061L,131081L,165L,290362L,3L,524297L,8205L,1109206L,3L,2130073L,3L,4371490L,33594L,8388617L,3L,17445321L,132L,33556496L };
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
public class A279789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279789Inst : IEnumerable<long>
{
public static readonly long[] Value=A279789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279789.Bytes);
public long this[int i]=>Value[i];

public static A279789Inst Instance=new A279789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279790
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,11L,12L,18L,24L,49L,53L,82L,102L,149L,236L,297L,392L,540L,702L,924L,1423L,1723L,2318L,3016L,3969L,5037L,6647L,9285L,11448L,15048L,19143L,24695L,31288L,40075L,50014L,68583L,83056L,107252L,133796L,171565L };
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
public class A279790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279790Inst : IEnumerable<long>
{
public static readonly long[] Value=A279790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279790.Bytes);
public long this[int i]=>Value[i];

public static A279790Inst Instance=new A279790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279791
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,6L,5L,8L,8L,16L,12L,23L,18L,36L,33L,50L,38L,84L,54L,106L,100L,155L,104L,244L,142L,301L,270L,436L,256L,684L,340L,788L,670L,1044L,585L,1868L,760L,1878L,1600L,2647L };
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
public class A279791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279791Inst : IEnumerable<long>
{
public static readonly long[] Value=A279791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279791.Bytes);
public long this[int i]=>Value[i];

public static A279791Inst Instance=new A279791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279792
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,0L,1L,2L,1L,0L,2L,1L,1L,2L,1L,1L,2L,0L,2L,3L,1L,1L,2L,2L,1L,2L,1L,1L,4L,1L,2L,3L,1L,2L,3L,1L,2L,2L,1L,2L,4L,0L,2L,5L,1L,1L,3L,2L,3L,4L,3L,1L,4L,3L,3L,5L,2L,1L,6L,1L,2L,5L,1L,3L,4L,2L,2L,4L,4L,3L,6L,3L,3L,7L,2L,4L,6L,1L,4L,5L,2L,2L,5L,4L,3L,5L,3L,2L,6L };
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
public class A279792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279792Inst : IEnumerable<long>
{
public static readonly long[] Value=A279792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279792.Bytes);
public long this[int i]=>Value[i];

public static A279792Inst Instance=new A279792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279793
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,15L,19L,25L,26L,137L,141L,257L,399L,508L,524L,607L,709L,953L,989L,2484L,3196L,4538L,6448L,35401L,36106L,51530L,79327L };
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
public class A279793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279793Inst : IEnumerable<long>
{
public static readonly long[] Value=A279793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279793.Bytes);
public long this[int i]=>Value[i];

public static A279793Inst Instance=new A279793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279794
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,2L,2L,3L,2L,2L,2L,1L,3L,3L,1L,3L,3L,3L,3L,5L,3L,2L,4L,4L,2L,4L,3L,3L,4L,1L,3L,4L,2L,4L,4L,3L,4L,5L,4L,4L,6L,2L,3L,5L,2L,4L,5L,3L,3L,4L,3L,4L,5L,2L,2L,5L,2L,4L,5L,3L,4L,5L,3L,3L,8L,5L,3L,6L,4L,4L,8L,4L,4L,7L,3L,4L,6L,5L,6L,7L,5L };
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
public class A279794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279794Inst : IEnumerable<long>
{
public static readonly long[] Value=A279794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279794.Bytes);
public long this[int i]=>Value[i];

public static A279794Inst Instance=new A279794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279795
{
public static readonly long[] Value={ 5L,7L,13L,433L,571L };
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
public class A279795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279795Inst : IEnumerable<long>
{
public static readonly long[] Value=A279795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279795.Bytes);
public long this[int i]=>Value[i];

public static A279795Inst Instance=new A279795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279796
{
public static readonly long[] Value={ 820L,1276L,1422L,1926L,2080L,2640L,3160L,3186L,3250L,4446L,4720L,4930L,5370L,6006L,6546L,7386L,7450L,7476L,9066L,9276L,10626L,10836L,13146L,13300L,15640L,15666L,16056L,16060L,16446L,17020L,17466L,17550L,17766L,18040L,18910L,19176L,19230L,19416L,20736L,21000L,21246L,21310L,21376L,21726L };
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
public class A279796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279796Inst : IEnumerable<long>
{
public static readonly long[] Value=A279796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A279796.Bytes);
public long this[int i]=>Value[i];

public static A279796Inst Instance=new A279796Inst();

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