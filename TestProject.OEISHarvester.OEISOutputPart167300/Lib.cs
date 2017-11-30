using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197757
{
public static readonly long[] Value={ 9L,2L,1L,8L,8L,4L,0L,8L,8L,0L,1L,5L,8L,6L,0L,7L,8L,4L,8L,1L,9L,9L,6L,9L,2L,4L,8L,8L,6L,1L,8L,1L,0L,6L,3L,6L,5L,7L,2L,9L,9L,5L,6L,7L,5L,8L,2L,6L,9L,9L,6L,5L,4L,6L,6L,2L,7L,1L,3L,6L,1L,5L,3L,8L,1L,9L,1L,2L,2L,0L,6L,5L,0L,7L,6L,6L,6L,2L,6L,9L,4L,8L,7L,4L,9L,7L,0L,9L,4L,9L,5L,5L,1L,4L,9L,9L,5L,5L,1L };
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
public class A197757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197757Inst : IEnumerable<long>
{
public static readonly long[] Value=A197757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197757.Bytes);
public long this[int i]=>Value[i];

public static A197757Inst Instance=new A197757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197758
{
public static readonly long[] Value={ 3L,7L,1L,4L,5L,8L,2L,9L,4L,0L,3L,3L,4L,8L,6L,3L,5L,2L,5L,0L,5L,8L,3L,2L,7L,2L,8L,5L,1L,9L,5L,1L,2L,4L,0L,9L,8L,0L,8L,9L,6L,8L,2L,6L,0L,7L,3L,9L,5L,7L,5L,3L,9L,0L,7L,2L,3L,4L,4L,5L,2L,9L,1L,0L,6L,3L,6L,6L,8L,0L,5L,8L,1L,2L,0L,6L,6L,9L,3L,6L,8L,8L,6L,9L,9L,1L,5L,1L,0L,5L,8L,9L,8L,3L,6L,8L,1L,2L,4L };
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
public class A197758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197758Inst : IEnumerable<long>
{
public static readonly long[] Value=A197758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197758.Bytes);
public long this[int i]=>Value[i];

public static A197758Inst Instance=new A197758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197759
{
public static readonly long[] Value={ 1L,8L,6L,1L,0L,4L,8L,0L,1L,6L,6L,5L,2L,7L,2L,4L,3L,6L,4L,6L,0L,0L,8L,2L,3L,4L,3L,5L,2L,2L,1L,3L,2L,0L,9L,2L,8L,6L,1L,6L,5L,4L,6L,3L,5L,3L,7L,5L,8L,9L,3L,0L,5L,4L,0L,0L,4L,9L,1L,2L,4L,8L,6L,5L,8L,8L,3L,0L,1L,0L,3L,8L,0L,1L,3L,2L,3L,1L,2L,0L,4L,4L,5L,5L,0L,3L,4L,4L,3L,6L,5L,8L,9L,7L,8L,8L,9L,1L,3L };
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
public class A197759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197759Inst : IEnumerable<long>
{
public static readonly long[] Value=A197759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197759.Bytes);
public long this[int i]=>Value[i];

public static A197759Inst Instance=new A197759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197760
{
public static readonly long[] Value={ 6L,4L,3L,1L,7L,1L,9L,7L,5L,4L,2L,1L,1L,8L,4L,1L,5L,9L,5L,6L,6L,6L,5L,6L,2L,5L,7L,5L,3L,5L,8L,0L,2L,6L,8L,0L,3L,3L,9L,6L,3L,8L,0L,6L,4L,7L,3L,5L,2L,2L,4L,7L,1L,7L,5L,2L,8L,3L,7L,6L,6L,2L,3L,2L,0L,3L,6L,7L,7L,8L,1L,3L,2L,4L,7L,1L,1L,9L,2L,0L,8L,8L,3L,4L,6L,0L,0L,1L,8L,9L,6L,4L,0L,8L,1L,6L,1L,0L,4L };
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
public class A197760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197760Inst : IEnumerable<long>
{
public static readonly long[] Value=A197760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197760.Bytes);
public long this[int i]=>Value[i];

public static A197760Inst Instance=new A197760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197761
{
public static readonly long[] Value={ 7L,2L,4L,0L,0L,2L,5L,8L,2L,8L,3L,3L,6L,8L,0L,7L,4L,4L,9L,3L,3L,4L,7L,1L,8L,9L,0L,6L,8L,9L,1L,2L,7L,7L,7L,6L,5L,4L,2L,4L,6L,8L,3L,1L,6L,2L,3L,8L,7L,9L,8L,8L,8L,0L,7L,6L,1L,8L,0L,9L,7L,6L,8L,2L,0L,2L,7L,9L,5L,5L,2L,0L,8L,2L,9L,6L,9L,6L,8L,3L,6L,1L,9L,5L,5L,7L,2L,3L,2L,1L,2L,1L,9L,1L,7L,3L,7L,4L,5L };
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
public class A197761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197761Inst : IEnumerable<long>
{
public static readonly long[] Value=A197761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197761.Bytes);
public long this[int i]=>Value[i];

public static A197761Inst Instance=new A197761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197762
{
public static readonly long[] Value={ 7L,8L,6L,1L,5L,1L,3L,7L,7L,7L,5L,7L,4L,2L,3L,2L,8L,6L,0L,6L,9L,5L,5L,8L,5L,8L,5L,8L,4L,2L,9L,5L,8L,9L,2L,9L,5L,2L,3L,1L,2L,2L,0L,5L,7L,8L,3L,7L,7L,2L,3L,2L,3L,7L,6L,6L,4L,9L,0L,1L,9L,7L,0L,1L,0L,1L,1L,8L,2L,0L,4L,7L,6L,2L,2L,3L,1L,0L,9L,1L,3L,7L,1L,1L,9L,1L,2L,8L,8L,9L,1L,5L,8L,5L,0L,8L,1L,3L,5L };
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
public class A197762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197762Inst : IEnumerable<long>
{
public static readonly long[] Value=A197762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197762.Bytes);
public long this[int i]=>Value[i];

public static A197762Inst Instance=new A197762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197763
{
public static readonly long[] Value={ 1L,1L,7L,75L,763L,18910L,792004L,61120305L,8542334163L,2135804958700L,966978394573292L };
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
public class A197763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197763Inst : IEnumerable<long>
{
public static readonly long[] Value=A197763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197763.Bytes);
public long this[int i]=>Value[i];

public static A197763Inst Instance=new A197763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197764
{
public static readonly BigInteger[] Value={ 5L,73L,1877L,69730L,3363233L,199205127L,13982257729L,1134344816185L,104416147080712L,10750872867074587L,1224163955433850944L,BigInteger.Parse("152733676280699540999"),BigInteger.Parse("20719969553916698313305"),BigInteger.Parse("3036565789908881887393114"),BigInteger.Parse("478082645334119488823777215"),BigInteger.Parse("80475210949356295594385157621") };
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
public class A197764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197764Inst Instance=new A197764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197765
{
public static readonly BigInteger[] Value={ 6L,111L,3606L,168152L,10162551L,753640011L,66200225627L,6719243243860L,773662803646265L,99627047203913815L,14186632841753756406UL,BigInteger.Parse("2213340465298424454703"),BigInteger.Parse("375449162169269152689332"),BigInteger.Parse("68797650004483898373052061"),BigInteger.Parse("13542753444466024362689788809") };
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
public class A197765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197765Inst Instance=new A197765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197766
{
public static readonly BigInteger[] Value={ 7L,157L,6163L,345818L,25120873L,2237952688L,236084694123L,28771727614750L,3977205817386553L,614815375624938277L,BigInteger.Parse("105089416995538138498"),BigInteger.Parse("19679693805738843682351"),BigInteger.Parse("4006775128162674717660622"),BigInteger.Parse("881207085092349552894218730"),BigInteger.Parse("208190711541113653367733416164") };
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
public class A197766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197766Inst Instance=new A197766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197767
{
public static readonly BigInteger[] Value={ 8L,211L,9710L,636904L,54039749L,5621026397L,692186010835L,98457959756723L,15883727818630152L,2865366503771469411L,BigInteger.Parse("571524481184700575470"),BigInteger.Parse("124887520213444076248620"),BigInteger.Parse("29669385469799155774434099"),BigInteger.Parse("7613687050766411443598268999") };
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
public class A197767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197767Inst Instance=new A197767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197768
{
public static readonly BigInteger[] Value={ 9L,273L,14409L,1081731L,104985729L,12487616539L,1758172862980L,285903205720513L,52725376090628156L,10872393464815690144UL,BigInteger.Parse("2478802987043990078457"),BigInteger.Parse("619122710473385614426210"),BigInteger.Parse("168115507427305189329095428"),BigInteger.Parse("49309285630177314887251611601") };
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
public class A197768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197768Inst Instance=new A197768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197769
{
public static readonly BigInteger[] Value={ 10L,343L,20422L,1726761L,188665363L,25257633874L,4001931082418L,732295911309957L,151957855559538859L,BigInteger.Parse("35257207352182955135"),BigInteger.Parse("9044237131202445725078"),BigInteger.Parse("2541585712463861383036827"),BigInteger.Parse("776473970630759909605090448"),BigInteger.Parse("256232041409079180707274204958") };
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
public class A197769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197769Inst Instance=new A197769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197770
{
public static readonly BigInteger[] Value={ 11L,421L,27911L,2624603L,318800201L,47439020042L,8353801755007L,1698808167100876L,391746480089540116L,BigInteger.Parse("101004512021025221013"),BigInteger.Parse("28791615763253886202481"),BigInteger.Parse("8990685731188213404550239"),BigInteger.Parse("3052132045866636492112058600"),BigInteger.Parse("1119164206256115117485135326642"),BigInteger.Parse("440822282742124422495281791483359") };
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
public class A197770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197770Inst Instance=new A197770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197771
{
public static readonly BigInteger[] Value={ 12L,507L,37038L,3834009L,512501793L,83914215403L,16258109291003L,3637416562713076L,922786228220640102L,BigInteger.Parse("261741863272493596615"),BigInteger.Parse("82078032321730681299098"),BigInteger.Parse("28195269239973685901676783"),BigInteger.Parse("10529425953839699619063326836") };
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
public class A197771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197771Inst Instance=new A197771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197772
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,25L,138L,968L,8313L,84735L,1000322L,13418848L,201526744L,3348677251L,60981586323L,1207531891440L,25829355773719L,593485342700358L,14577731251921826L,381175458103542506L,10570762449548976706UL,BigInteger.Parse("309889778765890035970"),BigInteger.Parse("9575316933047901325098") };
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
public class A197772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197772Inst Instance=new A197772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197773
{
public static readonly long[] Value={ 8L,16L,38L,77L,141L,235L,365L,537L,757L,1031L,1365L,1765L,2237L,2787L,3421L,4145L,4965L,5887L,6917L,8061L,9325L,10715L,12237L,13897L,15701L,17655L,19765L,22037L,24477L,27091L,29885L,32865L,36037L,39407L,42981L,46765L,50765L,54987L,59437L,64121L,69045L,74215L };
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
public class A197773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197773Inst : IEnumerable<long>
{
public static readonly long[] Value=A197773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197773.Bytes);
public long this[int i]=>Value[i];

public static A197773Inst Instance=new A197773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197774
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,0L,-1L,1L,1L,1L,-1L,0L,-1L,0L,1L,1L,-1L,0L,0L,1L,0L,0L,-1L,-1L,-1L,0L,1L,1L,1L,0L,-1L,1L,1L,0L,-1L,-1L,-1L,0L,0L,1L,-1L,-1L,0L,0L,1L,0L,-1L,0L,1L,0L,1L,1L,-1L,0L,-1L,1L,0L,0L,1L,-1L,-1L,0L,1L,-1L,-1L,0L,-1L,1L,0L,0L,1L,-1L,-1L,-1L,1L,1L,-1L,0L,1L,1L,1L,0L,-1L,0L,1L,0L,1L,1L,1L,0L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,-1L };
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
public class A197774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197774Inst : IEnumerable<long>
{
public static readonly long[] Value=A197774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197774.Bytes);
public long this[int i]=>Value[i];

public static A197774Inst Instance=new A197774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197775
{
public static readonly long[] Value={ 0L,-1L,-2L,-2L,-3L,-2L,-3L,-3L,-3L,-2L,-3L,-3L,-4L,-3L,-2L,-1L,-2L,-2L,-3L,-3L,-2L,-1L,-2L,-2L,-2L,-1L,-1L,-1L,-2L,-3L,-4L,-4L,-3L,-2L,-1L,-1L,-2L,-1L,0L,0L,-1L,-2L,-3L,-3L,-3L,-2L,-3L,-4L,-4L,-4L,-3L,-3L,-4L,-4L,-3L,-3L,-2L,-1L,-2L,-2L,-3L,-2L,-2L,-2L,-1L,-2L };
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
public class A197775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197775Inst : IEnumerable<long>
{
public static readonly long[] Value=A197775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197775.Bytes);
public long this[int i]=>Value[i];

public static A197775Inst Instance=new A197775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197776
{
public static readonly long[] Value={ 1L,5L,67L,3021L,384758L,153517349L,186804530634L,694775899316423L };
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
public class A197776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197776Inst : IEnumerable<long>
{
public static readonly long[] Value=A197776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197776.Bytes);
public long this[int i]=>Value[i];

public static A197776Inst Instance=new A197776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197777
{
public static readonly long[] Value={ 2L,14L,67L,338L,1646L,8085L,39748L,194964L,957860L,4707712L,23133353L,113660751L,558419575L,2743624616L,13480339775L,66233515886L,325425835373L,1598912188088L,7855923951863L,38598502682366L,189646074869215L,931788192551971L };
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
public class A197777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197777Inst : IEnumerable<long>
{
public static readonly long[] Value=A197777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197777.Bytes);
public long this[int i]=>Value[i];

public static A197777Inst Instance=new A197777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197778
{
public static readonly long[] Value={ 3L,43L,338L,3021L,25962L,221082L,1924263L,16672219L,144064579L,1245052112L,10769305267L,93170128818L,805820664778L,6968541278217L,60268080303023L,521264825241735L,4508358297890862L,38991305275498893L,337224718195909596L };
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
public class A197778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197778Inst : IEnumerable<long>
{
public static readonly long[] Value=A197778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197778.Bytes);
public long this[int i]=>Value[i];

public static A197778Inst Instance=new A197778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197779
{
public static readonly long[] Value={ 4L,124L,1646L,25962L,384758L,5833286L,88309448L,1329981026L,20064521716L,303052845328L,4574664964317L,69036523371066L,1042057567199143L,15729900331335344L,237425764865409042L,3583655555859630532L };
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
public class A197779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197779Inst : IEnumerable<long>
{
public static readonly long[] Value=A197779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197779.Bytes);
public long this[int i]=>Value[i];

public static A197779Inst Instance=new A197779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197780
{
public static readonly BigInteger[] Value={ 6L,352L,8085L,221082L,5833286L,153517349L,4052348046L,106662154198L,2816548576990L,74313847621002L,1959765215718653L,51696230890146989L,1363689536950015987L,BigInteger.Parse("35970623755533169978"),BigInteger.Parse("948840295066984918805") };
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
public class A197780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197780Inst Instance=new A197780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197781
{
public static readonly BigInteger[] Value={ 9L,1025L,39748L,1924263L,88309448L,4052348046L,186804530634L,8622121723045L,397804283640646L,18336405515418246L,845373728575358353L,BigInteger.Parse("38986854903558638616"),BigInteger.Parse("1797850629942273258934"),BigInteger.Parse("82902079988914118429426") };
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
public class A197781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197781Inst Instance=new A197781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197782
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,3L,14L,14L,3L,4L,43L,67L,43L,4L,6L,124L,338L,338L,124L,6L,9L,352L,1646L,3021L,1646L,352L,9L,13L,1025L,8085L,25962L,25962L,8085L,1025L,13L,19L,2977L,39748L,221082L,384758L,221082L,39748L,2977L,19L,28L,8619L,194964L,1924263L,5833286L,5833286L };
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
public class A197782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197782Inst : IEnumerable<long>
{
public static readonly long[] Value=A197782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197782.Bytes);
public long this[int i]=>Value[i];

public static A197782Inst Instance=new A197782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197783
{
public static readonly long[] Value={ 1L,1L,10L,67L,854L,17622L,946069L,78840479L,11293856230L,2985961804881L };
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
public class A197783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197783Inst : IEnumerable<long>
{
public static readonly long[] Value=A197783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197783.Bytes);
public long this[int i]=>Value[i];

public static A197783Inst Instance=new A197783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197784
{
public static readonly long[] Value={ 1L,5L,26L,273L,6522L,313923L,29509789L,5665631766L,2183620544690L,1689035632968963L };
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
public class A197784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197784Inst : IEnumerable<long>
{
public static readonly long[] Value=A197784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197784.Bytes);
public long this[int i]=>Value[i];

public static A197784Inst Instance=new A197784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197785
{
public static readonly long[] Value={ 1L,1L,7L,64L,805L,21526L,1060565L,95311741L,15835547951L,4848154085309L,2730611548295716L,2833706084143411564L };
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
public class A197785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197785Inst : IEnumerable<long>
{
public static readonly long[] Value=A197785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197785.Bytes);
public long this[int i]=>Value[i];

public static A197785Inst Instance=new A197785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197786
{
public static readonly long[] Value={ 1L,4L,18L,209L,4988L,221443L,19332957L,3266183233L,1068404830615L,677798120112881L,833288676199771911L };
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
public class A197786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197786Inst : IEnumerable<long>
{
public static readonly long[] Value=A197786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197786.Bytes);
public long this[int i]=>Value[i];

public static A197786Inst Instance=new A197786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197787
{
public static readonly long[] Value={ 1L,1L,7L,64L,859L,25741L,1390506L,144068133L,28038811204L,10322783689890L,7158209339360946L };
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
public class A197787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197787Inst : IEnumerable<long>
{
public static readonly long[] Value=A197787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197787.Bytes);
public long this[int i]=>Value[i];

public static A197787Inst Instance=new A197787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197788
{
public static readonly long[] Value={ 1L,5L,14L,63L,513L,10097L,259230L,11938480L,1034835441L,141000000947L };
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
public class A197788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197788Inst : IEnumerable<long>
{
public static readonly long[] Value=A197788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197788.Bytes);
public long this[int i]=>Value[i];

public static A197788Inst Instance=new A197788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197789
{
public static readonly long[] Value={ 1L,4L,7L,26L,287L,2300L,33118L,645914L,18803386L,827398260L };
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
public class A197789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197789Inst : IEnumerable<long>
{
public static readonly long[] Value=A197789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197789.Bytes);
public long this[int i]=>Value[i];

public static A197789Inst Instance=new A197789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197790
{
public static readonly long[] Value={ 1L,1L,13L,52L,786L,25425L,808145L,82768814L,12208450292L,3222958108566L };
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
public class A197790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197790Inst : IEnumerable<long>
{
public static readonly long[] Value=A197790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197790.Bytes);
public long this[int i]=>Value[i];

public static A197790Inst Instance=new A197790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197791
{
public static readonly long[] Value={ 1L,7L,24L,208L,2623L,56379L,2049939L,129937199L,14288858831L,2747104046529L };
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
public class A197791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197791Inst : IEnumerable<long>
{
public static readonly long[] Value=A197791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197791.Bytes);
public long this[int i]=>Value[i];

public static A197791Inst Instance=new A197791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197792
{
public static readonly long[] Value={ 1L,5L,23L,181L,2706L,73791L,3327225L,267114439L,38448796541L };
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
public class A197792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197792Inst : IEnumerable<long>
{
public static readonly long[] Value=A197792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197792.Bytes);
public long this[int i]=>Value[i];

public static A197792Inst Instance=new A197792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197793
{
public static readonly long[] Value={ 1L,5L,23L,181L,2757L,78811L,3813021L,346650159L,59637265200L };
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
public class A197793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197793Inst : IEnumerable<long>
{
public static readonly long[] Value=A197793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197793.Bytes);
public long this[int i]=>Value[i];

public static A197793Inst Instance=new A197793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197794
{
public static readonly long[] Value={ 1L,2L,11L,89L,1795L,57514L,3970760L,533389627L,136233868657L };
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
public class A197794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197794Inst : IEnumerable<long>
{
public static readonly long[] Value=A197794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197794.Bytes);
public long this[int i]=>Value[i];

public static A197794Inst Instance=new A197794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197795
{
public static readonly long[] Value={ 1L,2L,8L,53L,566L,10895L,355583L,19540276L,1853366075L,302167359547L };
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
public class A197795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197795Inst : IEnumerable<long>
{
public static readonly long[] Value=A197795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197795.Bytes);
public long this[int i]=>Value[i];

public static A197795Inst Instance=new A197795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197796
{
public static readonly long[] Value={ 1L,7L,45L,630L,16377L,793262L,73405633L,12833817343L,4231690321114L,2639675473285623L };
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
public class A197796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197796Inst : IEnumerable<long>
{
public static readonly long[] Value=A197796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197796.Bytes);
public long this[int i]=>Value[i];

public static A197796Inst Instance=new A197796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197797
{
public static readonly long[] Value={ 1L,5L,14L,87L,1079L,18216L,908323L,57289286L,5654429478L };
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
public class A197797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197797Inst : IEnumerable<long>
{
public static readonly long[] Value=A197797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197797.Bytes);
public long this[int i]=>Value[i];

public static A197797Inst Instance=new A197797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197798
{
public static readonly long[] Value={ 1L,4L,4L,41L,434L,2975L,123177L,4063153L,194524778L };
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
public class A197798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197798Inst : IEnumerable<long>
{
public static readonly long[] Value=A197798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197798.Bytes);
public long this[int i]=>Value[i];

public static A197798Inst Instance=new A197798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197799
{
public static readonly long[] Value={ 1L,5L,102L,7185L,1944779L,2076384112L,8356101105886L,127186506081050671L };
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
public class A197799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197799Inst : IEnumerable<long>
{
public static readonly long[] Value=A197799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197799.Bytes);
public long this[int i]=>Value[i];

public static A197799Inst Instance=new A197799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197800
{
public static readonly long[] Value={ 2L,16L,102L,596L,3713L,22742L,139212L,853186L,5231300L,32071177L,196597389L,1205159672L,7387795113L,45288409942L,277625447176L,1701887549750L,10432835696321L,63954921521562L,392053737458675L,2403351095713061L };
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
public class A197800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197800Inst : IEnumerable<long>
{
public static readonly long[] Value=A197800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197800.Bytes);
public long this[int i]=>Value[i];

public static A197800Inst Instance=new A197800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197801
{
public static readonly long[] Value={ 3L,47L,596L,7185L,84258L,1003304L,12108247L,145415587L,1741678883L,20881671948L,250537144927L,3005211136420L,36041194655182L,432263935701095L,5184637079331635L,62184399037504325L,745829859698448162L };
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
public class A197801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197801Inst : IEnumerable<long>
{
public static readonly long[] Value=A197801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197801.Bytes);
public long this[int i]=>Value[i];

public static A197801Inst Instance=new A197801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197802
{
public static readonly BigInteger[] Value={ 4L,154L,3713L,84258L,1944779L,45619023L,1067467454L,24842719624L,579640352124L,13530437284867L,315670688353352L,7364450700523381L,171831664404352036L,4009212488981256092L,BigInteger.Parse("93541351813085948519"),BigInteger.Parse("2182487674635263780504") };
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
public class A197802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197802Inst Instance=new A197802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197803
{
public static readonly BigInteger[] Value={ 6L,496L,22742L,1003304L,45619023L,2076384112L,94343594548L,4281509896358L,194608470264250L,8843165356246981L,401738582610521643L,18252432225115868140UL,BigInteger.Parse("829303172132470927219"),BigInteger.Parse("37678616097510599424872") };
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
public class A197803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197803Inst Instance=new A197803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197804
{
public static readonly BigInteger[] Value={ 9L,1601L,139212L,12108247L,1067467454L,94343594548L,8356101105886L,738902613491053L,65378440919070707L,5783165458408517862L,BigInteger.Parse("511560923077285542005"),BigInteger.Parse("45254949485645786464236"),BigInteger.Parse("4003399792733695557796480") };
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
public class A197804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197804.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197804Inst Instance=new A197804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197805
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,3L,16L,16L,3L,4L,47L,102L,47L,4L,6L,154L,596L,596L,154L,6L,9L,496L,3713L,7185L,3713L,496L,9L,13L,1601L,22742L,84258L,84258L,22742L,1601L,13L,19L,5183L,139212L,1003304L,1944779L,1003304L,139212L,5183L,19L,28L,16777L,853186L,12108247L };
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
public class A197805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197805Inst : IEnumerable<long>
{
public static readonly long[] Value=A197805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197805.Bytes);
public long this[int i]=>Value[i];

public static A197805Inst Instance=new A197805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197806
{
public static readonly long[] Value={ 1L,0L,2L,1L,6L,8L,9L,9L,5L,4L,0L,9L,2L,1L,8L,5L,2L,2L,0L,3L,1L,5L,5L,7L,0L,2L,8L,7L,9L,5L,7L,5L,9L,1L,6L,0L,6L,4L,7L,7L,2L,2L,6L,0L,3L,6L,7L,2L,4L,5L,8L,6L,4L,8L,3L,1L,5L,7L,6L,0L,9L,1L,9L,2L,9L,7L,6L,1L,6L,7L,7L,6L,8L,7L,5L,6L,2L,3L,1L,5L,3L,7L,7L,5L,2L,7L,4L,3L,0L,0L,8L,8L,4L,9L,3L,7L,7L,6L,7L };
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
public class A197806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197806Inst : IEnumerable<long>
{
public static readonly long[] Value=A197806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197806.Bytes);
public long this[int i]=>Value[i];

public static A197806Inst Instance=new A197806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197807
{
public static readonly long[] Value={ 1L,1L,3L,0L,6L,1L,9L,0L,7L,2L,7L,7L,6L,3L,9L,4L,9L,6L,1L,2L,8L,8L,6L,5L,0L,0L,5L,8L,9L,4L,5L,4L,0L,6L,8L,7L,0L,2L,7L,8L,6L,0L,8L,7L,8L,8L,9L,6L,9L,4L,2L,4L,3L,8L,5L,4L,2L,0L,9L,1L,2L,5L,6L,4L,6L,8L,5L,8L,7L,7L,4L,5L,8L,3L,3L,4L,1L,9L,9L,5L,8L,5L,0L,5L,3L,0L,9L,6L,7L,8L,3L,5L,6L,7L,0L,6L,5L,8L,5L };
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
public class A197807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197807Inst : IEnumerable<long>
{
public static readonly long[] Value=A197807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197807.Bytes);
public long this[int i]=>Value[i];

public static A197807Inst Instance=new A197807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197808
{
public static readonly long[] Value={ 1L,2L,0L,1L,5L,3L,8L,2L,9L,9L,3L,4L,0L,5L,7L,5L,1L,1L,1L,4L,8L,1L,5L,0L,8L,1L,6L,6L,5L,6L,8L,8L,5L,0L,4L,9L,1L,0L,6L,0L,8L,3L,5L,8L,1L,1L,0L,1L,8L,6L,0L,2L,7L,0L,4L,3L,2L,1L,1L,2L,0L,6L,0L,5L,6L,8L,0L,8L,5L,8L,4L,4L,0L,2L,1L,6L,9L,4L,5L,2L,2L,5L,8L,8L,4L,9L,1L,3L,7L,1L,2L,0L,5L,2L,8L,4L,3L,1L,6L };
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
public class A197808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197808Inst : IEnumerable<long>
{
public static readonly long[] Value=A197808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197808.Bytes);
public long this[int i]=>Value[i];

public static A197808Inst Instance=new A197808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197809
{
public static readonly long[] Value={ 1L,3L,4L,0L,5L,2L,5L,3L,0L,8L,1L,9L,7L,3L,9L,8L,4L,4L,7L,8L,6L,7L,6L,0L,6L,2L,8L,4L,9L,9L,6L,0L,6L,6L,0L,9L,2L,0L,5L,8L,3L,4L,1L,8L,6L,8L,9L,3L,1L,2L,0L,4L,5L,7L,5L,5L,2L,4L,7L,3L,5L,7L,7L,3L,0L,0L,2L,1L,3L,0L,7L,8L,1L,3L,0L,4L,2L,1L,6L,6L,7L,3L,0L,3L,4L,7L,6L,9L,9L,7L,5L,6L,5L,9L,9L,9L,0L,8L,2L };
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
public class A197809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197809Inst : IEnumerable<long>
{
public static readonly long[] Value=A197809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197809.Bytes);
public long this[int i]=>Value[i];

public static A197809Inst Instance=new A197809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197810
{
public static readonly long[] Value={ 7L,8L,8L,3L,9L,6L,8L,4L,5L,9L,9L,2L,9L,6L,5L,4L,2L,9L,0L,7L,8L,8L,2L,0L,9L,8L,3L,9L,8L,2L,0L,0L,1L,9L,1L,2L,2L,9L,5L,5L,1L,8L,7L,5L,3L,5L,3L,1L,2L,0L,4L,9L,1L,8L,6L,5L,0L,5L,6L,6L,5L,9L,8L,2L,7L,0L,6L,7L,8L,7L,2L,5L,7L,2L,4L,8L,7L,8L,1L,4L,6L,0L,0L,8L,8L,9L,3L,3L,7L,6L,7L,8L,6L,9L,8L,6L,2L,8L,2L };
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
public class A197810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197810Inst : IEnumerable<long>
{
public static readonly long[] Value=A197810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197810.Bytes);
public long this[int i]=>Value[i];

public static A197810Inst Instance=new A197810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197811
{
public static readonly long[] Value={ 1L,3L,8L,9L,4L,3L,7L,4L,5L,2L,7L,0L,4L,8L,2L,8L,3L,8L,9L,2L,9L,1L,4L,9L,8L,2L,5L,1L,4L,2L,9L,1L,8L,9L,2L,5L,5L,9L,6L,3L,3L,7L,3L,5L,7L,5L,8L,4L,7L,5L,0L,8L,3L,7L,1L,4L,1L,5L,6L,7L,2L,2L,7L,2L,9L,3L,7L,0L,4L,8L,1L,2L,4L,4L,7L,1L,1L,8L,9L,3L,8L,8L,4L,3L,6L,2L,8L,7L,1L,0L,6L,3L,1L,1L,2L,3L,7L,7L,6L };
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
public class A197811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197811Inst : IEnumerable<long>
{
public static readonly long[] Value=A197811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197811.Bytes);
public long this[int i]=>Value[i];

public static A197811Inst Instance=new A197811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197812
{
public static readonly long[] Value={ 9L,2L,9L,7L,3L,4L,4L,3L,0L,3L,6L,1L,8L,1L,2L,5L,0L,9L,6L,8L,8L,7L,0L,0L,4L,9L,4L,6L,9L,7L,6L,1L,0L,8L,8L,2L,4L,0L,3L,8L,8L,6L,8L,5L,5L,8L,6L,8L,9L,7L,7L,2L,0L,1L,7L,7L,2L,5L,3L,4L,9L,1L,4L,3L,6L,5L,7L,0L,7L,7L,6L,6L,8L,9L,7L,5L,9L,3L,7L,9L,1L,4L,9L,6L,7L,9L,3L,8L,5L,9L,3L,1L,2L,8L,1L,9L,4L,1L,7L };
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
public class A197812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197812Inst : IEnumerable<long>
{
public static readonly long[] Value=A197812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197812.Bytes);
public long this[int i]=>Value[i];

public static A197812Inst Instance=new A197812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197813
{
public static readonly long[] Value={ 1L,4L,2L,0L,7L,7L,6L,7L,7L,3L,1L,7L,1L,0L,0L,5L,2L,4L,9L,3L,2L,5L,0L,6L,6L,9L,4L,1L,6L,6L,1L,8L,4L,8L,8L,2L,4L,2L,4L,8L,8L,6L,0L,5L,3L,9L,6L,6L,9L,2L,4L,9L,9L,8L,8L,4L,6L,6L,5L,6L,1L,5L,0L,6L,6L,9L,5L,6L,8L,9L,4L,6L,7L,6L,7L,0L,2L,8L,3L,0L,1L,5L,3L,1L,9L,5L,3L,3L,8L,7L,0L,7L,8L,6L,5L,4L,5L,5L,6L };
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
public class A197813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197813Inst : IEnumerable<long>
{
public static readonly long[] Value=A197813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197813.Bytes);
public long this[int i]=>Value[i];

public static A197813Inst Instance=new A197813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197814
{
public static readonly long[] Value={ 1L,0L,2L,5L,1L,1L,9L,1L,1L,1L,9L,9L,2L,4L,2L,9L,0L,1L,4L,8L,4L,6L,1L,9L,8L,5L,7L,5L,0L,0L,5L,7L,8L,3L,2L,5L,1L,5L,3L,5L,3L,8L,3L,5L,2L,1L,4L,6L,7L,3L,4L,8L,9L,4L,2L,1L,5L,9L,2L,7L,4L,5L,5L,9L,7L,6L,7L,4L,9L,2L,7L,9L,1L,0L,2L,1L,2L,6L,0L,6L,9L,3L,1L,4L,3L,6L,1L,5L,9L,8L,8L,0L,8L,4L,5L,3L,6L,1L,0L };
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
public class A197814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197814Inst : IEnumerable<long>
{
public static readonly long[] Value=A197814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197814.Bytes);
public long this[int i]=>Value[i];

public static A197814Inst Instance=new A197814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197815
{
public static readonly long[] Value={ 5L,8L,9L,3L,0L,3L,2L,0L,8L,1L,5L,9L,0L,1L,2L,8L,7L,4L,7L,2L,5L,2L,2L,3L,9L,1L,9L,0L,7L,3L,8L,6L,9L,1L,8L,5L,8L,8L,9L,0L,6L,0L,9L,8L,8L,0L,5L,4L,0L,7L,0L,3L,0L,5L,5L,3L,9L,2L,1L,4L,0L,7L,5L,1L,1L,7L,1L,4L,5L,7L,1L,7L,7L,0L,6L,4L,7L,2L,4L,1L,0L,8L,8L,0L,5L,2L,2L,1L,0L,2L,0L,0L,1L,6L,9L,6L,5L,6L,7L };
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
public class A197815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197815Inst : IEnumerable<long>
{
public static readonly long[] Value=A197815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197815.Bytes);
public long this[int i]=>Value[i];

public static A197815Inst Instance=new A197815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197816
{
public static readonly long[] Value={ 102L,203L,36L,410L,50L,603L,70L,801L,970L,1010L,110L,1270L,130L,1490L,1510L,1630L,170L,1810L,190L,20030L,2110L,2230L,230L,2410L,2510L,2630L,2710L,2810L,290L,3070L,310L,32030L,3310L,3470L,3530L,3670L,370L,3830L,3970L,4010L,410L,4210L,430L,4430L,4570L,4610L,470L };
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
public class A197816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197816Inst : IEnumerable<long>
{
public static readonly long[] Value=A197816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197816.Bytes);
public long this[int i]=>Value[i];

public static A197816Inst Instance=new A197816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197817
{
public static readonly long[] Value={ 121L,20L,33L,4141L,55L,6161L,77L,8051L,9409L,10201L,1111L,120269L,1313L,140209L,150547L,160229L,1717L,180457L,1919L,20002379L,210367L,220417L,2323L,240277L,250247L,260123L,270187L,280157L,2929L,301781L,3131L,32003357L,330007L,340973L,350743L,360761L,3737L,380053L };
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
public class A197817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197817Inst : IEnumerable<long>
{
public static readonly long[] Value=A197817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197817.Bytes);
public long this[int i]=>Value[i];

public static A197817Inst Instance=new A197817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197818
{
public static readonly long[] Value={ 1L,3L,5L,15L,17L,51L,93L,255L,257L,771L,1453L,3855L,4593L,13299L,23901L,65535L,65537L,196611L,371373L,983055L,1175281L,3394803L,6103645L,16711935L,16908033L,50593539L,95245741L,252706575L,301011441L,871576563L,1566432605L,4294967295L };
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
public class A197818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197818Inst : IEnumerable<long>
{
public static readonly long[] Value=A197818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197818.Bytes);
public long this[int i]=>Value[i];

public static A197818Inst Instance=new A197818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197819
{
public static readonly long[] Value={ 0L,1L,0L,3L,2L,1L,0L,15L,10L,5L,12L,3L,6L,9L,8L,7L,2L,13L,4L,11L,14L,1L,0L,255L,170L,85L,204L,51L,102L,153L,136L,119L,34L,221L,68L,187L,238L,17L,240L,15L,90L,165L,60L,195L,150L,105L,120L,135L,210L,45L,180L,75L,30L,225L,160L,95L,10L,245L,108L,147L };
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
public class A197819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197819Inst : IEnumerable<long>
{
public static readonly long[] Value=A197819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197819.Bytes);
public long this[int i]=>Value[i];

public static A197819Inst Instance=new A197819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197820
{
public static readonly long[] Value={ 2L,2L,8L,7L,0L,8L,6L,1L,7L,7L,6L,5L,6L,5L,8L,4L,4L,8L,5L,3L,3L,7L,0L,3L,3L,3L,1L,2L,3L,1L,4L,4L,9L,1L,7L,3L,7L,3L,9L,5L,7L,8L,2L,0L,7L,5L,1L,2L,9L,2L,3L,9L,8L,4L,0L,8L,2L,9L,0L,8L,4L,3L,9L,0L,0L,4L,0L,1L,4L,3L,0L,8L,6L,4L,7L,9L,6L,9L,0L,1L,9L,2L,9L,0L,5L,6L,0L,3L,8L,9L,1L,5L,4L,1L,4L,4L,7L,3L,8L };
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
public class A197820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197820Inst : IEnumerable<long>
{
public static readonly long[] Value=A197820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197820.Bytes);
public long this[int i]=>Value[i];

public static A197820Inst Instance=new A197820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197821
{
public static readonly long[] Value={ 4L,5L,9L,2L,9L,5L,3L,4L,1L,2L,6L,2L,1L,0L,7L,5L,5L,1L,0L,5L,4L,8L,3L,7L,5L,1L,0L,3L,5L,8L,0L,5L,2L,6L,4L,9L,1L,9L,2L,0L,0L,4L,0L,4L,2L,1L,4L,7L,2L,5L,5L,0L,7L,2L,7L,3L,4L,0L,9L,2L,9L,0L,5L,4L,5L,3L,3L,6L,9L,0L,1L,8L,8L,4L,9L,5L,0L,8L,0L,6L,9L,5L,5L,7L,2L,6L,2L,8L,7L,5L,9L,9L,6L,1L,8L,6L,1L,5L,9L };
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
public class A197821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197821Inst : IEnumerable<long>
{
public static readonly long[] Value=A197821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197821.Bytes);
public long this[int i]=>Value[i];

public static A197821Inst Instance=new A197821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197822
{
public static readonly long[] Value={ 1L,7L,8L,7L,2L,0L,6L,7L,0L,3L,1L,8L,0L,7L,5L,0L,6L,1L,0L,1L,9L,8L,0L,3L,5L,2L,2L,0L,9L,8L,9L,1L,5L,7L,2L,7L,6L,1L,2L,2L,5L,2L,0L,0L,1L,6L,0L,2L,5L,4L,5L,0L,7L,0L,0L,1L,2L,1L,2L,5L,8L,3L,0L,9L,9L,2L,5L,4L,9L,3L,6L,0L,5L,7L,6L,1L,2L,0L,3L,8L,3L,0L,4L,1L,9L,1L,8L,6L,2L,2L,2L,2L,2L,7L,3L,8L,5L,6L,4L };
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
public class A197822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197822Inst : IEnumerable<long>
{
public static readonly long[] Value=A197822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197822.Bytes);
public long this[int i]=>Value[i];

public static A197822Inst Instance=new A197822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197823
{
public static readonly long[] Value={ 7L,8L,4L,4L,4L,0L,1L,9L,2L,8L,5L,5L,0L,2L,2L,8L,1L,3L,6L,0L,3L,5L,1L,4L,8L,1L,1L,7L,4L,9L,9L,0L,4L,2L,6L,0L,0L,7L,8L,6L,5L,3L,8L,2L,3L,6L,7L,1L,4L,1L,9L,7L,2L,0L,5L,1L,0L,6L,4L,5L,0L,3L,7L,1L,7L,4L,8L,7L,7L,7L,9L,1L,0L,7L,4L,5L,4L,9L,9L,0L,4L,7L,8L,0L,0L,0L,3L,1L,3L,8L,0L,3L,8L,6L,9L,0L,0L,2L,6L };
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
public class A197823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197823Inst : IEnumerable<long>
{
public static readonly long[] Value=A197823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197823.Bytes);
public long this[int i]=>Value[i];

public static A197823Inst Instance=new A197823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197824
{
public static readonly long[] Value={ 8L,6L,3L,3L,1L,3L,7L,7L,3L,1L,5L,8L,5L,4L,3L,7L,3L,6L,7L,4L,3L,5L,2L,1L,3L,6L,9L,3L,9L,7L,2L,0L,7L,4L,9L,5L,0L,8L,3L,2L,6L,1L,5L,5L,5L,8L,8L,9L,9L,0L,8L,0L,0L,5L,6L,6L,0L,4L,7L,0L,6L,3L,3L,2L,7L,5L,6L,3L,1L,3L,3L,1L,1L,5L,4L,0L,5L,5L,6L,7L,1L,1L,5L,1L,3L,8L,1L,4L,7L,9L,1L,9L,9L,5L,5L,3L,7L,3L,2L };
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
public class A197824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197824Inst : IEnumerable<long>
{
public static readonly long[] Value=A197824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197824.Bytes);
public long this[int i]=>Value[i];

public static A197824Inst Instance=new A197824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197825
{
public static readonly long[] Value={ 3L,5L,4L,4L,9L,6L,3L,6L,7L,4L,1L,3L,6L,7L,6L,7L,0L,4L,4L,7L,7L,3L,4L,5L,8L,9L,5L,9L,5L,0L,2L,7L,0L,7L,3L,3L,4L,9L,3L,4L,0L,3L,8L,7L,1L,3L,2L,9L,6L,0L,6L,8L,9L,0L,4L,8L,3L,8L,4L,1L,3L,2L,6L,3L,4L,4L,7L,5L,4L,4L,4L,3L,9L,7L,7L,4L,4L,3L,9L,6L,1L,9L,5L,8L,3L,2L,8L,8L,2L,1L,1L,2L,0L,2L,5L,4L,1L,0L,5L };
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
public class A197825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197825Inst : IEnumerable<long>
{
public static readonly long[] Value=A197825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197825.Bytes);
public long this[int i]=>Value[i];

public static A197825Inst Instance=new A197825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197826
{
public static readonly long[] Value={ 8L,9L,3L,6L,9L,3L,7L,8L,8L,9L,7L,4L,1L,6L,5L,1L,3L,0L,8L,1L,7L,1L,7L,5L,5L,5L,0L,2L,2L,6L,1L,1L,9L,9L,5L,4L,3L,9L,2L,0L,0L,5L,7L,4L,7L,0L,0L,0L,3L,1L,6L,2L,3L,2L,3L,8L,5L,6L,9L,7L,0L,4L,8L,3L,5L,7L,6L,0L,0L,3L,1L,6L,2L,5L,8L,3L,7L,9L,7L,4L,6L,0L,1L,5L,4L,2L,4L,3L,9L,5L,9L,1L,9L,1L,4L,7L,5L,2L,4L };
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
public class A197826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197826Inst : IEnumerable<long>
{
public static readonly long[] Value=A197826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197826.Bytes);
public long this[int i]=>Value[i];

public static A197826Inst Instance=new A197826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197827
{
public static readonly long[] Value={ 2L,4L,4L,0L,5L,5L,0L,5L,5L,1L,2L,1L,2L,4L,6L,6L,8L,6L,8L,5L,3L,5L,6L,4L,2L,9L,7L,8L,4L,8L,4L,9L,5L,3L,5L,6L,5L,6L,6L,3L,6L,9L,3L,6L,1L,6L,5L,8L,4L,1L,3L,6L,0L,5L,9L,4L,5L,7L,7L,6L,9L,0L,2L,8L,3L,2L,8L,3L,5L,3L,4L,7L,3L,8L,2L,2L,4L,7L,1L,9L,2L,5L,0L,9L,7L,7L,9L,7L,3L,9L,6L,8L,9L,3L,1L,4L,0L,6L,6L };
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
public class A197827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197827Inst : IEnumerable<long>
{
public static readonly long[] Value=A197827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197827.Bytes);
public long this[int i]=>Value[i];

public static A197827Inst Instance=new A197827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197828
{
public static readonly long[] Value={ 1L,9L,4L,0L,2L,1L,5L,7L,4L,4L,6L,8L,0L,2L,5L,3L,0L,5L,5L,0L,2L,7L,0L,3L,9L,1L,5L,6L,2L,4L,8L,8L,5L,2L,6L,8L,1L,5L,4L,8L,5L,7L,4L,7L,0L,8L,1L,5L,8L,3L,3L,0L,4L,2L,0L,7L,3L,5L,0L,3L,0L,2L,3L,3L,9L,8L,7L,7L,5L,9L,8L,1L,8L,4L,5L,3L,1L,3L,5L,6L,4L,8L,2L,2L,0L,5L,1L,8L,1L,2L,0L,9L,2L,7L,6L,1L,6L,1L,3L };
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
public class A197828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197828Inst : IEnumerable<long>
{
public static readonly long[] Value=A197828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197828.Bytes);
public long this[int i]=>Value[i];

public static A197828Inst Instance=new A197828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197829
{
public static readonly long[] Value={ 4L,3L,6L,8L,9L,4L,8L,9L,1L,5L,2L,3L,0L,2L,8L,1L,1L,6L,2L,1L,5L,5L,5L,6L,8L,3L,4L,2L,4L,2L,4L,4L,2L,0L,9L,9L,7L,8L,6L,8L,8L,9L,9L,1L,4L,9L,9L,5L,4L,9L,7L,1L,5L,0L,9L,1L,9L,2L,6L,4L,0L,6L,1L,2L,6L,7L,8L,3L,5L,9L,4L,2L,3L,1L,8L,1L,3L,1L,3L,8L,7L,1L,3L,8L,6L,1L,4L,7L,5L,0L,9L,0L,7L,5L,8L,0L,5L,3L,7L };
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
public class A197829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197829Inst : IEnumerable<long>
{
public static readonly long[] Value=A197829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197829.Bytes);
public long this[int i]=>Value[i];

public static A197829Inst Instance=new A197829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197830
{
public static readonly long[] Value={ 9L,1L,2L,5L,8L,0L,5L,5L,0L,1L,5L,9L,2L,7L,8L,8L,0L,1L,2L,8L,7L,2L,6L,9L,8L,7L,1L,2L,6L,7L,7L,0L,4L,2L,4L,4L,1L,9L,7L,2L,3L,7L,5L,5L,1L,7L,1L,3L,9L,1L,4L,3L,7L,8L,4L,8L,4L,2L,5L,7L,4L,0L,6L,5L,6L,9L,7L,2L,7L,6L,5L,0L,0L,9L,8L,9L,3L,6L,6L,7L,1L,1L,6L,0L,0L,7L,6L,2L,5L,5L,0L,6L,0L,0L,3L,1L,9L,3L,3L };
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
public class A197830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197830Inst : IEnumerable<long>
{
public static readonly long[] Value=A197830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197830.Bytes);
public long this[int i]=>Value[i];

public static A197830Inst Instance=new A197830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197831
{
public static readonly long[] Value={ 3L,2L,9L,9L,3L,2L,9L,1L,4L,5L,0L,3L,6L,2L,8L,4L,6L,9L,3L,1L,5L,8L,2L,1L,1L,4L,0L,1L,8L,0L,7L,9L,1L,0L,2L,4L,0L,8L,2L,0L,3L,6L,9L,7L,1L,1L,9L,9L,1L,5L,9L,0L,3L,9L,0L,9L,4L,5L,8L,8L,0L,9L,1L,7L,6L,9L,0L,2L,0L,5L,7L,1L,3L,7L,8L,5L,5L,3L,1L,1L,5L,1L,2L,2L,5L,6L,0L,0L,0L,7L,6L,4L,3L,7L,2L,7L,1L,1L,3L };
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
public class A197831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197831Inst : IEnumerable<long>
{
public static readonly long[] Value=A197831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197831.Bytes);
public long this[int i]=>Value[i];

public static A197831Inst Instance=new A197831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197832
{
public static readonly long[] Value={ 9L,3L,6L,8L,8L,6L,7L,7L,4L,1L,5L,2L,2L,0L,5L,5L,1L,9L,7L,8L,7L,9L,9L,3L,0L,3L,0L,9L,5L,4L,1L,5L,4L,2L,6L,6L,2L,3L,8L,0L,9L,8L,8L,9L,7L,4L,9L,4L,9L,3L,6L,4L,0L,3L,2L,3L,3L,4L,9L,3L,1L,2L,7L,0L,8L,5L,5L,6L,9L,2L,4L,1L,6L,7L,3L,4L,3L,7L,7L,6L,9L,2L,6L,2L,2L,2L,0L,4L,4L,1L,2L,7L,6L,5L,4L,4L,7L,8L,4L };
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
public class A197832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197832Inst : IEnumerable<long>
{
public static readonly long[] Value=A197832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197832.Bytes);
public long this[int i]=>Value[i];

public static A197832Inst Instance=new A197832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197833
{
public static readonly long[] Value={ 1L,6L,4L,8L,4L,3L,9L,4L,6L,7L,0L,4L,9L,4L,0L,0L,1L,2L,6L,0L,0L,5L,7L,0L,3L,5L,6L,1L,9L,0L,8L,8L,9L,8L,8L,9L,3L,0L,5L,2L,3L,2L,1L,8L,4L,8L,0L,9L,1L,2L,4L,0L,2L,0L,0L,3L,4L,0L,6L,2L,7L,1L,5L,7L,2L,6L,6L,6L,6L,8L,0L,3L,5L,6L,2L,9L,5L,3L,6L,9L,4L,7L,4L,3L,7L,0L,6L,5L,7L,8L,5L,2L,5L,2L,9L,6L,4L,1L,3L };
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
public class A197833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197833Inst : IEnumerable<long>
{
public static readonly long[] Value=A197833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197833.Bytes);
public long this[int i]=>Value[i];

public static A197833Inst Instance=new A197833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197834
{
public static readonly long[] Value={ 1L,9L,7L,2L,7L,7L,6L,6L,3L,6L,9L,3L,9L,5L,0L,9L,5L,6L,2L,4L,3L,7L,0L,9L,7L,9L,6L,0L,8L,8L,4L,5L,8L,7L,7L,2L,1L,8L,6L,2L,1L,8L,6L,9L,2L,9L,2L,8L,2L,5L,7L,6L,7L,4L,8L,0L,8L,3L,5L,9L,9L,8L,9L,7L,0L,6L,8L,8L,4L,2L,8L,2L,5L,7L,7L,4L,2L,3L,6L,3L,9L,3L,0L,0L,7L,1L,2L,7L,1L,3L,7L,3L,6L,9L,8L,1L,2L,2L,1L };
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
public class A197834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197834Inst : IEnumerable<long>
{
public static readonly long[] Value=A197834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197834.Bytes);
public long this[int i]=>Value[i];

public static A197834Inst Instance=new A197834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197835
{
public static readonly long[] Value={ 3L,7L,0L,4L,4L,9L,4L,4L,4L,1L,4L,8L,2L,7L,9L,8L,5L,5L,1L,4L,3L,8L,9L,5L,5L,1L,3L,0L,6L,3L,6L,4L,4L,2L,7L,7L,7L,7L,3L,3L,3L,5L,9L,4L,6L,2L,6L,7L,4L,6L,8L,3L,6L,5L,1L,4L,3L,0L,8L,1L,8L,1L,7L,8L,4L,3L,4L,4L,4L,4L,6L,0L,1L,2L,4L,0L,8L,0L,8L,2L,3L,6L,2L,5L,7L,6L,5L,5L,7L,3L,5L,5L,0L,9L,0L,9L,9L,9L,4L };
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
public class A197835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197835Inst : IEnumerable<long>
{
public static readonly long[] Value=A197835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197835.Bytes);
public long this[int i]=>Value[i];

public static A197835Inst Instance=new A197835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197836
{
public static readonly long[] Value={ 9L,3L,7L,6L,3L,4L,5L,4L,9L,2L,7L,6L,9L,5L,3L,9L,6L,8L,3L,5L,8L,6L,8L,7L,7L,0L,9L,9L,9L,2L,6L,5L,0L,3L,3L,6L,5L,6L,1L,2L,4L,7L,0L,8L,5L,2L,6L,4L,0L,0L,6L,0L,4L,1L,2L,3L,5L,9L,1L,3L,1L,6L,4L,6L,1L,9L,5L,9L,2L,9L,1L,4L,3L,1L,4L,6L,7L,1L,2L,0L,6L,2L,5L,7L,9L,9L,2L,1L,6L,6L,9L,7L,8L,1L,6L,8L,9L,1L,4L };
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
public class A197836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197836Inst : IEnumerable<long>
{
public static readonly long[] Value=A197836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197836.Bytes);
public long this[int i]=>Value[i];

public static A197836Inst Instance=new A197836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197837
{
public static readonly long[] Value={ 3L,7L,2L,8L,9L,9L,1L,6L,3L,4L,2L,2L,3L,3L,0L,9L,7L,6L,9L,2L,7L,0L,6L,1L,1L,2L,8L,5L,3L,7L,3L,9L,9L,4L,1L,6L,0L,9L,7L,5L,0L,1L,1L,5L,2L,1L,4L,3L,3L,4L,8L,3L,6L,3L,0L,1L,6L,9L,6L,7L,6L,8L,4L,4L,1L,8L,2L,3L,8L,2L,9L,7L,6L,8L,3L,3L,0L,0L,9L,5L,5L,2L,3L,7L,4L,7L,8L,0L,5L,5L,5L,6L,3L,3L,9L,2L,7L,3L,0L };
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
public class A197837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197837Inst : IEnumerable<long>
{
public static readonly long[] Value=A197837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197837.Bytes);
public long this[int i]=>Value[i];

public static A197837Inst Instance=new A197837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197838
{
public static readonly long[] Value={ 9L,5L,5L,3L,7L,2L,4L,3L,1L,0L,9L,3L,2L,1L,6L,6L,5L,8L,4L,4L,0L,0L,6L,7L,0L,7L,5L,0L,0L,0L,1L,3L,7L,1L,6L,1L,3L,6L,8L,2L,1L,6L,4L,8L,7L,5L,1L,2L,5L,4L,9L,5L,4L,9L,4L,2L,5L,4L,5L,4L,2L,0L,6L,2L,6L,6L,3L,2L,5L,2L,9L,1L,7L,6L,7L,6L,2L,8L,7L,2L,3L,4L,8L,9L,8L,4L,5L,2L,8L,9L,3L,5L,3L,0L,0L,4L,4L,8L,9L };
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
public class A197838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197838Inst : IEnumerable<long>
{
public static readonly long[] Value=A197838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197838.Bytes);
public long this[int i]=>Value[i];

public static A197838Inst Instance=new A197838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197839
{
public static readonly long[] Value={ 2L,5L,8L,3L,9L,2L,1L,4L,4L,3L,7L,1L,5L,9L,9L,6L,7L,4L,0L,2L,7L,5L,7L,4L,2L,3L,8L,0L,7L,3L,8L,6L,0L,2L,7L,5L,2L,6L,1L,0L,1L,6L,7L,1L,1L,3L,5L,5L,3L,3L,3L,7L,1L,4L,8L,5L,1L,6L,5L,7L,1L,4L,3L,0L,0L,8L,6L,6L,0L,7L,0L,4L,4L,6L,0L,0L,0L,8L,7L,7L,8L,1L,4L,7L,0L,5L,5L,3L,8L,8L,8L,7L,4L,3L,7L,8L,8L,4L,2L };
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
public class A197839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197839Inst : IEnumerable<long>
{
public static readonly long[] Value=A197839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197839.Bytes);
public long this[int i]=>Value[i];

public static A197839Inst Instance=new A197839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197840
{
public static readonly long[] Value={ 4L,1L,3L,2L,5L,7L,3L,4L,7L,0L,7L,5L,3L,8L,6L,8L,3L,0L,8L,1L,9L,8L,4L,4L,1L,7L,0L,5L,3L,6L,2L,8L,0L,6L,1L,2L,1L,0L,5L,5L,1L,8L,5L,3L,1L,5L,3L,8L,1L,1L,1L,8L,0L,1L,1L,7L,2L,6L,0L,4L,0L,6L,9L,4L,2L,3L,3L,7L,8L,0L,0L,3L,2L,1L,2L,4L,7L,6L,1L,8L,2L,7L,0L,6L,7L,2L,4L,2L,3L,5L,8L,4L,3L,9L,1L,8L,1L,4L,3L };
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
public class A197840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197840Inst : IEnumerable<long>
{
public static readonly long[] Value=A197840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197840.Bytes);
public long this[int i]=>Value[i];

public static A197840Inst Instance=new A197840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197841
{
public static readonly long[] Value={ 1L,8L,5L,0L,7L,1L,7L,4L,4L,1L,5L,6L,1L,9L,8L,2L,9L,0L,1L,2L,9L,7L,8L,7L,8L,8L,3L,1L,4L,5L,8L,8L,7L,4L,4L,9L,2L,3L,9L,5L,6L,3L,3L,6L,9L,1L,3L,7L,1L,4L,2L,8L,7L,9L,1L,6L,1L,7L,6L,9L,7L,0L,2L,3L,2L,0L,9L,6L,1L,4L,6L,7L,3L,5L,0L,9L,4L,6L,9L,2L,9L,6L,0L,2L,4L,5L,4L,8L,8L,9L,3L,2L,3L,3L,7L,3L,4L,3L,2L };
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
public class A197841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197841Inst : IEnumerable<long>
{
public static readonly long[] Value=A197841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197841.Bytes);
public long this[int i]=>Value[i];

public static A197841Inst Instance=new A197841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197842
{
public static readonly long[] Value={ 3L,8L,7L,7L,2L,2L,1L,2L,0L,2L,5L,4L,9L,8L,5L,3L,3L,4L,2L,7L,1L,8L,5L,2L,0L,0L,5L,2L,4L,8L,3L,2L,9L,2L,3L,6L,1L,5L,7L,7L,1L,5L,8L,9L,3L,8L,9L,2L,9L,9L,4L,3L,6L,7L,8L,2L,8L,6L,6L,4L,9L,5L,4L,7L,0L,0L,9L,3L,5L,0L,2L,5L,3L,4L,4L,9L,6L,5L,8L,5L,5L,1L,3L,2L,2L,1L,7L,3L,7L,2L,1L,6L,3L,0L,2L,6L,2L,8L,3L };
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
public class A197842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197842Inst : IEnumerable<long>
{
public static readonly long[] Value=A197842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197842.Bytes);
public long this[int i]=>Value[i];

public static A197842Inst Instance=new A197842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197843
{
public static readonly long[] Value={ 1L,7L,7L,3L,2L,3L,2L,1L,5L,7L,4L,9L,1L,7L,1L,6L,7L,2L,7L,0L,3L,8L,9L,9L,4L,6L,4L,1L,9L,7L,0L,8L,1L,6L,4L,1L,4L,1L,0L,2L,3L,7L,2L,3L,3L,5L,3L,6L,6L,7L,2L,8L,8L,2L,4L,4L,9L,4L,6L,2L,8L,1L,2L,1L,2L,5L,3L,7L,2L,4L,5L,4L,6L,6L,0L,4L,1L,4L,2L,7L,2L,1L,9L,2L,9L,7L,3L,7L,4L,8L,3L,3L,9L,8L,1L,1L,2L,3L,8L };
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
public class A197843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197843Inst : IEnumerable<long>
{
public static readonly long[] Value=A197843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197843.Bytes);
public long this[int i]=>Value[i];

public static A197843Inst Instance=new A197843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197844
{
public static readonly long[] Value={ 6L,2L,0L,7L,6L,2L,3L,3L,6L,5L,8L,6L,6L,1L,4L,7L,1L,4L,4L,5L,2L,1L,2L,0L,2L,4L,7L,3L,2L,1L,5L,1L,5L,3L,7L,1L,4L,4L,3L,4L,1L,1L,7L,7L,8L,5L,8L,7L,1L,4L,0L,9L,1L,6L,4L,2L,4L,8L,3L,0L,0L,9L,3L,7L,3L,1L,1L,0L,4L,9L,0L,2L,1L,6L,0L,2L,3L,6L,8L,0L,1L,5L,1L,6L,3L,7L,1L,7L,0L,3L,1L,1L,5L,2L,5L,5L,7L,6L,2L };
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
public class A197844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197844Inst : IEnumerable<long>
{
public static readonly long[] Value=A197844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197844.Bytes);
public long this[int i]=>Value[i];

public static A197844Inst Instance=new A197844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197845
{
public static readonly long[] Value={ 1L,7L,2L,8L,0L,7L,8L,0L,8L,6L,2L,5L,3L,1L,4L,2L,1L,7L,1L,3L,9L,7L,2L,4L,5L,4L,3L,2L,4L,2L,4L,7L,6L,8L,2L,6L,7L,7L,6L,2L,0L,8L,0L,6L,2L,0L,8L,4L,3L,1L,3L,3L,5L,4L,1L,6L,2L,6L,1L,2L,4L,2L,5L,1L,3L,8L,6L,4L,1L,6L,9L,0L,4L,2L,6L,1L,7L,0L,0L,3L,8L,7L,3L,5L,0L,7L,3L,9L,8L,9L,6L,7L,6L,4L,8L,6L,2L,4L,4L };
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
public class A197845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197845Inst : IEnumerable<long>
{
public static readonly long[] Value=A197845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197845.Bytes);
public long this[int i]=>Value[i];

public static A197845Inst Instance=new A197845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197846
{
public static readonly long[] Value={ 7L,7L,3L,6L,9L,6L,1L,8L,9L,2L,4L,3L,8L,0L,9L,4L,2L,1L,7L,1L,4L,7L,3L,9L,0L,5L,3L,5L,3L,0L,4L,5L,3L,3L,3L,6L,8L,0L,5L,7L,2L,1L,2L,5L,6L,8L,2L,4L,5L,8L,2L,4L,0L,7L,9L,1L,1L,0L,4L,5L,4L,2L,4L,9L,8L,1L,2L,9L,4L,1L,0L,7L,6L,2L,5L,1L,4L,0L,0L,5L,2L,7L,0L,1L,6L,9L,0L,0L,6L,3L,8L,8L,0L,4L,0L,8L,2L,8L,2L };
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
public class A197846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197846Inst : IEnumerable<long>
{
public static readonly long[] Value=A197846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197846.Bytes);
public long this[int i]=>Value[i];

public static A197846Inst Instance=new A197846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197847
{
public static readonly long[] Value={ 1L,6L,9L,8L,9L,9L,7L,7L,5L,1L,9L,9L,8L,4L,8L,9L,0L,8L,3L,1L,8L,4L,2L,9L,2L,8L,7L,9L,6L,9L,8L,5L,5L,4L,8L,1L,4L,5L,6L,2L,2L,3L,9L,0L,8L,1L,5L,2L,0L,2L,2L,2L,7L,3L,4L,9L,7L,5L,6L,9L,3L,7L,1L,2L,1L,9L,1L,8L,3L,3L,0L,0L,6L,5L,2L,0L,5L,2L,6L,9L,8L,0L,3L,6L,9L,8L,6L,8L,9L,5L,3L,1L,0L,1L,9L,0L,4L,4L,5L };
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
public class A197847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197847Inst : IEnumerable<long>
{
public static readonly long[] Value=A197847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197847.Bytes);
public long this[int i]=>Value[i];

public static A197847Inst Instance=new A197847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197848
{
public static readonly long[] Value={ 8L,8L,2L,0L,7L,4L,3L,6L,6L,1L,1L,8L,4L,7L,4L,9L,8L,0L,2L,1L,9L,8L,7L,3L,9L,5L,5L,2L,2L,3L,9L,4L,3L,7L,4L,9L,1L,5L,7L,0L,7L,7L,8L,0L,8L,0L,9L,9L,9L,0L,8L,6L,6L,5L,3L,2L,6L,4L,6L,6L,2L,7L,7L,5L,0L,1L,2L,1L,6L,7L,1L,9L,8L,9L,9L,7L,5L,8L,7L,6L,4L,4L,5L,0L,6L,3L,7L,1L,5L,5L,9L,1L,3L,1L,5L,9L,6L,6L,0L };
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
public class A197848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197848Inst : IEnumerable<long>
{
public static readonly long[] Value=A197848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197848.Bytes);
public long this[int i]=>Value[i];

public static A197848Inst Instance=new A197848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197849
{
public static readonly long[] Value={ 1L,0L,4L,8L,5L,5L,8L,3L,5L,9L,4L,9L,0L,4L,9L,4L,0L,9L,5L,7L,5L,8L,5L,6L,5L,2L,6L,4L,0L,4L,5L,4L,9L,3L,1L,9L,3L,1L,5L,3L,0L,9L,0L,2L,5L,3L,2L,8L,2L,2L,4L,6L,8L,1L,8L,8L,4L,3L,1L,1L,0L,2L,4L,1L,5L,1L,3L,5L,8L,8L,9L,5L,6L,0L,0L,5L,9L,0L,8L,9L,1L,7L,5L,2L,4L,4L,2L,1L,8L,2L,9L,9L,7L,0L,9L,5L,4L,0L,1L };
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
public class A197849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197849Inst : IEnumerable<long>
{
public static readonly long[] Value=A197849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197849.Bytes);
public long this[int i]=>Value[i];

public static A197849Inst Instance=new A197849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197850
{
public static readonly long[] Value={ 2L,6L,6L,7L,0L,2L,8L,4L,6L,4L,1L,0L,5L,8L,0L,1L,7L,9L,2L,6L,3L,5L,5L,4L,2L,1L,2L,9L,4L,9L,8L,3L,9L,9L,7L,4L,5L,8L,1L,5L,6L,8L,7L,8L,0L,8L,6L,3L,0L,3L,0L,2L,9L,7L,8L,5L,5L,1L,5L,5L,7L,5L,5L,6L,9L,0L,1L,1L,4L,1L,9L,8L,8L,3L,6L,3L,1L,8L,2L,9L,4L,1L,9L,1L,0L,4L,6L,8L,2L,6L,2L,6L,1L,3L,4L,5L,2L,3L,9L };
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
public class A197850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197850Inst : IEnumerable<long>
{
public static readonly long[] Value=A197850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197850.Bytes);
public long this[int i]=>Value[i];

public static A197850Inst Instance=new A197850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197851
{
public static readonly ulong[] Value={ 1L,4L,10L,103L,1487L,43030L,2321125L,232682724L,43647140344L,15284990897875L,9995202105923896L,12206122815436711870UL };
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
public class A197851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197851Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A197851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197851.Bytes);
public ulong this[int i]=>Value[i];

public static A197851Inst Instance=new A197851Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197852
{
public static readonly long[] Value={ 1L,4L,12L,81L,893L,15724L,461526L,21160235L,1588993194L,193123531704L,38467394450377L };
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
public class A197852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197852Inst : IEnumerable<long>
{
public static readonly long[] Value=A197852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197852.Bytes);
public long this[int i]=>Value[i];

public static A197852Inst Instance=new A197852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197853
{
public static readonly long[] Value={ 1L,7L,22L,263L,5883L,269045L,23032477L,3863987076L,1263453276727L,804280010720339L };
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
public class A197853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197853Inst : IEnumerable<long>
{
public static readonly long[] Value=A197853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197853.Bytes);
public long this[int i]=>Value[i];

public static A197853Inst Instance=new A197853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197854
{
public static readonly long[] Value={ 1L,1L,4L,23L,99L,3534L,128172L,3539360L,652403517L,143579369777L };
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
public class A197854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197854Inst : IEnumerable<long>
{
public static readonly long[] Value=A197854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197854.Bytes);
public long this[int i]=>Value[i];

public static A197854Inst Instance=new A197854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197855
{
public static readonly long[] Value={ 1L,2L,5L,18L,139L,1407L,36344L,1361785L,74076700L,9299546681L,1791187843433L };
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
public class A197855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197855Inst : IEnumerable<long>
{
public static readonly long[] Value=A197855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197855.Bytes);
public long this[int i]=>Value[i];

public static A197855Inst Instance=new A197855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197856
{
public static readonly long[] Value={ 1L,7L,45L,630L,16425L,795212L,73597267L,12852258424L,4231009372419L,2633791007183728L,3098137435019686237L };
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
public class A197856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197856Inst : IEnumerable<long>
{
public static readonly long[] Value=A197856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197856.Bytes);
public long this[int i]=>Value[i];

public static A197856Inst Instance=new A197856Inst();

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