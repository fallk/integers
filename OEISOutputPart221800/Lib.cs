using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A272462
{
public static readonly BigInteger[] Value={ 1L,144L,110736L,210615984L,746983671696L,4257350521714224L,BigInteger.Parse("35587232523796298256"),BigInteger.Parse("410153047417991816658864"),BigInteger.Parse("6233578942096421437956406416"),BigInteger.Parse("120792275605361900683656723353904"),BigInteger.Parse("2906718881167945096170286249866172176"),BigInteger.Parse("85040397046127662408816208740192211143344"),BigInteger.Parse("2972655821721881151201962319719058551015131536"),BigInteger.Parse("122359658857407586222518613315327725437983909211184") };
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
public class A272462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272462Inst Instance=new A272462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272463
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,12L,36L,112L,360L,1184L,3969L,13506L,46550L,162160L,570076L,2019864L,7205654L,25859788L,93299268L,338207096L,1231194329L,4499137382L,16498152995L,60689045230L,223891151262L,828156420320L,3070760666368L,11411884518800L,42498639965025L,158575098942194L,592761262161240L,2219513277432130L,8323806778346002L,31262959171040784L,117582688976071889L,442819400938052362L,1669735077567533522L,6303424784771599874L,BigInteger.Parse("23822450122837267190") };
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
public class A272463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272463Inst Instance=new A272463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272464
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,5L,2L,1L,4L,7L,3L,8L,5L,2L,1L,4L,11L,7L,10L,3L,8L,13L,5L,2L,1L,4L,15L,11L,18L,7L,17L,10L,3L,8L,21L,13L,5L,2L,1L,4L,19L,15L,26L,11L,29L,18L,25L,7L,24L,17L,27L,10L,3L,8L,21L,34L,13L,5L,2L,1L,4L,23L,19L,15L,41L,26L,37L,11L,40L,29L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272464Inst : IEnumerable<long>
{
public static readonly long[] Value=A272464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272464.Bytes);
public long this[int i]=>Value[i];

public static A272464Inst Instance=new A272464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272465
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,19L,29L,43L,64L,95L,142L,211L,317L,480L,726L,1096L,1644L,2458L,3669L,5480L,8204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272465Inst : IEnumerable<long>
{
public static readonly long[] Value=A272465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272465.Bytes);
public long this[int i]=>Value[i];

