using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A248982
{
public static readonly long[] Value={ 1L,3L,2L,6L,13L,5L,26L,8L,53L,93L,21L,177L,34L,328L,55L,599L,89L,1079L,144L,1924L,233L,3401L,377L,5969L,610L,10412L,987L,18067L,1597L,31207L,2584L,53688L,4181L,92037L,6765L,157281L,10946L,268016L,17711L,455551L,28657L,772519L,46368L,1307276L,75025L,2207953L,121393L,3722593L,196418L,6266068L,317811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248982Inst : IEnumerable<long>
{
public static readonly long[] Value=A248982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248982.Bytes);
public long this[int i]=>Value[i];

public static A248982Inst Instance=new A248982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248983
{
public static readonly long[] Value={ 1L,5L,3L,15L,6L,30L,10L,50L,69L,21L,98L,28L,132L,36L,171L,45L,215L,55L,264L,66L,318L,78L,377L,91L,441L,105L,510L,120L,584L,136L,663L,153L,747L,817L,190L,910L,210L,1008L,231L,1111L,253L,1219L,276L,1332L,300L,1450L,325L,1573L,351L,1701L,378L,1834L,406L,1972L,435L,2115L,465L,2263L,496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248983Inst : IEnumerable<long>
{
public static readonly long[] Value=A248983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248983.Bytes);
public long this[int i]=>Value[i];

public static A248983Inst Instance=new A248983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248984
{
public static readonly long[] Value={ 1326L,1654L,2042L,2494L,3014L,3606L,4742L,6130L,7782L,9710L,11926L,16166L,21426L,27758L,35214L,43846L,60294L,80882L,105830L,135358L,169686L,234886L,316898L,416654L,535086L,673126L,934566L,1264322L,1666342L,2144574L,2702966L,3757734L,5090290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248984Inst : IEnumerable<long>
{
public static readonly long[] Value=A248984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248984.Bytes);
public long this[int i]=>Value[i];

public static A248984Inst Instance=new A248984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248985
{
public static readonly long[] Value={ 2817L,4137L,6065L,8873L,12937L,18737L,30017L,47953L,76161L,119849L,185817L,315929L,533433L,891593L,1468537L,2367257L,4153753L,7216889L,12373897L,20836977L,34213297L,60900465L,107177641L,185861593L,316071033L,523226617L,937146425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248985Inst : IEnumerable<long>
{
public static readonly long[] Value=A248985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248985.Bytes);
public long this[int i]=>Value[i];

public static A248985Inst Instance=new A248985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248986
{
public static readonly long[] Value={ 5028L,7964L,12644L,20128L,32094L,51166L,86800L,147582L,250880L,425828L,720138L,1273450L,2248778L,3960786L,6947868L,12117086L,21840962L,39264144L,70332606L,125391740L,222194472L,403889704L,732101414L,1322338468L,2377963158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248986Inst : IEnumerable<long>
{
public static readonly long[] Value=A248986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248986.Bytes);
public long this[int i]=>Value[i];

public static A248986Inst Instance=new A248986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248987
{
public static readonly long[] Value={ 2L,53L,2L,204L,53L,2L,585L,204L,53L,2L,1326L,585L,204L,53L,2L,2817L,1654L,585L,204L,53L,2L,5028L,4137L,2042L,585L,204L,53L,2L,8789L,7964L,6065L,2494L,585L,204L,53L,2L,13970L,14661L,12644L,8873L,3014L,585L,204L,53L,2L,21601L,23778L,24583L,20128L,12937L,3606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248987Inst : IEnumerable<long>
{
public static readonly long[] Value=A248987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248987.Bytes);
public long this[int i]=>Value[i];

public static A248987Inst Instance=new A248987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248988
{
public static readonly long[] Value={ 2L,53L,204L,585L,1326L,2817L,5028L,8789L,13970L,21601L,31512L,45353L,62194L,84725L,111556L,145697L,185598L,235249L,291740L,360701L,438402L,530913L,634224L,755745L,889506L,1045157L,1215548L,1410889L,1623630L,1865681L,2126932L,2422133L,2739634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248988Inst : IEnumerable<long>
{
public static readonly long[] Value=A248988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248988.Bytes);
public long this[int i]=>Value[i];

public static A248988Inst Instance=new A248988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248989
{
public static readonly long[] Value={ 2L,53L,204L,585L,1654L,4137L,7964L,14661L,23778L,39441L,60264L,90193L,126626L,176141L,239692L,322385L,419046L,539841L,675924L,853485L,1053130L,1293121L,1559752L,1873217L,2232130L,2653637L,3111812L,3639577L,4210230L,4884793L,5609564L,6430901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248989Inst : IEnumerable<long>
{
public static readonly long[] Value=A248989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248989.Bytes);
public long this[int i]=>Value[i];

public static A248989Inst Instance=new A248989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248990
{
public static readonly long[] Value={ 2L,53L,204L,585L,2042L,6065L,12644L,24583L,40878L,72399L,115668L,180421L,260514L,371185L,521910L,723925L,962888L,1263913L,1604166L,2067027L,2592298L,3230455L,3942088L,4781303L,5766434L,6934955L,8208132L,9682923L,11277354L,13209205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248990Inst : IEnumerable<long>
{
public static readonly long[] Value=A248990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248990.Bytes);
public long this[int i]=>Value[i];

public static A248990Inst Instance=new A248990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248991
{
public static readonly long[] Value={ 2L,53L,204L,585L,2494L,8873L,20128L,41419L,70770L,133223L,222176L,361717L,538634L,788117L,1143690L,1636069L,2229208L,2986485L,3852114L,5061161L,6453778L,8167835L,10095656L,12387261L,15118434L,18394433L,21989412L,26180385L,30730830L,36337853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248991Inst : IEnumerable<long>
{
public static readonly long[] Value=A248991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248991.Bytes);
public long this[int i]=>Value[i];

public static A248991Inst Instance=new A248991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248992
{
public static readonly long[] Value={ 2L,53L,204L,585L,3014L,12937L,32094L,70037L,123076L,245471L,426828L,726053L,1117244L,1682603L,2516548L,3710543L,5180912L,7091467L,9311842L,12467375L,16165280L,20786881L,26043958L,32368635L,39971764L,49206501L,59436930L,71456833L,84599994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248992Inst : IEnumerable<long>
{
public static readonly long[] Value=A248992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248992.Bytes);
public long this[int i]=>Value[i];

public static A248992Inst Instance=new A248992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248993
{
public static readonly long[] Value={ 2L,53L,204L,585L,3606L,18737L,51166L,118685L,214530L,452471L,819664L,1457951L,2322068L,3606075L,5552828L,8435185L,12070626L,16889399L,22604370L,30828023L,40644920L,53118537L,67488086L,85033849L,106229450L,132318767L,161530092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248993Inst : IEnumerable<long>
{
public static readonly long[] Value=A248993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248993.Bytes);
public long this[int i]=>Value[i];

public static A248993Inst Instance=new A248993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248994
{
public static readonly long[] Value={ 2L,53L,204L,585L,4742L,30017L,86800L,206989L,376806L,854053L,1617708L,2998849L,4902560L,7778539L,12440676L,19535371L,28611276L,40771083L,55318846L,77181365L,103633374L,137581435L,176929022L,225283535L,285422254L,360064143L,444125526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248994Inst : IEnumerable<long>
{
public static readonly long[] Value=A248994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248994.Bytes);
public long this[int i]=>Value[i];

public static A248994Inst Instance=new A248994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248995
{
public static readonly long[] Value={ 190L,464L,1140L,2802L,6872L,16800L,41084L,100590L,246378L,603406L,1477382L,3616932L,8855718L,21683810L,53094696L,130003772L,318312974L,779389186L,1908348180L,4672636566L,11441043846L,28013571820L,68591653930L,167947819478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248995Inst : IEnumerable<long>
{
public static readonly long[] Value=A248995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248995.Bytes);
public long this[int i]=>Value[i];

public static A248995Inst Instance=new A248995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248996
{
public static readonly long[] Value={ 820L,2668L,8680L,28240L,91888L,299044L,973204L,3167500L,10309372L,33554728L,109215076L,355477276L,1157029012L,3765974644L,12257760052L,39897482020L,129861371368L,422682950584L,1375781835724L,4478003930896L,14575364597464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248996Inst : IEnumerable<long>
{
public static readonly long[] Value=A248996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248996.Bytes);
public long this[int i]=>Value[i];

public static A248996Inst Instance=new A248996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248997
{
public static readonly long[] Value={ 2540L,10360L,42308L,172888L,706704L,2888944L,11810564L,48286456L,197422012L,807188768L,3300330556L,13494048552L,55173290154L,225588339824L,922369809354L,3771323457556L,15419939994758L,63048058448056L,257786893864722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248997Inst : IEnumerable<long>
{
public static readonly long[] Value=A248997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248997.Bytes);
public long this[int i]=>Value[i];

public static A248997Inst Instance=new A248997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248998
{
public static readonly long[] Value={ 6450L,32398L,163112L,822348L,4149708L,20952218L,105819690L,534502810L,2700047696L,13640156760L,68910290082L,348142872600L,1758874033678L,8886170481316L,44894831402844L,226818881138008L,1145942126329774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248998Inst : IEnumerable<long>
{
public static readonly long[] Value=A248998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248998.Bytes);
public long this[int i]=>Value[i];

public static A248998Inst Instance=new A248998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248999
{
public static readonly long[] Value={ 13990L,82348L,485580L,2865126L,16909524L,99817384L,589354152L,3479916010L,20548067494L,121333048614L,716461085260L,4230692840640L,24982283288368L,147520857046232L,871114227605828L,5143954672207112L,30375223032465730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248999Inst : IEnumerable<long>
{
public static readonly long[] Value=A248999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248999.Bytes);
public long this[int i]=>Value[i];

public static A248999Inst Instance=new A248999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249000
{
public static readonly long[] Value={ 27740L,189660L,1298968L,8902860L,61034658L,418454994L,2869206494L,19673497892L,134897701458L,924972633722L,6342399495490L,43489021952576L,298198855766202L,2044713089447888L,14020347915273238L,96135813057541116L,659191600029773658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249000Inst : IEnumerable<long>
{
public static readonly long[] Value=A249000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249000.Bytes);
public long this[int i]=>Value[i];

public static A249000Inst Instance=new A249000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249001
{
public static readonly long[] Value={ 30L,190L,58L,820L,464L,112L,2540L,2668L,1140L,216L,6450L,10360L,8680L,2802L,416L,13990L,32398L,42308L,28240L,6872L,802L,27740L,82348L,163112L,172888L,91888L,16800L,1546L,50260L,189660L,485580L,822348L,706704L,299044L,41084L,2980L,86030L,387900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249001Inst : IEnumerable<long>
{
public static readonly long[] Value=A249001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249001.Bytes);
public long this[int i]=>Value[i];

public static A249001Inst Instance=new A249001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249002
{
public static readonly long[] Value={ 30L,190L,820L,2540L,6450L,13990L,27740L,50260L,86030L,139450L,217320L,325940L,475630L,674650L,937020L,1274160L,1703970L,2240850L,2908260L,3723400L,4715230L,5905430L,7328400L,9009880L,10991870L,13303750L,15994820L,19100260L,22676370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249002Inst : IEnumerable<long>
{
public static readonly long[] Value=A249002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249002.Bytes);
public long this[int i]=>Value[i];

public static A249002Inst Instance=new A249002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249003
{
public static readonly long[] Value={ 58L,464L,2668L,10360L,32398L,82348L,189660L,387900L,744378L,1335780L,2289960L,3737824L,5914730L,9025016L,13447116L,19506256L,27749742L,38646260L,53006324L,71470164L,95143346L,124907012L,162219976L,208226592L,264893594L,333635648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249003Inst : IEnumerable<long>
{
public static readonly long[] Value=A249003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249003.Bytes);
public long this[int i]=>Value[i];

public static A249003Inst Instance=new A249003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249004
{
public static readonly long[] Value={ 112L,1140L,8680L,42308L,163112L,485580L,1298968L,2997774L,6449496L,12811158L,24159584L,42911184L,73629888L,120844328L,193152322L,298869080L,452268778L,666984964L,966771826L,1372738118L,1920965096L,2643444158L,3592832436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249004Inst : IEnumerable<long>
{
public static readonly long[] Value=A249004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249004.Bytes);
public long this[int i]=>Value[i];

public static A249004Inst Instance=new A249004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249005
{
public static readonly long[] Value={ 216L,2802L,28240L,172888L,822348L,2865126L,8902860L,23177368L,55906496L,122921570L,254998668L,492803174L,916912140L,1618570176L,2775224082L,4580364152L,7372967710L,11513855042L,17636594106L,26371506592L,38792087628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249005Inst : IEnumerable<long>
{
public static readonly long[] Value=A249005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249005.Bytes);
public long this[int i]=>Value[i];

public static A249005Inst Instance=new A249005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249006
{
public static readonly long[] Value={ 416L,6872L,91888L,706704L,4149708L,16909524L,61034658L,179220600L,484680810L,1179584718L,2691862296L,5660060962L,11419487998L,21680491596L,39877845854L,70202009284L,120203803140L,198769546216L,321758154748L,506644858160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249006Inst : IEnumerable<long>
{
public static readonly long[] Value=A249006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249006.Bytes);
public long this[int i]=>Value[i];

public static A249006Inst Instance=new A249006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249007
{
public static readonly long[] Value={ 802L,16800L,299044L,2888944L,20952218L,99817384L,418454994L,1385871140L,4201910020L,11319995234L,28417289280L,65009432892L,142222105640L,290405064290L,573014867750L,1075969706928L,1959720585922L,3431451616020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249007Inst : IEnumerable<long>
{
public static readonly long[] Value=A249007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249007.Bytes);
public long this[int i]=>Value[i];

public static A249007Inst Instance=new A249007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249008
{
public static readonly long[] Value={ 1546L,41084L,973204L,11810564L,105819690L,589354152L,2869206494L,10716918348L,36428481062L,108634995458L,299997171280L,746679315998L,1771285007396L,3889902082248L,8233803171560L,16491148207236L,31949943270148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249008Inst : IEnumerable<long>
{
public static readonly long[] Value=A249008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249008.Bytes);
public long this[int i]=>Value[i];

public static A249008Inst Instance=new A249008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249009
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,1L,9L,1L,10L,11L,13L,14L,15L,16L,17L,18L,19L,20L,2L,3L,3L,4L,3L,5L,3L,6L,3L,7L,3L,8L,3L,9L,3L,10L,21L,4L,4L,5L,4L,6L,4L,7L,4L,8L,4L,9L,4L,10L,23L,5L,5L,6L,5L,7L,5L,8L,5L,9L,5L,10L,24L,6L,6L,7L,6L,8L,6L,9L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249009Inst : IEnumerable<long>
{
public static readonly long[] Value=A249009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249009.Bytes);
public long this[int i]=>Value[i];

public static A249009Inst Instance=new A249009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249010
{
public static readonly long[] Value={ 1L,-3L,0L,-12L,6L,-3L,0L,-24L,18L,-39L,0L,-36L,24L,-42L,0L,-12L,42L,-54L,0L,-60L,6L,-96L,0L,-72L,72L,-3L,0L,-120L,48L,-90L,0L,-96L,90L,-144L,0L,-24L,78L,-114L,0L,-168L,18L,-126L,0L,-132L,72L,-39L,0L,-144L,168L,-171L,0L,-216L,84L,-162L,0L,-36L,144L,-240L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249010Inst : IEnumerable<long>
{
public static readonly long[] Value=A249010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249010.Bytes);
public long this[int i]=>Value[i];

public static A249010Inst Instance=new A249010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249011
{
public static readonly long[] Value={ 3L,5L,59L,839L,541L,60453409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249011Inst : IEnumerable<long>
{
public static readonly long[] Value=A249011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249011.Bytes);
public long this[int i]=>Value[i];

public static A249011Inst Instance=new A249011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249012
{
public static readonly long[] Value={ 3L,5L,3L,23L,11L,13L,23L,263L,304349L,5644939L,151L,5644927L,18068879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249012Inst : IEnumerable<long>
{
public static readonly long[] Value=A249012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249012.Bytes);
public long this[int i]=>Value[i];

public static A249012Inst Instance=new A249012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249013
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,5L,6L,8L,10L,12L,15L,17L,20L,23L,26L,30L,33L,37L,41L,45L,50L,54L,59L,64L,69L,75L,80L,86L,92L,98L,105L,111L,118L,125L,132L,140L,147L,155L,163L,171L,180L,188L,197L,206L,215L,225L,234L,244L,254L,264L,275L,285L,296L,307L,318L,330L,341L,353L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249013Inst : IEnumerable<long>
{
public static readonly long[] Value=A249013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249013.Bytes);
public long this[int i]=>Value[i];

public static A249013Inst Instance=new A249013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249014
{
public static readonly BigInteger[] Value={ 1L,3L,15L,105L,933L,9951L,123123L,1727685L,27050985L,466795323L,8791179831L,179262508833L,3931730998605L,92237649141015L,2303515063987803L,60987344488950141L,1705641174191204433L,BigInteger.Parse("50228924171214633075"),BigInteger.Parse("1553143164997199612895") };
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
public class A249014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249014Inst Instance=new A249014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249015
{
public static readonly long[] Value={ 1L,1L,5L,17L,69L,339L,1677L,9321L,55137L,343659L,2285289L,15910857L,116120781L,886308147L,7033465989L,58008074409L,495792941337L,4381170220251L,39980186877537L,376025841184329L,3640077999981189L,36224841818288547L,370112212444620861L,3878334404076375657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249015Inst : IEnumerable<long>
{
public static readonly long[] Value=A249015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249015.Bytes);
public long this[int i]=>Value[i];

public static A249015Inst Instance=new A249015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249016
{
public static readonly long[] Value={ 1L,2L,3L,5L,13L,17L,21L,23L,33L,42L,43L,56L,57L,75L,84L,99L,101L,105L,109L,119L,133L,139L,157L,162L,163L,182L,183L,207L,208L,219L,220L,255L,257L,263L,267L,303L,305L,307L,315L,340L,341L,343L,383L,385L,387L,397L,411L,420L,421L,423L,469L,483L,485L,489L,505L,519L,523L,547L,552L,553L,581L,602L,603L,609L,618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249016Inst : IEnumerable<long>
{
public static readonly long[] Value=A249016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249016.Bytes);
public long this[int i]=>Value[i];

public static A249016Inst Instance=new A249016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249017
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,34L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,63L,64L,65L,67L,68L,69L,70L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,85L,86L,87L,88L,91L,93L,95L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249017Inst : IEnumerable<long>
{
public static readonly long[] Value=A249017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249017.Bytes);
public long this[int i]=>Value[i];

public static A249017Inst Instance=new A249017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249018
{
public static readonly long[] Value={ 2L,5L,4L,5L,0L,5L,5L,2L,3L,5L,6L,5L,3L,1L,9L,5L,1L,3L,3L,7L,0L,8L,8L,1L,7L,7L,0L,0L,3L,1L,5L,4L,6L,1L,5L,6L,0L,4L,6L,4L,9L,3L,7L,4L,1L,7L,2L,5L,0L,6L,1L,9L,4L,4L,4L,9L,8L,4L,5L,5L,0L,0L,0L,6L,3L,8L,6L,3L,8L,9L,2L,3L,9L,0L,0L,8L,8L,3L,1L,6L,8L,6L,0L,0L,2L,5L,8L,1L,2L,2L,6L,3L,5L,5L,8L,6L,1L,8L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249018Inst : IEnumerable<long>
{
public static readonly long[] Value=A249018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249018.Bytes);
public long this[int i]=>Value[i];

public static A249018Inst Instance=new A249018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249019
{
public static readonly long[] Value={ 1L,3L,9L,27L,81L,243L,540L,1440L,3804L,9960L,25908L,67344L,175884L,458832L,1196364L,3119304L,8134164L,21212832L,55316892L,144249168L,376159644L,980918904L,2557958964L,6670420704L,17394543180L,45359994336L,118285895244L,308455762488L,804364332180L,2097551985168L,5469815336796L,14263713072192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249019Inst : IEnumerable<long>
{
public static readonly long[] Value=A249019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249019.Bytes);
public long this[int i]=>Value[i];

public static A249019Inst Instance=new A249019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249020
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,7L,9L,11L,13L,16L,18L,21L,24L,27L,31L,34L,38L,42L,46L,51L,55L,60L,65L,70L,76L,81L,87L,93L,99L,106L,112L,119L,126L,133L,141L,148L,156L,164L,172L,181L,189L,198L,207L,216L,226L,235L,245L,255L,265L,276L,286L,297L,308L,319L,331L,342L,354L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249020Inst : IEnumerable<long>
{
public static readonly long[] Value=A249020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249020.Bytes);
public long this[int i]=>Value[i];

public static A249020Inst Instance=new A249020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249021
{
public static readonly long[] Value={ 7L,38L,117L,18L,268L,515L,70L,882L,32L,182L,99L,29718L,2072L,1068L,43L,2943L,378L,500L,5604L,4030L,4005L,8890182L,776L,5357L,57L,1744L,6948L,113582L,4832118L,8827L,1118L,1111225770L,68L,1764132L,11018L,3141L,251L,13545L,1710L,23156L,71011068L,16432L,6072L,82L,1407L,8920484118L,1063532L,19703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249021Inst : IEnumerable<long>
{
public static readonly long[] Value=A249021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249021.Bytes);
public long this[int i]=>Value[i];

public static A249021Inst Instance=new A249021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249022
{
public static readonly long[] Value={ 4L,6L,6L,5L,9L,9L,3L,0L,6L,2L,0L,3L,7L,2L,9L,2L,6L,5L,2L,2L,1L,7L,3L,4L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249022Inst : IEnumerable<long>
{
public static readonly long[] Value=A249022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249022.Bytes);
public long this[int i]=>Value[i];

public static A249022Inst Instance=new A249022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249023
{
public static readonly long[] Value={ 9L,9L,4L,3L,2L,2L,8L,7L,4L,7L,3L,3L,4L,6L,3L,9L,2L,8L,0L,8L,1L,5L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249023Inst : IEnumerable<long>
{
public static readonly long[] Value=A249023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249023.Bytes);
public long this[int i]=>Value[i];

public static A249023Inst Instance=new A249023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249024
{
public static readonly long[] Value={ 1L,-1L,1L,1L,1L,-1L,-13L,7L,7453L,6669L,-114753L,-123387L,-7307779L,4681807L,37377631L,3949479L,-309016992029L,-139291594927L,1061523546157L,562200661481L,12828113969679941L,-446763044161503L,-17777677128737999L,-3490123799181493L,7248496389957890833L,196409682891987107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249024Inst : IEnumerable<long>
{
public static readonly long[] Value=A249024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249024.Bytes);
public long this[int i]=>Value[i];

public static A249024Inst Instance=new A249024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249025
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,10L,12L,14L,15L,16L,18L,20L,22L,24L,25L,26L,28L,30L,32L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,52L,54L,55L,56L,58L,60L,62L,64L,65L,66L,68L,70L,72L,74L,75L,76L,78L,80L,82L,84L,85L,86L,88L,90L,92L,94L,95L,96L,98L,100L,102L,104L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249025Inst : IEnumerable<long>
{
public static readonly long[] Value=A249025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249025.Bytes);
public long this[int i]=>Value[i];

public static A249025Inst Instance=new A249025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249026
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,6L,4L,1L,2L,12L,24L,5L,1L,2L,24L,576L,120L,6L,1L,2L,48L,55296L,161280L,720L,7L,1L,2L,96L,36972288L,2781803520L,812851200L,5040L,8L,1L,2L,192L,6268637952000L,52260618977280L,994393803303936000L,61479419904000L,40320L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249026Inst : IEnumerable<long>
{
public static readonly long[] Value=A249026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249026.Bytes);
public long this[int i]=>Value[i];

public static A249026Inst Instance=new A249026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249027
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,6L,1L,2L,12L,24L,1L,2L,24L,576L,120L,1L,2L,48L,55296L,161280L,720L,1L,2L,96L,36972288L,2781803520L,812851200L,5040L,1L,2L,192L,6268637952000L,52260618977280L,994393803303936000L,61479419904000L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249027Inst : IEnumerable<long>
{
public static readonly long[] Value=A249027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249027.Bytes);
public long this[int i]=>Value[i];

public static A249027Inst Instance=new A249027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249028
{
public static readonly long[] Value={ 4L,24L,576L,36972288L,6268637952000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249028Inst : IEnumerable<long>
{
public static readonly long[] Value=A249028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249028.Bytes);
public long this[int i]=>Value[i];

public static A249028Inst Instance=new A249028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249029
{
public static readonly long[] Value={ -1L,2L,1L,2L,-1L,4L,-2L,3L,-2L,5L,-2L,4L,-3L,4L,-2L,3L,1L,2L,-1L,4L,-2L,4L,-3L,4L,-2L,3L,1L,1L,2L,-1L,2L,2L,-1L,4L,-2L,3L,-2L,5L,-2L,4L,-3L,5L,-3L,4L,-2L,3L,1L,1L,2L,-1L,2L,2L,-1L,3L,-1L,4L,-2L,3L,-2L,3L,1L,3L,-2L,3L,-2L,5L,-2L,4L,-3L,4L,-2L,3L,1L,2L,-1L,4L,-2L,4L,-3L,4L,-2L,4L,-1L,3L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249029Inst : IEnumerable<long>
{
public static readonly long[] Value=A249029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249029.Bytes);
public long this[int i]=>Value[i];

public static A249029Inst Instance=new A249029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249030
{
public static readonly long[] Value={ 2L,2L,2L,4L,3L,3L,2L,3L,4L,3L,2L,3L,5L,6L,6L,5L,5L,6L,6L,6L,4L,6L,6L,8L,7L,7L,6L,7L,8L,7L,4L,6L,6L,8L,7L,7L,6L,7L,8L,7L,3L,5L,5L,7L,6L,6L,5L,6L,7L,6L,3L,5L,5L,7L,6L,6L,5L,6L,7L,6L,3L,5L,5L,7L,6L,6L,5L,6L,7L,6L,4L,6L,6L,8L,7L,7L,6L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249030Inst : IEnumerable<long>
{
public static readonly long[] Value=A249030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249030.Bytes);
public long this[int i]=>Value[i];

public static A249030Inst Instance=new A249030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249031
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,10L,11L,12L,14L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,27L,28L,30L,31L,32L,34L,35L,36L,37L,38L,40L,41L,42L,44L,45L,46L,47L,48L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,77L,79L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,94L,95L,96L,97L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249031Inst : IEnumerable<long>
{
public static readonly long[] Value=A249031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249031.Bytes);
public long this[int i]=>Value[i];

public static A249031Inst Instance=new A249031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249032
{
public static readonly long[] Value={ 3L,6L,4L,5L,5L,6L,4L,6L,4L,6L,4L,5L,5L,6L,4L,5L,5L,6L,4L,5L,5L,6L,4L,6L,4L,6L,4L,5L,5L,6L,4L,6L,4L,6L,4L,5L,5L,6L,4L,6L,4L,6L,4L,5L,5L,6L,4L,5L,5L,6L,4L,5L,5L,6L,4L,6L,4L,6L,4L,5L,5L,6L,4L,5L,5L,6L,4L,5L,5L,6L,4L,6L,4L,6L,4L,5L,5L,6L,4L,5L,5L,6L,4L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249032Inst : IEnumerable<long>
{
public static readonly long[] Value=A249032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249032.Bytes);
public long this[int i]=>Value[i];

public static A249032Inst Instance=new A249032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249033
{
public static readonly long[] Value={ 2L,2L,5L,1L,11L,2L,7L,9L,4L,1L,5L,1L,16L,18L,9L,2L,10L,3L,32L,6L,30L,18L,1L,5L,1L,21L,7L,13L,52L,25L,48L,8L,29L,2L,3L,7L,3L,43L,15L,29L,103L,1L,1L,51L,43L,53L,1L,17L,59L,1L,5L,7L,15L,7L,86L,31L,59L,206L,3L,3L,102L,21L,65L,107L,2L,34L,118L,2L,10L,15L,30L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249033Inst : IEnumerable<long>
{
public static readonly long[] Value=A249033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249033.Bytes);
public long this[int i]=>Value[i];

public static A249033Inst Instance=new A249033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249034
{
public static readonly long[] Value={ 5L,13L,17L,21L,29L,37L,45L,49L,53L,61L,65L,69L,77L,81L,85L,93L,101L,109L,113L,117L,125L,133L,141L,145L,149L,157L,165L,173L,177L,181L,189L,193L,197L,205L,209L,213L,221L,229L,237L,241L,245L,253L,257L,261L,269L,273L,277L,285L,293L,301L,305L,309L,317L,321L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249034Inst : IEnumerable<long>
{
public static readonly long[] Value=A249034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249034.Bytes);
public long this[int i]=>Value[i];

public static A249034Inst Instance=new A249034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249035
{
public static readonly long[] Value={ 4L,0L,0L,9L,9L,8L,8L,8L,3L,6L,9L,9L,9L,3L,7L,5L,3L,4L,2L,3L,0L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249035Inst : IEnumerable<long>
{
public static readonly long[] Value=A249035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249035.Bytes);
public long this[int i]=>Value[i];

public static A249035Inst Instance=new A249035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249036
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,5L,6L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,13L,14L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L,38L,39L,39L,40L,40L,41L,41L,42L,42L,43L,43L,44L,44L,45L,45L,46L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249036Inst : IEnumerable<long>
{
public static readonly long[] Value=A249036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249036.Bytes);
public long this[int i]=>Value[i];

public static A249036Inst Instance=new A249036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249037
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,4L,5L,5L,6L,7L,7L,7L,8L,9L,9L,9L,10L,10L,11L,11L,12L,13L,13L,13L,14L,15L,15L,15L,16L,17L,17L,17L,18L,19L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,25L,25L,25L,26L,27L,27L,27L,28L,29L,29L,29L,30L,31L,31L,31L,32L,33L,33L,33L,34L,35L,35L,35L,36L,37L,37L,37L,38L,39L,39L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249037Inst : IEnumerable<long>
{
public static readonly long[] Value=A249037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249037.Bytes);
public long this[int i]=>Value[i];

public static A249037Inst Instance=new A249037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249038
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,4L,4L,5L,5L,5L,6L,7L,7L,7L,8L,9L,9L,10L,10L,11L,11L,11L,12L,13L,13L,13L,14L,15L,15L,15L,16L,17L,17L,17L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,23L,24L,25L,25L,25L,26L,27L,27L,27L,28L,29L,29L,29L,30L,31L,31L,31L,32L,33L,33L,33L,34L,35L,35L,35L,36L,37L,37L,37L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249038Inst : IEnumerable<long>
{
public static readonly long[] Value=A249038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249038.Bytes);
public long this[int i]=>Value[i];

public static A249038Inst Instance=new A249038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249039
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,17L,26L,37L,52L,70L,92L,120L,157L,200L,254L,323L,401L,490L,597L,719L,859L,1021L,1211L,1438L,1687L,1979L,2325L,2740L,3183L,3704L,4262L,4863L,5553L,6350L,7201L,8174L,9216L,10336L,11545L,12894L,14350L,15928L,17646L,19526L,21596L,23893L,26352L,29060L,32060L,35406L,39167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249039Inst : IEnumerable<long>
{
public static readonly long[] Value=A249039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249039.Bytes);
public long this[int i]=>Value[i];

public static A249039Inst Instance=new A249039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249040
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,3L,4L,5L,6L,7L,7L,8L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,13L,14L,14L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,22L,23L,24L,24L,25L,26L,27L,28L,28L,29L,30L,30L,30L,31L,31L,32L,33L,34L,34L,35L,36L,36L,36L,37L,37L,37L,37L,38L,38L,39L,40L,40L,40L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249040Inst : IEnumerable<long>
{
public static readonly long[] Value=A249040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249040.Bytes);
public long this[int i]=>Value[i];

public static A249040Inst Instance=new A249040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249041
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,7L,8L,8L,9L,10L,11L,12L,13L,13L,14L,15L,16L,16L,17L,17L,17L,18L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,21L,21L,21L,22L,22L,22L,22L,22L,23L,23L,23L,24L,25L,25L,26L,26L,26L,26L,27L,27L,27L,28L,29L,29L,30L,31L,32L,32L,33L,33L,33L,34L,35L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249041Inst : IEnumerable<long>
{
public static readonly long[] Value=A249041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249041.Bytes);
public long this[int i]=>Value[i];

public static A249041Inst Instance=new A249041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249042
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,4L,1L,6L,6L,1L,6L,7L,7L,24L,18L,1L,14L,36L,24L,1L,10L,11L,25L,70L,46L,15L,100L,180L,96L,1L,30L,150L,240L,120L,1L,15L,16L,65L,165L,101L,90L,455L,690L,326L,31L,360L,1170L,1440L,600L,1L,62L,540L,1560L,1800L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249042Inst : IEnumerable<long>
{
public static readonly long[] Value=A249042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249042.Bytes);
public long this[int i]=>Value[i];

public static A249042Inst Instance=new A249042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249043
{
public static readonly long[] Value={ 42L,48L,60L,66L,78L,93L,105L,111L,114L,120L,123L,129L,141L,147L,159L,174L,186L,201L,204L,210L,213L,219L,231L,237L,249L,264L,276L,291L,303L,309L,321L,327L,339L,354L,366L,381L,393L,408L,420L,426L,438L,453L,465L,480L,492L,507L,519L,534L,546L,561L,573L,588L,609L,624L,636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249043Inst : IEnumerable<long>
{
public static readonly long[] Value=A249043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249043.Bytes);
public long this[int i]=>Value[i];

public static A249043Inst Instance=new A249043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249044
{
public static readonly long[] Value={ 9L,20L,42L,64L,75L,86L,108L,110L,121L,132L,143L,154L,165L,176L,187L,198L,209L,222L,244L,255L,266L,288L,299L,310L,312L,323L,334L,345L,356L,378L,400L,411L,413L,424L,435L,446L,468L,490L,501L,512L,514L,525L,536L,558L,580L,591L,602L,615L,626L,637L,648L,670L,681L,692L,703L,714L,716L,738L,749L,760L,771L,782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249044Inst : IEnumerable<long>
{
public static readonly long[] Value=A249044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249044.Bytes);
public long this[int i]=>Value[i];

public static A249044Inst Instance=new A249044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249045
{
public static readonly long[] Value={ 3L,9L,42L,75L,108L,132L,165L,198L,222L,255L,288L,312L,345L,378L,411L,435L,468L,501L,525L,558L,591L,615L,648L,681L,714L,738L,771L,804L,828L,861L,894L,918L,951L,984L,1032L,1065L,1098L,1122L,1155L,1188L,1212L,1245L,1278L,1311L,1335L,1368L,1401L,1425L,1458L,1491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249045Inst : IEnumerable<long>
{
public static readonly long[] Value=A249045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249045.Bytes);
public long this[int i]=>Value[i];

public static A249045Inst Instance=new A249045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249046
{
public static readonly long[] Value={ 3L,42L,75L,132L,165L,222L,255L,312L,345L,411L,435L,501L,525L,591L,615L,681L,714L,771L,804L,861L,894L,951L,984L,1032L,1065L,1122L,1155L,1212L,1245L,1311L,1335L,1401L,1425L,1491L,1515L,1581L,1614L,1671L,1704L,1761L,1794L,1851L,1884L,1941L,1974L,2022L,2055L,2112L,2145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249046Inst : IEnumerable<long>
{
public static readonly long[] Value=A249046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249046.Bytes);
public long this[int i]=>Value[i];

public static A249046Inst Instance=new A249046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249047
{
public static readonly long[] Value={ 1L,5L,7L,20L,31L,53L,64L,86L,97L,110L,121L,143L,154L,176L,187L,209L,211L,233L,244L,266L,277L,299L,310L,323L,334L,356L,367L,389L,400L,413L,424L,446L,457L,479L,490L,512L,514L,536L,547L,569L,580L,602L,613L,626L,637L,659L,670L,692L,703L,716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249047Inst : IEnumerable<long>
{
public static readonly long[] Value=A249047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249047.Bytes);
public long this[int i]=>Value[i];

public static A249047Inst Instance=new A249047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249048
{
public static readonly long[] Value={ 9L,108L,198L,288L,378L,468L,558L,648L,738L,828L,918L,1098L,1188L,1278L,1368L,1458L,1548L,1638L,1728L,1818L,1917L,2007L,2088L,2178L,2268L,2358L,2448L,2538L,2628L,2718L,2817L,2907L,2997L,3078L,3168L,3258L,3348L,3438L,3528L,3618L,3717L,3807L,3897L,3987L,4068L,4158L,4248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249048Inst : IEnumerable<long>
{
public static readonly long[] Value=A249048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249048.Bytes);
public long this[int i]=>Value[i];

public static A249048Inst Instance=new A249048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249049
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,2L,3L,4L,7L,8L,11L,10L,15L,14L,15L,20L,23L,24L,27L,32L,37L,38L,43L,46L,47L,46L,45L,50L,53L,52L,51L,56L,63L,66L,67L,70L,71L,74L,81L,86L,89L,94L,95L,104L,105L,110L,115L,118L,119L,122L,127L,128L,137L,136L,137L,136L,139L,140L,151L,162L,165L,164L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249049Inst : IEnumerable<long>
{
public static readonly long[] Value=A249049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249049.Bytes);
public long this[int i]=>Value[i];

public static A249049Inst Instance=new A249049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249050
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,1L,2L,3L,6L,7L,10L,9L,14L,13L,14L,19L,22L,23L,26L,31L,36L,37L,42L,45L,46L,45L,44L,49L,52L,51L,50L,55L,62L,65L,66L,69L,70L,73L,80L,85L,88L,93L,94L,103L,104L,109L,114L,117L,118L,121L,126L,127L,136L,135L,136L,135L,138L,139L,150L,161L,164L,163L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249050Inst : IEnumerable<long>
{
public static readonly long[] Value=A249050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249050.Bytes);
public long this[int i]=>Value[i];

public static A249050Inst Instance=new A249050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249051
{
public static readonly long[] Value={ 2L,3L,7L,13L,0L,61L,421L,841L,0L,2521L,0L,27721L,0L,0L,360361L,720721L,0L,12252241L,0L,0L,0L,232792561L,0L,5354228881L,0L,26771144401L,0L,80313433201L,0L,2329089562801L,72201776446801L,0L,0L,0L,0L,144403552893601L,0L,0L,0L,5342931457063201L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249051Inst : IEnumerable<long>
{
public static readonly long[] Value=A249051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249051.Bytes);
public long this[int i]=>Value[i];

public static A249051Inst Instance=new A249051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249052
{
public static readonly long[] Value={ 205L,221L,305L,377L,505L,545L,689L,725L,745L,793L,905L,1205L,1345L,1405L,1469L,1513L,1517L,1537L,1717L,1885L,1945L,1961L,2005L,2041L,2045L,2105L,2225L,2245L,2329L,2353L,2525L,2533L,2669L,2701L,2845L,2993L,3005L,3205L,3305L,3497L,3505L,3737L,3757L,3805L,3893L,3965L,4069L,4105L,4145L,4205L,4321L,4369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249052Inst : IEnumerable<long>
{
public static readonly long[] Value=A249052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249052.Bytes);
public long this[int i]=>Value[i];

public static A249052Inst Instance=new A249052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249053
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,11L,12L,13L,14L,17L,18L,20L,23L,24L,25L,26L,29L,30L,31L,32L,37L,38L,41L,42L,44L,45L,47L,48L,53L,54L,55L,59L,60L,62L,63L,67L,68L,71L,72L,73L,74L,79L,80L,81L,82L,83L,84L,89L,90L,97L,98L,101L,102L,104L,105L,106L,108L,109L,110L,113L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249053Inst : IEnumerable<long>
{
public static readonly long[] Value=A249053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249053.Bytes);
public long this[int i]=>Value[i];

public static A249053Inst Instance=new A249053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249054
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,9L,10L,12L,7L,11L,14L,13L,15L,16L,17L,19L,23L,18L,20L,29L,31L,21L,22L,24L,37L,25L,26L,41L,27L,43L,28L,47L,30L,32L,53L,59L,33L,34L,61L,67L,35L,36L,71L,38L,73L,39L,40L,79L,83L,42L,89L,97L,101L,44L,45L,103L,46L,48L,107L,49L,50L,109L,113L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249054Inst : IEnumerable<long>
{
public static readonly long[] Value=A249054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249054.Bytes);
public long this[int i]=>Value[i];

public static A249054Inst Instance=new A249054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249055
{
public static readonly long[] Value={ 0L,2L,12L,30L,56L,90L,143L,210L,272L,342L,420L,506L,600L,702L,812L,992L,1122L,1260L,1406L,1560L,1722L,1892L,2070L,2256L,2450L,2652L,2862L,3135L,3422L,3660L,3906L,4160L,4422L,4692L,4970L,5256L,5550L,5852L,6162L,6480L,6806L,7140L,7482L,7832L,8372L,8742L,9120L,9506L,9900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249055Inst : IEnumerable<long>
{
public static readonly long[] Value=A249055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249055.Bytes);
public long this[int i]=>Value[i];

public static A249055Inst Instance=new A249055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249056
{
public static readonly BigInteger[] Value={ 1L,1L,15L,35L,3780L,9504L,2702700L,7001280L,3809332800L,10027987200L,8896257216000L,23655956688000L,31072794873120000L,83196255098880000L,BigInteger.Parse("151687572109032960000"),BigInteger.Parse("408177466766125056000"),BigInteger.Parse("986280987631626086400000"),BigInteger.Parse("2664118997179074699264000") };
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
public class A249056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249056Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249056.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249056Inst Instance=new A249056Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249057
{
public static readonly long[] Value={ 1L,4L,1L,5L,4L,1L,24L,11L,4L,1L,35L,52L,18L,4L,1L,192L,123L,84L,26L,4L,1L,315L,660L,285L,120L,35L,4L,1L,1920L,1545L,1500L,545L,160L,45L,4L,1L,3465L,9180L,4680L,2820L,930L,204L,56L,4L,1L,23040L,22005L,27180L,11220L,4740L,1470L,252L,68L,4L,1L,45045L,142380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249057Inst : IEnumerable<long>
{
public static readonly long[] Value=A249057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249057.Bytes);
public long this[int i]=>Value[i];

public static A249057Inst Instance=new A249057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249058
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,5L,7L,9L,12L,17L,24L,32L,45L,61L,82L,114L,154L,215L,293L,404L,557L,766L,1057L,1459L,2025L,2800L,3880L,5379L,7470L,10368L,14414L,20030L,27864L,38745L,53982L,75206L,104799L,146151L,203821L,284381L,396976L,554303L,774256L,1081749L,1511871L,2113506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249058Inst : IEnumerable<long>
{
public static readonly long[] Value=A249058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249058.Bytes);
public long this[int i]=>Value[i];

public static A249058Inst Instance=new A249058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249059
{
public static readonly long[] Value={ 1L,5L,10L,40L,110L,430L,1420L,5720L,21340L,89980L,367400L,1627120L,7138120L,33172040L,154520080L,751616800L,3687498320L,18719834320L,96157299040L,507993654080L,2719611532000L,14911459229920L,82901747529920L,470599687507840L,2708946870815680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249059Inst : IEnumerable<long>
{
public static readonly long[] Value=A249059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249059.Bytes);
public long this[int i]=>Value[i];

public static A249059Inst Instance=new A249059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249060
{
public static readonly long[] Value={ 1L,4L,5L,24L,35L,192L,315L,1920L,3465L,23040L,45045L,322560L,675675L,5160960L,11486475L,92897280L,218243025L,1857945600L,4583103525L,40874803200L,105411381075L,980995276800L,2635284526875L,25505877196800L,71152682225625L,714164561510400L,2063427784543125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249060Inst : IEnumerable<long>
{
public static readonly long[] Value=A249060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249060.Bytes);
public long this[int i]=>Value[i];

public static A249060Inst Instance=new A249060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249061
{
public static readonly long[] Value={ 2L,1L,1L,4L,1L,3L,1L,3L,2L,4L,1L,3L,1L,3L,2L,7L,1L,3L,1L,4L,2L,4L,1L,3L,10L,3L,2L,4L,1L,12L,1L,3L,5L,4L,2L,3L,1L,3L,2L,7L,1L,3L,1L,4L,2L,7L,1L,3L,10L,4L,2L,4L,1L,3L,10L,3L,2L,4L,1L,12L,1L,3L,6L,4L,2L,3L,1L,3L,2L,4L,1L,8L,1L,3L,5L,7L,2L,3L,1L,4L,2L,7L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249061Inst : IEnumerable<long>
{
public static readonly long[] Value=A249061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249061.Bytes);
public long this[int i]=>Value[i];

public static A249061Inst Instance=new A249061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249062
{
public static readonly long[] Value={ 1L,2L,5L,18L,69L,306L,1497L,7890L,45033L,273474L,1760301L,11961522L,85265325L,636026418L,4947725889L,40019230386L,335868650577L,2918173355010L,26199114476373L,242657102748114L,2314964975130261L,22717352863875762L,229029972003647145L,2369438933865972498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249062Inst : IEnumerable<long>
{
public static readonly long[] Value=A249062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249062.Bytes);
public long this[int i]=>Value[i];

public static A249062Inst Instance=new A249062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249063
{
public static readonly long[] Value={ 0L,-1L,-2L,-2L,0L,2L,3L,-1L,-4L,-4L,0L,4L,5L,0L,-5L,-6L,-2L,4L,7L,3L,-5L,-8L,-5L,3L,8L,5L,-3L,-9L,-8L,1L,10L,9L,-1L,-10L,-10L,-2L,9L,11L,3L,-9L,-13L,-6L,7L,13L,7L,-7L,-15L,-10L,4L,14L,11L,-3L,-15L,-14L,0L,13L,14L,1L,-14L,-17L,-5L,12L,17L,7L,-11L,-18L,-10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249063Inst : IEnumerable<long>
{
public static readonly long[] Value=A249063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249063.Bytes);
public long this[int i]=>Value[i];

public static A249063Inst Instance=new A249063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249064
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,11L,13L,8L,17L,19L,23L,25L,29L,31L,21L,37L,16L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,22L,109L,113L,27L,35L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,32L,121L,223L,227L,229L,233L,239L,241L,51L,251L,257L,263L,269L,271L,277L,281L,283L,49L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249064Inst : IEnumerable<long>
{
public static readonly long[] Value=A249064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249064.Bytes);
public long this[int i]=>Value[i];

public static A249064Inst Instance=new A249064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249065
{
public static readonly long[] Value={ 12L,420L,966L,2700L,5700L,5940L,7440L,12540L,71100L,76680L,107880L,118680L,121920L,156420L,160650L,161880L,259080L,284580L,339150L,353430L,395850L,498420L,585200L,600780L,701220L,746130L,752100L,771420L,870870L,1052220L,1249680L,1654620L,1684020L,1696080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249065Inst : IEnumerable<long>
{
public static readonly long[] Value=A249065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249065.Bytes);
public long this[int i]=>Value[i];

public static A249065Inst Instance=new A249065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249066
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249066Inst : IEnumerable<long>
{
public static readonly long[] Value=A249066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249066.Bytes);
public long this[int i]=>Value[i];

public static A249066Inst Instance=new A249066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249067
{
public static readonly long[] Value={ 9L,45L,27L,23L,18L,15L,13L,12L,9L,9L,9L,42L,62L,43L,54L,44L,53L,45L,43L,45L,43L,41L,35L,34L,36L,35L,34L,33L,32L,27L,26L,25L,25L,27L,26L,25L,25L,24L,24L,23L,22L,22L,21L,21L,18L,18L,18L,17L,17L,18L,18L,18L,17L,17L,17L,17L,16L,16L,16L,15L,15L,15L,15L,15L,14L,14L,14L,14L,14L,13L,13L,13L,13L,13L,12L,12L,12L,12L,12L,12L,12L,11L,11L,11L,11L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249067Inst : IEnumerable<long>
{
public static readonly long[] Value=A249067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249067.Bytes);
public long this[int i]=>Value[i];

public static A249067Inst Instance=new A249067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249068
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,2L,2L,3L,2L,4L,2L,5L,2L,6L,2L,7L,2L,8L,3L,3L,4L,3L,5L,3L,6L,3L,7L,3L,8L,4L,4L,5L,4L,6L,4L,7L,4L,8L,5L,5L,6L,5L,7L,5L,8L,6L,6L,7L,6L,8L,7L,7L,8L,8L,9L,18L,10L,11L,9L,22L,9L,24L,10L,13L,9L,28L,9L,30L,10L,14L,11L,13L,10L,15L,9L,38L,12L,11L,14L,13L,11L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249068Inst : IEnumerable<long>
{
public static readonly long[] Value=A249068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249068.Bytes);
public long this[int i]=>Value[i];

public static A249068Inst Instance=new A249068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249069
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,1L,7L,9L,12L,2L,13L,3L,16L,5L,6L,18L,1L,19L,2L,21L,3L,25L,27L,30L,32L,35L,38L,40L,41L,43L,45L,48L,13L,14L,15L,16L,18L,6L,53L,20L,7L,57L,21L,8L,64L,24L,65L,27L,69L,28L,72L,10L,73L,11L,76L,12L,33L,80L,13L,34L,85L,14L,37L,89L,15L,41L,94L,17L,46L,96L,1L,97L,2L,99L,3L,103L,4L,48L,49L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249069Inst : IEnumerable<long>
{
public static readonly long[] Value=A249069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249069.Bytes);
public long this[int i]=>Value[i];

public static A249069Inst Instance=new A249069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249070
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,1L,7L,9L,12L,2L,13L,3L,16L,5L,6L,18L,1L,19L,2L,21L,3L,25L,27L,30L,32L,35L,7L,40L,9L,44L,4L,10L,11L,12L,13L,14L,15L,16L,18L,5L,19L,6L,56L,20L,7L,61L,22L,8L,64L,26L,66L,9L,69L,10L,29L,30L,76L,11L,32L,81L,12L,33L,88L,13L,36L,37L,38L,39L,40L,42L,14L,43L,15L,44L,16L,46L,17L,49L,50L,51L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249070Inst : IEnumerable<long>
{
public static readonly long[] Value=A249070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249070.Bytes);
public long this[int i]=>Value[i];

public static A249070Inst Instance=new A249070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249071
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,0L,1L,2L,2L,2L,2L,2L,1L,0L,1L,2L,2L,3L,3L,4L,4L,3L,4L,4L,3L,3L,2L,2L,1L,0L,1L,2L,3L,3L,4L,4L,5L,5L,6L,6L,5L,6L,6L,7L,7L,6L,7L,7L,6L,6L,5L,6L,6L,5L,5L,4L,4L,3L,3L,2L,1L,0L,1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,8L,8L,8L,8L,9L,9L,10L,10L,11L,11L,10L,11L,11L,12L,12L,11L,12L,12L,11L,11L,10L,11L,11L,12L,12L,11L,12L,12L,11L,11L,10L,11L,11L,10L,10L,9L,9L,8L,8L,8L,8L,8L,7L,7L,6L,5L,5L,4L,3L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249071Inst : IEnumerable<long>
{
public static readonly long[] Value=A249071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249071.Bytes);
public long this[int i]=>Value[i];

public static A249071Inst Instance=new A249071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249072
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,0L,2L,1L,2L,2L,2L,3L,0L,2L,3L,1L,3L,2L,4L,0L,3L,2L,3L,3L,3L,4L,1L,3L,3L,4L,2L,4L,2L,4L,3L,4L,3L,5L,0L,3L,4L,4L,3L,6L,0L,4L,4L,4L,5L,1L,4L,4L,6L,1L,3L,5L,2L,5L,2L,4L,5L,3L,5L,3L,4L,5L,4L,4L,7L,0L,3L,7L,1L,4L,5L,3L,5L,4L,8L,0L,4L,5L,4L,6L,2L,6L,2L,5L,5L,4L,6L,3L,8L,1L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249072Inst : IEnumerable<long>
{
public static readonly long[] Value=A249072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249072.Bytes);
public long this[int i]=>Value[i];

public static A249072Inst Instance=new A249072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249073
{
public static readonly long[] Value={ 1L,2L,64L,128L,729L,1458L,4096L,8192L,15625L,31250L,46656L,93312L,117649L,235298L,262144L,524288L,531441L,1000000L,1062882L,1771561L,2000000L,2985984L,3543122L,4826809L,5971968L,7529536L,9653618L,11390625L,15059072L,16777216L,22781250L,24137569L,33554432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249073Inst : IEnumerable<long>
{
public static readonly long[] Value=A249073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249073.Bytes);
public long this[int i]=>Value[i];

public static A249073Inst Instance=new A249073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249074
{
public static readonly long[] Value={ 1L,4L,1L,6L,4L,1L,32L,14L,4L,1L,60L,72L,24L,4L,1L,384L,228L,120L,36L,4L,1L,840L,1392L,564L,176L,50L,4L,1L,6144L,4488L,3312L,1140L,240L,66L,4L,1L,15120L,31200L,14640L,6480L,2040L,312L,84L,4L,1L,122880L,104880L,97440L,37440L,11280L,3360L,392L,104L,4L,1L,332640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249074Inst : IEnumerable<long>
{
public static readonly long[] Value=A249074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249074.Bytes);
public long this[int i]=>Value[i];

public static A249074Inst Instance=new A249074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249075
{
public static readonly long[] Value={ 1L,5L,11L,51L,161L,773L,3027L,15395L,69881L,377781L,1915163L,10981907L,60776145L,368269541L,2191553891L,13976179203L,88489011497L,591631462805L,3954213899691L,27619472411891L,193696456198913L,1408953242322117L,10318990227472115L,77948745858933731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249075Inst : IEnumerable<long>
{
public static readonly long[] Value=A249075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249075.Bytes);
public long this[int i]=>Value[i];

public static A249075Inst Instance=new A249075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249076
{
public static readonly long[] Value={ 0L,64L,46656L,2985984L,64000000L,729000000L,5489031744L,30840979456L,139314069504L,531441000000L,1771561000000L,5289852801024L,14412774445056L,36343632130624L,85766121000000L,191102976000000L,404961208827904L,820972403643456L,1600135042849344L,3010936384000000L,5489031744000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249076Inst : IEnumerable<long>
{
public static readonly long[] Value=A249076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249076.Bytes);
public long this[int i]=>Value[i];

public static A249076Inst Instance=new A249076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249077
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,31L,41L,61L,67L,73L,79L,83L,89L,97L,103L,137L,139L,149L,151L,157L,181L,193L,199L,211L,223L,227L,239L,241L,271L,311L,317L,331L,337L,349L,373L,421L,433L,439L,443L,449L,461L,607L,619L,631L,643L,661L,691L,719L,739L,757L,811L,823L,829L,853L,859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249077Inst : IEnumerable<long>
{
public static readonly long[] Value=A249077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249077.Bytes);
public long this[int i]=>Value[i];

public static A249077Inst Instance=new A249077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249078
{
public static readonly BigInteger[] Value={ 1L,1L,4L,17L,96L,595L,4516L,37104L,351020L,3604001L,41007240L,502039444L,6703536516L,95376507135L,1459072099824L,23677731306350L,408821193129564L,7443839953433701L,143258713990271960L,2893053522512463984L,BigInteger.Parse("61396438056305204020"),BigInteger.Parse("1362146168353191078195"),BigInteger.Parse("31605702195327725326560") };
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
public class A249078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249078Inst Instance=new A249078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249079
{
public static readonly long[] Value={ 0L,29L,58L,87L,116L,145L,174L,203L,232L,261L,290L,319L,348L,377L,406L,436L,465L,494L,523L,552L,581L,610L,639L,668L,697L,726L,755L,784L,813L,842L,871L,900L,929L,958L,987L,1016L,1045L,1074L,1103L,1132L,1161L,1190L,1219L,1248L,1278L,1307L,1336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249079Inst : IEnumerable<long>
{
public static readonly long[] Value=A249079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249079.Bytes);
public long this[int i]=>Value[i];

public static A249079Inst Instance=new A249079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249080
{
public static readonly long[] Value={ 1324L,1944L,2844L,4136L,5964L,8504L,11964L,18884L,29484L,45428L,68892L,102564L,149644L,243804L,391596L,618620L,958668L,1453724L,2153964L,3554444L,5775660L,9219020L,14417004L,22033164L,32862124L,54520044L,89029164L,142746476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249080Inst : IEnumerable<long>
{
public static readonly long[] Value=A249080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249080.Bytes);
public long this[int i]=>Value[i];

public static A249080Inst Instance=new A249080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249081
{
public static readonly long[] Value={ 5005L,8805L,15493L,27213L,47645L,83045L,143925L,263405L,480725L,874421L,1584425L,2858305L,5130445L,9561325L,17773565L,32945477L,60874349L,112077225L,205513125L,386804645L,726595221L,1361924833L,2546660077L,4749273385L,8830446345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249081Inst : IEnumerable<long>
{
public static readonly long[] Value=A249081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249081.Bytes);
public long this[int i]=>Value[i];

public static A249081Inst Instance=new A249081Inst();

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