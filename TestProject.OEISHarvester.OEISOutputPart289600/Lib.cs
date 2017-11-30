using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A274443
{
public static readonly long[] Value={ 561L,21L,85L,15L,21L,35L,33L,21L,65L,91L,57L,91L,133L,55L,161L,91L,57L,133L,33L,253L,65L,91L,145L,115L,217L,451L,161L,703L,253L,551L,561L,253L,481L,217L,129L,451L,301L,1081L,161L,1189L,145L,989L,217L,235L,481L,703L,649L,329L,265L,1081L,1121L,1219L,145L,1037L,721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274443Inst : IEnumerable<long>
{
public static readonly long[] Value=A274443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274443.Bytes);
public long this[int i]=>Value[i];

public static A274443Inst Instance=new A274443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274444
{
public static readonly long[] Value={ 15L,65L,35L,15L,21L,35L,15L,35L,35L,77L,35L,55L,55L,143L,119L,51L,95L,155L,55L,323L,95L,119L,39L,391L,87L,209L,119L,299L,143L,341L,319L,629L,259L,899L,407L,185L,119L,299L,287L,1517L,203L,799L,159L,155L,407L,1189L,119L,517L,341L,1763L,1363L,629L,335L,2491L,493L,3599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274444Inst : IEnumerable<long>
{
public static readonly long[] Value=A274444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274444.Bytes);
public long this[int i]=>Value[i];

public static A274444Inst Instance=new A274444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274445
{
public static readonly long[] Value={ 385L,91L,65L,451L,33L,170171L,145L,1261L,161L,78409L,469L,294061L,649L,13051L,1921L,5251L,721L,8453501L,145L,300243L,1121L,47611L,3601L,1915801L,1057L,41311L,545L,5671L,1261L,19723133L,4321L,37759L,6913L,451L,4033L,102821L,1513L,40891L,11521L,1259497L,721L,364781L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274445Inst : IEnumerable<long>
{
public static readonly long[] Value=A274445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274445.Bytes);
public long this[int i]=>Value[i];

public static A274445Inst Instance=new A274445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274446
{
public static readonly long[] Value={ 399L,299L,55L,611L,143L,5549L,39L,155L,493L,615383L,713L,3247L,119L,1304489L,1333L,31415L,2599L,749L,2183L,440153L,155L,75499L,119L,168600949L,4223L,223649L,559L,66299L,6407L,15157L,3431L,85499L,799L,31589L,7313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274446Inst : IEnumerable<long>
{
public static readonly long[] Value=A274446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274446.Bytes);
public long this[int i]=>Value[i];

public static A274446Inst Instance=new A274446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274447
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-1L,-1L,13L,-47L,-73L,2447L,-16811L,-15551L,1726511L,-18994849L,10979677L,2983409137L,-48421103257L,135002366063L,778870772857L,-232033147779359L,1305952009204319L,58740282660173759L,-1862057132555380307L,16905219421196907793UL,BigInteger.Parse("527257187244811805207") };
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
public class A274447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274447Inst Instance=new A274447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274448
{
public static readonly BigInteger[] Value={ 1L,2L,16L,192L,3072L,61440L,1474560L,41287680L,1321205760L,47563407360L,1902536294400L,83711596953600L,4018156653772800L,208944145996185600L,11700872175786393600UL,BigInteger.Parse("702052330547183616000"),BigInteger.Parse("44931349155019751424000"),BigInteger.Parse("235025518657026392064000"),BigInteger.Parse("219983885462976702971904000"),BigInteger.Parse("16718775295186229425864704000"),BigInteger.Parse("1337502023614898354069176320000") };
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
public class A274448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274448Inst Instance=new A274448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274449
{
public static readonly long[] Value={ 2L,2L,8L,4L,32L,2L,128L,16L,176L,32L,2048L,4L,8192L,128L,2348L,256L,131072L,8L,524288L,424L,47824L,2048L,8388608L,16L,9389312L,8192L,785408L,11680L,536870912L,2L,2147483648L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274449Inst : IEnumerable<long>
{
public static readonly long[] Value=A274449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274449.Bytes);
public long this[int i]=>Value[i];

public static A274449Inst Instance=new A274449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274450
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,3L,2L,2L,1L,4L,1L,2L,3L,3L,1L,4L,1L,4L,3L,2L,1L,6L,2L,2L,2L,4L,1L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274450Inst : IEnumerable<long>
{
public static readonly long[] Value=A274450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274450.Bytes);
public long this[int i]=>Value[i];

public static A274450Inst Instance=new A274450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274451
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,1L,3L,2L,2L,1L,6L,1L,2L,4L,3L,1L,5L,1L,6L,4L,2L,1L,11L,2L,2L,2L,6L,1L,10L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274451Inst : IEnumerable<long>
{
public static readonly long[] Value=A274451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274451.Bytes);
public long this[int i]=>Value[i];

public static A274451Inst Instance=new A274451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274484
{
public static readonly BigInteger[] Value={ 1L,2L,6L,20L,71L,262L,994L,3852L,15183L,60686L,245410L,1002300L,4128448L,17129920L,71529800L,300355184L,1267386163L,5371101382L,22850230642L,97546995260L,417717017392L,1793765580704L,7722405668232L,33323153856880L,144099312039391L,624347587536782L,2710036186345914L,11782865084403212L,51310167663855675L,223762749750806942L,977155903597684074L,4272633455348970588L,BigInteger.Parse("18704696346822470087"),BigInteger.Parse("81978422471165944654") };
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
public class A274484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274484Inst Instance=new A274484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274485
{
public static readonly BigInteger[] Value={ 2L,50L,3925L,50881L,625000000L,117650L,1562500000000L,815737282L,3906250000000000L,25937425625L,9765625000000000000UL,23298085126577L,BigInteger.Parse("24414062500000000000000"),BigInteger.Parse("7862651120078217664621465531250"),BigInteger.Parse("61035156250000000000000000"),10000000000000001L,BigInteger.Parse("152587890625000000000000000000") };
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
public class A274485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274485Inst Instance=new A274485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274486
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,8L,1L,5L,20L,10L,6L,40L,45L,6L,7L,70L,140L,56L,2L,8L,112L,350L,280L,44L,9L,168L,756L,1008L,366L,20L,10L,240L,1470L,2940L,1920L,320L,5L,11L,330L,2640L,7392L,7590L,2552L,190L,12L,440L,4455L,16632L,24684L,13904L,2445L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274486Inst : IEnumerable<long>
{
public static readonly long[] Value=A274486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274486.Bytes);
public long this[int i]=>Value[i];

public static A274486Inst Instance=new A274486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274487
{
public static readonly long[] Value={ 1L,3L,3L,3L,11L,3L,11L,35L,171L,35L,235L,867L,3115L,5283L,9835L,21091L,39723L,117155L,27755L,66659L,69931L,1315235L,380011L,1244259L,5245227L,17871267L,22029419L,88654947L,56627499L,86774179L,697945195L,1556544611L,2252343595L,6761263523L,4719125611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274487Inst : IEnumerable<long>
{
public static readonly long[] Value=A274487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274487.Bytes);
public long this[int i]=>Value[i];

public static A274487Inst Instance=new A274487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274488
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,8L,3L,1L,1L,22L,8L,3L,1L,1L,62L,22L,8L,3L,1L,1L,178L,62L,22L,8L,3L,1L,1L,519L,178L,62L,22L,8L,3L,1L,1L,1533L,519L,178L,62L,22L,8L,3L,1L,1L,4578L,1533L,519L,178L,62L,22L,8L,3L,1L,1L,13800L,4578L,1533L,519L,178L,62L,22L,8L,3L,1L,1L,41937L,13800L,4578L,1533L,519L,178L,62L,22L,8L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274488Inst : IEnumerable<long>
{
public static readonly long[] Value=A274488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274488.Bytes);
public long this[int i]=>Value[i];

public static A274488Inst Instance=new A274488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274489
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,5L,11L,23L,50L,110L,247L,565L,1308L,3067L,7264L,17355L,41790L,101327L,247205L,606456L,1495255L,3703422L,9210589L,22994029L,57603919L,144770421L,364916488L,922357821L,2337297441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274489Inst : IEnumerable<long>
{
public static readonly long[] Value=A274489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274489.Bytes);
public long this[int i]=>Value[i];

public static A274489Inst Instance=new A274489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274490
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,3L,1L,0L,1L,8L,3L,1L,0L,1L,22L,8L,3L,1L,0L,1L,62L,22L,8L,3L,1L,0L,1L,178L,62L,22L,8L,3L,1L,0L,1L,519L,178L,62L,22L,8L,3L,1L,0L,1L,1533L,519L,178L,62L,22L,8L,3L,1L,0L,1L,4578L,1533L,519L,178L,62L,22L,8L,3L,1L,0L,1L,13800L,4578L,1533L,519L,178L,62L,22L,8L,3L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274490Inst : IEnumerable<long>
{
public static readonly long[] Value=A274490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274490.Bytes);
public long this[int i]=>Value[i];

public static A274490Inst Instance=new A274490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274491
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,3L,5L,4L,1L,6L,13L,9L,7L,13L,28L,32L,18L,6L,27L,68L,88L,58L,32L,2L,57L,166L,228L,207L,102L,34L,123L,394L,623L,621L,380L,166L,20L,267L,943L,1668L,1812L,1380L,630L,200L,5L,584L,2269L,4366L,5348L,4476L,2540L,967L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274491Inst : IEnumerable<long>
{
public static readonly long[] Value=A274491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274491.Bytes);
public long this[int i]=>Value[i];

public static A274491Inst Instance=new A274491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274492
{
public static readonly long[] Value={ 1L,1L,5L,16L,52L,170L,556L,1821L,5973L,19620L,64536L,212553L,700903L,2313864L,7646670L,25294673L,83748689L,277518319L,920332567L,3054319120L,10143305864L,33707066667L,112078220233L,372875904038L,1241182355688L,4133534991928L,13772413826888L,45908128269573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274492Inst : IEnumerable<long>
{
public static readonly long[] Value=A274492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274492.Bytes);
public long this[int i]=>Value[i];

public static A274492Inst Instance=new A274492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274493
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,13L,27L,57L,123L,267L,584L,1289L,2864L,6399L,14373L,32435L,73498L,167175L,381551L,873541L,2005622L,4616895L,10653607L,24638263L,57097885L,132575577L,308378460L,718506295L,1676706422L,3918515001L,9170350093L,21488961641L,50417138776L,118425429213L,278476687643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274493Inst : IEnumerable<long>
{
public static readonly long[] Value=A274493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274493.Bytes);
public long this[int i]=>Value[i];

public static A274493Inst Instance=new A274493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274494
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,0L,1L,8L,2L,1L,2L,22L,5L,4L,3L,0L,1L,62L,13L,12L,6L,1L,3L,178L,35L,35L,15L,5L,6L,0L,1L,519L,97L,103L,40L,17L,13L,1L,4L,1533L,275L,306L,110L,53L,33L,6L,10L,0L,1L,4578L,794L,917L,310L,163L,90L,23L,24L,1L,5L,13800L,2327L,2770L,891L,501L,253L,77L,63L,7L,15L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274494Inst : IEnumerable<long>
{
public static readonly long[] Value=A274494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274494.Bytes);
public long this[int i]=>Value[i];

public static A274494Inst Instance=new A274494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274495
{
public static readonly long[] Value={ 2L,3L,9L,23L,62L,171L,482L,1384L,4036L,11924L,35619L,107407L,326521L,999675L,3079634L,9539366L,29693294L,92831327L,291366477L,917765199L,2900217452L,9192097510L,29213057684L,93073003438L,297215560553L,951144390092L,3049877146281L,9797605279905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274495Inst : IEnumerable<long>
{
public static readonly long[] Value=A274495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274495.Bytes);
public long this[int i]=>Value[i];

public static A274495Inst Instance=new A274495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274496
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,4L,4L,8L,4L,8L,16L,8L,8L,24L,24L,8L,16L,48L,48L,16L,16L,64L,96L,64L,16L,32L,128L,192L,128L,32L,32L,160L,320L,320L,160L,32L,64L,320L,640L,640L,320L,64L,64L,384L,960L,1280L,960L,384L,64L,128L,768L,1920L,2560L,1920L,768L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274496Inst : IEnumerable<long>
{
public static readonly long[] Value=A274496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274496.Bytes);
public long this[int i]=>Value[i];

public static A274496Inst Instance=new A274496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274497
{
public static readonly long[] Value={ 0L,0L,2L,4L,16L,32L,96L,192L,512L,1024L,2560L,5120L,12288L,24576L,57344L,114688L,262144L,524288L,1179648L,2359296L,5242880L,10485760L,23068672L,46137344L,100663296L,201326592L,436207616L,872415232L,1879048192L,3758096384L,8053063680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274497Inst : IEnumerable<long>
{
public static readonly long[] Value=A274497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274497.Bytes);
public long this[int i]=>Value[i];

public static A274497Inst Instance=new A274497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274498
{
public static readonly long[] Value={ 1L,3L,3L,6L,9L,18L,9L,36L,36L,27L,108L,108L,27L,162L,324L,216L,81L,486L,972L,648L,81L,648L,1944L,2592L,1296L,243L,1944L,5832L,7776L,3888L,243L,2430L,9720L,19440L,19440L,7776L,729L,7290L,29160L,58320L,58320L,23328L,729L,8748L,43740L,116640L,174960L,139968L,46656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274498Inst : IEnumerable<long>
{
public static readonly long[] Value=A274498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274498.Bytes);
public long this[int i]=>Value[i];

public static A274498Inst Instance=new A274498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274499
{
public static readonly long[] Value={ 0L,0L,6L,18L,108L,324L,1458L,4374L,17496L,52488L,196830L,590490L,2125764L,6377292L,22320522L,66961566L,229582512L,688747536L,2324522934L,6973568802L,23245229340L,69735688020L,230127770466L,690383311398L,2259436291848L,6778308875544L,22029503845518L,66088511536554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274499Inst : IEnumerable<long>
{
public static readonly long[] Value=A274499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274499.Bytes);
public long this[int i]=>Value[i];

public static A274499Inst Instance=new A274499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274532
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,1L,3L,7L,1L,9L,1L,3L,4L,13L,1L,13L,1L,3L,7L,15L,1L,5L,19L,1L,3L,10L,17L,1L,21L,1L,3L,4L,5L,11L,28L,1L,25L,1L,3L,16L,25L,1L,5L,7L,41L,1L,3L,7L,15L,31L,1L,33L,1L,3L,4L,13L,14L,47L,1L,37L,1L,3L,7L,7L,25L,39L,1L,5L,13L,53L,1L,3L,28L,41L,1L,45L,1L,3L,4L,5L,11L,12L,22L,61L,1L,9L,61L,1L,3L,34L,49L,1L,5L,19L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274532Inst : IEnumerable<long>
{
public static readonly long[] Value=A274532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274532.Bytes);
public long this[int i]=>Value[i];

public static A274532Inst Instance=new A274532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274533
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,4L,5L,5L,4L,5L,6L,6L,7L,7L,4L,6L,8L,8L,7L,9L,9L,4L,7L,10L,10L,11L,11L,4L,6L,8L,10L,12L,12L,13L,13L,8L,9L,14L,14L,11L,13L,15L,15L,5L,8L,12L,16L,16L,17L,17L,8L,11L,12L,15L,18L,18L,19L,19L,7L,10L,10L,15L,20L,20L,13L,17L,21L,21L,16L,13L,22L,22L,23L,23L,6L,7L,10L,12L,16L,20L,24L,24L,21L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274533Inst : IEnumerable<long>
{
public static readonly long[] Value=A274533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274533.Bytes);
public long this[int i]=>Value[i];

public static A274533Inst Instance=new A274533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274534
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,2L,1L,1L,3L,3L,2L,3L,2L,2L,3L,4L,3L,3L,3L,3L,1L,1L,4L,4L,4L,3L,4L,3L,2L,2L,1L,1L,5L,4L,4L,4L,5L,4L,3L,3L,2L,1L,1L,5L,5L,4L,5L,6L,5L,4L,4L,3L,1L,1L,1L,1L,5L,5L,5L,6L,7L,6L,5L,5L,4L,2L,2L,1L,1L,1L,5L,5L,6L,6L,7L,7L,6L,6L,5L,3L,3L,2L,1L,2L,1L,1L,5L,5L,6L,7L,7L,7L,7L,6L,6L,4L,4L,3L,2L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274534Inst : IEnumerable<long>
{
public static readonly long[] Value=A274534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274534.Bytes);
public long this[int i]=>Value[i];

public static A274534Inst Instance=new A274534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274535
{
public static readonly long[] Value={ 5L,15L,20L,35L,30L,60L,40L,75L,65L,90L,60L,140L,70L,120L,120L,155L,90L,195L,100L,210L,160L,180L,120L,300L,155L,210L,200L,280L,150L,360L,160L,315L,240L,270L,240L,455L,190L,300L,280L,450L,210L,480L,220L,420L,390L,360L,240L,620L,285L,465L,360L,490L,270L,600L,360L,600L,400L,450L,300L,840L,310L,480L,520L,635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274535Inst : IEnumerable<long>
{
public static readonly long[] Value=A274535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274535.Bytes);
public long this[int i]=>Value[i];

public static A274535Inst Instance=new A274535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274536
{
public static readonly long[] Value={ 6L,18L,24L,42L,36L,72L,48L,90L,78L,108L,72L,168L,84L,144L,144L,186L,108L,234L,120L,252L,192L,216L,144L,360L,186L,252L,240L,336L,180L,432L,192L,378L,288L,324L,288L,546L,228L,360L,336L,540L,252L,576L,264L,504L,468L,432L,288L,744L,342L,558L,432L,588L,324L,720L,432L,720L,480L,540L,360L,1008L,372L,576L,624L,762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274536Inst : IEnumerable<long>
{
public static readonly long[] Value=A274536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274536.Bytes);
public long this[int i]=>Value[i];

public static A274536Inst Instance=new A274536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274537
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,3L,2L,1L,0L,0L,1L,3L,7L,2L,1L,0L,0L,1L,7L,14L,13L,3L,1L,0L,0L,1L,7L,35L,26L,22L,3L,1L,0L,0L,1L,15L,70L,113L,66L,34L,4L,1L,0L,0L,1L,15L,155L,226L,311L,102L,50L,4L,1L,0L,0L,1L,31L,310L,833L,933L,719L,200L,70L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274537Inst : IEnumerable<long>
{
public static readonly long[] Value=A274537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274537.Bytes);
public long this[int i]=>Value[i];

public static A274537Inst Instance=new A274537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274538
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,7L,14L,39L,95L,304L,865L,3103L,10038L,39773L,143473L,620382L,2461099L,11504723L,49658054L,249102263L,1159930119L,6205900348L,30959905841L,175763987955L,934068692102L,5602484594053L,31563436487785L,199267671153562L,1185224170637619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274538Inst : IEnumerable<long>
{
public static readonly long[] Value=A274538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274538.Bytes);
public long this[int i]=>Value[i];

public static A274538Inst Instance=new A274538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274539
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,155L,2079L,38629L,951187L,29979753L,1175837345L,56066617331L,3187704802281L,212628685506643L,16413606252207007L,1449425836362499605L,BigInteger.Parse("144977415195565990619"),BigInteger.Parse("16285937949513614300369"),BigInteger.Parse("2039447464767566886933057"),BigInteger.Parse("282862729890000953318773603") };
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
public class A274539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274539Inst Instance=new A274539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274540
{
public static readonly long[] Value={ 4L,1L,1L,3L,2L,5L,0L,3L,7L,8L,7L,8L,2L,9L,2L,7L,5L,1L,7L,1L,7L,3L,5L,8L,1L,8L,1L,5L,1L,4L,0L,3L,0L,4L,5L,0L,2L,4L,0L,1L,6L,6L,3L,9L,4L,3L,1L,5L,1L,1L,0L,9L,6L,1L,0L,0L,6L,8L,3L,6L,4L,7L,0L,9L,8L,5L,1L,5L,0L,9L,7L,8L,5L,8L,3L,0L,8L,0L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274540Inst : IEnumerable<long>
{
public static readonly long[] Value=A274540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274540.Bytes);
public long this[int i]=>Value[i];

public static A274540Inst Instance=new A274540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274541
{
public static readonly long[] Value={ 2L,0L,2L,8L,1L,1L,4L,9L,8L,1L,6L,4L,7L,4L,7L,2L,4L,5L,1L,1L,0L,8L,1L,2L,6L,1L,1L,2L,7L,4L,6L,3L,5L,1L,1L,7L,5L,1L,7L,4L,3L,2L,5L,0L,9L,2L,5L,4L,2L,6L,1L,3L,5L,2L,0L,6L,1L,7L,7L,7L,5L,9L,7L,2L,1L,2L,2L,2L,1L,5L,3L,9L,5L,0L,4L,8L,7L,1L,6L,5L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274541Inst : IEnumerable<long>
{
public static readonly long[] Value=A274541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274541.Bytes);
public long this[int i]=>Value[i];

public static A274541Inst Instance=new A274541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274542
{
public static readonly long[] Value={ 1L,6L,0L,2L,2L,4L,2L,9L,9L,7L,2L,0L,3L,5L,6L,0L,1L,5L,0L,9L,9L,5L,1L,7L,7L,7L,7L,2L,2L,2L,8L,6L,7L,8L,7L,5L,8L,5L,1L,2L,9L,6L,1L,6L,8L,2L,9L,5L,4L,5L,4L,7L,1L,8L,7L,4L,2L,6L,8L,2L,2L,4L,0L,5L,3L,0L,9L,1L,0L,0L,1L,6L,9L,9L,4L,9L,0L,4L,1L,9L,1L,9L,5L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274542Inst : IEnumerable<long>
{
public static readonly long[] Value=A274542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274542.Bytes);
public long this[int i]=>Value[i];

public static A274542Inst Instance=new A274542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274543
{
public static readonly long[] Value={ 1L,2L,9L,24L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274543Inst : IEnumerable<long>
{
public static readonly long[] Value=A274543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274543.Bytes);
public long this[int i]=>Value[i];

public static A274543Inst Instance=new A274543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274544
{
public static readonly BigInteger[] Value={ 1L,13L,925L,18241L,1333345L,26303005L,1922682061L,37928914465L,2772506198113L,54693468355021L,3997952014996381L,78867943439025313L,5765044033118582785L,BigInteger.Parse("113727519745606145821"),BigInteger.Parse("8313189497804981379085"),BigInteger.Parse("163995004605220623248065"),BigInteger.Parse("11987613490790750030057281") };
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
public class A274544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274544Inst Instance=new A274544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274545
{
public static readonly BigInteger[] Value={ 1L,29L,33293L,1130977L,1305146305L,44336554445L,51164345409437L,1738081606216033L,2005744667435597089L,BigInteger.Parse("68136275082544365341"),BigInteger.Parse("78629202401645931667661"),BigInteger.Parse("2671078254047822603875969"),BigInteger.Parse("3082421990543579145800043553"),BigInteger.Parse("104711609647046466634601365517") };
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
public class A274545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274545Inst Instance=new A274545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274546
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,11L,13L,14L,17L,19L,21L,22L,23L,26L,29L,31L,33L,34L,37L,38L,39L,41L,42L,43L,46L,47L,51L,53L,57L,58L,59L,61L,62L,66L,67L,69L,71L,73L,74L,77L,78L,79L,82L,83L,86L,87L,89L,91L,93L,94L,97L,101L,102L,103L,106L,107L,109L,111L,113L,114L,118L,119L,122L,123L,127L,129L,131L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274546Inst : IEnumerable<long>
{
public static readonly long[] Value=A274546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274546.Bytes);
public long this[int i]=>Value[i];

public static A274546Inst Instance=new A274546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274547
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,18L,40L,101L,254L,723L,2064L,6586L,21143L,74752L,266078L,1029983L,4013425L,16843526L,71136112L,321150717L,1458636308L,7038678613L,34161890155L,175261038904L,904125989974L,4909033438008L,26795600521492L,153376337926066L,882391616100249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274547Inst : IEnumerable<long>
{
public static readonly long[] Value=A274547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274547.Bytes);
public long this[int i]=>Value[i];

public static A274547Inst Instance=new A274547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274612
{
public static readonly long[] Value={ 101L,102L,103L,104L,105L,106L,107L,108L,109L,201L,202L,203L,204L,205L,206L,207L,208L,209L,301L,302L,303L,304L,305L,306L,307L,308L,309L,401L,402L,403L,404L,405L,406L,407L,408L,409L,501L,502L,503L,504L,505L,506L,507L,508L,509L,601L,602L,603L,604L,605L,606L,607L,608L,609L,701L,702L,703L,704L,705L,706L,707L,708L,709L,801L,802L,803L,804L,805L,806L,807L,808L,809L,901L,902L,903L,904L,905L,906L,907L,908L,909L,1011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274612Inst : IEnumerable<long>
{
public static readonly long[] Value=A274612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274612.Bytes);
public long this[int i]=>Value[i];

public static A274612Inst Instance=new A274612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274613
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,5L,1L,1L,5L,3L,1L,1L,5L,15L,7L,1L,5L,5L,21L,1L,1L,1L,15L,35L,7L,9L,1L,3L,35L,7L,9L,5L,1L,1L,21L,35L,21L,45L,11L,1L,7L,7L,63L,15L,55L,3L,1L,1L,7L,63L,105L,165L,33L,13L,1L,1L,21L,63L,165L,55L,39L,7L,1L,1L,9L,105L,231L,495L,143L,91L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274613Inst : IEnumerable<long>
{
public static readonly long[] Value=A274613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274613.Bytes);
public long this[int i]=>Value[i];

public static A274613Inst Instance=new A274613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274614
{
public static readonly long[] Value={ 2L,5L,6L,3L,1L,9L,4L,7L,8L,13L,14L,11L,12L,10L,18L,15L,16L,21L,22L,19L,17L,25L,20L,23L,24L,29L,30L,27L,28L,26L,34L,31L,32L,37L,38L,35L,33L,41L,36L,39L,40L,45L,46L,43L,44L,42L,50L,47L,48L,53L,54L,51L,49L,57L,52L,55L,56L,61L,62L,59L,60L,58L,66L,63L,64L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274614Inst : IEnumerable<long>
{
public static readonly long[] Value=A274614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274614.Bytes);
public long this[int i]=>Value[i];

public static A274614Inst Instance=new A274614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274615
{
public static readonly long[] Value={ 1L,4L,5L,2L,0L,8L,3L,6L,7L,12L,13L,10L,11L,9L,17L,14L,15L,20L,21L,18L,16L,24L,19L,22L,23L,28L,29L,26L,27L,25L,33L,30L,31L,36L,37L,34L,32L,40L,35L,38L,39L,44L,45L,42L,43L,41L,49L,46L,47L,52L,53L,50L,48L,56L,51L,54L,55L,60L,61L,58L,59L,57L,65L,62L,63L,68L,69L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274615Inst : IEnumerable<long>
{
public static readonly long[] Value=A274615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274615.Bytes);
public long this[int i]=>Value[i];

public static A274615Inst Instance=new A274615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274616
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,41L,42L,43L,43L,44L,45L,45L,46L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274616Inst : IEnumerable<long>
{
public static readonly long[] Value=A274616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274616.Bytes);
public long this[int i]=>Value[i];

public static A274616Inst Instance=new A274616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274617
{
public static readonly long[] Value={ 6L,1L,2L,5L,4L,7L,3L,9L,10L,11L,12L,8L,14L,13L,16L,17L,18L,19L,15L,21L,20L,23L,22L,25L,26L,27L,28L,24L,30L,29L,32L,33L,34L,35L,31L,37L,36L,39L,38L,41L,42L,43L,44L,40L,46L,45L,48L,49L,50L,51L,47L,53L,52L,55L,54L,57L,58L,59L,60L,56L,62L,61L,64L,65L,66L,67L,63L,69L,68L,71L,70L,73L,74L,75L,76L,72L,78L,77L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274617Inst : IEnumerable<long>
{
public static readonly long[] Value=A274617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274617.Bytes);
public long this[int i]=>Value[i];

public static A274617Inst Instance=new A274617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274618
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,3L,3L,2L,2L,8L,8L,9L,9L,7L,7L,6L,6L,5L,5L,4L,4L,3L,3L,2L,2L,8L,8L,9L,9L,4L,4L,5L,5L,12L,12L,13L,13L,9L,9L,8L,8L,2L,2L,3L,3L,4L,4L,5L,5L,15L,15L,14L,14L,3L,3L,2L,2L,8L,8L,9L,9L,7L,7L,6L,6L,5L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274618Inst : IEnumerable<long>
{
public static readonly long[] Value=A274618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274618.Bytes);
public long this[int i]=>Value[i];

public static A274618Inst Instance=new A274618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274619
{
public static readonly long[] Value={ 5L,0L,1L,4L,3L,6L,2L,8L,9L,10L,11L,7L,13L,12L,15L,16L,17L,18L,14L,20L,19L,22L,21L,24L,25L,26L,27L,23L,29L,28L,31L,32L,33L,34L,30L,36L,35L,38L,37L,40L,41L,42L,43L,39L,45L,44L,47L,48L,49L,50L,46L,52L,51L,54L,53L,56L,57L,58L,59L,55L,61L,60L,63L,64L,65L,66L,62L,68L,67L,70L,69L,72L,73L,74L,75L,71L,77L,76L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274619Inst : IEnumerable<long>
{
public static readonly long[] Value=A274619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274619.Bytes);
public long this[int i]=>Value[i];

public static A274619Inst Instance=new A274619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274620
{
public static readonly long[] Value={ 11L,24L,39L,146L,255L,366L,479L,684L,891L,11000L,11121L,11244L,11369L,11496L,21525L,21656L,21789L,31824L,31961L,42000L,42141L,42284L,52329L,52476L,62525L,62676L,72729L,72884L,82941L,93000L,93161L,103224L,103389L,113456L,123525L,123696L,133769L,143844L,153921L,164000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274620Inst : IEnumerable<long>
{
public static readonly long[] Value=A274620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274620.Bytes);
public long this[int i]=>Value[i];

public static A274620Inst Instance=new A274620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274621
{
public static readonly long[] Value={ 1L,-2L,3L,-6L,11L,-18L,28L,-44L,69L,-104L,152L,-222L,323L,-460L,645L,-902L,1254L,-1722L,2343L,-3174L,4278L,-5722L,7601L,-10056L,13250L,-17358L,22623L,-29382L,38021L,-48984L,62857L,-80404L,102528L,-130282L,165002L,-208398L,262495L,-329666L,412878L,-515840L,642941L,-799362L,991478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274621Inst : IEnumerable<long>
{
public static readonly long[] Value=A274621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274621.Bytes);
public long this[int i]=>Value[i];

public static A274621Inst Instance=new A274621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274622
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,4L,4L,1L,2L,8L,8L,2L,4L,14L,14L,4L,8L,24L,24L,8L,1L,14L,40L,40L,14L,1L,2L,24L,64L,64L,24L,2L,4L,40L,100L,100L,40L,4L,8L,64L,154L,154L,64L,8L,14L,100L,232L,232L,100L,14L,24L,154L,344L,344L,154L,24L,1L,40L,232L,504L,504L,232L,40L,1L,2L,64L,344L,728L,728L,344L,64L,2L,4L,100L,504L,1040L,1040L,504L,100L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274622Inst : IEnumerable<long>
{
public static readonly long[] Value=A274622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274622.Bytes);
public long this[int i]=>Value[i];

public static A274622Inst Instance=new A274622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274623
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,8L,4L,14L,8L,24L,1L,14L,40L,2L,24L,64L,4L,40L,100L,8L,64L,154L,14L,100L,232L,24L,154L,344L,1L,40L,232L,504L,2L,64L,344L,728L,4L,100L,504L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274623Inst : IEnumerable<long>
{
public static readonly long[] Value=A274623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274623.Bytes);
public long this[int i]=>Value[i];

public static A274623Inst Instance=new A274623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274624
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,2L,4L,8L,4L,1L,8L,14L,8L,1L,2L,14L,24L,14L,2L,4L,24L,40L,24L,4L,8L,40L,64L,40L,8L,14L,64L,100L,64L,14L,1L,24L,100L,154L,100L,24L,1L,2L,40L,154L,232L,154L,40L,2L,4L,64L,232L,344L,232L,64L,4L,8L,100L,344L,504L,344L,100L,8L,14L,154L,504L,728L,504L,154L,14L,24L,232L,728L,1040L,728L,232L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274624Inst : IEnumerable<long>
{
public static readonly long[] Value=A274624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274624.Bytes);
public long this[int i]=>Value[i];

public static A274624Inst Instance=new A274624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274625
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,8L,1L,8L,14L,2L,14L,24L,4L,24L,40L,8L,40L,64L,14L,64L,100L,1L,24L,100L,154L,2L,40L,154L,232L,4L,64L,232L,344L,8L,100L,344L,504L,14L,154L,504L,728L,24L,232L,728L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274625Inst : IEnumerable<long>
{
public static readonly long[] Value=A274625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274625.Bytes);
public long this[int i]=>Value[i];

public static A274625Inst Instance=new A274625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274626
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,9L,27L,63L,147L,343L,735L,1575L,3375L,6975L,14415L,29791L,60543L,123039L,250047L,504063L,1016127L,2048383L,4112895L,8258175L,16581375L,33227775L,66585855L,133432831L,267126783L,534776319L,1070599167L,2142244863L,4286583807L,8577357823L,17158905855L,34326194175L,68669157375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274626Inst : IEnumerable<long>
{
public static readonly long[] Value=A274626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274626.Bytes);
public long this[int i]=>Value[i];

public static A274626Inst Instance=new A274626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274627
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,9L,27L,81L,189L,441L,1029L,2401L,5145L,11025L,23625L,50625L,104625L,216225L,446865L,923521L,1876833L,3814209L,7751457L,15752961L,31755969L,64016001L,129048129L,260144641L,522337665L,1048788225L,2105834625L,4228250625L,8473082625L,16979393025L,34025371905L,68184176641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274627Inst : IEnumerable<long>
{
public static readonly long[] Value=A274627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274627.Bytes);
public long this[int i]=>Value[i];

public static A274627Inst Instance=new A274627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274868
{
public static readonly long[] Value={ 1L,2L,7L,14L,35L,70L,155L,310L,651L,1302L,2667L,5334L,10795L,21590L,43435L,86870L,174251L,348502L,698027L,1396054L,2794155L,5588310L,11180715L,22361430L,44731051L,89462102L,178940587L,357881174L,715795115L,1431590230L,2863245995L,5726491990L,11453115051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274868Inst : IEnumerable<long>
{
public static readonly long[] Value=A274868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274868.Bytes);
public long this[int i]=>Value[i];

public static A274868Inst Instance=new A274868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274869
{
public static readonly long[] Value={ 1L,2L,13L,26L,113L,226L,833L,1666L,5649L,11298L,36561L,73122L,230161L,460322L,1424401L,2848802L,8720657L,17441314L,53021969L,106043938L,320925969L,641851938L,1936736529L,3873473058L,11665150225L,23330300450L,70169841937L,140339683874L,421734846737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274869Inst : IEnumerable<long>
{
public static readonly long[] Value=A274869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274869.Bytes);
public long this[int i]=>Value[i];

public static A274869Inst Instance=new A274869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274870
{
public static readonly long[] Value={ 1L,3L,22L,66L,311L,933L,3632L,10896L,38337L,115011L,381594L,1144782L,3664507L,10993521L,34404964L,103214892L,318365333L,955095999L,2918309966L,8754929898L,26585715663L,79757146989L,241208177496L,723624532488L,2182538747689L,6547616243067L,19713018571138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274870Inst : IEnumerable<long>
{
public static readonly long[] Value=A274870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274870.Bytes);
public long this[int i]=>Value[i];

public static A274870Inst Instance=new A274870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274871
{
public static readonly long[] Value={ 1L,3L,34L,102L,719L,2157L,12260L,36780L,185457L,556371L,2607078L,7821234L,34949443L,104848329L,453798280L,1361394840L,5763944693L,17291834079L,72085646282L,216256938846L,891613471047L,2674840413141L,10940569830060L,32821709490180L,133469376708409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274871Inst : IEnumerable<long>
{
public static readonly long[] Value=A274871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274871.Bytes);
public long this[int i]=>Value[i];

public static A274871Inst Instance=new A274871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274872
{
public static readonly long[] Value={ 1L,4L,50L,200L,1519L,6076L,36564L,146256L,770481L,3081924L,14934774L,59739096L,273905827L,1095623308L,4836291512L,19345166048L,83144608885L,332578435540L,1402399388442L,5609597553768L,23330003686119L,93320014744476L,384220628807964L,1536882515231856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274872Inst : IEnumerable<long>
{
public static readonly long[] Value=A274872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274872.Bytes);
public long this[int i]=>Value[i];

public static A274872Inst Instance=new A274872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274873
{
public static readonly long[] Value={ 1L,4L,70L,280L,2919L,11676L,94944L,379776L,2669361L,10677444L,68321994L,273287976L,1640345707L,6561382828L,37643205652L,150572822608L,836008721925L,3344034887700L,18122573826942L,72490295307768L,385781480224959L,1543125920899836L,8099850233307144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274873Inst : IEnumerable<long>
{
public static readonly long[] Value=A274873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274873.Bytes);
public long this[int i]=>Value[i];

public static A274873Inst Instance=new A274873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274874
{
public static readonly long[] Value={ 1L,5L,95L,475L,5294L,26470L,227294L,1136470L,8351711L,41758555L,277114769L,1385573845L,8568214932L,42841074660L,251848578952L,1259242894760L,7132223195725L,35661115978625L,196428153720067L,982140768600335L,5296485323226634L,26482426616133170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274874Inst : IEnumerable<long>
{
public static readonly long[] Value=A274874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274874.Bytes);
public long this[int i]=>Value[i];

public static A274874Inst Instance=new A274874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274875
{
public static readonly BigInteger[] Value={ 1L,0L,1L,3L,35L,226L,3632L,36780L,770481L,10677444L,277114769L,4882093495L,151410615066L,3238949008872L,116936529884088L,2943848265346408L,121318690777898613L,3513774792447267240L,BigInteger.Parse("162794429514873454259"),BigInteger.Parse("5332375501915984656921"),BigInteger.Parse("274393112247007415104839") };
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
public class A274875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274875.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274875Inst Instance=new A274875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274876
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,3L,0L,1L,2L,0L,0L,4L,0L,1L,1L,1L,0L,4L,0L,2L,3L,1L,0L,4L,0L,1L,1L,2L,0L,5L,0L,1L,2L,1L,1L,4L,0L,1L,3L,1L,0L,7L,0L,2L,4L,0L,0L,4L,0L,2L,3L,1L,0L,2L,0L,2L,0L,0L,0L,9L,0L,0L,2L,0L,0L,5L,0L,3L,0L,2L,0L,8L,0L,0L,2L,2L,2L,6L,0L,2L,2L,1L,0L,6L,0L,1L,1L,2L,0L,8L,1L,1L,1L,0L,0L,2L,0L,1L,0L,4L,0L,4L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274876Inst : IEnumerable<long>
{
public static readonly long[] Value=A274876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274876.Bytes);
public long this[int i]=>Value[i];

public static A274876Inst Instance=new A274876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274877
{
public static readonly long[] Value={ 1L,6L,18L,12L,24L,60L,156L,84L,144L,120L,816L,336L,360L,1224L,840L,924L,2184L,1800L,2640L,7200L,1260L,3960L,7140L,8400L,3780L,5040L,2520L,9360L,12600L,20160L,11340L,10080L,15120L,19656L,16380L,41580L,18480L,48720L,34320L,25200L,54600L,27720L,87360L,134640L,60060L,73920L,32760L,43680L,159600L,143640L,55440L,85800L,96096L,65520L,131040L,120120L,157080L,154440L,98280L,191520L,166320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274877Inst : IEnumerable<long>
{
public static readonly long[] Value=A274877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274877.Bytes);
public long this[int i]=>Value[i];

public static A274877Inst Instance=new A274877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274878
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,6L,0L,2L,4L,0L,10L,20L,0L,2L,12L,6L,0L,14L,84L,42L,0L,2L,28L,32L,8L,0L,18L,252L,288L,72L,0L,2L,60L,120L,60L,10L,0L,22L,660L,1320L,660L,110L,0L,2L,124L,390L,300L,96L,12L,0L,26L,1612L,5070L,3900L,1248L,156L,0L,2L,252L,1176L,1260L,588L,140L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274878Inst : IEnumerable<long>
{
public static readonly long[] Value=A274878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274878.Bytes);
public long this[int i]=>Value[i];

public static A274878Inst Instance=new A274878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274879
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,4L,6L,12L,12L,4L,8L,8L,20L,40L,48L,32L,10L,20L,24L,16L,70L,140L,180L,160L,80L,28L,56L,72L,64L,32L,252L,504L,672L,672L,480L,192L,84L,168L,224L,224L,160L,64L,924L,1848L,2520L,2688L,2240L,1344L,448L,264L,528L,720L,768L,640L,384L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274879Inst : IEnumerable<long>
{
public static readonly long[] Value=A274879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274879.Bytes);
public long this[int i]=>Value[i];

public static A274879Inst Instance=new A274879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274880
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,4L,2L,18L,11L,1L,10L,8L,2L,65L,57L,17L,1L,28L,28L,12L,2L,238L,252L,116L,23L,1L,84L,96L,54L,16L,2L,882L,1050L,615L,195L,29L,1L,264L,330L,220L,88L,20L,2L,3300L,4257L,2915L,1210L,294L,35L,1L,858L,1144L,858L,416L,130L,24L,2L,12441L,17017L,13013L,6461L,2093L,413L,41L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274880Inst : IEnumerable<long>
{
public static readonly long[] Value=A274880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274880.Bytes);
public long this[int i]=>Value[i];

public static A274880Inst Instance=new A274880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274881
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,6L,0L,3L,3L,0L,18L,12L,0L,4L,12L,4L,0L,40L,80L,20L,0L,5L,40L,20L,5L,0L,75L,375L,150L,30L,0L,6L,120L,90L,30L,6L,0L,126L,1470L,882L,252L,42L,0L,7L,350L,371L,147L,42L,7L,0L,196L,5292L,4508L,1568L,392L,56L,0L,8L,1008L,1456L,672L,224L,56L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274881Inst : IEnumerable<long>
{
public static readonly long[] Value=A274881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274881.Bytes);
public long this[int i]=>Value[i];

public static A274881Inst Instance=new A274881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274882
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,9L,23L,62L,176L,512L,1551L,4822L,15266L,49141L,160728L,532890L,1785162L,6039328L,20617808L,70951548L,245911020L,857888714L,3010811846L,10624583264L,37680980256L,134260382400L,480440869030L,1726092837412L,6224442777366L,22523780202156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274882Inst : IEnumerable<long>
{
public static readonly long[] Value=A274882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274882.Bytes);
public long this[int i]=>Value[i];

public static A274882Inst Instance=new A274882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274883
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,3L,6L,12L,8L,2L,24L,24L,32L,16L,10L,20L,120L,80L,80L,32L,5L,120L,120L,480L,240L,192L,64L,35L,70L,840L,560L,1680L,672L,448L,128L,14L,560L,560L,4480L,2240L,5376L,1792L,1024L,256L,126L,252L,5040L,3360L,20160L,8064L,16128L,4608L,2304L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274883Inst : IEnumerable<long>
{
public static readonly long[] Value=A274883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274883.Bytes);
public long this[int i]=>Value[i];

public static A274883Inst Instance=new A274883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274964
{
public static readonly BigInteger[] Value={ 1L,2L,3L,6L,10L,27L,63L,290L,732L,3950L,14773L,119427L,492167L,4739742L,29304550L,503805954L,2394731095L,33364109691L,267779096008L,6778552047060L,47933808592698L,1141492809790630L,13812159440293116L,631536544942731743L,5059663373178085810L,BigInteger.Parse("161991873932527358590"),BigInteger.Parse("2458252827155843942412"),BigInteger.Parse("157277460804140189938404"),BigInteger.Parse("1910359108470010215694334"),BigInteger.Parse("104035730915390562574302557"),BigInteger.Parse("2638816703576929939008316379"),BigInteger.Parse("345342948094489081419419253954") };
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
public class A274964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274964Inst Instance=new A274964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274965
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,20L,46L,104L,238L,540L,1228L,2780L,6289L,14180L,31924L,71688L,160694L,359452L,802642L,1788988L,3980916L,8844064L,19618506L,43455324L,96121164L,212331796L,468445180L,1032216460L,2271818652L,4994434788L,10968013396L,24061103888L,52730956193L,115449870424L,252530306764L,551873275488L,1204991320660L,2628810554176L,5730295148952L,12480957518212L,27163290056278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274965Inst : IEnumerable<long>
{
public static readonly long[] Value=A274965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274965.Bytes);
public long this[int i]=>Value[i];

public static A274965Inst Instance=new A274965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274966
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,30L,180L,1380L,11760L,116760L,1288560L,15772680L,211217160L,3070766160L,48126078000L,808938290160L,14511273416640L,276665518649520L,5585442224281920L,119014292440002960L,2668801991050475280L,BigInteger.Parse("62817503812807423680"),BigInteger.Parse("1548361707766975221120"),BigInteger.Parse("39881143737823187479680"),BigInteger.Parse("1071331562128332368223360"),BigInteger.Parse("29961996486664600243005120"),BigInteger.Parse("870964354095824682016202880"),BigInteger.Parse("26276077241407778648357894400"),BigInteger.Parse("821576644748718055815635297280") };
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
public class A274966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274966.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274966Inst Instance=new A274966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274967
{
public static readonly long[] Value={ 77L,119L,143L,161L,187L,203L,209L,221L,299L,319L,323L,329L,371L,377L,391L,407L,413L,437L,473L,493L,497L,517L,527L,533L,539L,551L,581L,583L,589L,611L,623L,629L,649L,667L,689L,707L,713L,731L,737L,749L,767L,779L,791L,799L,803L,817L,851L,869L,893L,899L,901L,913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274967Inst : IEnumerable<long>
{
public static readonly long[] Value=A274967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274967.Bytes);
public long this[int i]=>Value[i];

public static A274967Inst Instance=new A274967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274968
{
public static readonly long[] Value={ 4L,8L,14L,20L,26L,32L,38L,44L,50L,56L,62L,68L,74L,80L,86L,98L,104L,110L,116L,122L,128L,134L,140L,146L,152L,158L,164L,170L,182L,188L,194L,200L,206L,212L,218L,224L,230L,236L,242L,248L,254L,266L,272L,278L,284L,290L,296L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274968Inst : IEnumerable<long>
{
public static readonly long[] Value=A274968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274968.Bytes);
public long this[int i]=>Value[i];

public static A274968Inst Instance=new A274968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274969
{
public static readonly long[] Value={ 1L,1L,4L,21L,121L,728L,4488L,28101L,177859L,1134705L,7283640L,46981740L,304253964L,1976886616L,12880883408L,84130964709L,550649378199L,3610705776755L,23714554702020L,155979407872365L,1027269675638745L,6773476758296220L,44709685668953760L,295402076512228140L,1953492865541875476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274969Inst : IEnumerable<long>
{
public static readonly long[] Value=A274969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274969.Bytes);
public long this[int i]=>Value[i];

public static A274969Inst Instance=new A274969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274970
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,698L,4393L,28551L,187403L,1231517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274970Inst : IEnumerable<long>
{
public static readonly long[] Value=A274970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274970.Bytes);
public long this[int i]=>Value[i];

public static A274970Inst Instance=new A274970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274971
{
public static readonly long[] Value={ 1L,7L,19L,31L,37L,43L,61L,67L,79L,91L,103L,127L,139L,151L,157L,163L,169L,199L,211L,217L,223L,247L,271L,283L,307L,313L,331L,343L,349L,367L,373L,379L,397L,403L,427L,439L,463L,469L,487L,499L,511L,523L,547L,553L,571L,577L,607L,613L,619L,631L,643L,661L,679L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274971Inst : IEnumerable<long>
{
public static readonly long[] Value=A274971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274971.Bytes);
public long this[int i]=>Value[i];

public static A274971Inst Instance=new A274971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274972
{
public static readonly BigInteger[] Value={ 4L,4387L,4273420L,4162307179L,4054082919412L,3948672601200595L,3846003059486460604L,BigInteger.Parse("3746003031267211428187"),BigInteger.Parse("3648603106451204444594020"),BigInteger.Parse("3553735679680441861823147779"),BigInteger.Parse("3461334903405643922211301343212"),BigInteger.Parse("3371336642181417499791945685141195") };
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
public class A274972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274972.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274972Inst Instance=new A274972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274973
{
public static readonly long[] Value={ 1L,13L,55L,139L,277L,481L,763L,1135L,1609L,2197L,2911L,3763L,4765L,5929L,7267L,8791L,10513L,12445L,14599L,16987L,19621L,22513L,25675L,29119L,32857L,36901L,41263L,45955L,50989L,56377L,62131L,68263L,74785L,81709L,89047L,96811L,105013L,113665L,122779L,132367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274973Inst : IEnumerable<long>
{
public static readonly long[] Value=A274973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274973.Bytes);
public long this[int i]=>Value[i];

public static A274973Inst Instance=new A274973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274974
{
public static readonly long[] Value={ 1L,13L,49L,117L,225L,381L,593L,869L,1217L,1645L,2161L,2773L,3489L,4317L,5265L,6341L,7553L,8909L,10417L,12085L,13921L,15933L,18129L,20517L,23105L,25901L,28913L,32149L,35617L,39325L,43281L,47493L,51969L,56717L,61745L,67061L,72673L,78589L,84817L,91365L,98241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274974Inst : IEnumerable<long>
{
public static readonly long[] Value=A274974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274974.Bytes);
public long this[int i]=>Value[i];

public static A274974Inst Instance=new A274974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274975
{
public static readonly long[] Value={ 3L,2L,6L,11L,26L,57L,129L,289L,650L,1460L,3281L,7372L,16565L,37221L,83635L,187926L,422266L,948823L,2131986L,4790529L,10764221L,24186985L,54347662L,122118088L,274396853L,616564132L,1385407029L,3112981337L,6994805571L,15717185450L,35316195134L,79354770147L,178308549978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274975Inst : IEnumerable<long>
{
public static readonly long[] Value=A274975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274975.Bytes);
public long this[int i]=>Value[i];

public static A274975Inst Instance=new A274975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274976
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,9L,57L,98L,122L,123L,249L,304L,318L,339L,374L,390L,476L,619L,1358L,1724L,3351L,5046L,5572L,6685L,9421L,14362L,97353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274976Inst : IEnumerable<long>
{
public static readonly long[] Value=A274976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274976.Bytes);
public long this[int i]=>Value[i];

public static A274976Inst Instance=new A274976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274977
{
public static readonly long[] Value={ 1L,6L,9L,27L,54L,135L,297L,702L,1593L,3699L,8478L,19575L,45009L,103734L,238761L,549963L,1266246L,2916135L,6714873L,15463278L,35607897L,81997731L,188821422L,434814615L,1001278881L,2305722726L,5309559369L,12226727547L,28155405654L,64835588295L,149301805257L,343808570142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274977Inst : IEnumerable<long>
{
public static readonly long[] Value=A274977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274977.Bytes);
public long this[int i]=>Value[i];

public static A274977Inst Instance=new A274977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274978
{
public static readonly long[] Value={ 0L,1L,13L,16L,40L,45L,81L,88L,136L,145L,205L,216L,288L,301L,385L,400L,496L,513L,621L,640L,760L,781L,913L,936L,1080L,1105L,1261L,1288L,1456L,1485L,1665L,1696L,1888L,1921L,2125L,2160L,2376L,2413L,2641L,2680L,2920L,2961L,3213L,3256L,3520L,3565L,3841L,3888L,4176L,4225L,4525L,4576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274978Inst : IEnumerable<long>
{
public static readonly long[] Value=A274978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274978.Bytes);
public long this[int i]=>Value[i];

public static A274978Inst Instance=new A274978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274979
{
public static readonly long[] Value={ 0L,1L,15L,18L,46L,51L,93L,100L,156L,165L,235L,246L,330L,343L,441L,456L,568L,585L,711L,730L,870L,891L,1045L,1068L,1236L,1261L,1443L,1470L,1666L,1695L,1905L,1936L,2160L,2193L,2431L,2466L,2718L,2755L,3021L,3060L,3340L,3381L,3675L,3718L,4026L,4071L,4393L,4440L,4776L,4825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274979Inst : IEnumerable<long>
{
public static readonly long[] Value=A274979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274979.Bytes);
public long this[int i]=>Value[i];

public static A274979Inst Instance=new A274979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275012
{
public static readonly long[] Value={ 1L,1L,4L,11L,29L,69L,174L,413L,995L,2364L,5581L,13082L,30600L,71111L,164660L,379682L,872749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275012Inst : IEnumerable<long>
{
public static readonly long[] Value=A275012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275012.Bytes);
public long this[int i]=>Value[i];

public static A275012Inst Instance=new A275012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275013
{
public static readonly long[] Value={ 2L,7L,26L,97L,241L,2521L,16022L,26603L,39343L,104659L,248407L,506509L,584213L,2560177L,4036967L,4417813L,5167587L,9725107L,25045771L,27489679L,70416259L,111555371L,174266683L,359589563L,1075714923L,6820213333L,15378035161L,16598109467L,19423306039L,30133946677L,74466436042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275013Inst : IEnumerable<long>
{
public static readonly long[] Value=A275013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275013.Bytes);
public long this[int i]=>Value[i];

public static A275013Inst Instance=new A275013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275014
{
public static readonly long[] Value={ 3L,9L,29L,101L,247L,2531L,16033L,26615L,39359L,104677L,248426L,506531L,584237L,2560202L,4036993L,4417843L,5167619L,9725141L,25045807L,27489719L,70416301L,111555415L,174266734L,359589619L,1075714987L,6820213399L,15378035231L,16598109538L,19423306117L,30133946758L,74466436127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275014Inst : IEnumerable<long>
{
public static readonly long[] Value=A275014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275014.Bytes);
public long this[int i]=>Value[i];

public static A275014Inst Instance=new A275014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275015
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,1L,3L,3L,2L,1L,3L,3L,3L,2L,1L,3L,3L,3L,3L,2L,1L,3L,3L,3L,3L,3L,2L,1L,3L,3L,3L,3L,3L,3L,2L,1L,3L,3L,3L,3L,3L,3L,3L,2L,1L,3L,3L,3L,3L,3L,3L,3L,3L,2L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,1L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275015Inst : IEnumerable<long>
{
public static readonly long[] Value=A275015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275015.Bytes);
public long this[int i]=>Value[i];

public static A275015Inst Instance=new A275015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275016
{
public static readonly long[] Value={ 0L,0L,0L,5L,5L,15L,35L,55L,135L,255L,495L,1055L,2015L,4095L,8255L,16255L,32895L,65535L,130815L,262655L,523775L,1048575L,2098175L,4192255L,8390655L,16777215L,33550335L,67117055L,134209535L,268435455L,536887295L,1073709055L,2147516415L,4294967295L,8589869055L,17180000255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275016Inst : IEnumerable<long>
{
public static readonly long[] Value=A275016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275016.Bytes);
public long this[int i]=>Value[i];

public static A275016Inst Instance=new A275016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275017
{
public static readonly long[] Value={ 1L,2L,1L,1L,4L,6L,7L,7L,10L,12L,13L,17L,18L,20L,23L,23L,24L,30L,35L,31L,32L,40L,41L,39L,42L,50L,55L,51L,48L,56L,61L,57L,66L,74L,71L,65L,78L,86L,79L,77L,88L,96L,91L,85L,100L,108L,97L,91L,114L,132L,113L,97L,120L,142L,121L,109L,136L,154L,133L,117L,144L,164L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275017Inst : IEnumerable<long>
{
public static readonly long[] Value=A275017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275017.Bytes);
public long this[int i]=>Value[i];

public static A275017Inst Instance=new A275017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275018
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,5L,6L,10L,11L,19L,20L,29L,33L,38L,43L,56L,60L,76L,81L,90L,98L,118L,121L,138L,147L,163L,172L,197L,202L,230L,243L,260L,273L,294L,303L,336L,352L,373L,384L,421L,430L,470L,487L,508L,528L,572L,583L,623L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275018Inst : IEnumerable<long>
{
public static readonly long[] Value=A275018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275018.Bytes);
public long this[int i]=>Value[i];

public static A275018Inst Instance=new A275018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275019
{
public static readonly long[] Value={ 0L,2L,1L,2L,0L,3L,2L,3L,0L,2L,1L,2L,0L,4L,3L,4L,0L,2L,1L,2L,0L,3L,2L,3L,0L,2L,1L,2L,0L,5L,4L,5L,0L,2L,1L,2L,0L,3L,2L,3L,0L,2L,1L,2L,0L,4L,3L,4L,0L,2L,1L,2L,0L,3L,2L,3L,0L,2L,1L,2L,0L,6L,5L,6L,0L,2L,1L,2L,0L,3L,2L,3L,0L,2L,1L,2L,0L,4L,3L,4L,0L,2L,1L,2L,0L,3L,2L,3L,0L,2L,1L,2L,0L,5L,4L,5L,0L,2L,1L,2L,0L,3L,2L,3L,0L,2L,1L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275019Inst : IEnumerable<long>
{
public static readonly long[] Value=A275019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275019.Bytes);
public long this[int i]=>Value[i];

public static A275019Inst Instance=new A275019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275020
{
public static readonly long[] Value={ 1L,2L,3L,10L,19L,35L,43L,80L,107L,143L,199L,218L,255L,304L,353L,560L,904L,996L,1051L,6141L,8075L,9913L,11151L,28469L,75244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275020Inst : IEnumerable<long>
{
public static readonly long[] Value=A275020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275020.Bytes);
public long this[int i]=>Value[i];

public static A275020Inst Instance=new A275020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275021
{
public static readonly long[] Value={ 79L,83L,127L,131L,163L,167L,379L,383L,397L,401L,439L,443L,487L,491L,499L,503L,673L,677L,739L,743L,757L,761L,769L,773L,907L,911L,937L,941L,967L,971L,1009L,1013L,1213L,1217L,1549L,1553L,1567L,1571L,1579L,1583L,1597L,1601L,2203L,2207L,2293L,2297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275021Inst : IEnumerable<long>
{
public static readonly long[] Value=A275021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275021.Bytes);
public long this[int i]=>Value[i];

public static A275021Inst Instance=new A275021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275022
{
public static readonly long[] Value={ 47L,53L,251L,257L,331L,337L,353L,359L,367L,373L,541L,547L,557L,563L,587L,593L,607L,613L,647L,653L,727L,733L,947L,953L,977L,983L,991L,997L,1097L,1103L,1117L,1123L,1181L,1187L,1361L,1367L,1433L,1439L,1493L,1499L,1657L,1663L,1741L,1747L,1753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275022Inst : IEnumerable<long>
{
public static readonly long[] Value=A275022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275022.Bytes);
public long this[int i]=>Value[i];

public static A275022Inst Instance=new A275022Inst();

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