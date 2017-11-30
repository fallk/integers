using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A259482
{
public static readonly long[] Value={ 2L,6L,44L,2014L };
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
public class A259482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259482Inst : IEnumerable<long>
{
public static readonly long[] Value=A259482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259482.Bytes);
public long this[int i]=>Value[i];

public static A259482Inst Instance=new A259482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259483
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,9L,10L,19L,20L,29L,39L,42L,52L,62L,72L,91L,101L,111L,163L,254L,264L,365L,629L,730L,994L,1095L,1359L,1460L,1724L,2089L,2454L,2819L,9076L,9441L,9806L,18517L,18882L,39488L,48929L,58370L,67811L,107299L,116740L,156228L,165669L,214598L,224039L,272968L,331338L,380267L };
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
public class A259483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259483Inst : IEnumerable<long>
{
public static readonly long[] Value=A259483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259483.Bytes);
public long this[int i]=>Value[i];

public static A259483Inst Instance=new A259483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259484
{
public static readonly long[] Value={ 1L,0L,9L,4L,0L,6L,1681L,22L,0L,0L,97969L,118L,16900321L,914L,1062961L,542L,0L,262L,2827367929L,382L };
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
public class A259484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259484Inst : IEnumerable<long>
{
public static readonly long[] Value=A259484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259484.Bytes);
public long this[int i]=>Value[i];

public static A259484Inst Instance=new A259484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259485
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,275L,4066L,85888L,2567269L,107630237L,6269269823L,502429080919L,54869692738326L,8091237358339821L,1597342350434681954L,BigInteger.Parse("418809228874760212806"),BigInteger.Parse("144760685900877097431589"),BigInteger.Parse("65510311668753649557469187"),BigInteger.Parse("38566383210089506976493649269"),BigInteger.Parse("29359678772700284486457832056879") };
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
public class A259485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259485Inst Instance=new A259485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259486
{
public static readonly long[] Value={ 1L,7L,19L,43L,73L,109L,157L,211L,271L,343L,421L,505L,601L,703L,811L,931L,1057L,1189L,1333L,1483L,1639L,1807L,1981L,2161L,2353L,2551L,2755L,2971L,3193L,3421L,3661L,3907L,4159L,4423L,4693L,4969L,5257L,5551L,5851L,6163L,6481L,6805L,7141L,7483L,7831L,8191L,8557L };
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
public class A259486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259486Inst : IEnumerable<long>
{
public static readonly long[] Value=A259486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259486.Bytes);
public long this[int i]=>Value[i];

public static A259486Inst Instance=new A259486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259487
{
public static readonly long[] Value={ 2L,1860L,408L,25011L,51312L,37977L,695L,4071L,10970L,3621L,17671L,12005L,1230L,19494L,542L,577L,408L,2476L,584L,542L,469L,34229L,343L,24078L,3011L,25749L,20706L,24198L,2478L,3926L,1030L,1030L,13857L,3621L,343L,13380L,2476L,4922L,2476L,296L,19176L,29175L,34737L,13L,625L,2956L,408L,572L,7L,469L,15604L,9699L,26515L,2167L,5302L,9773L,54254L,1410L,4524L,4351L };
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
public class A259487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259487Inst : IEnumerable<long>
{
public static readonly long[] Value=A259487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259487.Bytes);
public long this[int i]=>Value[i];

public static A259487Inst Instance=new A259487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259488
{
public static readonly long[] Value={ 2L,3L,7L,13L,296L,343L,395L,405L,408L,463L,469L,473L,542L,572L,577L,584L,625L,671L,673L,695L,837L,984L,1016L,1030L,1074L,1165L,1224L,1230L,1328L,1410L,1445L,1679L,1825L,1860L,1867L,1949L,2078L,2091L,2095L,2123L,2167L,2476L,2478L,2616L,2753L,2764L,2956L,3011L,3065L,3416L,3621L,3646L,3712L,3720L,3758L,3872L,3926L,4063L,4071L,4079L,4133L,4217L,4312L,4351L,4524L,4745L,4855L,4865L,4882L,4922L };
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
public class A259488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259488Inst : IEnumerable<long>
{
public static readonly long[] Value=A259488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259488.Bytes);
public long this[int i]=>Value[i];

public static A259488Inst Instance=new A259488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259489
{
public static readonly long[] Value={ 17L,38L,131L,171L,360L,392L,500L,512L,605L,729L,863L,1031L,1035L,1481L,1737L,1994L,2156L,2268L,2483L,2513L,2520L,2732L,2817L,3011L,3240L,3384L,3449L,3710L,3881L,3923L,4032L,4100L,4112L,4145L,4572L,5193L,5456L,5598L,5720L,5832L,5903L,5924L,7164L,7388L,7625L,7631L };
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
public class A259489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259489Inst : IEnumerable<long>
{
public static readonly long[] Value=A259489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259489.Bytes);
public long this[int i]=>Value[i];

public static A259489Inst Instance=new A259489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259490
{
public static readonly long[] Value={ 2L,4L,9L,33L,595L,1127L,2003L,3611L,4356L,6926L };
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
public class A259490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259490Inst : IEnumerable<long>
{
public static readonly long[] Value=A259490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259490.Bytes);
public long this[int i]=>Value[i];

public static A259490Inst Instance=new A259490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259491
{
public static readonly long[] Value={ 1L,-4L,0L,16L,-16L,8L,0L,-96L,112L,44L,0L,176L,-448L,-88L,0L,-32L,1136L,-200L,0L,-176L,-2016L,384L,0L,224L,3136L,484L,0L,-608L,-5504L,-792L,0L,640L,9328L,-704L,0L,192L,-12112L,648L,0L,352L,14112L,792L,0L,-208L,-21312L,-88L,0L,-2112L,31808L,-932L,0L,800L };
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
public class A259491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259491Inst : IEnumerable<long>
{
public static readonly long[] Value=A259491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259491.Bytes);
public long this[int i]=>Value[i];

public static A259491Inst Instance=new A259491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259492
{
public static readonly long[] Value={ 4L,48852L,6L,27330L,89814L,13080L,9570L,44592L,6762L,28560L,1560L,8580L,2958L,672L,9816L,6300L,40050L,53580L,3354L,858L,4530L,100650L,182520L,49740L,48660L,25296L,66990L,87120L,43680L,6840L,52122L,2970L,22770L,15888L,34704L,406350L,67890L,99630L,92490L,83064L,28614L,8580L,32070L,42L,50442L,38676L,818202L,30450L,47880L,4620L };
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
public class A259492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259492Inst : IEnumerable<long>
{
public static readonly long[] Value=A259492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259492.Bytes);
public long this[int i]=>Value[i];

public static A259492Inst Instance=new A259492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259493
{
public static readonly long[] Value={ 0L,1L,21L,148L,1078L,7898L,60843L,486390L,3969956L,33123937L,280486145L,2411806083L };
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
public class A259493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259493Inst : IEnumerable<long>
{
public static readonly long[] Value=A259493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259493.Bytes);
public long this[int i]=>Value[i];

public static A259493Inst Instance=new A259493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259494
{
public static readonly long[] Value={ 3L,3L,3L,2L,2L,3L,7L,4L,3L,6L,3L,6L,1L,2L,0L,6L,3L,3L,4L,3L,7L,4L,1L,7L,8L,6L,1L,7L,7L,8L,9L,2L,2L,7L,9L,6L,0L,2L,8L,0L,6L,8L,4L,5L,0L,4L,8L,7L,4L,2L,6L,8L,2L,3L,4L,0L,8L,4L,3L,1L,4L,0L,9L,9L,3L,2L,0L,7L,5L,8L,8L,0L,9L,6L,3L,5L,4L,0L,7L,0L,4L,9L,4L,0L,2L,3L,0L,0L,8L,2L,9L,8L,3L,8L,1L,9L,1L,8L,7L,6L,8L,2L,7L,1L,3L };
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
public class A259494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259494Inst : IEnumerable<long>
{
public static readonly long[] Value=A259494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259494.Bytes);
public long this[int i]=>Value[i];

public static A259494Inst Instance=new A259494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259495
{
public static readonly long[] Value={ 4L,285L,902L,2013L,8493L,37406L,61918L,90094L,120001L,184484L,250550L,303853L,352941L,360446L,375565L,501693L,724934L,889285L,940093L,995630L,1079662L,1473565L,1488957L,1517206L,1573045L,1581806L,1692302L,1864285L,2048973L,2693517L,3393934L,3509997L,4083526L,4194406L };
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
public class A259495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259495Inst : IEnumerable<long>
{
public static readonly long[] Value=A259495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259495.Bytes);
public long this[int i]=>Value[i];

public static A259495Inst Instance=new A259495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259496
{
public static readonly long[] Value={ 5L,7L,104L,105L,1754L,3255L,16215L,22935L,67431L,93074L,983775L,1025504L,2200694L,2619705L,3365438L,4163355L,4447064L,4695704L,6372794L,7838265L,9718904L,11903775L,23992215L,26879684L,29357475L,37239735L,40588485L,41207144L,48615735L,56424555L,76466985L,81591194L,83864055L };
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
public class A259496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259496Inst : IEnumerable<long>
{
public static readonly long[] Value=A259496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259496.Bytes);
public long this[int i]=>Value[i];

public static A259496Inst Instance=new A259496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259497
{
public static readonly BigInteger[] Value={ 1L,10L,96L,918L,8778L,83970L,803652L,7695702L,73736351L,706940003L,6782083197L,65107856455L,625462980243L,6012764576492L,57843691102715L,556865542063090L,5364870125881211L,51722954280818076L,499024949301954326L,4818086348226292202L,BigInteger.Parse("46551954003050282966") };
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
public class A259497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259497Inst Instance=new A259497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259498
{
public static readonly long[] Value={ 1L,3L,6L,2L,6L,4L,5L,2L,3L,1L,2L,8L,7L,3L,6L,3L,3L,6L,6L,2L,8L,5L,3L,6L,2L,9L,3L,3L,7L,0L,2L,0L,4L,6L,7L,2L,3L,8L,9L,7L,9L,8L,0L,2L,4L,0L,1L,2L,2L,5L,3L,4L,8L,2L,7L,9L,9L,3L,1L,6L,1L,6L,7L,6L,8L,2L,8L,4L,7L,0L,7L,3L,9L,4L,6L,8L,2L,5L,8L,5L,3L,4L,0L,4L,8L,9L,6L,7L,8L,3L,7L,0L,1L,4L,2L,7L,2L,0L,1L,5L,4L,8L,9L,8L,3L };
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
public class A259498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259498Inst : IEnumerable<long>
{
public static readonly long[] Value=A259498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259498.Bytes);
public long this[int i]=>Value[i];

public static A259498Inst Instance=new A259498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259499
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,4L,7L,4L,7L,6L,0L,6L,3L,5L,1L,8L,7L,1L,8L,8L,6L,3L,7L,7L,6L,6L,8L,7L,9L,4L,7L,2L,4L,4L,7L,1L,4L,4L,2L,4L,6L,2L,7L,7L,0L,5L,6L,5L,4L,0L,6L,1L,1L,7L,1L,3L,5L,3L,6L,5L,2L,9L,4L,5L,3L,0L,7L,6L,4L,7L,9L,8L,9L,9L,7L,9L,7L,0L,3L,9L,6L,9L,9L,6L,6L,6L,6L,9L,7L,4L,5L,3L,0L,4L,1L,3L,4L,0L,7L,9L,7L,7L,3L };
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
public class A259499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259499Inst : IEnumerable<long>
{
public static readonly long[] Value=A259499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259499.Bytes);
public long this[int i]=>Value[i];

public static A259499Inst Instance=new A259499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259500
{
public static readonly long[] Value={ 1L,5L,6L,3L,4L,6L,8L,0L,9L,4L,3L,2L,7L,9L,0L,0L,5L,5L,2L,0L,4L,9L,9L,5L,8L,9L,2L,4L,0L,8L,9L,3L,0L,0L,9L,4L,0L,6L,7L,5L,1L,2L,6L,0L,0L,1L,8L,7L,6L,7L,4L,1L,2L,6L,9L,7L,2L,4L,1L,6L,5L,3L,3L,5L,1L,9L,1L,6L,9L,3L,3L,4L,3L,7L,1L,5L,9L,0L,9L,7L,0L,0L,2L,2L,5L,5L,3L,0L,2L,1L,0L,4L,3L,0L,2L,6L,2L,5L,6L,2L,8L,3L,7L,6L,1L };
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
public class A259500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259500Inst : IEnumerable<long>
{
public static readonly long[] Value=A259500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259500.Bytes);
public long this[int i]=>Value[i];

public static A259500Inst Instance=new A259500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259501
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,3L,6L,1L,8L,6L,8L,0L,1L,3L,6L,0L,5L,5L,7L,3L,4L,4L,6L,4L,5L,8L,1L,2L,1L,1L,9L,4L,6L,7L,3L,4L,4L,8L,7L,7L,3L,3L,8L,3L,9L,5L,7L,2L,7L,8L,0L,1L,7L,0L,2L,0L,5L,6L,7L,2L,7L,6L,0L,4L,7L,4L,0L,0L,1L,8L,0L,1L,0L,1L,9L,6L,2L,5L,1L,3L,8L,1L,1L,6L,7L,5L,4L,5L,6L,8L,9L,8L,5L,5L,2L,9L,5L,2L,4L,7L,8L,2L,1L };
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
public class A259501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259501Inst : IEnumerable<long>
{
public static readonly long[] Value=A259501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259501.Bytes);
public long this[int i]=>Value[i];

public static A259501Inst Instance=new A259501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259502
{
public static readonly long[] Value={ 5L,47L,151051L,240727L,911135839L };
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
public class A259502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259502Inst : IEnumerable<long>
{
public static readonly long[] Value=A259502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259502.Bytes);
public long this[int i]=>Value[i];

public static A259502Inst Instance=new A259502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259503
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,12L,133L };
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
public class A259503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259503Inst : IEnumerable<long>
{
public static readonly long[] Value=A259503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259503.Bytes);
public long this[int i]=>Value[i];

public static A259503Inst Instance=new A259503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259504
{
public static readonly long[] Value={ 27L,44L,75L,98L,116L,124L,147L,153L,164L,170L,171L,174L,230L,244L,245L,284L,285L,332L,356L,369L,387L,425L,428L,429L,434L,435L,474L,506L,507L,530L,548L,555L,574L,595L,602L,603L,604L,605L,609L,627L,637L,638L,645L,651L,657L,710L };
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
public class A259504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259504Inst : IEnumerable<long>
{
public static readonly long[] Value=A259504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259504.Bytes);
public long this[int i]=>Value[i];

public static A259504Inst Instance=new A259504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259505
{
public static readonly long[] Value={ 997L,8647L,47521L,85991L,283411L,4594451L,5476381L,52728733L,53920829L,100980223L,127072849L,436118521L,585293099L,858905011L };
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
public class A259505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259505Inst : IEnumerable<long>
{
public static readonly long[] Value=A259505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259505.Bytes);
public long this[int i]=>Value[i];

public static A259505Inst Instance=new A259505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259506
{
public static readonly long[] Value={ 0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,18L };
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
public class A259506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259506Inst : IEnumerable<long>
{
public static readonly long[] Value=A259506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259506.Bytes);
public long this[int i]=>Value[i];

public static A259506Inst Instance=new A259506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259507
{
public static readonly BigInteger[] Value={ 11L,129L,3270L,189211L,25009044L,7648655920L,5419416491691L,8914474231755265L,BigInteger.Parse("34039639215186145019"),BigInteger.Parse("301765460087856679774300"),BigInteger.Parse("6209472935212672846469197010"),BigInteger.Parse("296556812586707699012345431324530") };
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
public class A259507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259507Inst Instance=new A259507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259508
{
public static readonly long[] Value={ 11L,31L,87L,245L,689L,1939L,5455L,15349L,43185L,121507L,341871L,961893L,2706385L,7614707L,21424783L,60280917L,169606769L,477206723L,1342671919L,3777750469L,10629103249L,29906114067L,84144036943L,236748209589L,666116301873L };
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
public class A259508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259508Inst : IEnumerable<long>
{
public static readonly long[] Value=A259508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259508.Bytes);
public long this[int i]=>Value[i];

public static A259508Inst Instance=new A259508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259509
{
public static readonly long[] Value={ 31L,129L,533L,2219L,9227L,38409L,159845L,665339L,2769251L,11526489L,47976173L,199690619L,831166667L,3459548649L,14399597045L,59935131419L,249466635731L,1038349453209L,4321898626973L,17988942330779L,74874972302267L };
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
public class A259509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259509Inst : IEnumerable<long>
{
public static readonly long[] Value=A259509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259509.Bytes);
public long this[int i]=>Value[i];

public static A259509Inst Instance=new A259509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259510
{
public static readonly long[] Value={ 87L,533L,3270L,20293L,126045L,784130L,4879059L,30366347L,189000090L,1176388523L,7322185101L,45575811794L,283679519673L,1765722127481L,10990478900276L,68408656100315L,425799800891931L,2650329642920874L,16496595246904901L };
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
public class A259510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259510Inst : IEnumerable<long>
{
public static readonly long[] Value=A259510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259510.Bytes);
public long this[int i]=>Value[i];

public static A259510Inst Instance=new A259510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259511
{
public static readonly long[] Value={ 245L,2219L,20293L,189211L,1769635L,16602297L,155863519L,1464104971L,13754727159L,129236342101L,1214294685989L,11409748154969L,107208173420527L,1007356261075135L,9465372066487451L,88939216552231467L,835696481415998163L };
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
public class A259511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259511Inst : IEnumerable<long>
{
public static readonly long[] Value=A259511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259511.Bytes);
public long this[int i]=>Value[i];

public static A259511Inst Instance=new A259511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259512
{
public static readonly long[] Value={ 689L,9227L,126045L,1769635L,25009044L,355119489L,5050441910L,71892362811L,1023722858631L,14580213573278L,207670950496698L,2958047253018009L,42134766083598488L,600177800077956164L,8549101075136347880L };
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
public class A259512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259512Inst : IEnumerable<long>
{
public static readonly long[] Value=A259512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259512.Bytes);
public long this[int i]=>Value[i];

public static A259512Inst Instance=new A259512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259513
{
public static readonly BigInteger[] Value={ 1939L,38409L,784130L,16602297L,355119489L,7648655920L,165145291429L,3570854380319L,77252441141038L,1671822431529063L,36183987347406927L,783203835623251972L,16952835485122685135UL,BigInteger.Parse("366959278189068079729") };
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
public class A259513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259513Inst Instance=new A259513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259514
{
public static readonly BigInteger[] Value={ 5455L,159845L,4879059L,155863519L,5050441910L,165145291429L,5419416491691L,178189978426775L,5863673028670869L,193037954503379878L,6356162616151817217L,BigInteger.Parse("209309725547903232235"),BigInteger.Parse("6892887914526552330337"),BigInteger.Parse("226998362243741163894455") };
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
public class A259514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259514Inst Instance=new A259514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259515
{
public static readonly long[] Value={ 11L,31L,31L,87L,129L,87L,245L,533L,533L,245L,689L,2219L,3270L,2219L,689L,1939L,9227L,20293L,20293L,9227L,1939L,5455L,38409L,126045L,189211L,126045L,38409L,5455L,15349L,159845L,784130L,1769635L,1769635L,784130L,159845L,15349L,43185L,665339L,4879059L };
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
public class A259515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259515Inst : IEnumerable<long>
{
public static readonly long[] Value=A259515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259515.Bytes);
public long this[int i]=>Value[i];

public static A259515Inst Instance=new A259515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259516
{
public static readonly BigInteger[] Value={ 12L,208L,10148L,1447270L,589476522L,690701197282L,2319907090839600L,BigInteger.Parse("22358169205318921642"),BigInteger.Parse("618015376234777766725512"),BigInteger.Parse("49001406150402919507454031696"),BigInteger.Parse("11144067669109506484357454122890578") };
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
public class A259516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259516Inst Instance=new A259516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259517
{
public static readonly long[] Value={ 12L,38L,120L,380L,1204L,3816L,12096L,38344L,121552L,385328L,1221520L,3872320L,12275584L,38914656L,123362816L,391070784L,1239728192L,3930045568L,12458584320L,39494789760L,125201899264L,396900848896L,1258210017536L,3988634573824L };
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
public class A259517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259517Inst : IEnumerable<long>
{
public static readonly long[] Value=A259517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259517.Bytes);
public long this[int i]=>Value[i];

public static A259517Inst Instance=new A259517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259518
{
public static readonly long[] Value={ 38L,208L,1122L,6100L,33162L,180370L,981092L,5336678L,29029222L,157906912L,858948710L,4672329330L,25415560796L,138250260726L,752024907134L,4090708107616L,22251780062734L,121040588343338L,658411326480860L };
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
public class A259518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259518Inst : IEnumerable<long>
{
public static readonly long[] Value=A259518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259518.Bytes);
public long this[int i]=>Value[i];

public static A259518Inst Instance=new A259518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259519
{
public static readonly long[] Value={ 120L,1122L,10148L,93028L,851604L,7802386L,71482990L,654942820L,6000746068L,54980553426L,503747889040L,4615487155540L,42288462097532L,387459445851174L,3550018521891070L,32526324212267086L,298015844551102894L };
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
public class A259519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259519Inst : IEnumerable<long>
{
public static readonly long[] Value=A259519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259519.Bytes);
public long this[int i]=>Value[i];

public static A259519Inst Instance=new A259519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259520
{
public static readonly ulong[] Value={ 380L,6100L,93028L,1447270L,22453286L,348802846L,5417785744L,84159480298L,1307320968014L,20307866257912L,315461519753608L,4900368198470600L,76122150981402540L,1182478924960407640L,18368587834267497600UL };
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
public class A259520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259520Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A259520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259520.Bytes);
public ulong this[int i]=>Value[i];

public static A259520Inst Instance=new A259520Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259521
{
public static readonly BigInteger[] Value={ 1204L,33162L,851604L,22453286L,589476522L,15503669216L,407656116320L,10720344908210L,281914700860322L,7413627501305340L,194959116068482708L,5126921239618282672L,BigInteger.Parse("134824786575257866732"),BigInteger.Parse("3545543860883412901370") };
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
public class A259521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259521Inst Instance=new A259521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259522
{
public static readonly BigInteger[] Value={ 3816L,180370L,7802386L,348802846L,15503669216L,690701197282L,30760063948568L,1370113260798484L,61026150956984294L,2718196509534712330L,BigInteger.Parse("121072404917335019622"),BigInteger.Parse("5392745165174671566554"),BigInteger.Parse("240200883776268055011402") };
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
public class A259522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259522Inst Instance=new A259522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259523
{
public static readonly BigInteger[] Value={ 12096L,981092L,71482990L,5417785744L,407656116320L,30760063948568L,2319907090839600L,175002064330576058L,13200853335762678450UL,BigInteger.Parse("995789443731005584732"),BigInteger.Parse("75115949821301822140996"),BigInteger.Parse("5666270721518268054510606") };
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
public class A259523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259523Inst Instance=new A259523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259524
{
public static readonly long[] Value={ 12L,38L,38L,120L,208L,120L,380L,1122L,1122L,380L,1204L,6100L,10148L,6100L,1204L,3816L,33162L,93028L,93028L,33162L,3816L,12096L,180370L,851604L,1447270L,851604L,180370L,12096L,38344L,981092L,7802386L,22453286L,22453286L,7802386L,981092L,38344L };
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
public class A259524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259524Inst : IEnumerable<long>
{
public static readonly long[] Value=A259524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259524.Bytes);
public long this[int i]=>Value[i];

public static A259524Inst Instance=new A259524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259525
{
public static readonly long[] Value={ 0L,0L,0L,1L,-1L,0L,2L,0L,-2L,0L,3L,2L,-2L,-3L,0L,4L,5L,0L,-5L,-4L,0L,5L,9L,5L,-5L,-9L,-5L,0L,6L,14L,14L,0L,-14L,-14L,-6L,0L,7L,20L,28L,14L,-14L,-28L,-20L,-7L,0L,8L,27L,48L,42L,0L,-42L,-48L,-27L,-8L,0L,9L,35L,75L,90L,42L,-42L,-90L,-75L,-35L,-9L,0L,10L,44L,110L };
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
public class A259525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259525Inst : IEnumerable<long>
{
public static readonly long[] Value=A259525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259525.Bytes);
public long this[int i]=>Value[i];

public static A259525Inst Instance=new A259525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259526
{
public static readonly long[] Value={ 1L,6L,7L,2L,12L,3L,8L,20L,21L,9L,4L,13L,45L,14L,5L,10L,22L,27L,28L,23L,11L,50L,15L,46L,42L,47L,16L,51L,33L,24L,29L,61L,60L,30L,25L,34L,52L,17L,48L,41L,88L,105L,49L,18L,53L,35L,26L,31L,67L,62L,63L,68L,32L,58L,36L,54L,19L,91L,106L,87L,111L,94L,107L,90L,120L,55L };
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
public class A259526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259526Inst : IEnumerable<long>
{
public static readonly long[] Value=A259526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259526.Bytes);
public long this[int i]=>Value[i];

public static A259526Inst Instance=new A259526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259527
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,2L,2L,2L,1L,2L,8L,2L,16L,2L,2L,1L,64L,2L,128L,4L,2L,4L,512L,2L,1L,4L,1L,2L,8192L,2L,8192L,4L,2L,16L,2L,1L,65536L,64L,4L,2L,524288L,8L,1048576L,4L,4L,128L,8388608L,2L,1L,1L,8L,2L,67108864L,4L,2L,2L,4L,256L,536870912L,2L,2147483648L,2048L,2L,1L,1L };
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
public class A259527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259527Inst : IEnumerable<long>
{
public static readonly long[] Value=A259527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259527.Bytes);
public long this[int i]=>Value[i];

public static A259527Inst Instance=new A259527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259528
{
public static readonly BigInteger[] Value={ 1L,122L,2333L,34444L,455555L,5666666L,67777777L,788888888L,8999999999L,BigInteger.Parse("101010101010101010010"),BigInteger.Parse("11111111110111111111111"),BigInteger.Parse("1212121121212121212121212"),BigInteger.Parse("131313013131313131313131313"),BigInteger.Parse("14141241414141414141414141414") };
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
public class A259528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259528Inst Instance=new A259528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259529
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,2L,2L,3L,3L,3L,3L,5L,6L,5L,6L,8L,9L,10L,10L,13L,15L,15L,17L,20L,23L,24L,25L,30L,34L,36L,39L,45L,50L,53L,57L,65L,73L,77L,83L,94L,104L,110L,118L,132L,145L,154L,166L,185L,201L,214L,230L,253L,276L,293L,316L,346L,375L,399L,427L,467L,505L,537L,575L };
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
public class A259529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259529Inst : IEnumerable<long>
{
public static readonly long[] Value=A259529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259529.Bytes);
public long this[int i]=>Value[i];

public static A259529Inst Instance=new A259529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259530
{
public static readonly long[] Value={ 2L,7L,53L,103L,1171L,1699L };
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
public class A259530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259530Inst : IEnumerable<long>
{
public static readonly long[] Value=A259530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259530.Bytes);
public long this[int i]=>Value[i];

public static A259530Inst Instance=new A259530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259531
{
public static readonly long[] Value={ 1L,1L,14L,11L,6L,31L,2L,34L,2L,76L,1L,100L,71L,38L,1L,7L,62L,1128L,1L,180L,123L,15L,174L,128L,4L,111L,110L,2L,4L,2L,2241L,21L,144L,416L,397L,31L,11L,8L,15L,5L,91L,56L,53L,23L,89L,18L,25L,341L,12L,1L,66L,454L,159L,36L,573L,26L,2L,488L,72L,416L,802L,440L,28L,30L,595L,17L,236L,947L,1289L,1287L,1000L,367L,80L,407L,1L,77L,938L,150L,36L,1L };
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
public class A259531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259531Inst : IEnumerable<long>
{
public static readonly long[] Value=A259531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259531.Bytes);
public long this[int i]=>Value[i];

public static A259531Inst Instance=new A259531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259532
{
public static readonly long[] Value={ 1L,8L,8L,12L,8L,12L,1L,2304L,2304L,1L,5L,8L,12L,8L,5L,24L,1600L,12L,12L,1600L,24L,28L,2304L,3600L,1L,3600L,2304L,28L,8L,12544L,2304L,5L,5L,2304L,12544L,8L,1L,8L,7056L,24L,5L,24L,7056L,8L,1L,40L,8L,2304L,28L,14400L,14400L,28L,2304L,8L,40L,44L,1600L,12L,8L };
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
public class A259532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259532Inst : IEnumerable<long>
{
public static readonly long[] Value=A259532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259532.Bytes);
public long this[int i]=>Value[i];

public static A259532Inst Instance=new A259532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259533
{
public static readonly BigInteger[] Value={ 1L,4L,18L,94L,582L,4294L,37398L,378214L,4366422L,56697574L,817979478L,12981058534L,224732536662L,4214866778854L,85130743747158L,1842265527790054L,42525237455785302L,1042966136232956134L,BigInteger.Parse("27084277306054500438"),BigInteger.Parse("742412698554626764774"),BigInteger.Parse("21421502369955072576342"),BigInteger.Parse("648998599988032588957414") };
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
public class A259533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259533Inst Instance=new A259533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259534
{
public static readonly BigInteger[] Value={ 5L,29L,509L,131069L,8589934589L,5506148072189L,1509659159988837629L,BigInteger.Parse("90050548615896750734368618889875709"),BigInteger.Parse("111565998552535226317138856424609779410946920431869"),BigInteger.Parse("270528914968139650436266764640655805238384653911572627709") };
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
public class A259534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259534Inst Instance=new A259534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259535
{
public static readonly long[] Value={ 2L,3L,17L,107L,13313L };
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
public class A259535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259535Inst : IEnumerable<long>
{
public static readonly long[] Value=A259535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259535.Bytes);
public long this[int i]=>Value[i];

public static A259535Inst Instance=new A259535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259536
{
public static readonly long[] Value={ 14L,20L,42L,45L,52L,55L,121L,377L,451L,4331L,9211L,18042L,52093L,58743L,112853L,143498L,170322L,182293L,226118L,289811L,298489L,394067L,400831L,456745L,507678L,541362L,769667L,929582L,1132069L,1150595L,1218361L,1230403L,1262507L,1431109L,1516082L,1875155L };
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
public class A259536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259536Inst : IEnumerable<long>
{
public static readonly long[] Value=A259536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259536.Bytes);
public long this[int i]=>Value[i];

public static A259536Inst Instance=new A259536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259537
{
public static readonly long[] Value={ 1L,56L,48L,147L,148L,49L,55L,2L,8L,14L,20L,26L,32L,38L,33L,27L,21L,15L,9L,3L,66L,50L,149L,158L,177L,57L,74L,88L,102L,116L,130L,45L,44L,131L,117L,103L,89L,75L,58L,178L,157L,150L,51L,65L,4L,10L,16L,22L,28L,34L,39L,139L,125L,111L,97L,83L,496L,186L,196L,163L,173L };
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
public class A259537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259537Inst : IEnumerable<long>
{
public static readonly long[] Value=A259537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259537.Bytes);
public long this[int i]=>Value[i];

public static A259537Inst Instance=new A259537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259538
{
public static readonly long[] Value={ 1L,-2L,1L,-1L,0L,1L,2L,-2L,1L,1L,-2L,0L,1L,-4L,1L,1L,-2L,2L,3L,-2L,2L,1L,-4L,2L,2L,-6L,3L,2L,-4L,3L,2L,-6L,3L,4L,-8L,3L,5L,-10L,5L,3L,-10L,6L,7L,-10L,5L,8L,-12L,6L,7L,-16L,8L,7L,-16L,9L,9L,-18L,10L,10L,-22L,10L,11L,-26L,13L,12L,-26L,15L,14L,-28L,15L,17L,-34L };
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
public class A259538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259538Inst : IEnumerable<long>
{
public static readonly long[] Value=A259538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259538.Bytes);
public long this[int i]=>Value[i];

public static A259538Inst Instance=new A259538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259539
{
public static readonly long[] Value={ 60L,828L,858L,1032L,1050L,1230L,1320L,1878L,2028L,2340L,3252L,3390L,3462L,4548L,5502L,6870L,6948L,7590L,7878L,8010L,9438L,9720L,9858L,10038L,10068L,10302L,11490L,11718L,13932L,14388L,15138L,15270L,15288L,16068L,16188L,16230L,17208L,17292L,17838L,17910L };
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
public class A259539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259539Inst : IEnumerable<long>
{
public static readonly long[] Value=A259539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259539.Bytes);
public long this[int i]=>Value[i];

public static A259539Inst Instance=new A259539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259540
{
public static readonly long[] Value={ 60L,326940L,728700L,115020L,375258L,70920L,33150L,297990L,2340L,72870L,858L,1416210L,284130L,78978L,91368L,9438L,5547000L,767760L,1182918L,30468L,485208L,60L,7908810L,916188L,21522L,823968L,87720L,390210L,3252L,72870L,7878L,1823010L,1179990L,98010L,3462L,7878L,280590L,6870L,60L,434460L };
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
public class A259540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259540Inst : IEnumerable<long>
{
public static readonly long[] Value=A259540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259540.Bytes);
public long this[int i]=>Value[i];

public static A259540Inst Instance=new A259540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259541
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,13L,23L,30L,31L,36L,109L,119L,158L,351L,1645L,1653L,2003L,3476L,3520L,3934L,4913L,8037L,9379L,35324L,36516L,91951L,128955L,200003L,390066L,402603L,1068869L,2000003L,2144992L,2467458L,2867828L,3392245L,3607663L };
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
public class A259541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259541Inst : IEnumerable<long>
{
public static readonly long[] Value=A259541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259541.Bytes);
public long this[int i]=>Value[i];

public static A259541Inst Instance=new A259541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259542
{
public static readonly long[] Value={ 1L,5L,7L,13L,17L,3L,9L,11L,19L,23L,33L,39L,51L,21L,35L,37L,53L,57L,15L,27L,29L,43L,47L,25L,31L,41L,49L,61L,71L,85L,97L,59L,73L,83L,99L,111L,45L,65L,67L,89L,93L,63L,69L,87L,95L,115L,125L,147L,159L,81L,75L,107L,103L,79L,77L,55L,101L,109L,131L,141L,165L,177L };
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
public class A259542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259542Inst : IEnumerable<long>
{
public static readonly long[] Value=A259542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259542.Bytes);
public long this[int i]=>Value[i];

public static A259542Inst Instance=new A259542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259543
{
public static readonly long[] Value={ 1L,6L,2L,3L,7L,8L,4L,19L,5L,9L,14L,10L,24L,20L,21L,25L,11L,15L,16L,12L,26L,22L,37L,23L,27L,13L,17L,56L,18L,32L,28L,42L,38L,39L,43L,29L,33L,51L,55L,54L,50L,34L,30L,44L,40L,71L,41L,45L,31L,35L,57L,53L,92L,52L,58L,36L,68L,46L,76L,72L,73L,77L,47L,67L,63L,59L,87L };
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
public class A259543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259543Inst : IEnumerable<long>
{
public static readonly long[] Value=A259543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259543.Bytes);
public long this[int i]=>Value[i];

public static A259543Inst Instance=new A259543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259544
{
public static readonly long[] Value={ 1L,2L,4L,7L,16L,32L,75L,169L,396L };
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
public class A259544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259544Inst : IEnumerable<long>
{
public static readonly long[] Value=A259544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259544.Bytes);
public long this[int i]=>Value[i];

public static A259544Inst Instance=new A259544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259545
{
public static readonly long[] Value={ 1L,2L,4L,7L,16L,34L,78L,178L };
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
public class A259545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259545Inst : IEnumerable<long>
{
public static readonly long[] Value=A259545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259545.Bytes);
public long this[int i]=>Value[i];

public static A259545Inst Instance=new A259545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259546
{
public static readonly long[] Value={ 0L,1L,8L,54L,192L,625L,1728L,4459L,10752L,24786L,55000L,118459L,248832L,511901L,1034488L,2058750L,4042752L,7846061L,15069888L,28677479L,54120000L,101370906L,188586728L,348669719L,640991232L,1172265625L,2133603368L,3866095494L,6976587072L,12541531081L };
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
public class A259546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259546Inst : IEnumerable<long>
{
public static readonly long[] Value=A259546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259546.Bytes);
public long this[int i]=>Value[i];

public static A259546Inst Instance=new A259546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259547
{
public static readonly long[] Value={ 0L,1L,16L,162L,768L,3125L,10368L,31213L,86016L,223074L,550000L,1303049L,2985984L,6654713L,14482832L,30881250L,64684032L,133383037L,271257984L,544872101L,1082400000L,2128789026L,4148908016L,8019403537L,15383789568L,29306640625L,55473687568L,104384578338L };
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
public class A259547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259547Inst : IEnumerable<long>
{
public static readonly long[] Value=A259547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259547.Bytes);
public long this[int i]=>Value[i];

public static A259547Inst Instance=new A259547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259548
{
public static readonly long[] Value={ 1L,5L,11L,17L,23L,25L,29L,41L,47L,53L,55L,59L,71L,83L,85L,89L,101L,107L,113L,115L,121L,125L,131L,137L,145L,149L,167L,173L,179L,187L,191L,197L,205L,227L,233L,235L,239L,251L,253L,257L,263L,265L,269L,275L,281L,289L,293L,295L,311L,317L,319L,347L,353L,355L,359L,383L };
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
public class A259548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259548Inst : IEnumerable<long>
{
public static readonly long[] Value=A259548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259548.Bytes);
public long this[int i]=>Value[i];

public static A259548Inst Instance=new A259548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259549
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,37L,37L,38L,38L };
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
public class A259549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259549Inst : IEnumerable<long>
{
public static readonly long[] Value=A259549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259549.Bytes);
public long this[int i]=>Value[i];

public static A259549Inst Instance=new A259549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259550
{
public static readonly BigInteger[] Value={ 1L,2L,42L,1001L,25194L,653752L,17298645L,463991880L,12570420330L,343176898988L,9425842448792L,260170725132045L,7210477496434485L,200519284375732896L,5592628786362932776L,BigInteger.Parse("156375886125188595376"),BigInteger.Parse("4382048530314336892010"),BigInteger.Parse("123033460966787345446836") };
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
public class A259550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259550Inst Instance=new A259550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259551
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,1L,2L,1L,3L,2L,4L,4L,5L,4L,6L,5L,7L,6L,9L,8L,11L,11L,13L,13L,17L,15L,20L,19L,23L,23L,27L,27L,33L,33L,38L,39L,45L,45L,53L,54L,62L,63L,73L,74L,84L,86L,97L,100L,112L,115L,130L,134L,148L,154L,170L,176L,195L,202L,222L,232L,255L,264L,290L,301L,329L };
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
public class A259551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259551Inst : IEnumerable<long>
{
public static readonly long[] Value=A259551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259551.Bytes);
public long this[int i]=>Value[i];

public static A259551Inst Instance=new A259551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259552
{
public static readonly long[] Value={ 41L,43L,53L,83L,151L,281L,503L,853L,1373L,2111L,3121L,4463L,6203L,8413L,11171L,14561L,18673L,23603L,29453L,36331L,44351L,53633L,64303L,76493L,90341L,105991L,123593L,143303L,165283L,189701L,216731L,246553L,279353L,315323L,354661L,397571L,444263L,494953L };
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
public class A259552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259552Inst : IEnumerable<long>
{
public static readonly long[] Value=A259552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259552.Bytes);
public long this[int i]=>Value[i];

public static A259552Inst Instance=new A259552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259553
{
public static readonly long[] Value={ 2L,6L,53L,12034L };
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
public class A259553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259553Inst : IEnumerable<long>
{
public static readonly long[] Value=A259553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259553.Bytes);
public long this[int i]=>Value[i];

public static A259553Inst Instance=new A259553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259554
{
public static readonly long[] Value={ 1L,7L,52L,403L,3206L,25954L,212738L,1760035L,14666470L,122920642L,1035046816L,8749594462L,74207078908L,631140253072L,5381022869822L,45975731083555L,393556869530630L,3374504760608026L,28977403637496104L,249167023897718138L };
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
public class A259554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259554Inst : IEnumerable<long>
{
public static readonly long[] Value=A259554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259554.Bytes);
public long this[int i]=>Value[i];

public static A259554Inst Instance=new A259554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259555
{
public static readonly long[] Value={ 17L,21L,29L,41L,57L,77L,101L,129L,161L,197L,237L,281L,329L,381L,437L,497L,561L,629L,701L,777L,857L,941L,1029L,1121L,1217L,1317L,1421L,1529L,1641L,1757L,1877L,2001L,2129L,2261L,2397L,2537L,2681L,2829L,2981L,3137L,3297L,3461L,3629L,3801L,3977L,4157L,4341L,4529L };
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
public class A259555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259555Inst : IEnumerable<long>
{
public static readonly long[] Value=A259555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259555.Bytes);
public long this[int i]=>Value[i];

public static A259555Inst Instance=new A259555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259556
{
public static readonly long[] Value={ 3L,6L,5L,8L,8L,6L,11L,10L,9L,8L,14L,13L,11L,11L,10L,16L,16L,14L,13L,13L,11L,19L,18L,17L,16L,15L,14L,13L,21L,21L,19L,19L,18L,16L,16L,14L,24L,23L,22L,21L,21L,19L,18L,17L,16L,27L,26L,24L,24L,23L,22L,21L,19L,19L,18L,29L,29L,27L,26L,26L,24L,24L,22L,21L,21L,19L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L };
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
public class A259556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259556Inst : IEnumerable<long>
{
public static readonly long[] Value=A259556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259556.Bytes);
public long this[int i]=>Value[i];

public static A259556Inst Instance=new A259556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259557
{
public static readonly ulong[] Value={ 1L,3L,35L,462L,6435L,92378L,1352078L,20058300L,300540195L,4537567650L,68923264410L,1052049481860L,16123801841550L,247959266474052L,3824345300380220L,59132290782430712L,916312070471295267L,14226520737620288370UL };
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
public class A259557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259557Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A259557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259557.Bytes);
public ulong this[int i]=>Value[i];

public static A259557Inst Instance=new A259557Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259558
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,12L,15L,16L,18L,19L,23L,24L,25L,28L,29L,31L,36L,38L,39L,40L,42L,44L,52L,56L,58L,59L,60L,63L,64L,71L,73L,74L,76L,80L,85L,88L,91L,92L,94L,96L,98L,99L,102L,103L,106L,107L,109L,110L,111L,112L,113L,117L,126L,129L,130L,131L,132L,133L,134L,136L,139L,141L,142L,143L,144L,151L,152L,159L,160L,161L,165L,168L,169L,173L };
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
public class A259558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259558Inst : IEnumerable<long>
{
public static readonly long[] Value=A259558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259558.Bytes);
public long this[int i]=>Value[i];

public static A259558Inst Instance=new A259558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259559
{
public static readonly long[] Value={ 3L,4L,10L,12L,19L,29L,34L,36L,45L,46L,50L,61L,85L,89L,91L,104L,112L,117L,118L,119L,129L,130L,137L,138L,143L,147L,148L,158L,178L,179L,181L,185L,200L,202L,206L,214L,220L,233L,238L,239L,244L,248L,249L,258L,262L,275L,299L,304L,314L,333L,338L,340L };
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
public class A259559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259559Inst : IEnumerable<long>
{
public static readonly long[] Value=A259559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259559.Bytes);
public long this[int i]=>Value[i];

public static A259559Inst Instance=new A259559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259560
{
public static readonly long[] Value={ 11L,23L,29L,47L,53L,59L,67L,79L,83L,89L,103L,107L,131L,137L,139L,149L,167L,173L,179L,191L,223L,227L,229L,233L,239L,263L,269L,277L,283L,293L,311L,317L,347L,349L,359L,367L,373L,383L,389L,431L,439L,461L,467L,479L,499L,503L,509L,523L,557L,563L,569L,587L,593L,607L };
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
public class A259560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259560Inst : IEnumerable<long>
{
public static readonly long[] Value=A259560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259560.Bytes);
public long this[int i]=>Value[i];

public static A259560Inst Instance=new A259560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259561
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,10L,11L,29L,40L,76L,199L,521L,1364L,3571L,9349L,24476L,64079L,167761L,439204L,1149851L,3010349L,7881196L,20633239L,54018521L,141422324L,370248451L,969323029L,2537720636L,6643838879L,17393796001L,45537549124L,119218851371L,312119004989L,817138163596L };
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
public class A259561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259561Inst : IEnumerable<long>
{
public static readonly long[] Value=A259561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259561.Bytes);
public long this[int i]=>Value[i];

public static A259561Inst Instance=new A259561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259562
{
public static readonly long[] Value={ 2L,414L,556L,3962L,4972L,6151L,6521L,8440L,8665L,13769L,13909L,15576L,16696L,17176L,19926L,20630L,21541L,27090L,30822L,62118L,65349L,74014L,94203L,98600L,101231L,103058L,108333L,112332L,136036L,142714L,145588L,147150L,160730L,162366L,169137L,194681L,200837L };
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
public class A259562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259562Inst : IEnumerable<long>
{
public static readonly long[] Value=A259562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259562.Bytes);
public long this[int i]=>Value[i];

public static A259562Inst Instance=new A259562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259563
{
public static readonly BigInteger[] Value={ 0L,0L,2571912L,2472394752L,138662798400L,1666179072000L,-4637478825000L,-272992368918528L,-3187483870330368L,-23209723979366400L,-126970182577359000L,-566493158246400000L,-2161675076294530368L,-7278963158259007488L,BigInteger.Parse("-22112928086617859400"),BigInteger.Parse("-61611251010011136000") };
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
public class A259563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259563.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259563Inst Instance=new A259563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259564
{
public static readonly long[] Value={ 5L,7L,11L,30L,133L,160L,415L,527L,883L,1257L,2025L,2771L,2775L,6650L,6932L,13793L,19091L,30695L,32341L,33722L,36372L,37944L,40532L,42141L,47230L,60986L,77956L,82165L,90564L,111414L,113106L,136036L,147573L,148357L,158279L,169137L,169604L,171549L,174540L,187679L };
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
public class A259564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259564Inst : IEnumerable<long>
{
public static readonly long[] Value=A259564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259564.Bytes);
public long this[int i]=>Value[i];

public static A259564Inst Instance=new A259564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259565
{
public static readonly long[] Value={ 1L,3L,7L,5L,9L,11L,15L,13L,17L,21L,23L,19L,25L,27L,31L,29L,33L,35L,39L,37L,41L,43L,49L,45L,47L,55L,51L,59L,57L,53L,61L,63L,67L,65L,69L,71L,75L,73L,81L,77L,79L,85L,87L,83L,89L,93L,95L,91L,97L,105L,99L,103L,101L,109L,111L,107L,113L,115L,121L,117L,119L,125L,129L };
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
public class A259565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259565Inst : IEnumerable<long>
{
public static readonly long[] Value=A259565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259565.Bytes);
public long this[int i]=>Value[i];

public static A259565Inst Instance=new A259565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259566
{
public static readonly long[] Value={ 1L,4L,7L,13L,16L,22L,25L,40L,43L,49L,52L,67L,70L,76L,79L,121L,124L,130L,133L,148L,151L,157L,160L,202L,205L,211L,214L,229L,232L,238L,241L,364L,367L,373L,376L,391L,394L,400L,403L,445L,448L,454L,457L,472L,475L,481L,484L,607L,610L,616L,619L,634L,637L,643L,646L,688L,691L,697L,700L,715L,718L,724L,727L,1093L,1096L,1102L,1105L,1120L };
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
public class A259566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259566Inst : IEnumerable<long>
{
public static readonly long[] Value=A259566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259566.Bytes);
public long this[int i]=>Value[i];

public static A259566Inst Instance=new A259566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259567
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,2L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
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
public class A259567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259567Inst : IEnumerable<long>
{
public static readonly long[] Value=A259567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259567.Bytes);
public long this[int i]=>Value[i];

public static A259567Inst Instance=new A259567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259568
{
public static readonly long[] Value={ 1L,5L,9L,13L,21L,25L,29L,37L,41L,45L,53L,57L,61L,85L,89L,93L,101L,105L,109L,117L,121L,125L,149L,153L,157L,165L,169L,173L,181L,185L,189L,213L,217L,221L,229L,233L,237L,245L,249L,253L,341L,345L,349L,357L,361L,365L,373L,377L,381L,405L,409L,413L,421L,425L,429L,437L,441L,445L,469L,473L,477L,485L,489L,493L,501L,505L,509L,597L,601L,605L };
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
public class A259568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259568Inst : IEnumerable<long>
{
public static readonly long[] Value=A259568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259568.Bytes);
public long this[int i]=>Value[i];

public static A259568Inst Instance=new A259568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259569
{
public static readonly long[] Value={ 1L,2L,1L,6L,6L,1L,12L,24L,14L,1L,20L,60L,70L,30L,1L,30L,120L,210L,180L,62L,1L,42L,210L,490L,630L,434L,126L,1L,56L,336L,980L,1680L,1736L,1008L,254L,1L,72L,504L,1764L,3780L,5208L,4536L,2286L,510L,1L,90L,720L,2940L,7560L,13020L,15120L,11430L,5100L,1022L,1L,110L,990L,4620L,13860L,28644L,41580L,41910L,28050L,11242L,2046L,1L };
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
public class A259569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259569Inst : IEnumerable<long>
{
public static readonly long[] Value=A259569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259569.Bytes);
public long this[int i]=>Value[i];

public static A259569Inst Instance=new A259569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259570
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,8L,7L,9L,12L,10L,11L,13L,14L,16L,15L,17L,18L,20L,19L,21L,22L,24L,25L,23L,27L,30L,26L,29L,28L,31L,32L,34L,33L,35L,36L,38L,37L,40L,41L,39L,44L,42L,43L,45L,48L,46L,47L,49L,51L,53L,52L,50L,56L,54L,55L,57L,58L,60L,61L,59L,65L,62L,67L,63L,64L,68L };
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
public class A259570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259570Inst : IEnumerable<long>
{
public static readonly long[] Value=A259570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259570.Bytes);
public long this[int i]=>Value[i];

public static A259570Inst Instance=new A259570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259571
{
public static readonly long[] Value={ 3L,7L,8L,17L,23L,27L,38L,39L,43L,48L,58L,65L,66L,67L,68L,69L,74L,75L,76L,77L,78L,83L,84L,88L,89L,91L,92L,93L,98L,99L,105L,110L,113L,140L,156L,157L,170L,182L,186L,188L,191L,194L,205L,212L,215L,218L,222L,227L,229L,234L,235L,241L,246L,247L,252L,267L,287L,293L,294L };
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
public class A259571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259571Inst : IEnumerable<long>
{
public static readonly long[] Value=A259571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259571.Bytes);
public long this[int i]=>Value[i];

public static A259571Inst Instance=new A259571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259572
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,2L,3L,2L,0L,0L,2L,3L,3L,2L,0L,0L,3L,4L,6L,4L,3L,0L,0L,3L,6L,6L,6L,6L,3L,0L,0L,4L,6L,8L,10L,8L,6L,4L,0L,0L,4L,7L,9L,10L,10L,9L,7L,4L,0L,0L,5L,9L,12L,12L,15L,12L,12L,9L,5L,0L,0L,5L,9L,12L,14L,15L,15L,14L,12L,9L,5L,0L,0L,6L,10L };
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
public class A259572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259572Inst : IEnumerable<long>
{
public static readonly long[] Value=A259572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259572.Bytes);
public long this[int i]=>Value[i];

public static A259572Inst Instance=new A259572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259573
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,3L,6L,5L,6L,3L,8L,3L,6L,7L,8L,3L,8L,3L,8L,9L,6L,3L,12L,5L,6L,7L,10L,3L,14L,3L,10L,9L,6L,9L,14L,3L,6L,9L,12L,3L,12L,3L,12L,11L,6L,3L,18L,5L,10L,9L,12L,3L,12L,9L,14L,9L,6L,3L,22L,3L,6L,13L,12L,9L,14L,3L,12L,9L,14L,3L,18L,3L,6L,13L,12L,9L,16L };
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
public class A259573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259573Inst : IEnumerable<long>
{
public static readonly long[] Value=A259573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259573.Bytes);
public long this[int i]=>Value[i];

public static A259573Inst Instance=new A259573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259574
{
public static readonly long[] Value={ 0L,1L,4L,11L,22L,42L,66L,104L,150L,211L,280L,377L,474L,604L,750L,916L,1096L,1323L,1548L,1831L,2122L,2446L,2794L,3212L,3620L,4087L,4590L,5141L,5698L,6360L,6990L,7728L,8484L,9289L,10156L,11091L,12006L,13042L,14122L,15280L,16420L,17727L,18984L,20401L,21852L };
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
public class A259574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259574Inst : IEnumerable<long>
{
public static readonly long[] Value=A259574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259574.Bytes);
public long this[int i]=>Value[i];

public static A259574Inst Instance=new A259574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259575
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,2L,1L,1L,3L,4L,4L,3L,1L,1L,3L,5L,6L,5L,3L,1L,1L,4L,6L,7L,7L,6L,4L,1L,1L,4L,7L,8L,10L,8L,7L,4L,1L,1L,5L,8L,10L,11L,11L,10L,8L,5L,1L,1L,5L,9L,12L,13L,15L,13L,12L,9L,5L,1L,1L,6L,10L,13L,15L,16L,16L,15L,13L,10L,6L,1L,1L,6L };
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
public class A259575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259575Inst : IEnumerable<long>
{
public static readonly long[] Value=A259575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259575.Bytes);
public long this[int i]=>Value[i];

public static A259575Inst Instance=new A259575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259576
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,4L,3L,4L,3L,6L,3L,6L,3L,6L,5L,6L,3L,8L,3L,8L,5L,6L,3L,10L,5L,6L,5L,10L,3L,10L,3L,8L,5L,6L,7L,14L,3L,6L,5L,12L,3L,12L,3L,10L,11L,6L,3L,14L,5L,10L,5L,10L,3L,12L,9L,12L,5L,6L,3L,18L,3L,6L,11L,10L,9L,14L,3L,10L,5L,16L,3L,18L,3L,6L,9L,10L,7L,14L,3L };
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
public class A259576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259576Inst : IEnumerable<long>
{
public static readonly long[] Value=A259576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259576.Bytes);
public long this[int i]=>Value[i];

public static A259576Inst Instance=new A259576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259577
{
public static readonly long[] Value={ 1L,2L,6L,13L,26L,44L,72L,108L,156L,215L,290L,381L,486L,610L,758L,924L,1112L,1329L,1566L,1839L,2134L,2456L,2816L,3220L,3640L,4099L,4608L,5153L,5726L,6368L,7020L,7744L,8504L,9305L,10180L,11103L,12042L,13060L,14146L,15296L,16460L,17739L,19026L,20421L,21876L };
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
public class A259577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259577Inst : IEnumerable<long>
{
public static readonly long[] Value=A259577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259577.Bytes);
public long this[int i]=>Value[i];

public static A259577Inst Instance=new A259577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259578
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,4L,3L,4L,2L,2L,4L,5L,5L,4L,2L,2L,5L,6L,6L,6L,5L,2L,2L,5L,6L,8L,8L,6L,5L,2L,2L,6L,8L,10L,10L,10L,8L,6L,2L,2L,6L,9L,11L,12L,12L,11L,9L,6L,2L,2L,7L,9L,12L,14L,15L,14L,12L,9L,7L,2L,2L,7L,11L,14L,16L,17L,17L,16L,14L,11L,7L,2L,2L,8L };
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
public class A259578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259578Inst : IEnumerable<long>
{
public static readonly long[] Value=A259578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259578.Bytes);
public long this[int i]=>Value[i];

public static A259578Inst Instance=new A259578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259579
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,4L,3L,4L,5L,4L,3L,6L,3L,4L,5L,6L,3L,6L,3L,6L,7L,6L,3L,10L,3L,6L,7L,8L,3L,12L,3L,8L,9L,6L,5L,12L,3L,6L,9L,10L,3L,12L,3L,10L,9L,6L,3L,16L,5L,8L,9L,10L,3L,10L,5L,10L,9L,6L,3L,20L,3L,6L,9L,10L,5L,14L,3L,10L,9L,12L,3L,16L,3L,6L,11L,10L,9L,14L,3L,14L };
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
public class A259579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259579Inst : IEnumerable<long>
{
public static readonly long[] Value=A259579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259579.Bytes);
public long this[int i]=>Value[i];

public static A259579Inst Instance=new A259579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259580
{
public static readonly long[] Value={ 2L,5L,8L,17L,30L,50L,78L,116L,162L,227L,300L,389L,498L,628L,766L,940L,1128L,1347L,1584L,1855L,2146L,2486L,2838L,3236L,3660L,4135L,4626L,5177L,5754L,6392L,7050L,7776L,8524L,9353L,10204L,11127L,12078L,13114L,14170L,15328L,16500L,17775L,19068L,20461L,21900L };
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
public class A259580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259580Inst : IEnumerable<long>
{
public static readonly long[] Value=A259580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259580.Bytes);
public long this[int i]=>Value[i];

public static A259580Inst Instance=new A259580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259581
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,4L,6L,4L,3L,3L,5L,6L,6L,5L,3L,3L,5L,7L,6L,7L,5L,3L,3L,6L,9L,9L,9L,9L,6L,3L,3L,6L,9L,10L,10L,10L,9L,6L,3L,3L,7L,10L,12L,13L,13L,12L,10L,7L,3L,3L,7L,12L,12L,15L,15L,15L,12L,12L,7L,3L,3L,8L,12L,15L,17L,18L,18L,17L,15L,12L,8L,3L };
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
public class A259581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259581Inst : IEnumerable<long>
{
public static readonly long[] Value=A259581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259581.Bytes);
public long this[int i]=>Value[i];

public static A259581Inst Instance=new A259581Inst();

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