public static A272465Inst Instance=new A272465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272466
{
public static readonly long[] Value={ 6L,9L,12L,14L,16L,20L,22L,28L,30L,33L,35L,36L,49L,50L,54L,58L,64L,66L,72L,74L,75L,77L,78L,80L,86L,87L,88L,90L,94L,96L,102L,110L,116L,118L,120L,121L,124L,126L,130L,132L,141L,143L,146L,150L,158L,161L,162L,168L,169L,172L,176L,180L,182L,183L,187L,189L,191L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272466Inst : IEnumerable<long>
{
public static readonly long[] Value=A272466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272466.Bytes);
public long this[int i]=>Value[i];

public static A272466Inst Instance=new A272466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272467
{
public static readonly BigInteger[] Value={ 1L,6L,186L,14166L,2009946L,458225526L,153212718906L,70632832168086L,42939614599671066L,BigInteger.Parse("33282798350926545846"),BigInteger.Parse("32036398991671262130426"),BigInteger.Parse("37490905748197466281582806"),BigInteger.Parse("52420996658289450763331680986"),BigInteger.Parse("86309558223400912513674314622966"),BigInteger.Parse("165280246718130394753827229389826746"),BigInteger.Parse("364233987506387128128991081880073730326"),BigInteger.Parse("915234544675507984101674168382043517591706") };
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
public class A272467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272467Inst Instance=new A272467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272468
{
public static readonly BigInteger[] Value={ 1L,1L,16L,861L,96151L,18222146L,5239250961L,2125867405481L,1156996954702696L,813362896424049741L,BigInteger.Parse("717389213154874345231"),BigInteger.Parse("775695142663748111834426"),BigInteger.Parse("1009031532010773852853587441"),BigInteger.Parse("1554520965241408817492939532161"),BigInteger.Parse("2799176143277347317623990785312576"),BigInteger.Parse("5825065298299069164298296125454811821"),BigInteger.Parse("13872866932424152546975929055708940259511"),BigInteger.Parse("37490505378893715802821349609594581921197906") };
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
public class A272468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272468Inst Instance=new A272468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272469
{
public static readonly long[] Value={ 0L,6L,50L,322L,1874L,10558L,58716L,325758L,1808778L,10068548L,56213606L,314785072L,1767660604L,9951449844L,56151698716L,317484868212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272469Inst : IEnumerable<long>
{
public static readonly long[] Value=A272469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272469.Bytes);
public long this[int i]=>Value[i];

public static A272469Inst Instance=new A272469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272470
{
public static readonly long[] Value={ 14L,21L,35L,49L,77L,91L,119L,133L,161L,203L,217L,259L,287L,301L,329L,371L,413L,427L,469L,497L,511L,553L,581L,623L,679L,707L,721L,749L,763L,791L,889L,917L,959L,973L,1043L,1057L,1099L,1141L,1169L,1211L,1253L,1267L,1337L,1351L,1379L,1393L,1477L,1561L,1589L,1603L,1631L,1673L,1687L,1757L,1799L,1841L,1883L,1897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272470Inst : IEnumerable<long>
{
public static readonly long[] Value=A272470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272470.Bytes);
public long this[int i]=>Value[i];

public static A272470Inst Instance=new A272470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272471
{
public static readonly long[] Value={ 1L,1L,2L,4L,3L,9L,1L,4L,18L,7L,6L,35L,26L,1L,9L,64L,73L,10L,13L,112L,179L,52L,1L,19L,192L,403L,194L,13L,28L,323L,850L,597L,87L,1L,41L,534L,1707L,1624L,408L,16L,60L,872L,3303L,4046L,1532L,131L,1L,88L,1410L,6203L,9428L,4951L,742L,19L,129L,2260L,11366L,20847L,14361L,3308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272471Inst : IEnumerable<long>
{
public static readonly long[] Value=A272471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272471.Bytes);
public long this[int i]=>Value[i];

public static A272471Inst Instance=new A272471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272472
{
public static readonly long[] Value={ 0L,2L,0L,1L,3L,0L,9L,0L,1L,0L,10L,0L,12L,4L,0L,27L,0L,13L,0L,18L,0L,56L,0L,16L,6L,0L,75L,0L,97L,0L,18L,0L,38L,0L,198L,0L,152L,0L,18L,10L,0L,177L,0L,433L,0L,214L,0L,18L,0L,72L,0L,570L,0L,836L,0L,282L,0L,18L,16L,0L,393L,0L,1517L,0L,1442L,0L,354L,0L,18L,0L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272472Inst : IEnumerable<long>
{
public static readonly long[] Value=A272472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272472.Bytes);
public long this[int i]=>Value[i];

public static A272472Inst Instance=new A272472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272473
{
public static readonly long[] Value={ 1L,3L,1L,4L,18L,7L,4L,27L,13L,2L,32L,32L,3L,52L,64L,7L,3L,62L,133L,40L,3L,99L,269L,110L,9L,5L,152L,437L,280L,48L,5L,163L,730L,669L,138L,9L,6L,258L,1243L,1318L,433L,48L,8L,343L,1823L,2670L,1239L,154L,9L,8L,408L,2949L,5240L,2849L,600L,48L,11L,632L,4577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272473Inst : IEnumerable<long>
{
public static readonly long[] Value=A272473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272473.Bytes);
public long this[int i]=>Value[i];

public static A272473Inst Instance=new A272473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272474
{
public static readonly long[] Value={ 0L,3L,0L,4L,0L,1L,6L,0L,35L,0L,26L,0L,1L,0L,18L,0L,56L,0L,16L,3L,0L,52L,0L,64L,0L,7L,0L,10L,0L,88L,0L,80L,2L,0L,60L,0L,182L,0L,81L,0L,8L,0L,160L,0L,320L,0L,96L,2L,0L,102L,0L,500L,0L,449L,0L,112L,0L,18L,0L,340L,0L,952L,0L,600L,0L,120L,4L,0L,184L,0L,1056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272474Inst : IEnumerable<long>
{
public static readonly long[] Value=A272474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272474.Bytes);
public long this[int i]=>Value[i];

public static A272474Inst Instance=new A272474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272475
{
public static readonly long[] Value={ 4L,6L,8L,10L,11L,12L,16L,18L,20L,22L,23L,24L,28L,30L,32L,33L,35L,36L,40L,42L,43L,44L,46L,48L,50L,52L,54L,55L,56L,58L,60L,64L,66L,68L,69L,70L,72L,75L,76L,77L,78L,80L,82L,83L,84L,86L,88L,90L,92L,95L,96L,99L,100L,102L,104L,105L,106L,108L,110L,112L,114L,115L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272475Inst : IEnumerable<long>
{
public static readonly long[] Value=A272475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272475.Bytes);
public long this[int i]=>Value[i];

public static A272475Inst Instance=new A272475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272476
{
public static readonly long[] Value={ 3L,5L,2L,3L,11L,5L,15L,7L,19L,21L,23L,11L,27L,13L,31L,33L,35L,17L,39L,19L,43L,45L,47L,23L,51L,53L,55L,57L,59L,29L,63L,31L,67L,69L,71L,73L,75L,37L,79L,81L,83L,41L,87L,43L,91L,93L,95L,47L,99L,101L,103L,105L,107L,53L,111L,113L,115L,117L,119L,59L,123L,61L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272476Inst : IEnumerable<long>
{
public static readonly long[] Value=A272476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272476.Bytes);
public long this[int i]=>Value[i];

public static A272476Inst Instance=new A272476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272477
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,27L,29L,31L,32L,33L,34L,35L,36L,37L,39L,40L,41L,43L,45L,47L,48L,49L,51L,53L,55L,57L,59L,61L,63L,64L,65L,66L,67L,68L,69L,71L,72L,73L,75L,77L,79L,80L,81L,83L,85L,87L,89L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272477Inst : IEnumerable<long>
{
public static readonly long[] Value=A272477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272477.Bytes);
public long this[int i]=>Value[i];

public static A272477Inst Instance=new A272477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272478
{
public static readonly long[] Value={ 17L,19L,79L,103L,107L,109L,5119L,6079L,6911L,7039L,7103L,7151L,7159L,7919L,7927L,7933L,8059L,8111L,8123L,8167L,8171L,8179L,442367L,458239L,458719L,458747L,487423L,491503L,499711L,507839L,507901L,515839L,516091L,520063L,523007L,523261L,523519L,523759L,523771L,523903L,524219L,524221L,524269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272478Inst : IEnumerable<long>
{
public static readonly long[] Value=A272478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272478.Bytes);
public long this[int i]=>Value[i];

public static A272478Inst Instance=new A272478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272479
{
public static readonly long[] Value={ 10L,10L,12L,20L,10L,12L,70L,40L,18L,1L,10L,3L,76L,10L,12L,35L,296L,9L,10L,2L,3L,20L,10L,6L,14L,184L,9L,10L,20999L,3L,100L,10L,12L,98L,16L,9L,10L,11L,12L,4L,10L,6L,99799L,40L,9L,10L,2099999L,12L,52L,5L,12L,49L,1000L,9L,10L,11L,12L,1001L,7998998L,6L,7999999L,200L,9L,10L,319L,12L,68989999L,98L,30L,7L,1000L,9L,10L,11L,12L,13L,56L,15L,10000L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272479Inst : IEnumerable<long>
{
public static readonly long[] Value=A272479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272479.Bytes);
public long this[int i]=>Value[i];

public static A272479Inst Instance=new A272479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272480
{
public static readonly long[] Value={ 3L,7L,17L,41L,95L,223L,523L,1201L,2781L,6445L,14731L,33859L,77899L,177523L,406115L,929825L,2114387L,4821367L,11001423L,24974353L,56813401L,129315249L,293157759L,665688917L,1512325105L,3424615395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272480Inst : IEnumerable<long>
{
public static readonly long[] Value=A272480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272480.Bytes);
public long this[int i]=>Value[i];

public static A272480Inst Instance=new A272480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272481
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,3L,1L,0L,0L,3L,15L,25L,15L,3L,0L,0L,17L,119L,329L,455L,329L,119L,17L,0L,0L,155L,1395L,5325L,11235L,14301L,11235L,5325L,1395L,155L,0L,0L,2073L,22803L,110605L,311355L,563013L,683067L,563013L,311355L,110605L,22803L,2073L,0L,0L,38227L,496951L,2918825L,10241231L,23904881L,39102063L,45956625L,39102063L,23904881L,10241231L,2918825L,496951L,38227L,0L,0L,929569L,13943535L,96075665L,403075855L,1150348017L,2362479119L,3600524785L,4136759055L,3600524785L,2362479119L,1150348017L,403075855L,96075665L,13943535L,929569L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272481Inst : IEnumerable<long>
{
public static readonly long[] Value=A272481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272481.Bytes);
public long this[int i]=>Value[i];

public static A272481Inst Instance=new A272481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272482
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,455L,14301L,683067L,45956625L,4136759055L,479777869285L,69653708853443L,12371662732650585L,2638795469278520279L,BigInteger.Parse("665531624367489426925"),BigInteger.Parse("195911141957772574473675"),BigInteger.Parse("66564029296445548535841825"),BigInteger.Parse("25853886516555100370014075935"),BigInteger.Parse("11383146182215029605579802759285"),BigInteger.Parse("5639331535011059552351840518792275"),BigInteger.Parse("3122923020612123544335165657648107625"),BigInteger.Parse("1921790647828858936591348065677192750055") };
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
public class A272482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272482Inst Instance=new A272482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272483
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,24L,76L,240L,787L,2670L,9233L,32293L,114051L,406588L,1461748L,5293301L,19287242L,70660178L,260127781L,961814451L,3570265304L,13299988867L,49705359457L,186309387918L,700228153534L,2638299418839L,9963349661693L,37705935306758L,142978684267052L,543164138444912L,2066978553423647L,7878398598991602L,30074161433351617L,114964340210315649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272483Inst : IEnumerable<long>
{
public static readonly long[] Value=A272483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272483.Bytes);
public long this[int i]=>Value[i];

public static A272483Inst Instance=new A272483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272484
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,28L,86L,278L,928L,3164L,10958L,38428L,136168L,486796L,1753660L,6359961L,23202408L,85093552L,313548346L,1160248084L,4309812532L,16064728072L,60070599076L,225271863550L,847042748378L,3192758928650L,12061704111576L,45662648135238L,173204482763760L,658180582310888L,2505341336035650L,9551632787000829L,36469897605758744L,139443687986144472L,533869533407865024L,2046496258409861740L,7854102611559917914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272484Inst : IEnumerable<long>
{
public static readonly long[] Value=A272484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272484.Bytes);
public long this[int i]=>Value[i];

public static A272484Inst Instance=new A272484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272485
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,72L,274L,1084L,4413L,18365L,77773L,334065L,1451929L,6373379L,28214851L,125826137L,564736106L,2549004457L,11563003842L,52688331678L,241049183598L,1106818411361L,5098961600041L,23561122837102L,109171473224810L,507136264223327L,2361332083301582L,11018704225690520L,51520180227572593L,241344269535483201L,1132543412040153639L,5323310040423904420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272485Inst : IEnumerable<long>
{
public static readonly long[] Value=A272485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272485.Bytes);
public long this[int i]=>Value[i];

public static A272485Inst Instance=new A272485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272486
{
public static readonly long[] Value={ 8L,13L,16L,19L,24L,26L,27L,32L,37L,38L,40L,42L,43L,45L,48L,50L,51L,53L,54L,56L,59L,61L,64L,66L,67L,69L,70L,72L,75L,77L,78L,80L,82L,83L,85L,88L,90L,91L,96L,99L,101L,104L,107L,109L,110L,112L,114L,115L,116L,117L,120L,122L,125L,126L,128L,131L,133L,136L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272486Inst : IEnumerable<long>
{
public static readonly long[] Value=A272486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272486.Bytes);
public long this[int i]=>Value[i];

public static A272486Inst Instance=new A272486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272487
{
public static readonly long[] Value={ 8L,6L,7L,7L,6L,7L,4L,7L,8L,2L,3L,5L,1L,1L,6L,2L,4L,0L,9L,5L,1L,5L,3L,6L,6L,6L,5L,6L,9L,6L,7L,1L,7L,5L,0L,9L,2L,1L,9L,9L,8L,1L,4L,5L,5L,5L,7L,4L,9L,1L,9L,7L,5L,2L,8L,8L,9L,0L,9L,4L,6L,0L,7L,0L,6L,4L,4L,0L,6L,5L,0L,3L,3L,0L,6L,3L,9L,6L,8L,4L,3L,0L,4L,1L,5L,6L,8L,0L,4L,3L,5L,4L,8L,9L,1L,2L,2L,0L,4L,1L,7L,7L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272487Inst : IEnumerable<long>
{
public static readonly long[] Value=A272487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272487.Bytes);
public long this[int i]=>Value[i];

public static A272487Inst Instance=new A272487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272488
{
public static readonly long[] Value={ 6L,8L,4L,0L,4L,0L,2L,8L,6L,6L,5L,1L,3L,3L,7L,4L,6L,6L,0L,8L,8L,1L,9L,9L,2L,2L,9L,3L,6L,4L,5L,1L,9L,1L,6L,1L,5L,2L,6L,1L,6L,6L,7L,3L,5L,0L,2L,8L,3L,2L,1L,2L,5L,6L,9L,3L,0L,0L,9L,6L,9L,9L,5L,3L,6L,9L,4L,2L,9L,5L,2L,7L,4L,0L,4L,1L,5L,5L,1L,9L,9L,1L,2L,8L,3L,8L,0L,3L,6L,4L,6L,7L,7L,0L,5L,1L,0L,9L,5L,0L,8L,0L,9L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272488Inst : IEnumerable<long>
{
public static readonly long[] Value=A272488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272488.Bytes);
public long this[int i]=>Value[i];

public static A272488Inst Instance=new A272488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272489
{
public static readonly long[] Value={ 5L,6L,3L,4L,6L,5L,1L,1L,3L,6L,8L,2L,8L,5L,9L,3L,9L,5L,4L,2L,2L,8L,3L,5L,8L,3L,0L,6L,9L,3L,2L,3L,3L,7L,9L,8L,0L,7L,1L,5L,5L,5L,7L,9L,7L,9L,4L,6L,5L,3L,3L,7L,4L,3L,6L,6L,2L,1L,6L,0L,6L,1L,2L,1L,7L,5L,6L,9L,7L,5L,9L,7L,0L,3L,8L,0L,5L,8L,3L,3L,6L,2L,4L,6L,9L,3L,5L,2L,3L,6L,9L,0L,3L,7L,7L,3L,0L,9L,9L,9L,3L,5L,9L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272489Inst : IEnumerable<long>
{
public static readonly long[] Value=A272489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272489.Bytes);
public long this[int i]=>Value[i];

public static A272489Inst Instance=new A272489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272490
{
public static readonly long[] Value={ 4L,7L,8L,6L,3L,1L,3L,2L,8L,5L,7L,5L,1L,1L,5L,5L,3L,4L,2L,9L,7L,5L,0L,7L,4L,5L,2L,5L,2L,0L,4L,2L,3L,7L,9L,0L,4L,0L,6L,3L,4L,6L,0L,4L,5L,4L,7L,6L,6L,1L,2L,0L,2L,6L,7L,1L,0L,3L,1L,9L,4L,3L,7L,3L,2L,3L,6L,6L,3L,1L,2L,5L,7L,0L,1L,5L,0L,3L,7L,4L,3L,9L,2L,2L,3L,8L,9L,9L,6L,4L,4L,4L,1L,7L,2L,8L,8L,9L,4L,5L,1L,7L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272490Inst : IEnumerable<long>
{
public static readonly long[] Value=A272490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272490.Bytes);
public long this[int i]=>Value[i];

public static A272490Inst Instance=new A272490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272491
{
public static readonly long[] Value={ 3L,2L,9L,1L,8L,9L,1L,8L,0L,5L,6L,1L,4L,6L,7L,7L,8L,8L,2L,8L,7L,3L,0L,4L,1L,1L,8L,1L,7L,5L,8L,7L,6L,8L,3L,9L,0L,2L,4L,3L,4L,4L,9L,6L,6L,7L,1L,9L,3L,0L,8L,2L,4L,6L,7L,0L,2L,9L,4L,2L,5L,4L,8L,0L,9L,8L,1L,5L,3L,8L,0L,5L,7L,0L,4L,9L,4L,3L,4L,1L,2L,5L,9L,5L,5L,7L,4L,6L,2L,8L,7L,6L,0L,1L,8L,7L,9L,8L,6L,0L,7L,7L,2L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272491Inst : IEnumerable<long>
{
public static readonly long[] Value=A272491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272491.Bytes);
public long this[int i]=>Value[i];

public static A272491Inst Instance=new A272491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272492
{
public static readonly BigInteger[] Value={ 1L,3L,18L,90L,630L,4410L,37800L,340200L,3515400L,38669400L,471517200L,6129723600L,86497210800L,1297458162000L,20841060240000L,354298024080000L,6389869069584000L,121407512322096000L,2430526127309280000L,BigInteger.Parse("51041048673494880000"),BigInteger.Parse("1123451899297247520000") };
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
public class A272492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272492.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272492Inst Instance=new A272492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272493
{
public static readonly BigInteger[] Value={ 1L,4L,30L,200L,1610L,13440L,130200L,1327200L,15107400L,183321600L,2422820400L,34104470400L,515897382000L,8276556288000L,141290381232000L,2546760408192000L,48489153817104000L,970454450085120000L,BigInteger.Parse("20400874234060320000"),BigInteger.Parse("448974320483969280000") };
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
public class A272493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272493Inst Instance=new A272493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272494
{
public static readonly BigInteger[] Value={ 1L,5L,45L,350L,3290L,30870L,334950L,3765300L,46950750L,617867250L,8815156350L,133031398500L,2149039893000L,36645888279000L,662781093975000L,12612741639498000L,252857867367105000L,5314211504296695000L,BigInteger.Parse("117053051989758885000"),BigInteger.Parse("2693288170000578150000") };
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
public class A272494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272494Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272494.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272494Inst Instance=new A272494Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272495
{
public static readonly BigInteger[] Value={ 1L,6L,63L,560L,5922L,61992L,739662L,9086616L,122792670L,1741884144L,26631631026L,428931318816L,7362963616008L,132977285400960L,2538822785931432L,50863863365419104L,1070731366348427784L,BigInteger.Parse("23576426902769412672"),BigInteger.Parse("542918591829347774040"),BigInteger.Parse("13035693339696004705728") };
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
public class A272495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272495Inst Instance=new A272495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272496
{
public static readonly BigInteger[] Value={ 1L,7L,84L,840L,9870L,113652L,1480248L,19699680L,286768482L,4358914560L,71096721696L,1216711960464L,22116370171896L,421629228820800L,8473857766133760L,178260053918650704L,3931319749640138856L,BigInteger.Parse("90499126549555707984"),BigInteger.Parse("2174651142277047610176"),BigInteger.Parse("54390059451824183287200") };
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
public class A272496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272496Inst Instance=new A272496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272497
{
public static readonly BigInteger[] Value={ 1L,8L,108L,1200L,15510L,194832L,2749032L,39402792L,614555370L,9964468800L,172686804576L,3129181488576L,60039964804248L,1204868044448640L,25426155055055040L,560350692475352064L,12919636322380914984UL,BigInteger.Parse("310342487192287684992"),BigInteger.Parse("7768115419959585662400") };
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
public class A272497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272497Inst Instance=new A272497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272498
{
public static readonly BigInteger[] Value={ 1L,9L,135L,1650L,23265L,316602L,4810806L,73880235L,1229123610L,21174714990L,388551217626L,7431930745668L,150102842702670L,3162843042018660L,69923464752835980L,1611044465380180974L,BigInteger.Parse("38759812951913315262"),BigInteger.Parse("969843174518264324850"),BigInteger.Parse("25246982138722170061950") };
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
public class A272498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272498Inst Instance=new A272498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272499
{
public static readonly BigInteger[] Value={ 1L,10L,165L,2200L,33605L,492492L,8018010L,131342640L,2321677930L,42349478600L,820275716546L,16515429370440L,350240612952230L,7731410818511380L,178693701272340540L,4296129057927296304L,BigInteger.Parse("107666415418378051950"),BigInteger.Parse("2801776425029317564400"),BigInteger.Parse("75741144900761549630850") };
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
public class A272499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272499Inst Instance=new A272499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272500
{
public static readonly BigInteger[] Value={ 1L,11L,198L,2860L,47047L,738738L,12828816L,223282488L,4179020274L,80464009340L,1640551617848L,34682405557800L,770529476530814L,17782248154604934L,428864975324828328L,10740325059575465640UL,BigInteger.Parse("279932748231053890830"),BigInteger.Parse("7564798231253861700960"),BigInteger.Parse("212075260563875086898520") };
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
public class A272500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272500Inst Instance=new A272500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272501
{
public static readonly ulong[] Value={ 1L,10L,100L,990L,9640L,91900L,855100L,7754050L,68545360L,592095160L,5020469200L,42054532750L,350538754600L,2926602465940L,24587635740040L,208406304739450L,1784567064858400L,15453880256710000L,135459380264937760L,1202295227210127910L,10804306958861721400UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272501Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A272501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272501.Bytes);
public ulong this[int i]=>Value[i];

public static A272501Inst Instance=new A272501Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272502
{
public static readonly BigInteger[] Value={ 1L,10L,100L,1000L,9990L,99550L,987850L,9744850L,95410450L,925825060L,8893045900L,84482314300L,793301261050L,7362408236050L,67558485684790L,613509413395150L,5521782692963800L,49350428808293800L,438963976165310200L,3895008340554766360L,BigInteger.Parse("34553010749282271550") };
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
public class A272502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272502Inst Instance=new A272502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272503
{
public static readonly BigInteger[] Value={ 1L,10L,100L,1000L,10000L,99990L,999460L,9982990L,99591760L,991733140L,9851207860L,97545740500L,962166785680L,9447649239610L,92290336898860L,896407655754610L,8653070630861920L,82985161693086280L,790512637315007440L,7479643461956322760L,BigInteger.Parse("70304610246340134880") };
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
public class A272503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272503Inst Instance=new A272503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272504
{
public static readonly long[] Value={ 1L,9L,14L,54L,71L,179L,216L,420L,473L,809L,898L,1378L,1499L,2147L,2304L,3192L,3349L,4445L,4714L,6070L,6331L,8019L,8348L,10368L,10773L,13161L,13638L,16442L,16951L,20127L,20796L,24376L,25077L,29193L,30078L,34706L,35631L,40791L,41724L,47496L,48669L,55025L,56178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272504Inst : IEnumerable<long>
{
public static readonly long[] Value=A272504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272504.Bytes);
public long this[int i]=>Value[i];

public static A272504Inst Instance=new A272504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272505
{
public static readonly long[] Value={ 7L,-3L,35L,-23L,91L,-71L,167L,-151L,283L,-247L,391L,-359L,527L,-491L,731L,-731L,939L,-827L,1087L,-1095L,1427L,-1359L,1691L,-1615L,1983L,-1911L,2327L,-2295L,2667L,-2507L,2911L,-2879L,3415L,-3231L,3743L,-3703L,4235L,-4227L,4839L,-4599L,5183L,-5203L,5727L,-5623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272505Inst : IEnumerable<long>
{
public static readonly long[] Value=A272505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272505.Bytes);
public long this[int i]=>Value[i];

public static A272505Inst Instance=new A272505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272506
{
public static readonly long[] Value={ 1L,5L,4L,20L,9L,37L,28L,57L,41L,72L,101L,152L,148L,204L,244L,332L,281L,317L,288L,368L,448L,493L,556L,712L,709L,728L,793L,876L,925L,960L,1045L,1328L,1273L,1269L,1257L,1437L,1429L,1605L,1753L,1921L,1997L,1993L,2153L,2325L,2361L,2349L,2608L,2969L,2860L,2729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272506Inst : IEnumerable<long>
{
public static readonly long[] Value=A272506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272506.Bytes);
public long this[int i]=>Value[i];

public static A272506Inst Instance=new A272506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272507
{
public static readonly long[] Value={ 1L,5L,20L,57L,332L,1328L,5329L,21333L,85513L,346804L,1382669L,5513932L,22072048L,88358301L,353454697L,1414085800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272507Inst : IEnumerable<long>
{
public static readonly long[] Value=A272507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272507.Bytes);
public long this[int i]=>Value[i];

public static A272507Inst Instance=new A272507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272508
{
public static readonly long[] Value={ 1L,6L,10L,30L,39L,76L,104L,161L,202L,274L,375L,527L,675L,879L,1123L,1455L,1736L,2053L,2341L,2709L,3157L,3650L,4206L,4918L,5627L,6355L,7148L,8024L,8949L,9909L,10954L,12282L,13555L,14824L,16081L,17518L,18947L,20552L,22305L,24226L,26223L,28216L,30369L,32694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272508Inst : IEnumerable<long>
{
public static readonly long[] Value=A272508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272508.Bytes);
public long this[int i]=>Value[i];

public static A272508Inst Instance=new A272508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272509
{
public static readonly long[] Value={ 4L,-1L,16L,-11L,28L,-9L,29L,-16L,31L,29L,51L,-4L,56L,40L,88L,-51L,36L,-29L,80L,80L,45L,63L,156L,-3L,19L,65L,83L,49L,35L,85L,283L,-55L,-4L,-12L,180L,-8L,176L,148L,168L,76L,-4L,160L,172L,36L,-12L,259L,361L,-109L,-131L,252L,311L,9L,4L,256L,92L,172L,24L,164L,412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272509Inst : IEnumerable<long>
{
public static readonly long[] Value=A272509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272509.Bytes);
public long this[int i]=>Value[i];

public static A272509Inst Instance=new A272509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272510
{
public static readonly long[] Value={ 1L,4L,13L,32L,33L,100L,65L,160L,97L,300L,145L,376L,177L,580L,257L,712L,345L,988L,433L,1112L,465L,1460L,601L,1688L,745L,2100L,897L,2312L,897L,2772L,1081L,3048L,1281L,3612L,1481L,3920L,1505L,4500L,1817L,4848L,1993L,5580L,2209L,5992L,2401L,6628L,2497L,7072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272510Inst : IEnumerable<long>
{
public static readonly long[] Value=A272510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272510.Bytes);
public long this[int i]=>Value[i];

public static A272510Inst Instance=new A272510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272511
{
public static readonly long[] Value={ 1L,4L,32L,160L,712L,3048L,12864L,52440L,210640L,840352L,3353008L,13392000L,53523920L,214003872L,855827888L,3422933120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272511Inst : IEnumerable<long>
{
public static readonly long[] Value=A272511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272511.Bytes);
public long this[int i]=>Value[i];

public static A272511Inst Instance=new A272511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272512
{
public static readonly long[] Value={ 1L,5L,18L,50L,83L,183L,248L,408L,505L,805L,950L,1326L,1503L,2083L,2340L,3052L,3397L,4385L,4818L,5930L,6395L,7855L,8456L,10144L,10889L,12989L,13886L,16198L,17095L,19867L,20948L,23996L,25277L,28889L,30370L,34290L,35795L,40295L,42112L,46960L,48953L,54533L,56742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272512Inst : IEnumerable<long>
{
public static readonly long[] Value=A272512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272512.Bytes);
public long this[int i]=>Value[i];

public static A272512Inst Instance=new A272512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272513
{
public static readonly long[] Value={ 3L,9L,19L,1L,67L,-35L,95L,-63L,203L,-155L,231L,-199L,403L,-323L,455L,-367L,643L,-555L,679L,-647L,995L,-859L,1087L,-943L,1355L,-1203L,1415L,-1415L,1875L,-1691L,1967L,-1767L,2331L,-2131L,2439L,-2415L,2995L,-2683L,3031L,-2855L,3587L,-3371L,3783L,-3591L,4227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272513Inst : IEnumerable<long>
{
public static readonly long[] Value=A272513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272513.Bytes);
public long this[int i]=>Value[i];

public static A272513Inst Instance=new A272513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272514
{
public static readonly long[] Value={ 3L,4L,15L,21L,63L,92L,255L,385L,1023L,1585L,4095L,6475L,16383L,26332L,65535L,106761L,262143L,431909L,1048575L,1744435L,4194303L,7036529L,16777215L,28354131L,67108863L,114159427L,268435455L,459312151L,1073741823L,1846943452L,4294967295L,7423131481L,17179869183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272514Inst : IEnumerable<long>
{
public static readonly long[] Value=A272514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272514.Bytes);
public long this[int i]=>Value[i];

public static A272514Inst Instance=new A272514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272515
{
public static readonly long[] Value={ 60L,105L,448L,2016L,4980L,15675L,61644L,155155L,482573L,1733550L,4549808L,13890360L,48104628L,128949675L,392009140L,1322692581L,3607864403L,10929721440L,36245555284L,100109572875L,302709337515L,990788537700L,2763564406113L,8344789976616L,27039048750600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272515Inst : IEnumerable<long>
{
public static readonly long[] Value=A272515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272515.Bytes);
public long this[int i]=>Value[i];

public static A272515Inst Instance=new A272515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272516
{
public static readonly long[] Value={ 12600L,27720L,138600L,643500L,4408404L,12687675L,60780720L,238299880L,1295666424L,4208874756L,18840460800L,72351683460L,361100656224L,1228553894491L,5370616442928L,20605640103400L,97659853077800L,342942099783075L,1479570975628200L,5678915129142255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272516Inst : IEnumerable<long>
{
public static readonly long[] Value=A272516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272516.Bytes);
public long this[int i]=>Value[i];

public static A272516Inst Instance=new A272516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272517
{
public static readonly long[] Value={ 37837800L,100900800L,588107520L,2977294320L,20020160160L,164118754800L,635661248040L,3295178686800L,17741374681800L,95826446465904L,623399389674600L,2664090278249400L,13876038856379700L,71797074694745400L,375274098870636420L,2199911433079733100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272517Inst : IEnumerable<long>
{
public static readonly long[] Value=A272517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272517.Bytes);
public long this[int i]=>Value[i];

public static A272517Inst Instance=new A272517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272518
{
public static readonly BigInteger[] Value={ 2053230379200L,6453009763200L,43288940494800L,242418066770880L,1707999012720000L,12887361202716000L,144924867388501200L,620550897351184800L,4048435123506774000L,BigInteger.Parse("23424084614648718000"),BigInteger.Parse("161250104584826056800"),BigInteger.Parse("1013722794731975328000"),BigInteger.Parse("8616255173755280251200") };
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
public class A272518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272518Inst Instance=new A272518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272519
{
public static readonly BigInteger[] Value={ 2431106898187968000L,8812762505931384000L,BigInteger.Parse("67144857188048640000"),BigInteger.Parse("416298114565901568000"),BigInteger.Parse("3144312274410635328000"),BigInteger.Parse("23728992530256389376000"),BigInteger.Parse("238675412699786289427200"),BigInteger.Parse("3207620559498676985664000"),BigInteger.Parse("16207982672116390803648000"),BigInteger.Parse("117220515926387332979520000") };
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
public class A272519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272519Inst Instance=new A272519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272520
{
public static readonly BigInteger[] Value={ BigInteger.Parse("73566121315513295589120000"),BigInteger.Parse("302438498741554659644160000"),BigInteger.Parse("2585849164240292339957568000"),BigInteger.Parse("17681163441201479441398176000"),BigInteger.Parse("144230432460463828639480320000"),BigInteger.Parse("1126747392322972404668523840000"),BigInteger.Parse("11096383744399962905356299840000"),BigInteger.Parse("126335461333640259667975104096000") };
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
public class A272520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272520Inst Instance=new A272520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272521
{
public static readonly BigInteger[] Value={ BigInteger.Parse("65191584694745586153436251091200000"),BigInteger.Parse("299881289595829696305806755019520000"),BigInteger.Parse("2847357699192726409368266158771200000"),BigInteger.Parse("21355182743945448070261996190784000000"),BigInteger.Parse("188337379875526275760583438815706112000"),BigInteger.Parse("1546608042571126104473205339509472000000") };
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
public class A272521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272521Inst Instance=new A272521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272522
{
public static readonly BigInteger[] Value={ BigInteger.Parse("1906765806522767212441719098019963758016000000"),BigInteger.Parse("9707171378661360354248751771737997313536000000"),BigInteger.Parse("101439940907011215701899456014662071926451200000"),BigInteger.Parse("829726696136835328433485294068646178065075200000"),BigInteger.Parse("7898017947032824439221398664897536276307929600000") };
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
public class A272522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272522Inst Instance=new A272522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272523
{
public static readonly long[] Value={ 2L,3L,4L,10L,35L,60L,65L,72L,87L,218L,226L,326L,365L,461L,611L,1244L,1566L,4839L,4913L,5396L,7020L,8410L,9714L,10362L,11405L,21695L,25240L,56076L,56588L,74579L,81990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272523Inst : IEnumerable<long>
{
public static readonly long[] Value=A272523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272523.Bytes);
public long this[int i]=>Value[i];

public static A272523Inst Instance=new A272523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272524
{
public static readonly long[] Value={ 1L,36L,136L,276L,1176L,2016L,2556L,2628L,3240L,4560L,11628L,12720L,12880L,18336L,18528L,25200L,32640L,32896L,51360L,64620L,73920L,86320L,89676L,100128L,114960L,115440L,126756L,131328L,148240L,166176L,248160L,253116L,265356L,270480L,294528L,295296L,320400L,345696L,373680L,380628L,400960L,401856L,438516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272524Inst : IEnumerable<long>
{
public static readonly long[] Value=A272524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272524.Bytes);
public long this[int i]=>Value[i];

public static A272524Inst Instance=new A272524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272525
{
public static readonly BigInteger[] Value={ 1L,22L,343L,4664L,58985L,713306L,8367627L,96021948L,1083676269L,12071330590L,133058984911L,1454046639232L,15775034293553L,170096021947874L,1824417009602195L,19478737997256516L,207133058984910837L,2194787379972565158L,BigInteger.Parse("23182441700960219479"),BigInteger.Parse("244170096021947873800") };
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
public class A272525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272525Inst Instance=new A272525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272526
{
public static readonly long[] Value={ 7L,4L,3L,9L,8L,5L,6L,1L,7L,8L,2L,8L,1L,3L,4L,0L,6L,2L,9L,9L,4L,3L,7L,9L,8L,8L,5L,9L,2L,0L,4L,1L,0L,5L,5L,2L,2L,7L,3L,7L,5L,9L,9L,4L,7L,5L,9L,6L,4L,2L,8L,3L,9L,1L,7L,0L,9L,2L,9L,6L,9L,1L,8L,5L,1L,1L,9L,8L,6L,5L,7L,6L,6L,4L,9L,8L,2L,5L,2L,3L,0L,4L,4L,9L,0L,9L,4L,4L,7L,6L,1L,2L,1L,7L,0L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272526Inst : IEnumerable<long>
{
public static readonly long[] Value=A272526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272526.Bytes);
public long this[int i]=>Value[i];

public static A272526Inst Instance=new A272526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272527
{
public static readonly long[] Value={ 9L,14L,20L,28L,36L,56L,67L,94L,124L,155L,173L,192L,213L,230L,253L,344L,395L,475L,504L,534L,596L,725L,759L,795L,1230L,1359L,1449L,1549L,1596L,1647L,1688L,1745L,1798L,2005L,2119L,2164L,2335L,2395L,2457L,2759L,2885L,2952L,3340L,3627L,3696L,3835L,3909L,3987L,4438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272527Inst : IEnumerable<long>
{
public static readonly long[] Value=A272527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272527.Bytes);
public long this[int i]=>Value[i];

public static A272527Inst Instance=new A272527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272528
{
public static readonly long[] Value={ 1L,3L,8L,20L,28L,44L,48L,92L,188L,228L,236L,324L,332L,428L,668L,716L,756L,908L,1052L,1388L,1436L,1532L,1868L,1916L,2012L,2252L,2348L,2876L,3356L,3452L,3548L,3932L,4076L,4748L,5132L,5228L,5276L,5468L,5756L,5948L,6092L,6476L,7292L,7628L,8108L,8156L,8252L,8396L,8828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272528Inst : IEnumerable<long>
{
public static readonly long[] Value=A272528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272528.Bytes);
public long this[int i]=>Value[i];

public static A272528Inst Instance=new A272528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272529
{
public static readonly long[] Value={ 8L,189L,405L,465L,2187L,2565L,3483L,6885L,41283L,46875L,389691L,796875L,13410657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272529Inst : IEnumerable<long>
{
public static readonly long[] Value=A272529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272529.Bytes);
public long this[int i]=>Value[i];

public static A272529Inst Instance=new A272529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272530
{
public static readonly long[] Value={ 0L,3L,7L,27L,15L,427L,55L,31L,215L,219L,111L,119L,63L,431L,443L,471L,439L,223L,239L,1879L,127L,1719L,863L,1755L,891L,887L,879L,3423L,447L,495L,479L,3451L,3447L,255L,3439L,3503L,1727L,27355L,1967L,1787L,1775L,14167L,1783L,1759L,1911L,1903L,895L,7855L,991L,959L,6907L,6895L,7087L,55983L,511L,7099L,6879L,14043L,7007L,3455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272530Inst : IEnumerable<long>
{
public static readonly long[] Value=A272530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272530.Bytes);
public long this[int i]=>Value[i];

public static A272530Inst Instance=new A272530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272531
{
public static readonly long[] Value={ 1L,1L,8L,7L,3L,0L,9L,3L,4L,9L,5L,7L,6L,4L,0L,8L,4L,3L,0L,1L,7L,6L,6L,6L,8L,8L,4L,1L,1L,5L,5L,3L,3L,8L,6L,2L,3L,1L,2L,5L,7L,8L,6L,6L,6L,9L,9L,6L,2L,5L,4L,8L,8L,7L,8L,3L,9L,5L,9L,6L,0L,8L,7L,8L,7L,8L,9L,3L,3L,9L,3L,1L,2L,6L,6L,5L,9L,0L,2L,9L,0L,1L,1L,6L,2L,5L,1L,7L,7L,7L,9L,0L,3L,2L,3L,6L,9L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272531Inst : IEnumerable<long>
{
public static readonly long[] Value=A272531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272531.Bytes);
public long this[int i]=>Value[i];

public static A272531Inst Instance=new A272531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272532
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272532Inst : IEnumerable<long>
{
public static readonly long[] Value=A272532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272532.Bytes);
public long this[int i]=>Value[i];

public static A272532Inst Instance=new A272532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272533
{
public static readonly long[] Value={ 16L,20L,24L,28L,32L,36L,40L,42L,44L,48L,52L,54L,56L,60L,64L,66L,68L,72L,76L,78L,80L,81L,84L,88L,90L,92L,96L,99L,100L,102L,104L,108L,110L,112L,114L,116L,117L,120L,124L,126L,128L,130L,132L,135L,136L,138L,140L,144L,148L,150L,152L,153L,156L,160L,162L,164L,168L,170L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272533Inst : IEnumerable<long>
{
public static readonly long[] Value=A272533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272533.Bytes);
public long this[int i]=>Value[i];

public static A272533Inst Instance=new A272533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272534
{
public static readonly long[] Value={ 4L,1L,5L,8L,2L,3L,3L,8L,1L,6L,3L,5L,5L,1L,8L,6L,7L,4L,2L,0L,3L,4L,8L,4L,5L,6L,8L,8L,1L,0L,2L,5L,0L,3L,3L,2L,4L,3L,3L,1L,6L,9L,5L,2L,1L,2L,5L,5L,4L,4L,7L,6L,7L,2L,8L,1L,4L,3L,6L,3L,9L,4L,7L,7L,6L,4L,7L,6L,5L,6L,5L,1L,3L,2L,8L,1L,4L,8L,7L,5L,2L,6L,0L,9L,2L,5L,7L,5L,1L,3L,4L,4L,5L,4L,5L,5L,1L,4L,6L,1L,1L,5L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272534Inst : IEnumerable<long>
{
public static readonly long[] Value=A272534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272534.Bytes);
public long this[int i]=>Value[i];

public static A272534Inst Instance=new A272534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272535
{
public static readonly long[] Value={ 3L,9L,0L,1L,8L,0L,6L,4L,4L,0L,3L,2L,2L,5L,6L,5L,3L,5L,6L,9L,6L,5L,6L,9L,7L,3L,6L,9L,5L,4L,0L,4L,4L,4L,8L,1L,8L,5L,5L,3L,8L,3L,2L,3L,5L,5L,0L,3L,9L,0L,9L,6L,1L,5L,5L,0L,9L,0L,0L,4L,1L,7L,8L,9L,8L,9L,5L,2L,6L,6L,3L,7L,5L,7L,1L,8L,4L,9L,1L,6L,0L,4L,5L,0L,6L,5L,0L,6L,1L,8L,4L,6L,8L,1L,8L,0L,7L,6L,3L,4L,6L,1L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272535Inst : IEnumerable<long>
{
public static readonly long[] Value=A272535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272535.Bytes);
public long this[int i]=>Value[i];

public static A272535Inst Instance=new A272535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272536
{
public static readonly long[] Value={ 3L,1L,2L,8L,6L,8L,9L,3L,0L,0L,8L,0L,4L,6L,1L,7L,3L,8L,0L,2L,0L,2L,1L,0L,6L,3L,8L,9L,3L,4L,3L,3L,3L,7L,8L,4L,6L,2L,7L,7L,9L,9L,7L,8L,4L,1L,7L,1L,3L,2L,1L,5L,8L,0L,1L,6L,9L,2L,8L,2L,6L,9L,2L,1L,1L,5L,5L,1L,7L,5L,8L,6L,6L,1L,1L,2L,4L,7L,1L,5L,8L,6L,7L,3L,3L,9L,1L,7L,4L,5L,3L,5L,3L,6L,9L,7L,3L,7L,6L,7L,5L,0L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272536Inst : IEnumerable<long>
{
public static readonly long[] Value=A272536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272536.Bytes);
public long this[int i]=>Value[i];

public static A272536Inst Instance=new A272536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272537
{
public static readonly long[] Value={ 0L,1L,2L,3L,9L,11L,13L,15L,17L,24L,37L,44L,48L,58L,65L,104L,393L,413L,1265L,2292L,2620L,3037L,3628L,5159L,5629L,12809L,18572L,26875L,29695L,32267L,34277L,43621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272537Inst : IEnumerable<long>
{
public static readonly long[] Value=A272537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272537.Bytes);
public long this[int i]=>Value[i];

public static A272537Inst Instance=new A272537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272538
{
public static readonly long[] Value={ 2L,1L,406L,2926L,81810L,521626L,4276350L,1590715126L,266048146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272538Inst : IEnumerable<long>
{
public static readonly long[] Value=A272538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272538.Bytes);
public long this[int i]=>Value[i];

public static A272538Inst Instance=new A272538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272539
{
public static readonly long[] Value={ 1L,5L,13L,32L,41L,76L,77L,164L,137L,240L,173L,428L,249L,520L,317L,800L,405L,892L,525L,1248L,589L,1408L,733L,1824L,837L,2012L,1025L,2484L,1141L,2700L,1329L,3276L,1465L,3512L,1681L,4172L,1825L,4424L,2089L,5164L,2225L,5456L,2525L,6264L,2673L,6592L,2997L,7464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272539Inst : IEnumerable<long>
{
public static readonly long[] Value=A272539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272539.Bytes);
public long this[int i]=>Value[i];

public static A272539Inst Instance=new A272539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272540
{
public static readonly long[] Value={ 1L,5L,32L,164L,800L,3276L,13356L,53784L,215768L,864108L,3458412L,13837464L,55357400L,221444460L,885807468L,3543288984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272540Inst : IEnumerable<long>
{
public static readonly long[] Value=A272540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272540.Bytes);
public long this[int i]=>Value[i];

public static A272540Inst Instance=new A272540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272541
{
public static readonly long[] Value={ 1L,6L,19L,51L,92L,168L,245L,409L,546L,786L,959L,1387L,1636L,2156L,2473L,3273L,3678L,4570L,5095L,6343L,6932L,8340L,9073L,10897L,11734L,13746L,14771L,17255L,18396L,21096L,22425L,25701L,27166L,30678L,32359L,36531L,38356L,42780L,44869L,50033L,52258L,57714L,60239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272541Inst : IEnumerable<long>
{
public static readonly long[] Value=A272541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272541.Bytes);
public long this[int i]=>Value[i];

public static A272541Inst Instance=new A272541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272542
{
public static readonly long[] Value={ 4L,8L,19L,9L,35L,1L,87L,-27L,103L,-67L,255L,-179L,271L,-203L,483L,-395L,487L,-367L,723L,-659L,819L,-675L,1091L,-987L,1175L,-987L,1459L,-1343L,1559L,-1371L,1947L,-1811L,2047L,-1831L,2491L,-2347L,2599L,-2335L,3075L,-2939L,3231L,-2931L,3739L,-3591L,3919L,-3595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272542Inst : IEnumerable<long>
{
public static readonly long[] Value=A272542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272542.Bytes);
public long this[int i]=>Value[i];

public static A272542Inst Instance=new A272542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272543
{
public static readonly long[] Value={ 1L,8L,5L,44L,17L,112L,29L,204L,61L,336L,73L,492L,109L,672L,157L,876L,229L,1136L,241L,1420L,277L,1728L,329L,2044L,429L,2432L,477L,2812L,573L,3264L,633L,3652L,861L,4168L,873L,4708L,909L,5272L,961L,5844L,1061L,6488L,1113L,7108L,1237L,7800L,1353L,8388L,1645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272543Inst : IEnumerable<long>
{
public static readonly long[] Value=A272543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272543.Bytes);
public long this[int i]=>Value[i];

public static A272543Inst Instance=new A272543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272544
{
public static readonly long[] Value={ 1L,8L,44L,204L,876L,3652L,14972L,60588L,243604L,976380L,3907732L,15630108L,62502964L,249929340L,999409492L,3996593628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272544Inst : IEnumerable<long>
{
public static readonly long[] Value=A272544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272544.Bytes);
public long this[int i]=>Value[i];

public static A272544Inst Instance=new A272544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272545
{
public static readonly long[] Value={ 1L,9L,14L,58L,75L,187L,216L,420L,481L,817L,890L,1382L,1491L,2163L,2320L,3196L,3425L,4561L,4802L,6222L,6499L,8227L,8556L,10600L,11029L,13461L,13938L,16750L,17323L,20587L,21220L,24872L,25733L,29901L,30774L,35482L,36391L,41663L,42624L,48468L,49529L,56017L,57130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272545Inst : IEnumerable<long>
{
public static readonly long[] Value=A272545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272545.Bytes);
public long this[int i]=>Value[i];

public static A272545Inst Instance=new A272545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272546
{
public static readonly long[] Value={ 7L,-3L,39L,-27L,95L,-83L,175L,-143L,275L,-263L,419L,-383L,563L,-515L,719L,-647L,907L,-895L,1179L,-1143L,1451L,-1399L,1715L,-1615L,2003L,-1955L,2335L,-2239L,2691L,-2631L,3019L,-2791L,3307L,-3295L,3835L,-3799L,4363L,-4311L,4883L,-4783L,5427L,-5375L,5995L,-5871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272546Inst : IEnumerable<long>
{
public static readonly long[] Value=A272546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272546.Bytes);
public long this[int i]=>Value[i];

public static A272546Inst Instance=new A272546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272547
{
public static readonly long[] Value={ 1L,5L,21L,85L,309L,1245L,4929L,19493L,78013L,311345L,1247009L,4991273L,19979925L,79962153L,319941873L,1280018137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272547Inst : IEnumerable<long>
{
public static readonly long[] Value=A272547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272547.Bytes);
public long this[int i]=>Value[i];

public static A272547Inst Instance=new A272547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272548
{
public static readonly long[] Value={ 1L,6L,14L,35L,59L,96L,148L,233L,317L,414L,538L,667L,827L,1044L,1304L,1613L,1953L,2250L,2646L,2963L,3331L,3792L,4272L,4809L,5393L,5950L,6666L,7371L,8179L,9176L,10288L,11533L,12789L,13894L,15226L,16435L,17755L,19108L,20560L,21961L,23429L,24974L,26602L,28243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272548Inst : IEnumerable<long>
{
public static readonly long[] Value=A272548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272548.Bytes);
public long this[int i]=>Value[i];

public static A272548Inst Instance=new A272548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272549
{
public static readonly long[] Value={ 0L,1L,6L,3L,10L,15L,28L,21L,36L,45L,66L,55L,78L,91L,120L,105L,136L,153L,190L,171L,210L,231L,276L,253L,300L,325L,378L,351L,406L,435L,496L,465L,528L,561L,630L,595L,666L,703L,780L,741L,820L,861L,946L,903L,990L,1035L,1128L,1081L,1176L,1225L,1326L,1275L,1378L,1431L,1540L,1485L,1596L,1653L,1770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272549Inst : IEnumerable<long>
{
public static readonly long[] Value=A272549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272549.Bytes);
public long this[int i]=>Value[i];

public static A272549Inst Instance=new A272549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272550
{
public static readonly long[] Value={ 11L,19L,31L,59L,61L,79L,101L,109L,131L,139L,151L,179L,181L,199L,211L,229L,241L,269L,271L,349L,401L,409L,421L,439L,461L,479L,491L,499L,521L,569L,571L,599L,601L,619L,631L,659L,661L,709L,751L,769L,811L,829L,881L,919L,941L,1009L,1021L,1039L,1051L,1069L,1091L,1109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272550Inst : IEnumerable<long>
{
public static readonly long[] Value=A272550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272550.Bytes);
public long this[int i]=>Value[i];

public static A272550Inst Instance=new A272550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272551
{
public static readonly BigInteger[] Value={ 1L,24L,997L,51264L,2940841L,180296088L,11559133741L,765337680384L,51921457661905L,3590122671128664L,252070718210663749L,17922684123178825536UL,BigInteger.Parse("1287832671004683373753"),BigInteger.Parse("93368940577497932331288"),BigInteger.Parse("6821632357294515590873917"),BigInteger.Parse("501741975445243527381995520"),BigInteger.Parse("37121266623211130111114816929") };
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
public class A272551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272551.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A272551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272551Inst Instance=new A272551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272552
{
public static readonly long[] Value={ 11376L,14562L,15057L,15723L,16659L,20421L,21330L,24867L,28494L,28746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272552Inst : IEnumerable<long>
{
public static readonly long[] Value=A272552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272552.Bytes);
public long this[int i]=>Value[i];

public static A272552Inst Instance=new A272552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272553
{
public static readonly long[] Value={ 20L,464L,650L,2744L,3980L,5504L,5736L,5922L,7032L,8130L,10472L,18618L,24312L,27654L,38874L,39500L,43032L,45492L,56870L,64410L,71058L,79068L,85158L,89178L,92130L,97014L,109928L,117114L,118902L,127688L,130304L,175554L,180438L,187304L,188292L,208452L,224058L,244674L,249788L,269192L,294380L,305624L,347964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272553Inst : IEnumerable<long>
{
public static readonly long[] Value=A272553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272553.Bytes);
public long this[int i]=>Value[i];

public static A272553Inst Instance=new A272553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272554
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,57L,61L,62L,63L,64L,65L,66L,68L,69L,70L,73L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272554Inst : IEnumerable<long>
{
public static readonly long[] Value=A272554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272554.Bytes);
public long this[int i]=>Value[i];

public static A272554Inst Instance=new A272554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272555
{
public static readonly long[] Value={ 965201L,653687L,429409L,272563L,166693L,98321L,56597L,32969L,20873L,15443L,13241L,12007L,10429L,7933L,4493L,461L,3583L,6961L,9007L,9157L,7019L,2423L,4549L,13553L,23993L,35051L,45737L,54959L,61613L,64693L,63421L,57397L,46769L,32423L,16193L,1091L,8443L,6271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272555Inst : IEnumerable<long>
{
public static readonly long[] Value=A272555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272555.Bytes);
public long this[int i]=>Value[i];

public static A272555Inst Instance=new A272555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272556
{
public static readonly long[] Value={ 1L,4L,13L,36L,37L,88L,85L,156L,109L,268L,181L,380L,237L,564L,365L,740L,317L,1028L,393L,1360L,393L,1500L,781L,1600L,861L,2060L,993L,2416L,1101L,2800L,1469L,3040L,1441L,3832L,1345L,4388L,1517L,4740L,1881L,5076L,2037L,5692L,2297L,6252L,2633L,6704L,2909L,7576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272556Inst : IEnumerable<long>
{
public static readonly long[] Value=A272556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272556.Bytes);
public long this[int i]=>Value[i];

public static A272556Inst Instance=new A272556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272557
{
public static readonly long[] Value={ 1L,4L,36L,156L,740L,3040L,12852L,52648L,214820L,865744L,3487180L,13994100L,56047356L,224295004L,897465820L,3590094664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272557Inst : IEnumerable<long>
{
public static readonly long[] Value=A272557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272557.Bytes);
public long this[int i]=>Value[i];

public static A272557Inst Instance=new A272557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272558
{
public static readonly long[] Value={ 1L,5L,18L,54L,91L,179L,264L,420L,529L,797L,978L,1358L,1595L,2159L,2524L,3264L,3581L,4609L,5002L,6362L,6755L,8255L,9036L,10636L,11497L,13557L,14550L,16966L,18067L,20867L,22336L,25376L,26817L,30649L,31994L,36382L,37899L,42639L,44520L,49596L,51633L,57325L,59622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272558Inst : IEnumerable<long>
{
public static readonly long[] Value=A272558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272558.Bytes);
public long this[int i]=>Value[i];

public static A272558Inst Instance=new A272558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272559
{
public static readonly long[] Value={ 3L,9L,23L,1L,51L,-3L,71L,-47L,159L,-87L,199L,-143L,327L,-199L,375L,-423L,711L,-635L,967L,-967L,1107L,-719L,819L,-739L,1199L,-1067L,1423L,-1315L,1699L,-1331L,1571L,-1599L,2391L,-2487L,3043L,-2871L,3223L,-2859L,3195L,-3039L,3655L,-3395L,3955L,-3619L,4071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272559Inst : IEnumerable<long>
{
public static readonly long[] Value=A272559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272559.Bytes);
public long this[int i]=>Value[i];

public static A272559Inst Instance=new A272559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272560
{
public static readonly long[] Value={ 1L,5L,13L,36L,37L,88L,85L,156L,109L,268L,181L,380L,237L,564L,365L,740L,317L,1028L,393L,1360L,393L,1500L,781L,1600L,861L,2060L,993L,2420L,1081L,2824L,1481L,3024L,1449L,3816L,1325L,4440L,1513L,4692L,1881L,5052L,2117L,5648L,2273L,6284L,2621L,6620L,3041L,7484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272560Inst : IEnumerable<long>
{
public static readonly long[] Value=A272560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272560.Bytes);
public long this[int i]=>Value[i];

public static A272560Inst Instance=new A272560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272561
{
public static readonly long[] Value={ 1L,5L,36L,156L,740L,3024L,12656L,53552L,216197L,866044L,3487225L,13994416L,56043560L,224257009L,897119561L,3589343753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272561Inst : IEnumerable<long>
{
public static readonly long[] Value=A272561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272561.Bytes);
public long this[int i]=>Value[i];

public static A272561Inst Instance=new A272561Inst();

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