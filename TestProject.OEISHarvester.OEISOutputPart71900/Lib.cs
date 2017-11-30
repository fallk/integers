using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A188061
{
public static readonly long[] Value={ 4L,9L,16L,25L,49L,55L,64L,81L,121L,161L,169L,209L,256L,289L,351L,361L,529L,551L,625L,649L,729L,841L,961L,1024L,1079L,1189L,1369L,1407L,1443L,1681L,1849L,2015L,2209L,2289L,2401L,2809L,2849L,2915L,2975L,3401L,3481L,3721L,3857L,4096L,4489L,4599L,4887L,5041L,5329L,6049L,6241L,6319L,6561L,6889L,6993L,7921L,8569L,9409L,9701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188061Inst : IEnumerable<long>
{
public static readonly long[] Value=A188061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188061.Bytes);
public long this[int i]=>Value[i];

public static A188061Inst Instance=new A188061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188062
{
public static readonly long[] Value={ 6L,30L,36L,120L,540L,216L,360L,5580L,6480L,1296L,720L,46800L,124200L,64800L,7776L,720L,331920L,1895400L,1976400L,583200L,46656L,0L,1995840L,24736320L,46947600L,25855200L,4898880L,279936L,0L,9979200L,284074560L,946527120L,876355200L,297198720L,39191040L,1679616L,0L,39916800L,2900620800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188062Inst : IEnumerable<long>
{
public static readonly long[] Value=A188062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188062.Bytes);
public long this[int i]=>Value[i];

public static A188062Inst Instance=new A188062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188063
{
public static readonly long[] Value={ 17L,281L,677L,953L,2729L,4241L,4637L,18749L,55217L,112997L,115769L,148781L,151733L,326693L,623393L,637841L,744833L,907733L,1056833L,1444481L,1774937L,1831481L,1866737L,1939097L,2028197L,2564369L,2566601L,3146237L,4635317L,4777433L,5629157L,5960501L,6247601L,6837221L,7248737L,7278041L,7340537L,7442849L,7766237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188063Inst : IEnumerable<long>
{
public static readonly long[] Value=A188063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188063.Bytes);
public long this[int i]=>Value[i];

public static A188063Inst Instance=new A188063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188064
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,10L,16L,17L,19L,21L,27L,29L,35L,41L,65L,66L,68L,70L,76L,78L,84L,90L,114L,116L,122L,128L,152L,158L,182L,206L,326L,327L,329L,331L,337L,339L,345L,351L,375L,377L,383L,389L,413L,419L,443L,467L,587L,589L,595L,601L,625L,631L,655L,679L,799L,805L,829L,853L,973L,997L,1117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188064Inst : IEnumerable<long>
{
public static readonly long[] Value=A188064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188064.Bytes);
public long this[int i]=>Value[i];

public static A188064Inst Instance=new A188064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188065
{
public static readonly long[] Value={ 5L,8L,35L,38L,50L,80L,101L,102L,110L,178L,196L,201L,221L,227L,257L,258L,279L,289L,319L,329L,331L,341L,345L,350L,355L,356L,371L,379L,380L,384L,405L,406L,408L,417L,427L,455L,457L,473L,497L,500L,514L,553L,564L,576L,635L,638L,639L,641L,644L,656L,665L,668L,674L,689L,709L,711L,722L,725L,773L,781L,792L,800L,804L,836L,858L,862L,894L,923L,933L,943L,961L,973L,978L,981L,983L,992L,996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188065Inst : IEnumerable<long>
{
public static readonly long[] Value=A188065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188065.Bytes);
public long this[int i]=>Value[i];

public static A188065Inst Instance=new A188065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188066
{
public static readonly long[] Value={ 7L,42L,49L,210L,882L,343L,840L,11172L,12348L,2401L,2520L,117600L,288120L,144060L,16807L,5040L,1076040L,5433120L,5330220L,1512630L,117649L,5040L,8643600L,89029080L,155296680L,81177810L,14823774L,823543L,0L,60540480L,1306912320L,3884433840L,3360055440L,1087076760L,138355224L,5764801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188066Inst : IEnumerable<long>
{
public static readonly long[] Value=A188066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188066.Bytes);
public long this[int i]=>Value[i];

public static A188066Inst Instance=new A188066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188067
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,5L,18L,14L,40L,30L,75L,55L,126L,91L,196L,140L,288L,204L,405L,285L,550L,385L,726L,506L,936L,650L,1183L,819L,1470L,1015L,1800L,1240L,2176L,1496L,2601L,1785L,3078L,2109L,3610L,2470L,4200L,2870L,4851L,3311L,5566L,3795L,6348L,4324L,7200L,4900L,8125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188067Inst : IEnumerable<long>
{
public static readonly long[] Value=A188067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188067.Bytes);
public long this[int i]=>Value[i];

public static A188067Inst Instance=new A188067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188068
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188068Inst : IEnumerable<long>
{
public static readonly long[] Value=A188068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188068.Bytes);
public long this[int i]=>Value[i];

public static A188068Inst Instance=new A188068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188069
{
public static readonly long[] Value={ 1L,4L,8L,12L,15L,19L,23L,27L,30L,34L,38L,42L,45L,49L,53L,56L,60L,64L,68L,71L,75L,79L,83L,86L,90L,94L,98L,101L,105L,109L,112L,116L,120L,124L,127L,131L,135L,139L,142L,146L,150L,154L,157L,161L,165L,168L,172L,176L,180L,183L,187L,191L,195L,198L,202L,206L,209L,213L,217L,221L,224L,228L,232L,236L,239L,243L,247L,251L,254L,258L,262L,265L,269L,273L,277L,280L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188069Inst : IEnumerable<long>
{
public static readonly long[] Value=A188069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188069.Bytes);
public long this[int i]=>Value[i];

public static A188069Inst Instance=new A188069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188070
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,46L,47L,48L,50L,51L,52L,54L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,69L,70L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L,87L,88L,89L,91L,92L,93L,95L,96L,97L,99L,100L,102L,103L,104L,106L,107L,108L,110L,111L,113L,114L,115L,117L,118L,119L,121L,122L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188070Inst : IEnumerable<long>
{
public static readonly long[] Value=A188070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188070.Bytes);
public long this[int i]=>Value[i];

public static A188070Inst Instance=new A188070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188071
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188071Inst : IEnumerable<long>
{
public static readonly long[] Value=A188071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188071.Bytes);
public long this[int i]=>Value[i];

public static A188071Inst Instance=new A188071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188072
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,12L,13L,15L,16L,19L,20L,23L,24L,27L,28L,30L,31L,34L,35L,38L,39L,42L,43L,45L,46L,49L,50L,53L,54L,56L,57L,60L,61L,64L,65L,68L,69L,71L,72L,75L,76L,79L,80L,83L,84L,86L,87L,90L,91L,94L,95L,98L,99L,101L,102L,105L,106L,109L,110L,112L,113L,116L,117L,120L,121L,124L,125L,127L,128L,131L,132L,135L,136L,139L,140L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188072Inst : IEnumerable<long>
{
public static readonly long[] Value=A188072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188072.Bytes);
public long this[int i]=>Value[i];

public static A188072Inst Instance=new A188072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188073
{
public static readonly long[] Value={ 3L,6L,7L,10L,11L,14L,17L,18L,21L,22L,25L,26L,29L,32L,33L,36L,37L,40L,41L,44L,47L,48L,51L,52L,55L,58L,59L,62L,63L,66L,67L,70L,73L,74L,77L,78L,81L,82L,85L,88L,89L,92L,93L,96L,97L,100L,103L,104L,107L,108L,111L,114L,115L,118L,119L,122L,123L,126L,129L,130L,133L,134L,137L,138L,141L,144L,145L,148L,149L,152L,153L,156L,159L,160L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188073Inst : IEnumerable<long>
{
public static readonly long[] Value=A188073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188073.Bytes);
public long this[int i]=>Value[i];

public static A188073Inst Instance=new A188073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188074
{
public static readonly long[] Value={ 7L,11L,18L,22L,26L,33L,37L,41L,48L,52L,59L,63L,67L,74L,78L,82L,89L,93L,97L,104L,108L,115L,119L,123L,130L,134L,138L,145L,149L,153L,160L,164L,171L,175L,179L,186L,190L,194L,201L,205L,212L,216L,220L,227L,231L,235L,242L,246L,250L,257L,261L,268L,272L,276L,283L,287L,291L,298L,302L,306L,313L,317L,324L,328L,332L,339L,343L,347L,354L,358L,362L,369L,373L,380L,384L,388L,395L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188074Inst : IEnumerable<long>
{
public static readonly long[] Value=A188074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188074.Bytes);
public long this[int i]=>Value[i];

public static A188074Inst Instance=new A188074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188075
{
public static readonly long[] Value={ 4L,15L,30L,45L,56L,71L,86L,101L,112L,127L,142L,157L,168L,183L,198L,209L,224L,239L,254L,265L,280L,295L,310L,321L,336L,351L,366L,377L,392L,407L,418L,433L,448L,463L,474L,489L,504L,519L,530L,545L,560L,575L,586L,601L,616L,627L,642L,657L,672L,683L,698L,713L,728L,739L,754L,769L,780L,795L,810L,825L,836L,851L,866L,881L,892L,907L,922L,937L,948L,963L,978L,989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188075Inst : IEnumerable<long>
{
public static readonly long[] Value=A188075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188075.Bytes);
public long this[int i]=>Value[i];

public static A188075Inst Instance=new A188075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188508
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,12L,49L,49L,12L,21L,144L,229L,144L,21L,37L,441L,971L,971L,441L,37L,65L,1369L,4351L,5626L,4351L,1369L,65L,114L,4225L,20124L,35079L,35079L,20124L,4225L,114L,200L,12996L,92597L,230877L,317751L,230877L,92597L,12996L,200L,351L,40000L,423074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188508Inst : IEnumerable<long>
{
public static readonly long[] Value=A188508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188508.Bytes);
public long this[int i]=>Value[i];

public static A188508Inst Instance=new A188508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188509
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,7L,1L,9L,13L,15L,1L,17L,25L,29L,31L,1L,33L,49L,57L,61L,63L,1L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188509Inst : IEnumerable<long>
{
public static readonly long[] Value=A188509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188509.Bytes);
public long this[int i]=>Value[i];

public static A188509Inst Instance=new A188509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188510
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188510Inst : IEnumerable<long>
{
public static readonly long[] Value=A188510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188510.Bytes);
public long this[int i]=>Value[i];

public static A188510Inst Instance=new A188510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188511
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,4L,4L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,42L,42L,43L,44L,44L,45L,46L,46L,47L,48L,49L,49L,50L,51L,51L,52L,53L,53L,54L,55L,56L,56L,57L,58L,58L,59L,60L,60L,61L,62L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188511Inst : IEnumerable<long>
{
public static readonly long[] Value=A188511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188511.Bytes);
public long this[int i]=>Value[i];

public static A188511Inst Instance=new A188511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188512
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188512Inst : IEnumerable<long>
{
public static readonly long[] Value=A188512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188512.Bytes);
public long this[int i]=>Value[i];

public static A188512Inst Instance=new A188512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188513
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,9L,11L,5L,1L,29L,40L,23L,7L,1L,97L,147L,99L,39L,9L,1L,333L,544L,413L,194L,59L,11L,1L,1165L,2025L,1691L,907L,333L,83L,13L,1L,4135L,7575L,6842L,4078L,1725L,524L,111L,15L,1L,14845L,28455L,27464L,17856L,8453L,2979L,775L,143L,17L,1L,53791L,107277L,109631L,76718L,39851L,15804L,4797L,1094L,179L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188513Inst : IEnumerable<long>
{
public static readonly long[] Value=A188513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188513.Bytes);
public long this[int i]=>Value[i];

public static A188513Inst Instance=new A188513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188514
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-5L,11L,91L,-391L,-4115L,27971L,357331L,-3353731L,-50789375L,607914581L,10692083221L,-155442170521L,-3120028100285L,53341649623091L,1204301220497011L,-23663734574555011L,-593828627529030095L,13182525824990398001UL };
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
public class A188514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188514Inst Instance=new A188514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188515
{
public static readonly BigInteger[] Value={ 2L,16L,229L,6760L,342240L,32470385L,5593606875L,1811059364020L,1103649329789000L,1283030748540574429L,BigInteger.Parse("2858394905740312536937"),BigInteger.Parse("12271770983630246007920447"),BigInteger.Parse("101822638806356395388304091003"),BigInteger.Parse("1636793382556126237888634491914956") };
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
public class A188515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188515Inst Instance=new A188515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188516
{
public static readonly long[] Value={ 4L,16L,49L,144L,400L,1089L,2916L,7744L,20449L,53824L,141376L,370881L,972196L,2547216L,6671889L,17472400L,45751696L,119793025L,313644100L,821166336L,2149898689L,5628600576L,14736017664L,38579637889L,101003196100L,264430435984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188516Inst : IEnumerable<long>
{
public static readonly long[] Value=A188516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188516.Bytes);
public long this[int i]=>Value[i];

public static A188516Inst Instance=new A188516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188517
{
public static readonly long[] Value={ 7L,49L,229L,1016L,4143L,16438L,63575L,242843L,918833L,3457086L,12955090L,48421778L,180653858L,673156166L,2506152176L,9324771027L,34680539851L,128945324565L,479330913137L,1781567026168L,6621013690288L,24604558144729L,91429145674242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188517Inst : IEnumerable<long>
{
public static readonly long[] Value=A188517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188517.Bytes);
public long this[int i]=>Value[i];

public static A188517Inst Instance=new A188517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188518
{
public static readonly long[] Value={ 12L,144L,1016L,6760L,40230L,231400L,1286120L,7034258L,37987114L,203649331L,1086048101L,5772562367L,30611227680L,162077331288L,857234934742L,4530655310672L,23933312899024L,126384275780253L,667233389909168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188518Inst : IEnumerable<long>
{
public static readonly long[] Value=A188518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188518.Bytes);
public long this[int i]=>Value[i];

public static A188518Inst Instance=new A188518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188519
{
public static readonly long[] Value={ 20L,400L,4143L,40230L,342240L,2800798L,22015314L,169875850L,1291198707L,9730141740L,72859323174L,543367409130L,4040626627139L,29988912453443L,222268109960222L,1645817547627269L,12178540896840119L,90075084742836021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188519Inst : IEnumerable<long>
{
public static readonly long[] Value=A188519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188519.Bytes);
public long this[int i]=>Value[i];

public static A188519Inst Instance=new A188519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188520
{
public static readonly long[] Value={ 33L,1089L,16438L,231400L,2800798L,32470385L,359696109L,3903047802L,41642655120L,440047202716L,4617244898772L,48229127405889L,502163657044635L,5217313950984361L,54124162283409093L,560894846117339319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188520Inst : IEnumerable<long>
{
public static readonly long[] Value=A188520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188520.Bytes);
public long this[int i]=>Value[i];

public static A188520Inst Instance=new A188520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188521
{
public static readonly ulong[] Value={ 54L,2916L,63575L,1286120L,22015314L,359696109L,5593606875L,85072486586L,1270511986433L,18779814902475L,275479123825628L,4021463733992753L,58503148106709186L,849117447746208056L,12303966393066654445UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188521Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A188521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188521.Bytes);
public ulong this[int i]=>Value[i];

public static A188521Inst Instance=new A188521Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188522
{
public static readonly BigInteger[] Value={ 88L,7744L,242843L,7034258L,169875850L,3903047802L,85072486586L,1811059364020L,37821597590709L,781325885220314L,16012231196353370L,326488652600242878L,6633121196128165894L,BigInteger.Parse("134436194716739170904"),BigInteger.Parse("2720029462045283755053") };
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
public class A188522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188522Inst Instance=new A188522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188523
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,12L,49L,49L,12L,20L,144L,229L,144L,20L,33L,400L,1016L,1016L,400L,33L,54L,1089L,4143L,6760L,4143L,1089L,54L,88L,2916L,16438L,40230L,40230L,16438L,2916L,88L,143L,7744L,63575L,231400L,342240L,231400L,63575L,7744L,143L,232L,20449L,242843L,1286120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188523Inst : IEnumerable<long>
{
public static readonly long[] Value=A188523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188523.Bytes);
public long this[int i]=>Value[i];

public static A188523Inst Instance=new A188523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188972
{
public static readonly long[] Value={ 2L,4L,5L,8L,10L,12L,13L,15L,17L,19L,22L,24L,27L,28L,29L,31L,34L,35L,37L,40L,43L,44L,45L,48L,49L,51L,52L,55L,56L,57L,62L,63L,65L,67L,71L,72L,73L,78L,79L,80L,82L,85L,86L,88L,91L,92L,93L,94L,99L,100L,102L,103L,105L,108L,109L,111L,112L,113L,116L,119L,120L,121L,127L,128L,130L,131L,133L,135L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188972Inst : IEnumerable<long>
{
public static readonly long[] Value=A188972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188972.Bytes);
public long this[int i]=>Value[i];

public static A188972Inst Instance=new A188972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188973
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188973Inst : IEnumerable<long>
{
public static readonly long[] Value=A188973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188973.Bytes);
public long this[int i]=>Value[i];

public static A188973Inst Instance=new A188973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188974
{
public static readonly long[] Value={ 1L,3L,6L,7L,9L,11L,13L,15L,18L,20L,21L,23L,27L,29L,30L,31L,33L,36L,38L,40L,41L,43L,45L,48L,49L,51L,53L,54L,57L,59L,62L,63L,66L,68L,69L,72L,73L,75L,78L,79L,81L,83L,85L,86L,89L,91L,93L,96L,97L,99L,102L,104L,105L,108L,110L,111L,113L,116L,117L,119L,121L,123L,125L,126L,129L,131L,133L,135L,138L,139L,141L,143L,146L,148L,149L,152L,154L,156L,157L,159L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188974Inst : IEnumerable<long>
{
public static readonly long[] Value=A188974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188974.Bytes);
public long this[int i]=>Value[i];

public static A188974Inst Instance=new A188974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188975
{
public static readonly long[] Value={ 2L,4L,5L,8L,10L,12L,14L,16L,17L,19L,22L,24L,25L,26L,28L,32L,34L,35L,37L,39L,42L,44L,46L,47L,50L,52L,55L,56L,58L,60L,61L,64L,65L,67L,70L,71L,74L,76L,77L,80L,82L,84L,87L,88L,90L,92L,94L,95L,98L,100L,101L,103L,106L,107L,109L,112L,114L,115L,118L,120L,122L,124L,127L,128L,130L,132L,134L,136L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188975Inst : IEnumerable<long>
{
public static readonly long[] Value=A188975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188975.Bytes);
public long this[int i]=>Value[i];

public static A188975Inst Instance=new A188975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188976
{
public static readonly long[] Value={ 1L,9L,116L,900L,7836L,71865L,640513L,5706113L,51056136L,456396688L,4078122040L,36448590305L,325763780945L,2911451082361L,26020738951500L,232557947597540L,2078461123504804L,18576017680577225L,166021162669244641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188976Inst : IEnumerable<long>
{
public static readonly long[] Value=A188976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188976.Bytes);
public long this[int i]=>Value[i];

public static A188976Inst Instance=new A188976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188977
{
public static readonly BigInteger[] Value={ 2L,116L,7264L,295264L,12838276L,577290185L,25631148992L,1136766429824L,50487034527632L,2241979819401172L,99549503635633660L,4420377191555167852L,BigInteger.Parse("196282145900912402736"),BigInteger.Parse("8715672825193463217812"),BigInteger.Parse("387009187279257877916264") };
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
public class A188977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188977Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188977.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188977.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188977Inst Instance=new A188977Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188978
{
public static readonly BigInteger[] Value={ 4L,900L,295264L,54113236L,10523263424L,2184414516364L,446454227170968L,90637093836201284L,BigInteger.Parse("18447462299508458652"),BigInteger.Parse("3757678170703167716673"),BigInteger.Parse("765103415743509162801632"),BigInteger.Parse("155767055441358236289145024") };
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
public class A188978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188978.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188978Inst Instance=new A188978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188979
{
public static readonly long[] Value={ 6L,7836L,12838276L,10523263424L,9562891914304L,9298230791255360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188979Inst : IEnumerable<long>
{
public static readonly long[] Value=A188979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188979.Bytes);
public long this[int i]=>Value[i];

public static A188979Inst Instance=new A188979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188980
{
public static readonly long[] Value={ 13L,71865L,577290185L,2184414516364L,9298230791255360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188980Inst : IEnumerable<long>
{
public static readonly long[] Value=A188980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188980.Bytes);
public long this[int i]=>Value[i];

public static A188980Inst Instance=new A188980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188981
{
public static readonly long[] Value={ 0L,1L,1L,2L,9L,2L,4L,116L,116L,4L,6L,900L,7264L,900L,6L,13L,7836L,295264L,295264L,7836L,13L,24L,71865L,12838276L,54113236L,12838276L,71865L,24L,45L,640513L,577290185L,10523263424L,10523263424L,577290185L,640513L,45L,84L,5706113L,25631148992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188981Inst : IEnumerable<long>
{
public static readonly long[] Value=A188981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188981.Bytes);
public long this[int i]=>Value[i];

public static A188981Inst Instance=new A188981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188982
{
public static readonly long[] Value={ 0L,2L,12L,46L,120L,122L,828L,6554L,28560L,86158L,145668L,246046L,3369960L,17021162L,58317492L,128629846L,13651680L,1590277918L,9719139348L,37641223154L,99498527400L,107655263398L,647549275812L,5284814079046L,23290743888720L,71041880304722L,123471611274972L,182714776311554L,2701419604443960L,13833225534613558L,47880898349909868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188982Inst : IEnumerable<long>
{
public static readonly long[] Value=A188982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188982.Bytes);
public long this[int i]=>Value[i];

public static A188982Inst Instance=new A188982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188983
{
public static readonly long[] Value={ 1L,3L,5L,9L,119L,597L,2035L,4449L,239L,56403L,341525L,1315911L,3455641L,3627003L,23161315L,186118929L,815616479L,2474152797L,4241902555L,6712571031L,95420159401L,485257533003L,1671083125805L,3718150825791L,584824319281L,44827014819597L,276564805068235L,1076637637754649L,2864483360640839L,3190610873034597L,18094618450123325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188983Inst : IEnumerable<long>
{
public static readonly long[] Value=A188983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188983.Bytes);
public long this[int i]=>Value[i];

public static A188983Inst Instance=new A188983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188984
{
public static readonly BigInteger[] Value={ 1L,3L,65L,943L,62689L,1128197L,42790845L,842157399L,136312116961L,2817640708457L,118490151386655L,2526390089218393L,217977129447815405L,4748017126294329161L,BigInteger.Parse("208584441836961908949"),BigInteger.Parse("4614991020517094410279"),BigInteger.Parse("1644116252728526666074977"),BigInteger.Parse("36812969231234813601419473"),BigInteger.Parse("1656740336870818323274233515"),BigInteger.Parse("37445969415289365495538129125"),BigInteger.Parse("3398982473269915594232889691503"),BigInteger.Parse("77410530113072758320538102052283"),BigInteger.Parse("3537571318060518004220386126288923") };
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
public class A188984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188984Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188984.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188984.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188984Inst Instance=new A188984Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188985
{
public static readonly BigInteger[] Value={ 2L,16L,295L,10812L,852448L,144733702L,55080396536L,46897992282392L,90347796732080200L,BigInteger.Parse("391616769266718212264"),BigInteger.Parse("3836378499038367303867568"),BigInteger.Parse("84709934712009857654653118434"),BigInteger.Parse("4225407805631534612606491862152228") };
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
public class A188985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188985.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A188985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188985Inst Instance=new A188985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188986
{
public static readonly long[] Value={ 7L,49L,295L,1793L,10871L,65937L,399911L,2425505L,14710935L,89223345L,541148807L,3282123457L,19906418039L,120734483153L,732267120743L,4441275782369L,26936796718423L,163374456576241L,990882967287879L,6009807624994561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188986Inst : IEnumerable<long>
{
public static readonly long[] Value=A188986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188986.Bytes);
public long this[int i]=>Value[i];

public static A188986Inst Instance=new A188986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188987
{
public static readonly long[] Value={ 12L,144L,1256L,10812L,92532L,791388L,6768028L,57879084L,494973804L,4232940812L,36199474380L,309572453388L,2647417026444L,22640311889164L,193616539257612L,1655779498747404L,14159977029956108L,121093992068450316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188987Inst : IEnumerable<long>
{
public static readonly long[] Value=A188987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188987.Bytes);
public long this[int i]=>Value[i];

public static A188987Inst Instance=new A188987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189308
{
public static readonly BigInteger[] Value={ 8L,2177L,216708L,27850597L,3373180708L,415003748241L,50887086987153L,6245362716915409L,766353972986446648L,BigInteger.Parse("94042354890961935736"),BigInteger.Parse("11540205645392517527841"),BigInteger.Parse("1416135670291723758792082") };
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
public class A189308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189308Inst Instance=new A189308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189309
{
public static readonly BigInteger[] Value={ 13L,11854L,3224934L,1198076276L,415003748241L,146610388175180L,51602303242460441L,18184674267197745416UL,BigInteger.Parse("6407249556340878009729"),BigInteger.Parse("2257732956802944727095141"),BigInteger.Parse("795558276694503198933970657") };
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
public class A189309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189309.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189309Inst Instance=new A189309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189310
{
public static readonly BigInteger[] Value={ 21L,64554L,47862876L,51426223446L,50887086987153L,51602303242460441L,BigInteger.Parse("52114841233680255776"),BigInteger.Parse("52723822292058373369892"),BigInteger.Parse("53334566247423719719274768"),BigInteger.Parse("53960411851826546879505032814"),BigInteger.Parse("54594452516600107067153896876896") };
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
public class A189310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189310Inst Instance=new A189310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189311
{
public static readonly BigInteger[] Value={ 34L,351521L,710856569L,2208514085834L,6245362716915409L,18184674267197745416UL,BigInteger.Parse("52723822292058373369892"),BigInteger.Parse("153220700522675894994117846"),BigInteger.Parse("445293170067952800448783450060"),BigInteger.Parse("1294456714606839116930081199704670") };
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
public class A189311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189311.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189311Inst Instance=new A189311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189312
{
public static readonly long[] Value={ 1L,2L,2L,3L,14L,3L,5L,73L,73L,5L,8L,400L,960L,400L,8L,13L,2177L,14714L,14714L,2177L,13L,21L,11854L,216708L,654049L,216708L,11854L,21L,34L,64554L,3224934L,27850597L,27850597L,3224934L,64554L,34L,55L,351521L,47862876L,1198076276L,3373180708L,1198076276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189312Inst : IEnumerable<long>
{
public static readonly long[] Value=A189312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189312.Bytes);
public long this[int i]=>Value[i];

public static A189312Inst Instance=new A189312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189313
{
public static readonly long[] Value={ 2L,97L,127L,157L,199L,227L,241L,277L,307L,313L,331L,367L,379L,397L,409L,457L,467L,487L,547L,617L,619L,643L,647L,709L,727L,739L,757L,773L,787L,797L,829L,877L,883L,907L,967L,977L,1033L,1039L,1069L,1087L,1117L,1123L,1171L,1193L,1237L,1249L,1277L,1291L,1297L,1303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189313Inst : IEnumerable<long>
{
public static readonly long[] Value=A189313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189313.Bytes);
public long this[int i]=>Value[i];

public static A189313Inst Instance=new A189313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189314
{
public static readonly long[] Value={ 1L,4L,8L,52L,82L,128L,136L,142L,172L,178L,192L,214L,232L,262L,292L,304L,332L,346L,352L,382L,388L,412L,448L,472L,478L,484L,500L,502L,542L,556L,586L,592L,604L,622L,632L,640L,652L,676L,712L,724L,752L,766L,772L,802L,808L,832L,838L,841L,862L,864L,916L,922L,934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189314Inst : IEnumerable<long>
{
public static readonly long[] Value=A189314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189314.Bytes);
public long this[int i]=>Value[i];

public static A189314Inst Instance=new A189314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189315
{
public static readonly long[] Value={ 5L,10L,30L,100L,350L,1250L,4500L,16250L,58750L,212500L,768750L,2781250L,10062500L,36406250L,131718750L,476562500L,1724218750L,6238281250L,22570312500L,81660156250L,295449218750L,1068945312500L,3867480468750L,13992675781250L,50625976562500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189315Inst : IEnumerable<long>
{
public static readonly long[] Value=A189315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189315.Bytes);
public long this[int i]=>Value[i];

public static A189315Inst Instance=new A189315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189316
{
public static readonly long[] Value={ 5L,5L,15L,35L,95L,245L,645L,1685L,4415L,11555L,30255L,79205L,207365L,542885L,1421295L,3720995L,9741695L,25504085L,66770565L,174807605L,457652255L,1198149155L,3136795215L,8212236485L,21499914245L,56287506245L,147362604495L,385800307235L,1010038317215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189316Inst : IEnumerable<long>
{
public static readonly long[] Value=A189316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189316.Bytes);
public long this[int i]=>Value[i];

public static A189316Inst Instance=new A189316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189317
{
public static readonly long[] Value={ 5L,20L,180L,1700L,16100L,152500L,1444500L,13682500L,129602500L,1227612500L,11628112500L,110143062500L,1043290062500L,9882185312500L,93605402812500L,886643101562500L,8398404001562500L,79550824507812500L,753516225070312500L,7137408128164062500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189317Inst : IEnumerable<long>
{
public static readonly long[] Value=A189317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189317.Bytes);
public long this[int i]=>Value[i];

public static A189317Inst Instance=new A189317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189318
{
public static readonly long[] Value={ 5L,5L,25L,65L,225L,705L,2305L,7425L,24065L,77825L,251905L,815105L,2637825L,8536065L,27623425L,89391105L,289275905L,936116225L,3029336065L,9803137025L,31723618305L,102659784705L,332214042625L,1075067224065L,3478990618625L,11258250133505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189318Inst : IEnumerable<long>
{
public static readonly long[] Value=A189318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189318.Bytes);
public long this[int i]=>Value[i];

public static A189318Inst Instance=new A189318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189319
{
public static readonly long[] Value={ 2L,6L,11L,32L,54L,179L,253L,866L,1161L,3234L,4100L,12289L,11179L,28957L,35448L,81956L,60820L,184122L,127607L,389213L,298758L,584334L,434068L,1773649L,705685L,1778949L,1505153L,3979185L,1735705L,7116031L,2564548L,11409548L,5647305L,10489351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189319Inst : IEnumerable<long>
{
public static readonly long[] Value=A189319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189319.Bytes);
public long this[int i]=>Value[i];

public static A189319Inst Instance=new A189319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189320
{
public static readonly long[] Value={ 5L,7L,11L,16L,22L,28L,34L,40L,46L,52L,58L,64L,70L,76L,82L,88L,94L,100L,106L,112L,118L,124L,130L,136L,142L,148L,154L,160L,166L,172L,178L,184L,190L,196L,202L,208L,214L,220L,226L,232L,238L,244L,250L,256L,262L,268L,274L,280L,286L,292L,298L,304L,310L,316L,322L,328L,334L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189320Inst : IEnumerable<long>
{
public static readonly long[] Value=A189320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189320.Bytes);
public long this[int i]=>Value[i];

public static A189320Inst Instance=new A189320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189321
{
public static readonly long[] Value={ 7L,12L,20L,32L,49L,70L,94L,120L,148L,178L,210L,244L,280L,318L,358L,400L,444L,490L,538L,588L,640L,694L,750L,808L,868L,930L,994L,1060L,1128L,1198L,1270L,1344L,1420L,1498L,1578L,1660L,1744L,1830L,1918L,2008L,2100L,2194L,2290L,2388L,2488L,2590L,2694L,2800L,2908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189321Inst : IEnumerable<long>
{
public static readonly long[] Value=A189321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189321.Bytes);
public long this[int i]=>Value[i];

public static A189321Inst Instance=new A189321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189322
{
public static readonly long[] Value={ 8L,12L,21L,33L,54L,84L,119L,157L,195L,233L,271L,309L,347L,385L,423L,461L,499L,537L,575L,613L,651L,689L,727L,765L,803L,841L,879L,917L,955L,993L,1031L,1069L,1107L,1145L,1183L,1221L,1259L,1297L,1335L,1373L,1411L,1449L,1487L,1525L,1563L,1601L,1639L,1677L,1715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189322Inst : IEnumerable<long>
{
public static readonly long[] Value=A189322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189322.Bytes);
public long this[int i]=>Value[i];

public static A189322Inst Instance=new A189322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189323
{
public static readonly long[] Value={ 10L,18L,36L,64L,110L,179L,275L,393L,528L,676L,836L,1008L,1192L,1388L,1596L,1816L,2048L,2292L,2548L,2816L,3096L,3388L,3692L,4008L,4336L,4676L,5028L,5392L,5768L,6156L,6556L,6968L,7392L,7828L,8276L,8736L,9208L,9692L,10188L,10696L,11216L,11748L,12292L,12848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189323Inst : IEnumerable<long>
{
public static readonly long[] Value=A189323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189323.Bytes);
public long this[int i]=>Value[i];

public static A189323Inst Instance=new A189323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189404
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,11L,13L,14L,16L,17L,18L,20L,22L,23L,25L,26L,27L,29L,30L,32L,34L,35L,37L,38L,39L,41L,42L,45L,46L,47L,49L,50L,51L,53L,55L,56L,58L,59L,61L,62L,63L,65L,67L,68L,70L,71L,73L,74L,75L,78L,79L,80L,82L,83L,84L,86L,87L,90L,91L,92L,94L,95L,96L,98L,100L,102L,103L,104L,106L,107L,108L,111L,112L,113L,115L,116L,118L,119L,120L,123L,124L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189404Inst : IEnumerable<long>
{
public static readonly long[] Value=A189404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189404.Bytes);
public long this[int i]=>Value[i];

public static A189404Inst Instance=new A189404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189405
{
public static readonly long[] Value={ 3L,8L,13L,16L,21L,26L,31L,34L,39L,44L,49L,52L,57L,62L,65L,70L,75L,80L,83L,88L,93L,98L,101L,106L,111L,116L,119L,124L,129L,132L,137L,142L,147L,150L,155L,160L,165L,168L,173L,178L,183L,186L,191L,196L,199L,204L,209L,214L,217L,222L,227L,232L,235L,240L,245L,248L,253L,258L,263L,266L,271L,276L,281L,284L,289L,294L,299L,302L,307L,312L,315L,320L,325L,330L,333L,338L,343L,348L,351L,356L,361L,366L,369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189405Inst : IEnumerable<long>
{
public static readonly long[] Value=A189405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189405.Bytes);
public long this[int i]=>Value[i];

public static A189405Inst Instance=new A189405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189406
{
public static readonly long[] Value={ 5L,11L,18L,23L,29L,36L,42L,47L,54L,60L,67L,72L,78L,85L,90L,96L,103L,109L,114L,121L,127L,134L,139L,145L,152L,158L,163L,170L,176L,181L,188L,194L,201L,206L,212L,219L,225L,230L,237L,243L,250L,255L,261L,268L,273L,279L,286L,292L,297L,304L,310L,317L,322L,328L,335L,340L,346L,353L,359L,364L,371L,377L,384L,389L,395L,402L,408L,413L,420L,426L,431L,438L,444L,451L,456L,462L,469L,475L,480L,487L,493L,500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189406Inst : IEnumerable<long>
{
public static readonly long[] Value=A189406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189406.Bytes);
public long this[int i]=>Value[i];

public static A189406Inst Instance=new A189406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189407
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,12L,14L,15L,17L,19L,20L,22L,24L,25L,27L,28L,30L,32L,33L,35L,37L,38L,40L,41L,43L,45L,46L,48L,50L,51L,53L,55L,56L,58L,59L,61L,63L,64L,66L,68L,69L,71L,73L,74L,76L,77L,79L,81L,82L,84L,86L,87L,89L,91L,92L,94L,95L,97L,99L,100L,102L,104L,105L,107L,108L,110L,112L,113L,115L,117L,118L,120L,122L,123L,125L,126L,128L,130L,131L,133L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189407Inst : IEnumerable<long>
{
public static readonly long[] Value=A189407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189407.Bytes);
public long this[int i]=>Value[i];

public static A189407Inst Instance=new A189407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189408
{
public static readonly long[] Value={ 1181895L,43730115L,416690995L,1880394945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189408Inst : IEnumerable<long>
{
public static readonly long[] Value=A189408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189408.Bytes);
public long this[int i]=>Value[i];

public static A189408Inst Instance=new A189408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189409
{
public static readonly BigInteger[] Value={ 2L,5L,37L,901L,44101L,5336101L,901800901L,260620460101L,94083986096101L,49770428644836901L,BigInteger.Parse("41856930490307832901"),BigInteger.Parse("40224510201185827416901"),BigInteger.Parse("55067354465423397733736101"),BigInteger.Parse("92568222856376731590410384101") };
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
public class A189409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189409Inst Instance=new A189409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189410
{
public static readonly BigInteger[] Value={ 30L,224L,31248L,3104896L,1648898363392L,9007070406180864L,648516009881239552L,BigInteger.Parse("74276402290253369241782714368"),BigInteger.Parse("183899464903906662846152739755417029065034185182550163456"),BigInteger.Parse("521712837267651850100441428388555336932039109444807734641004395552458397047586816") };
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
public class A189410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189410Inst Instance=new A189410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189411
{
public static readonly long[] Value={ 5L,13L,17L,37L,53L,61L,73L,97L,157L,193L,241L,277L,313L,337L,397L,421L,457L,541L,577L,613L,661L,673L,733L,757L,877L,997L,1093L,1153L,1201L,1213L,1237L,1249L,1321L,1381L,1453L,1621L,1657L,1753L,1873L,1933L,1993L,2017L,2137L,2341L,2473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189411Inst : IEnumerable<long>
{
public static readonly long[] Value=A189411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189411.Bytes);
public long this[int i]=>Value[i];

public static A189411Inst Instance=new A189411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189412
{
public static readonly long[] Value={ 0L,0L,24L,720L,6300L,34812L,135552L,436944L,1198968L,2929656L,6516984L,13502448L,26208516L,48407988L,85481280L,145200888L,238502808L,380729160L,591761304L,899049096L,1336994100L,1950873276L,2798226336L,3952174032L,5500597632L,7555866072L,10253438688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189412Inst : IEnumerable<long>
{
public static readonly long[] Value=A189412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189412.Bytes);
public long this[int i]=>Value[i];

public static A189412Inst Instance=new A189412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189413
{
public static readonly long[] Value={ 0L,1L,70L,1038L,7398L,35727L,130768L,400116L,1062016L,2531001L,5529310L,11272710L,21639022L,39559591L,69283632L,116910052L,190977408L,303286461L,469431366L,710400658L,1053055398L,1532253131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189413Inst : IEnumerable<long>
{
public static readonly long[] Value=A189413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189413.Bytes);
public long this[int i]=>Value[i];

public static A189413Inst Instance=new A189413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189414
{
public static readonly long[] Value={ 0L,1L,94L,1758L,13698L,70539L,266320L,837060L,2260984L,5460657L,12046294L,24775158L,47847538L,87967579L,154764912L,262110940L,429480216L,684015621L,1061192670L,1609449754L,2390049498L,3483126407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189414Inst : IEnumerable<long>
{
public static readonly long[] Value=A189414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189414.Bytes);
public long this[int i]=>Value[i];

public static A189414Inst Instance=new A189414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189415
{
public static readonly long[] Value={ 0L,1L,50L,490L,2618L,9519L,28432L,70796L,157912L,321161L,610482L,1082570L,1848362L,3003015L,4716792L,7204604L,10730528L,15530189L,22093410L,30723078L,42146178L,56981411L,75952240L,99685104L,129757248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189415Inst : IEnumerable<long>
{
public static readonly long[] Value=A189415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189415.Bytes);
public long this[int i]=>Value[i];

public static A189415Inst Instance=new A189415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189416
{
public static readonly long[] Value={ 0L,1L,22L,158L,674L,2159L,5664L,13004L,26904L,51401L,92094L,156710L,255090L,400359L,608656L,900100L,1299336L,1836461L,2546550L,3472162L,4661898L,6173123L,8071952L,10434600L,13346080L,16905033L,21221558L,26419338L,32636098L,40027283L,48761448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189416Inst : IEnumerable<long>
{
public static readonly long[] Value=A189416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189416.Bytes);
public long this[int i]=>Value[i];

public static A189416Inst Instance=new A189416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189417
{
public static readonly long[] Value={ 0L,1L,10L,58L,222L,631L,1584L,3340L,6504L,11697L,19978L,31922L,49822L,74167L,107672L,152484L,211944L,286725L,383578L,502262L,651526L,833979L,1056104L,1318104L,1637336L,2011577L,2452634L,2965902L,3568086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189417Inst : IEnumerable<long>
{
public static readonly long[] Value=A189417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189417.Bytes);
public long this[int i]=>Value[i];

public static A189417Inst Instance=new A189417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189418
{
public static readonly long[] Value={ 0L,1L,6L,22L,66L,151L,312L,564L,984L,1601L,2478L,3622L,5242L,7271L,9856L,13124L,17296L,22229L,28286L,35306L,43850L,53891L,65520L,78624L,94272L,111977L,131990L,154514L,180290L,208611L,240840L,276032L,315720L,359497L,407470L,460078L,519018L,582447L,651232L,725820L,808416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189418Inst : IEnumerable<long>
{
public static readonly long[] Value=A189418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189418.Bytes);
public long this[int i]=>Value[i];

public static A189418Inst Instance=new A189418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189419
{
public static readonly long[] Value={ 1L,2L,9L,3L,7L,10L,34L,4L,15L,8L,26L,11L,31L,35L,110L,5L,57L,16L,68L,52L,41L,27L,63L,12L,47L,32L,100L,36L,106L,111L,209L,6L,23L,58L,88L,17L,124L,69L,82L,53L,145L,42L,118L,28L,397L,64L,95L,13L,76L,48L,152L,33L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189419Inst : IEnumerable<long>
{
public static readonly long[] Value=A189419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189419.Bytes);
public long this[int i]=>Value[i];

public static A189419Inst Instance=new A189419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189596
{
public static readonly long[] Value={ 1L,1L,1L,4L,10L,22L,63L,168L,398L,864L,1998L,4814L,11515L,27219L,64834L,155776L,370324L,875660L,2075443L,4937760L,11743610L,27890804L,66275841L,157582669L,374562749L,889810081L,2114058291L,5024124329L,11940009567L,28372771969L,67421703499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189596Inst : IEnumerable<long>
{
public static readonly long[] Value=A189596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189596.Bytes);
public long this[int i]=>Value[i];

public static A189596Inst Instance=new A189596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189597
{
public static readonly long[] Value={ 1L,1L,2L,4L,13L,35L,111L,293L,718L,1741L,4273L,10855L,27633L,71187L,182287L,465019L,1180545L,2992281L,7598016L,19309456L,49129136L,125000325L,318018255L,808823885L,2056605339L,5229131690L,13296028742L,33810904043L,85982027049L,218658167715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189597Inst : IEnumerable<long>
{
public static readonly long[] Value=A189597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189597.Bytes);
public long this[int i]=>Value[i];

public static A189597Inst Instance=new A189597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189598
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,35L,126L,368L,920L,2285L,5896L,15456L,41206L,111892L,304175L,816621L,2172175L,5772781L,15372397L,41000988L,109503212L,292725922L,782460503L,2090016819L,5579586307L,14894046299L,39762451293L,106166731292L,283495287002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189598Inst : IEnumerable<long>
{
public static readonly long[] Value=A189598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189598.Bytes);
public long this[int i]=>Value[i];

public static A189598Inst Instance=new A189598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189599
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,35L,144L,425L,1035L,2436L,6140L,16922L,49176L,144117L,410571L,1135249L,3089181L,8424096L,23191590L,64417192L,179639575L,500440977L,1389439997L,3846685210L,10639680698L,29446636078L,81589820105L,226250592841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189599Inst : IEnumerable<long>
{
public static readonly long[] Value=A189599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189599.Bytes);
public long this[int i]=>Value[i];

public static A189599Inst Instance=new A189599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189600
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,21L,37L,64L,111L,194L,339L,591L,1030L,1796L,3132L,5461L,9522L,16604L,28953L,50485L,88030L,153498L,267655L,466710L,813802L,1419027L,2474358L,4314538L,7523260L,13118310L,22874400L,39886095L,69549390L,121273283L,211464244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189600Inst : IEnumerable<long>
{
public static readonly long[] Value=A189600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189600.Bytes);
public long this[int i]=>Value[i];

public static A189600Inst Instance=new A189600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189601
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,51L,117L,250L,524L,1123L,2428L,5274L,11493L,24927L,54025L,117003L,253155L,548139L,1187354L,2572374L,5573514L,12074638L,26156163L,56658896L,122731402L,265858041L,575909407L,1247556710L,2702508126L,5854265152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189601Inst : IEnumerable<long>
{
public static readonly long[] Value=A189601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189601.Bytes);
public long this[int i]=>Value[i];

public static A189601Inst Instance=new A189601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189602
{
public static readonly long[] Value={ 1L,1L,1L,4L,13L,35L,89L,221L,499L,1146L,2755L,6750L,16570L,40293L,97355L,234629L,565632L,1365768L,3303221L,7992751L,19333657L,46743931L,112983171L,273083004L,660115058L,1595837810L,3858133501L,9327445000L,22549449187L,54512990509L,131783650621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189602Inst : IEnumerable<long>
{
public static readonly long[] Value=A189602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189602.Bytes);
public long this[int i]=>Value[i];

public static A189602Inst Instance=new A189602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189603
{
public static readonly BigInteger[] Value={ 1L,3L,20L,464L,30283L,5897476L,3394457868L,5778059258273L,29117129479453520L,BigInteger.Parse("434446215594380010575") };
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
public class A189603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189603Inst Instance=new A189603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189604
{
public static readonly long[] Value={ 1L,6L,20L,72L,256L,912L,3248L,11568L,41200L,146736L,522608L,1861296L,6629104L,23609904L,84087920L,299483568L,1066626544L,3798846768L,13529793392L,48187073712L,171620807920L,611236571184L,2176951329392L,7753327130544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189604Inst : IEnumerable<long>
{
public static readonly long[] Value=A189604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189604.Bytes);
public long this[int i]=>Value[i];

public static A189604Inst Instance=new A189604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189605
{
public static readonly long[] Value={ 1L,13L,72L,464L,2853L,17617L,108785L,671452L,4144996L,25586605L,157944449L,974979853L,6018479996L,37151644524L,229334423389L,1415664871777L,8738797243193L,53943965676260L,332992213004236L,2055536935944305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189605Inst : IEnumerable<long>
{
public static readonly long[] Value=A189605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189605.Bytes);
public long this[int i]=>Value[i];

public static A189605Inst Instance=new A189605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189606
{
public static readonly long[] Value={ 1L,28L,256L,2853L,30283L,321815L,3414588L,36212912L,383990913L,4071436782L,43168209556L,457694879893L,4852734814404L,51451313282657L,545514314383676L,5783833141059232L,61323273361025444L,650181923557415105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189606Inst : IEnumerable<long>
{
public static readonly long[] Value=A189606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189606.Bytes);
public long this[int i]=>Value[i];

public static A189606Inst Instance=new A189606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189607
{
public static readonly BigInteger[] Value={ 1L,60L,912L,17617L,321815L,5897476L,107793872L,1968061359L,35917517449L,655347656612L,11956214759290L,218119695889901L,3979116037755048L,72589531392230391L,1324217776135660990L,BigInteger.Parse("24157052394845982633") };
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
public class A189607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189607Inst Instance=new A189607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189608
{
public static readonly BigInteger[] Value={ 1L,129L,3248L,108785L,3414588L,107793872L,3394457868L,106717857552L,3352763054744L,105288130659056L,3305643786649888L,103772022994114688L,3257440136563770512L,BigInteger.Parse("102248757981895108688"),BigInteger.Parse("3209460671164514648880") };
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
public class A189608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189608Inst Instance=new A189608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189609
{
public static readonly BigInteger[] Value={ 1L,277L,11568L,671452L,36212912L,1968061359L,106717857552L,5778059258273L,312573095738121L,16898643737922425L,913264073225048477L,BigInteger.Parse("49345410349072594251"),BigInteger.Parse("2665888554266786412238"),BigInteger.Parse("144014204839657901069783") };
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
public class A189609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189609Inst Instance=new A189609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189610
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,6L,1L,1L,13L,20L,13L,1L,1L,28L,72L,72L,28L,1L,1L,60L,256L,464L,256L,60L,1L,1L,129L,912L,2853L,2853L,912L,129L,1L,1L,277L,3248L,17617L,30283L,17617L,3248L,277L,1L,1L,595L,11568L,108785L,321815L,321815L,108785L,11568L,595L,1L,1L,1278L,41200L,671452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189610Inst : IEnumerable<long>
{
public static readonly long[] Value=A189610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189610.Bytes);
public long this[int i]=>Value[i];

public static A189610Inst Instance=new A189610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189611
{
public static readonly BigInteger[] Value={ 2L,16L,292L,8496L,532565L,118571483L,61652076124L,52939317116118L,90112326418652948L,BigInteger.Parse("433430536108638364008"),BigInteger.Parse("5597804841379220076966699") };
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
public class A189611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189611Inst Instance=new A189611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189644
{
public static readonly long[] Value={ 3L,33L,263L,2161L,17655L,144353L,1180167L,9648721L,78885143L,644942273L,5272862503L,43109407281L,352450114615L,2881530764193L,23558566731847L,192608065601041L,1574708145738583L,12874360876413313L,105257071556189543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189644Inst : IEnumerable<long>
{
public static readonly long[] Value=A189644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189644.Bytes);
public long this[int i]=>Value[i];

public static A189644Inst Instance=new A189644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189645
{
public static readonly BigInteger[] Value={ 5L,185L,4277L,107080L,2631821L,64890337L,1598901325L,39401919001L,970964720320L,23927183356745L,589629702461885L,14530053018698289L,358059360274087325L,8823540150072892232L,BigInteger.Parse("217435624721745257829"),BigInteger.Parse("5358195248586080351465") };
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
public class A189645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189645Inst Instance=new A189645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189646
{
public static readonly BigInteger[] Value={ 8L,913L,55440L,3774889L,250758892L,16718653553L,1113666564608L,74192202677913L,4942510226322656L,329259659094878233L,BigInteger.Parse("21934564726533463456"),BigInteger.Parse("1461233359853832299585"),BigInteger.Parse("97344209607823094421972") };
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
public class A189646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189646Inst Instance=new A189646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189647
{
public static readonly BigInteger[] Value={ 13L,4777L,799069L,157346785L,30010432933L,5760755884032L,1104421532180261L,211788908613601649L,BigInteger.Parse("40611524427488470629"),BigInteger.Parse("7787535228500656118433"),BigInteger.Parse("1493309632024085211828077"),BigInteger.Parse("286351787186005572629329841") };
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
public class A189647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189647.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189647Inst Instance=new A189647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189648
{
public static readonly BigInteger[] Value={ 21L,24577L,11047585L,6156828073L,3292827578005L,1778231752192145L,958681588788944613L,BigInteger.Parse("517069529154777840681"),BigInteger.Parse("278864582730126081862829"),BigInteger.Parse("150399411952876520217908417"),BigInteger.Parse("81114338143785708962035111845") };
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
public class A189648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A189648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189648Inst Instance=new A189648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}