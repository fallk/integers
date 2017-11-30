using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A154505
{
public static readonly long[] Value={ 1601L,240101L,1464101L,2755601L,6100901L,72250001L,75342401L,139948901L,281568401L,284596901L,325441601L,351937601L,655360001L,683299601L,702250001L,1479940901L,1621672901L,1830984101L,2168764901L,2219352101L,2544193601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154505Inst : IEnumerable<long>
{
public static readonly long[] Value=A154505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154505.Bytes);
public long this[int i]=>Value[i];

public static A154505Inst Instance=new A154505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154506
{
public static readonly long[] Value={ 43L,107L,149L,2719L,3323L,5641L,5843L,7253L,7757L,8059L,8563L,9067L,12697L,182141L,188147L,224177L,279221L,298237L,300239L,315251L,350281L,360289L,362291L,371299L,388313L,412333L,418339L,424343L,448363L,453367L,460373L,469379L,473383L,549449L,558457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154506Inst : IEnumerable<long>
{
public static readonly long[] Value=A154506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154506.Bytes);
public long this[int i]=>Value[i];

public static A154506Inst Instance=new A154506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154507
{
public static readonly long[] Value={ 1L,12L,64L,85L,96L,128L,1510L,1611L,1812L,2013L,2114L,2215L,2416L,2517L,2618L,2820L,3021L,3222L,3424L,3525L,3626L,3827L,3928L,4029L,4230L,4431L,4532L,4633L,4834L,4935L,5036L,5137L,5238L,5439L,5540L,5742L,6044L,6245L,6346L,6447L,6548L,6649L,6850L,6951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154507Inst : IEnumerable<long>
{
public static readonly long[] Value=A154507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154507.Bytes);
public long this[int i]=>Value[i];

public static A154507Inst Instance=new A154507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154508
{
public static readonly long[] Value={ 3L,7L,9L,19L,23L,41L,43L,53L,57L,59L,63L,67L,97L,141L,147L,177L,221L,237L,239L,251L,281L,289L,291L,299L,313L,333L,339L,343L,363L,367L,373L,379L,383L,449L,457L,459L,463L,467L,489L,497L,503L,507L,527L,529L,539L,547L,563L,569L,579L,583L,597L,599L,601L,603L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154508Inst : IEnumerable<long>
{
public static readonly long[] Value=A154508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154508.Bytes);
public long this[int i]=>Value[i];

public static A154508Inst Instance=new A154508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154509
{
public static readonly long[] Value={ 8L,5L,3L,7L,7L,5L,8L,2L,7L,8L,7L,5L,8L,0L,6L,0L,1L,3L,7L,4L,4L,6L,3L,7L,3L,7L,4L,4L,6L,1L,4L,5L,5L,0L,2L,1L,3L,2L,7L,6L,0L,0L,4L,7L,8L,2L,0L,7L,6L,9L,9L,3L,7L,1L,7L,4L,6L,5L,8L,2L,8L,7L,2L,5L,3L,6L,6L,3L,3L,0L,6L,8L,8L,6L,9L,7L,8L,8L,2L,5L,2L,8L,5L,1L,5L,8L,5L,2L,9L,9L,6L,4L,6L,0L,4L,0L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154509Inst : IEnumerable<long>
{
public static readonly long[] Value=A154509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154509.Bytes);
public long this[int i]=>Value[i];

public static A154509Inst Instance=new A154509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154510
{
public static readonly long[] Value={ 10657L,16561L,23761L,32257L,65521L,79201L,287281L,374977L,474337L,510049L,624961L,665857L,708049L,988417L,1039681L,1092241L,1146097L,1315441L,1374481L,1755937L,1893457L,2036161L,2259937L,2913697L,3090097L,3553777L,4470049L,5255281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154510Inst : IEnumerable<long>
{
public static readonly long[] Value=A154510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154510.Bytes);
public long this[int i]=>Value[i];

public static A154510Inst Instance=new A154510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154511
{
public static readonly long[] Value={ 577L,31249L,40897L,64081L,77617L,126001L,186049L,208657L,581041L,982801L,1367857L,1616401L,2101249L,2567377L,3836449L,4038481L,4141441L,4566241L,4898449L,5359537L,7691041L,8413201L,8711137L,10941841L,12152449L,13240657L,14183137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154511Inst : IEnumerable<long>
{
public static readonly long[] Value=A154511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154511.Bytes);
public long this[int i]=>Value[i];

public static A154511Inst Instance=new A154511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154512
{
public static readonly long[] Value={ 3L,5L,1L,1L,1L,2L,3L,3L,4L,5L,6L,7L,8L,8L,1L,1L,1L,3L,1L,1L,9L,1L,1L,1L,1L,1L,3L,1L,9L,2L,9L,2L,2L,3L,2L,1L,3L,1L,3L,3L,3L,9L,3L,3L,3L,3L,9L,3L,4L,3L,4L,4L,3L,4L,5L,5L,5L,1L,7L,5L,9L,5L,3L,6L,9L,6L,9L,3L,7L,1L,7L,7L,3L,7L,9L,7L,8L,1L,8L,9L,8L,3L,8L,7L,1L,9L,9L,3L,9L,1L,9L,9L,9L,1L,3L,9L,0L,0L,9L,1L,9L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154512Inst : IEnumerable<long>
{
public static readonly long[] Value=A154512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154512.Bytes);
public long this[int i]=>Value[i];

public static A154512Inst Instance=new A154512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154513
{
public static readonly long[] Value={ 6L,8L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,9L,1L,4L,6L,0L,1L,1L,1L,7L,1L,1L,1L,3L,8L,3L,1L,5L,1L,1L,1L,1L,1L,1L,1L,3L,5L,1L,8L,1L,8L,1L,0L,1L,7L,0L,1L,5L,1L,1L,2L,5L,8L,2L,2L,5L,2L,9L,2L,4L,2L,8L,0L,2L,2L,8L,2L,1L,2L,2L,2L,2L,6L,2L,2L,2L,5L,2L,5L,2L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154513Inst : IEnumerable<long>
{
public static readonly long[] Value=A154513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154513.Bytes);
public long this[int i]=>Value[i];

public static A154513Inst Instance=new A154513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154514
{
public static readonly long[] Value={ 577L,2449L,5617L,10081L,15841L,22897L,31249L,40897L,51841L,64081L,77617L,92449L,108577L,126001L,144721L,164737L,186049L,208657L,232561L,257761L,284257L,312049L,341137L,371521L,403201L,436177L,470449L,506017L,542881L,581041L,620497L,661249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154514Inst : IEnumerable<long>
{
public static readonly long[] Value=A154514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154514.Bytes);
public long this[int i]=>Value[i];

public static A154514Inst Instance=new A154514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154515
{
public static readonly long[] Value={ 721L,2737L,6049L,10657L,16561L,23761L,32257L,42049L,53137L,65521L,79201L,94177L,110449L,128017L,146881L,167041L,188497L,211249L,235297L,260641L,287281L,315217L,344449L,374977L,406801L,439921L,474337L,510049L,547057L,585361L,624961L,665857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154515Inst : IEnumerable<long>
{
public static readonly long[] Value=A154515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154515.Bytes);
public long this[int i]=>Value[i];

public static A154515Inst Instance=new A154515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154516
{
public static readonly long[] Value={ 8L,34L,78L,140L,220L,318L,434L,568L,720L,890L,1078L,1284L,1508L,1750L,2010L,2288L,2584L,2898L,3230L,3580L,3948L,4334L,4738L,5160L,5600L,6058L,6534L,7028L,7540L,8070L,8618L,9184L,9768L,10370L,10990L,11628L,12284L,12958L,13650L,14360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154516Inst : IEnumerable<long>
{
public static readonly long[] Value=A154516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154516.Bytes);
public long this[int i]=>Value[i];

public static A154516Inst Instance=new A154516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154517
{
public static readonly long[] Value={ 10L,38L,84L,148L,230L,330L,448L,584L,738L,910L,1100L,1308L,1534L,1778L,2040L,2320L,2618L,2934L,3268L,3620L,3990L,4378L,4784L,5208L,5650L,6110L,6588L,7084L,7598L,8130L,8680L,9248L,9834L,10438L,11060L,11700L,12358L,13034L,13728L,14440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154517Inst : IEnumerable<long>
{
public static readonly long[] Value=A154517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154517.Bytes);
public long this[int i]=>Value[i];

public static A154517Inst Instance=new A154517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154518
{
public static readonly long[] Value={ 204L,420L,636L,852L,1068L,1284L,1500L,1716L,1932L,2148L,2364L,2580L,2796L,3012L,3228L,3444L,3660L,3876L,4092L,4308L,4524L,4740L,4956L,5172L,5388L,5604L,5820L,6036L,6252L,6468L,6684L,6900L,7116L,7332L,7548L,7764L,7980L,8196L,8412L,8628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154518Inst : IEnumerable<long>
{
public static readonly long[] Value=A154518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154518.Bytes);
public long this[int i]=>Value[i];

public static A154518Inst Instance=new A154518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154519
{
public static readonly long[] Value={ 228L,444L,660L,876L,1092L,1308L,1524L,1740L,1956L,2172L,2388L,2604L,2820L,3036L,3252L,3468L,3684L,3900L,4116L,4332L,4548L,4764L,4980L,5196L,5412L,5628L,5844L,6060L,6276L,6492L,6708L,6924L,7140L,7356L,7572L,7788L,8004L,8220L,8436L,8652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154519Inst : IEnumerable<long>
{
public static readonly long[] Value=A154519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154519.Bytes);
public long this[int i]=>Value[i];

public static A154519Inst Instance=new A154519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154520
{
public static readonly long[] Value={ 1L,4L,8L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,7L,8L,9L,9L,9L,9L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,3L,4L,1L,4L,4L,4L,5L,1L,1L,5L,1L,6L,1L,6L,1L,7L,1L,1L,8L,1L,8L,8L,1L,1L,1L,0L,0L,2L,0L,2L,1L,2L,1L,2L,2L,2L,2L,2L,3L,2L,3L,3L,2L,4L,2L,4L,4L,5L,2L,2L,2L,6L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154520Inst : IEnumerable<long>
{
public static readonly long[] Value=A154520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154520.Bytes);
public long this[int i]=>Value[i];

public static A154520Inst Instance=new A154520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154521
{
public static readonly long[] Value={ 4L,6L,9L,0L,4L,5L,8L,0L,2L,6L,7L,2L,4L,5L,8L,2L,6L,8L,1L,4L,5L,8L,2L,5L,0L,4L,5L,7L,8L,1L,0L,2L,5L,6L,2L,0L,0L,1L,1L,4L,6L,1L,0L,2L,2L,2L,2L,3L,4L,3L,6L,0L,4L,4L,6L,8L,2L,5L,5L,6L,5L,1L,6L,9L,7L,1L,7L,8L,4L,8L,6L,8L,9L,9L,9L,0L,2L,0L,6L,0L,3L,1L,7L,1L,2L,1L,4L,2L,0L,3L,2L,7L,4L,3L,4L,7L,9L,4L,5L,6L,6L,8L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154521Inst : IEnumerable<long>
{
public static readonly long[] Value=A154521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154521.Bytes);
public long this[int i]=>Value[i];

public static A154521Inst Instance=new A154521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154522
{
public static readonly long[] Value={ 5L,30L,32L,36L,42L,43L,47L,48L,49L,50L,64L,68L,71L,74L,76L,84L,87L,102L,130L,138L,139L,141L,151L,156L,165L,169L,188L,189L,191L,192L,195L,196L,198L,199L,202L,210L,215L,216L,218L,221L,230L,233L,234L,242L,248L,255L,256L,257L,268L,271L,282L,284L,286L,293L,294L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154522Inst : IEnumerable<long>
{
public static readonly long[] Value=A154522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154522.Bytes);
public long this[int i]=>Value[i];

public static A154522Inst Instance=new A154522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154523
{
public static readonly long[] Value={ 11L,13L,18L,31L,41L,52L,62L,73L,80L,81L,110L,112L,113L,114L,115L,116L,121L,125L,128L,133L,135L,140L,141L,142L,152L,156L,157L,164L,167L,170L,180L,187L,188L,189L,191L,192L,193L,194L,195L,196L,198L,199L,211L,215L,216L,217L,218L,219L,221L,231L,241L,251L,261L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154523Inst : IEnumerable<long>
{
public static readonly long[] Value=A154523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154523.Bytes);
public long this[int i]=>Value[i];

public static A154523Inst Instance=new A154523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154524
{
public static readonly long[] Value={ 3L,5L,7L,19L,23L,29L,47L,61L,97L,181L,233L,307L,401L,887L,1021L,1087L,1361L,1481L,2053L,2293L,5407L,5857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154524Inst : IEnumerable<long>
{
public static readonly long[] Value=A154524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154524.Bytes);
public long this[int i]=>Value[i];

public static A154524Inst Instance=new A154524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154525
{
public static readonly long[] Value={ 2L,3L,5L,7L,19L,31L,47L,89L,127L,139L,2251L,3271L,4253L,4373L,4549L,5449L,13331L,37123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154525Inst : IEnumerable<long>
{
public static readonly long[] Value=A154525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154525.Bytes);
public long this[int i]=>Value[i];

public static A154525Inst Instance=new A154525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154526
{
public static readonly long[] Value={ 3L,5L,7L,19L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154526Inst : IEnumerable<long>
{
public static readonly long[] Value=A154526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154526.Bytes);
public long this[int i]=>Value[i];

public static A154526Inst Instance=new A154526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154527
{
public static readonly long[] Value={ 8L,4L,1L,6L,7L,1L,8L,8L,5L,7L,9L,3L,3L,5L,9L,5L,1L,4L,1L,6L,4L,1L,6L,4L,4L,8L,1L,1L,4L,4L,9L,1L,3L,0L,6L,6L,6L,0L,6L,6L,9L,2L,9L,5L,6L,9L,2L,8L,4L,7L,3L,1L,9L,0L,5L,6L,7L,4L,7L,1L,2L,7L,3L,5L,5L,5L,2L,9L,3L,1L,3L,1L,7L,8L,2L,1L,7L,1L,8L,1L,5L,6L,9L,0L,5L,5L,5L,4L,8L,6L,8L,3L,4L,5L,6L,2L,8L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154527Inst : IEnumerable<long>
{
public static readonly long[] Value=A154527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154527.Bytes);
public long this[int i]=>Value[i];

public static A154527Inst Instance=new A154527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154528
{
public static readonly long[] Value={ 9L,22L,34L,35L,36L,38L,39L,44L,56L,57L,58L,63L,65L,66L,75L,78L,85L,87L,88L,93L,95L,111L,224L,225L,226L,228L,232L,242L,252L,262L,272L,282L,292L,322L,333L,344L,345L,346L,348L,354L,355L,356L,357L,358L,364L,365L,366L,368L,369L,374L,375L,376L,377L,378L,384L,385L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154528Inst : IEnumerable<long>
{
public static readonly long[] Value=A154528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154528.Bytes);
public long this[int i]=>Value[i];

public static A154528Inst Instance=new A154528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154529
{
public static readonly long[] Value={ 1L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154529Inst : IEnumerable<long>
{
public static readonly long[] Value=A154529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154529.Bytes);
public long this[int i]=>Value[i];

public static A154529Inst Instance=new A154529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154530
{
public static readonly long[] Value={ 23L,43L,67L,89L,109L,1213L,2221L,2423L,3433L,3637L,4241L,4243L,5051L,5657L,5857L,6263L,6869L,7069L,7877L,7879L,8081L,8887L,9091L,9293L,9697L,10099L,102101L,102103L,108107L,108109L,112111L,114113L,120121L,124123L,126127L,138139L,148147L,150151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154530Inst : IEnumerable<long>
{
public static readonly long[] Value=A154530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154530.Bytes);
public long this[int i]=>Value[i];

public static A154530Inst Instance=new A154530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154531
{
public static readonly long[] Value={ 199211L,211199L,233239L,239233L,257263L,263257L,353359L,359353L,523541L,541523L,653659L,659653L,971977L,977971L,19731979L,19791973L,23332339L,23392333L,32593271L,32713259L,36373643L,36433637L,37613767L,37673761L,42834289L,42894283L,49934999L,49994993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154531Inst : IEnumerable<long>
{
public static readonly long[] Value=A154531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154531.Bytes);
public long this[int i]=>Value[i];

public static A154531Inst Instance=new A154531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154532
{
public static readonly long[] Value={ 9876543210L,9994363488L,9999257781L,9999112926L,9995722269L,9999409158L,9998033316L,9993870774L,9986053188L,9964052493L,9975246786L,9966918135L,9938689137L,9998781633L,9813743148L,9970902252L,9740383767L,9829440591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154532Inst : IEnumerable<long>
{
public static readonly long[] Value=A154532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154532.Bytes);
public long this[int i]=>Value[i];

public static A154532Inst Instance=new A154532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154533
{
public static readonly long[] Value={ 10L,9L,10L,13L,18L,25L,34L,45L,58L,73L,90L,109L,130L,153L,178L,205L,234L,265L,298L,333L,370L,409L,450L,493L,538L,585L,634L,685L,738L,793L,850L,909L,970L,1033L,1098L,1165L,1234L,1305L,1378L,1453L,1530L,1609L,1690L,1773L,1858L,1945L,2034L,2125L,2218L,2313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154533Inst : IEnumerable<long>
{
public static readonly long[] Value=A154533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154533.Bytes);
public long this[int i]=>Value[i];

public static A154533Inst Instance=new A154533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154534
{
public static readonly long[] Value={ 77L,105L,201L,203L,205L,207L,209L,301L,303L,305L,309L,403L,405L,407L,501L,505L,507L,603L,605L,609L,703L,705L,707L,779L,801L,803L,805L,807L,899L,901L,903L,905L,909L,989L,1011L,1015L,1017L,1023L,1025L,1027L,1029L,1035L,1037L,1041L,1043L,1045L,1047L,1053L,1055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154534Inst : IEnumerable<long>
{
public static readonly long[] Value=A154534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154534.Bytes);
public long this[int i]=>Value[i];

public static A154534Inst Instance=new A154534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154535
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,14L,21L,31L,34L,41L,45L,56L,66L,70L,75L,80L,89L,93L,96L,101L,116L,127L,142L,149L,162L,167L,171L,176L,185L,190L,192L,194L,199L,215L,218L,223L,225L,231L,238L,239L,264L,269L,275L,313L,321L,326L,374L,375L,386L,404L,410L,416L,418L,419L,427L,436L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154535Inst : IEnumerable<long>
{
public static readonly long[] Value=A154535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154535.Bytes);
public long this[int i]=>Value[i];

public static A154535Inst Instance=new A154535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154536
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,9L,11L,12L,14L,15L,16L,22L,25L,26L,29L,31L,33L,36L,39L,53L,59L,60L,63L,70L,72L,74L,80L,87L,94L,128L,141L,142L,145L,152L,169L,171L,173L,179L,193L,210L,227L,309L,339L,340L,343L,350L,367L,408L,410L,412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154536Inst : IEnumerable<long>
{
public static readonly long[] Value=A154536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154536.Bytes);
public long this[int i]=>Value[i];

public static A154536Inst Instance=new A154536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154537
{
public static readonly long[] Value={ 1L,1L,2L,1L,8L,4L,1L,26L,36L,8L,1L,80L,232L,128L,16L,1L,242L,1320L,1360L,400L,32L,1L,728L,7084L,12160L,6320L,1152L,64L,1L,2186L,36876L,99288L,81200L,25312L,3136L,128L,1L,6560L,188752L,768768L,929376L,440832L,91392L,8192L,256L,1L,19682L,956880L,5758880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154537Inst : IEnumerable<long>
{
public static readonly long[] Value=A154537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154537.Bytes);
public long this[int i]=>Value[i];

public static A154537Inst Instance=new A154537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154538
{
public static readonly long[] Value={ 8L,3L,0L,4L,0L,0L,4L,4L,9L,6L,1L,3L,0L,0L,2L,4L,3L,7L,8L,8L,7L,2L,4L,3L,0L,3L,1L,5L,6L,6L,8L,1L,8L,9L,5L,9L,8L,3L,4L,3L,0L,1L,8L,2L,1L,3L,1L,3L,1L,1L,9L,1L,8L,5L,1L,6L,2L,2L,3L,6L,5L,4L,7L,0L,7L,4L,9L,5L,3L,4L,6L,0L,0L,7L,9L,7L,1L,5L,2L,2L,0L,2L,5L,0L,1L,7L,8L,9L,9L,3L,7L,6L,0L,7L,7L,7L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154538Inst : IEnumerable<long>
{
public static readonly long[] Value=A154538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154538.Bytes);
public long this[int i]=>Value[i];

public static A154538Inst Instance=new A154538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154539
{
public static readonly long[] Value={ 2L,11L,13L,17L,19L,23L,29L,31L,41L,47L,61L,67L,71L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,311L,313L,317L,331L,337L,353L,373L,383L,419L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154539Inst : IEnumerable<long>
{
public static readonly long[] Value=A154539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154539.Bytes);
public long this[int i]=>Value[i];

public static A154539Inst Instance=new A154539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154540
{
public static readonly long[] Value={ 3L,9L,0L,6L,8L,9L,0L,5L,9L,5L,6L,0L,8L,5L,1L,8L,5L,2L,9L,3L,2L,4L,0L,5L,8L,3L,7L,3L,4L,3L,7L,2L,0L,6L,6L,8L,4L,6L,2L,4L,6L,4L,5L,8L,0L,0L,7L,1L,7L,0L,6L,1L,6L,7L,2L,5L,1L,0L,5L,0L,9L,0L,5L,0L,3L,5L,7L,0L,3L,3L,0L,0L,4L,4L,0L,2L,9L,8L,3L,7L,7L,8L,3L,7L,2L,4L,2L,0L,2L,1L,8L,2L,7L,7L,4L,5L,8L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154540Inst : IEnumerable<long>
{
public static readonly long[] Value=A154540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154540.Bytes);
public long this[int i]=>Value[i];

public static A154540Inst Instance=new A154540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154541
{
public static readonly BigInteger[] Value={ 1L,2L,420L,23000L,441000L,89000000L,2340000000L,8210000000L,6160000000000L,25410000000000L,27600000000000L,42600000000000L,2930000000000000L,8440000000000000L,445000000000000000L,BigInteger.Parse("65110000000000000000"),BigInteger.Parse("227000000000000000000"),BigInteger.Parse("250200000000000000000"),BigInteger.Parse("449100000000000000000"),BigInteger.Parse("4932000000000000000000") };
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
public class A154541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154541Inst Instance=new A154541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154542
{
public static readonly long[] Value={ 2L,4L,6L,4L,9L,7L,3L,5L,2L,0L,7L,1L,7L,9L,2L,7L,1L,6L,7L,1L,9L,7L,0L,4L,0L,4L,0L,7L,6L,7L,8L,6L,4L,0L,3L,9L,6L,3L,0L,7L,9L,3L,2L,3L,6L,6L,6L,6L,6L,0L,4L,9L,6L,8L,9L,0L,5L,2L,8L,9L,0L,3L,9L,4L,7L,9L,5L,4L,9L,2L,2L,7L,6L,1L,9L,1L,0L,2L,5L,8L,2L,3L,6L,5L,5L,5L,9L,3L,1L,1L,3L,7L,5L,9L,5L,2L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154542Inst : IEnumerable<long>
{
public static readonly long[] Value=A154542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154542.Bytes);
public long this[int i]=>Value[i];

public static A154542Inst Instance=new A154542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154543
{
public static readonly long[] Value={ 1L,9L,5L,3L,4L,4L,5L,2L,9L,7L,8L,0L,4L,2L,5L,9L,2L,6L,4L,6L,6L,2L,0L,2L,9L,1L,8L,6L,7L,1L,8L,6L,0L,3L,3L,4L,2L,3L,1L,2L,3L,2L,2L,9L,0L,0L,3L,5L,8L,5L,3L,0L,8L,3L,6L,2L,5L,5L,2L,5L,4L,5L,2L,5L,1L,7L,8L,5L,1L,6L,5L,0L,2L,2L,0L,1L,4L,9L,1L,8L,8L,9L,1L,8L,6L,2L,1L,0L,1L,0L,9L,1L,3L,8L,7L,2L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154543Inst : IEnumerable<long>
{
public static readonly long[] Value=A154543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154543.Bytes);
public long this[int i]=>Value[i];

public static A154543Inst Instance=new A154543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154544
{
public static readonly long[] Value={ 3L,5L,7L,37L,43L,53L,59L,73L,79L,83L,97L,223L,227L,229L,347L,349L,359L,367L,379L,389L,397L,439L,443L,449L,463L,563L,569L,577L,587L,593L,599L,643L,653L,659L,673L,683L,739L,743L,757L,773L,839L,853L,857L,859L,863L,883L,887L,937L,953L,983L,997L,1117L,1151L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154544Inst : IEnumerable<long>
{
public static readonly long[] Value=A154544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154544.Bytes);
public long this[int i]=>Value[i];

public static A154544Inst Instance=new A154544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154545
{
public static readonly long[] Value={ 1L,15L,21L,25L,27L,33L,45L,49L,51L,55L,69L,81L,91L,99L,115L,117L,119L,121L,123L,125L,129L,133L,135L,141L,143L,145L,147L,153L,155L,159L,161L,165L,169L,171L,175L,177L,183L,185L,187L,189L,195L,213L,215L,217L,219L,221L,231L,235L,237L,243L,245L,247L,249L,253L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154545Inst : IEnumerable<long>
{
public static readonly long[] Value=A154545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154545.Bytes);
public long this[int i]=>Value[i];

public static A154545Inst Instance=new A154545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154546
{
public static readonly long[] Value={ 0L,2L,20L,26L,32L,52L,60L,72L,76L,80L,96L,106L,110L,112L,122L,132L,142L,176L,180L,206L,216L,232L,236L,242L,246L,260L,262L,280L,282L,286L,292L,312L,320L,342L,346L,362L,366L,370L,406L,410L,420L,422L,432L,450L,460L,462L,470L,486L,500L,512L,532L,546L,562L,570L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154546Inst : IEnumerable<long>
{
public static readonly long[] Value=A154546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154546.Bytes);
public long this[int i]=>Value[i];

public static A154546Inst Instance=new A154546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154547
{
public static readonly long[] Value={ 902501L,10824101L,19096901L,26832401L,40322501L,166926401L,255360401L,309760001L,335622401L,338928101L,404814401L,412090001L,430562501L,441840401L,651270401L,702780101L,885062501L,1006792901L,1029768101L,1160764901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154547Inst : IEnumerable<long>
{
public static readonly long[] Value=A154547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154547.Bytes);
public long this[int i]=>Value[i];

public static A154547Inst Instance=new A154547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154548
{
public static readonly long[] Value={ 60L,72L,180L,282L,312L,420L,432L,462L,570L,642L,810L,1062L,1452L,1620L,2130L,2592L,3252L,3360L,3540L,4050L,4650L,4800L,5640L,5742L,5850L,6090L,6360L,6552L,6792L,7332L,7350L,7560L,7590L,8292L,9042L,9462L,10140L,10530L,10860L,11070L,11172L,11940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154548Inst : IEnumerable<long>
{
public static readonly long[] Value=A154548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154548.Bytes);
public long this[int i]=>Value[i];

public static A154548Inst Instance=new A154548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154549
{
public static readonly long[] Value={ 111111L,222222L,333333L,444444L,555555L,666666L,777777L,888888L,999999L,1111110L,1222221L,1333332L,1444443L,1555554L,1666665L,1777776L,1888887L,1999998L,2111109L,2222220L,2333331L,2444442L,2555553L,2666664L,2777775L,2888886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154549Inst : IEnumerable<long>
{
public static readonly long[] Value=A154549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154549.Bytes);
public long this[int i]=>Value[i];

public static A154549Inst Instance=new A154549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154550
{
public static readonly long[] Value={ 3L,5L,11L,23L,29L,47L,59L,83L,131L,223L,233L,239L,347L,401L,449L,467L,479L,503L,509L,607L,641L,673L,971L,997L,1013L,1151L,1163L,1217L,1249L,1283L,1301L,1399L,1409L,1427L,1451L,1459L,1481L,1523L,1601L,1627L,1709L,1733L,1787L,1847L,1889L,1997L,2039L,2309L,2441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154550Inst : IEnumerable<long>
{
public static readonly long[] Value=A154550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154550.Bytes);
public long this[int i]=>Value[i];

public static A154550Inst Instance=new A154550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154551
{
public static readonly long[] Value={ 3L,5L,7L,29L,37L,67L,89L,97L,151L,181L,241L,257L,269L,271L,359L,373L,421L,439L,457L,509L,563L,571L,577L,593L,659L,709L,739L,769L,853L,947L,991L,997L,1117L,1129L,1193L,1201L,1291L,1297L,1321L,1399L,1423L,1471L,1499L,1511L,1579L,1627L,1657L,1721L,1753L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154551Inst : IEnumerable<long>
{
public static readonly long[] Value=A154551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154551.Bytes);
public long this[int i]=>Value[i];

public static A154551Inst Instance=new A154551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154552
{
public static readonly long[] Value={ 3L,5L,29L,509L,997L,1399L,1627L,3307L,4217L,5477L,5689L,6569L,6599L,7369L,7393L,7841L,8191L,8861L,10067L,11311L,11801L,13859L,14401L,15859L,16987L,17851L,18211L,20593L,21101L,24169L,25013L,25339L,25621L,26209L,28019L,28409L,28439L,32009L,35677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154552Inst : IEnumerable<long>
{
public static readonly long[] Value=A154552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154552.Bytes);
public long this[int i]=>Value[i];

public static A154552Inst Instance=new A154552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154553
{
public static readonly long[] Value={ 2L,3L,23L,503L,991L,1381L,1621L,3301L,4211L,5471L,5683L,6563L,6581L,7351L,7369L,7829L,8179L,8849L,10061L,11299L,11789L,13841L,14389L,15823L,16981L,17839L,18199L,20563L,21089L,24151L,24989L,25321L,25609L,26203L,28001L,28403L,28433L,32003L,35671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154553Inst : IEnumerable<long>
{
public static readonly long[] Value=A154553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154553.Bytes);
public long this[int i]=>Value[i];

public static A154553Inst Instance=new A154553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154554
{
public static readonly long[] Value={ 2L,3L,5L,13L,17L,31L,37L,41L,53L,73L,89L,97L,101L,107L,113L,151L,157L,167L,173L,181L,197L,211L,223L,229L,241L,281L,283L,313L,331L,337L,349L,353L,373L,409L,421L,433L,439L,457L,487L,509L,541L,547L,587L,617L,643L,653L,659L,677L,701L,751L,757L,761L,769L,773L,821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154554Inst : IEnumerable<long>
{
public static readonly long[] Value=A154554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154554.Bytes);
public long this[int i]=>Value[i];

public static A154554Inst Instance=new A154554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154555
{
public static readonly long[] Value={ 7L,11L,19L,43L,47L,127L,131L,163L,179L,191L,199L,263L,347L,367L,419L,431L,443L,491L,503L,523L,571L,619L,691L,727L,743L,787L,839L,863L,1051L,1087L,1091L,1123L,1291L,1319L,1367L,1451L,1487L,1499L,1571L,1579L,1583L,1667L,1723L,1783L,1823L,1931L,1951L,2003L,2039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154555Inst : IEnumerable<long>
{
public static readonly long[] Value=A154555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154555.Bytes);
public long this[int i]=>Value[i];

public static A154555Inst Instance=new A154555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154556
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,1L,-1L,0L,0L,1L,1L,2L,-3L,2L,1L,-1L,-5L,5L,-5L,5L,1L,1L,9L,0L,-5L,0L,9L,1L,-1L,-14L,-21L,35L,-35L,21L,14L,1L,1L,20L,70L,-56L,35L,-56L,70L,20L,1L,-1L,-27L,-162L,-42L,189L,-189L,42L,162L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154556Inst : IEnumerable<long>
{
public static readonly long[] Value=A154556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154556.Bytes);
public long this[int i]=>Value[i];

public static A154556Inst Instance=new A154556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154557
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,-1L,2L,1L,0L,3L,-3L,3L,1L,0L,-15L,12L,-6L,4L,1L,0L,105L,-75L,30L,-10L,5L,1L,0L,-945L,630L,-225L,60L,-15L,6L,1L,0L,10395L,-6615L,2205L,-525L,105L,-21L,7L,1L,0L,-135135L,83160L,-26460L,5880L,-1050L,168L,-28L,8L,1L,0L,2027025L,-1216215L,374220L,-79380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154557Inst : IEnumerable<long>
{
public static readonly long[] Value=A154557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154557.Bytes);
public long this[int i]=>Value[i];

public static A154557Inst Instance=new A154557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154558
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,1L,6L,12L,9L,1L,8L,24L,36L,21L,1L,10L,40L,90L,105L,51L,1L,12L,60L,180L,315L,306L,127L,1L,14L,84L,315L,735L,1071L,889L,323L,1L,16L,112L,504L,1470L,2856L,3556L,2584L,835L,1L,18L,144L,756L,2646L,6426L,10668L,11628L,7515L,2188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154558Inst : IEnumerable<long>
{
public static readonly long[] Value=A154558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154558.Bytes);
public long this[int i]=>Value[i];

public static A154558Inst Instance=new A154558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154559
{
public static readonly long[] Value={ 1L,2L,0L,3L,2L,0L,4L,6L,4L,0L,5L,12L,16L,9L,0L,6L,20L,40L,45L,21L,0L,7L,30L,80L,135L,126L,51L,0L,8L,42L,140L,315L,441L,357L,127L,0L,9L,56L,224L,630L,1176L,1428L,1016L,323L,0L,10L,72L,336L,1134L,2646L,4284L,4572L,2907L,835L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154559Inst : IEnumerable<long>
{
public static readonly long[] Value=A154559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154559.Bytes);
public long this[int i]=>Value[i];

public static A154559Inst Instance=new A154559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154560
{
public static readonly long[] Value={ 1L,9L,26L,55L,99L,161L,244L,351L,485L,649L,846L,1079L,1351L,1665L,2024L,2431L,2889L,3401L,3970L,4599L,5291L,6049L,6876L,7775L,8749L,9801L,10934L,12151L,13455L,14849L,16336L,17919L,19601L,21385L,23274L,25271L,27379L,29601L,31940L,34399L,36981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154560Inst : IEnumerable<long>
{
public static readonly long[] Value=A154560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154560.Bytes);
public long this[int i]=>Value[i];

public static A154560Inst Instance=new A154560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154561
{
public static readonly long[] Value={ 3L,5L,11L,7L,13L,17L,23L,13L,23L,23L,13L,17L,23L,29L,19L,17L,29L,23L,17L,19L,23L,29L,23L,19L,31L,23L,17L,19L,29L,31L,31L,23L,11L,19L,19L,17L,19L,23L,17L,17L,17L,23L,29L,31L,23L,29L,23L,13L,19L,19L,31L,23L,23L,17L,11L,31L,23L,13L,23L,29L,23L,29L,29L,19L,23L,31L,37L,29L,37L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154561Inst : IEnumerable<long>
{
public static readonly long[] Value=A154561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154561.Bytes);
public long this[int i]=>Value[i];

public static A154561Inst Instance=new A154561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154562
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,101L,202L,233L,303L,351L,404L,427L,466L,505L,606L,699L,707L,808L,909L,1252L,2068L,5050L,10001L,19247L,20002L,30003L,40004L,50005L,60006L,70007L,80008L,90009L,319519L,500050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154562Inst : IEnumerable<long>
{
public static readonly long[] Value=A154562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154562.Bytes);
public long this[int i]=>Value[i];

public static A154562Inst Instance=new A154562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154563
{
public static readonly long[] Value={ 18L,60L,138L,150L,1278L,1620L,2730L,4128L,6360L,11718L,13398L,17490L,20808L,23028L,28308L,29670L,51870L,61380L,69828L,73848L,78540L,92568L,97500L,115770L,138570L,166668L,176610L,193380L,200928L,258318L,304980L,430008L,500910L,518760L,536190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154563Inst : IEnumerable<long>
{
public static readonly long[] Value=A154563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154563.Bytes);
public long this[int i]=>Value[i];

public static A154563Inst Instance=new A154563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154564
{
public static readonly long[] Value={ 1L,6L,8L,2L,6L,0L,6L,1L,9L,4L,4L,8L,5L,9L,8L,5L,2L,9L,5L,1L,3L,4L,5L,6L,6L,3L,5L,9L,2L,7L,1L,0L,5L,2L,2L,5L,3L,0L,2L,4L,6L,6L,9L,3L,9L,9L,8L,7L,3L,1L,6L,7L,2L,0L,9L,6L,6L,0L,0L,5L,6L,6L,9L,1L,4L,9L,3L,7L,4L,6L,1L,6L,2L,9L,2L,6L,9L,1L,3L,2L,7L,7L,3L,3L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154564Inst : IEnumerable<long>
{
public static readonly long[] Value=A154564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154564.Bytes);
public long this[int i]=>Value[i];

public static A154564Inst Instance=new A154564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154565
{
public static readonly long[] Value={ 2L,15L,51L,210L,330L,651L,1365L,1650L,1926L,3480L,5430L,5985L,6501L,11310L,16485L,16590L,21660L,25026L,27270L,28635L,35190L,38001L,39285L,46905L,48690L,58905L,64170L,90651L,109485L,143376L,148995L,151845L,190995L,311676L,316251L,332526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154565Inst : IEnumerable<long>
{
public static readonly long[] Value=A154565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154565.Bytes);
public long this[int i]=>Value[i];

public static A154565Inst Instance=new A154565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154566
{
public static readonly long[] Value={ 1023456789L,3164252736L,4642110594L,5623720662L,6312942339L,6813614229L,7197035958L,7513755246L,7747685775L,7961085846L,8120306331L,8275283289L,8393900487L,8626922994L,8594070624L,8691229761L,8800389678L,8807854905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154566Inst : IEnumerable<long>
{
public static readonly long[] Value=A154566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154566.Bytes);
public long this[int i]=>Value[i];

public static A154566Inst Instance=new A154566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154567
{
public static readonly long[] Value={ 1L,5L,1L,1L,3L,9L,1L,5L,9L,4L,4L,6L,9L,3L,8L,5L,5L,8L,6L,2L,0L,2L,9L,8L,6L,8L,1L,9L,6L,1L,8L,6L,4L,7L,7L,9L,5L,7L,8L,5L,4L,4L,9L,4L,9L,4L,3L,6L,7L,5L,4L,4L,3L,7L,1L,0L,9L,1L,2L,0L,4L,0L,6L,0L,4L,1L,6L,7L,0L,9L,1L,5L,6L,5L,3L,5L,4L,1L,6L,8L,2L,6L,4L,8L,3L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154567Inst : IEnumerable<long>
{
public static readonly long[] Value=A154567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154567.Bytes);
public long this[int i]=>Value[i];

public static A154567Inst Instance=new A154567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154568
{
public static readonly long[] Value={ 8L,10L,15L,18L,14L,12L,6L,9L,12L,15L,22L,16L,10L,20L,16L,10L,18L,21L,8L,14L,10L,20L,22L,16L,21L,26L,15L,22L,16L,18L,21L,26L,15L,24L,18L,14L,21L,15L,24L,22L,30L,20L,22L,15L,18L,20L,27L,26L,26L,24L,27L,34L,34L,21L,21L,22L,25L,32L,32L,28L,22L,27L,27L,36L,30L,25L,28L,18L,20L,18L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154568Inst : IEnumerable<long>
{
public static readonly long[] Value=A154568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154568.Bytes);
public long this[int i]=>Value[i];

public static A154568Inst Instance=new A154568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154569
{
public static readonly BigInteger[] Value={ 0L,4L,372L,95304L,45231880L,33784239180L,36348656777148L,53168436739227280L,BigInteger.Parse("101441716823942402448"),BigInteger.Parse("244654264259760069435540"),BigInteger.Parse("727702646597963991868772740"),BigInteger.Parse("2616780161875511741808194232024"),BigInteger.Parse("11190492899233441015089845457437592") };
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
public class A154569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154569Inst Instance=new A154569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154570
{
public static readonly long[] Value={ 1L,3L,-4L,2L,-6L,-2L,-14L,-18L,-46L,-82L,-174L,-338L,-686L,-1362L,-2734L,-5458L,-10926L,-21842L,-43694L,-87378L,-174766L,-349522L,-699054L,-1398098L,-2796206L,-5592402L,-11184814L,-22369618L,-44739246L,-89478482L,-178956974L,-357913938L,-715827886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154570Inst : IEnumerable<long>
{
public static readonly long[] Value=A154570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154570.Bytes);
public long this[int i]=>Value[i];

public static A154570Inst Instance=new A154570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154571
{
public static readonly long[] Value={ 0L,3L,4L,5L,7L,8L,12L,15L,16L,17L,19L,20L,24L,27L,28L,29L,31L,32L,36L,39L,40L,41L,43L,44L,48L,51L,52L,53L,55L,56L,60L,63L,64L,65L,67L,68L,72L,75L,76L,77L,79L,80L,84L,87L,88L,89L,91L,92L,96L,99L,100L,101L,103L,104L,108L,111L,112L,113L,115L,116L,120L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154571Inst : IEnumerable<long>
{
public static readonly long[] Value=A154571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154571.Bytes);
public long this[int i]=>Value[i];

public static A154571Inst Instance=new A154571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154572
{
public static readonly long[] Value={ 1L,3L,9L,1L,6L,6L,2L,5L,0L,9L,4L,0L,0L,4L,9L,5L,7L,6L,4L,1L,0L,8L,3L,0L,1L,6L,5L,0L,8L,2L,0L,4L,7L,7L,1L,5L,5L,0L,1L,0L,9L,1L,5L,2L,7L,1L,3L,5L,6L,3L,7L,3L,6L,1L,8L,3L,6L,2L,1L,7L,3L,7L,1L,4L,9L,7L,2L,7L,9L,6L,6L,1L,0L,3L,8L,9L,6L,1L,0L,2L,5L,6L,3L,1L,9L,9L,0L,5L,6L,4L,0L,8L,3L,6L,8L,6L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154572Inst : IEnumerable<long>
{
public static readonly long[] Value=A154572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154572.Bytes);
public long this[int i]=>Value[i];

public static A154572Inst Instance=new A154572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154573
{
public static readonly long[] Value={ 9699690L,65893166030L,10042712381260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154573Inst : IEnumerable<long>
{
public static readonly long[] Value=A154573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154573.Bytes);
public long this[int i]=>Value[i];

public static A154573Inst Instance=new A154573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154574
{
public static readonly long[] Value={ 1L,3L,0L,2L,2L,9L,6L,8L,6L,5L,2L,0L,2L,8L,3L,9L,5L,0L,9L,7L,7L,4L,6L,8L,6L,1L,2L,4L,4L,7L,9L,0L,6L,8L,8L,9L,4L,8L,7L,4L,8L,8L,1L,9L,3L,3L,5L,7L,2L,3L,5L,3L,8L,9L,0L,8L,3L,6L,8L,3L,6L,3L,5L,0L,1L,1L,9L,0L,1L,1L,0L,0L,1L,4L,6L,7L,6L,6L,1L,2L,5L,9L,4L,5L,7L,4L,7L,3L,4L,0L,6L,0L,9L,2L,4L,8L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154574Inst : IEnumerable<long>
{
public static readonly long[] Value=A154574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154574.Bytes);
public long this[int i]=>Value[i];

public static A154574Inst Instance=new A154574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154575
{
public static readonly long[] Value={ 18L,36L,58L,84L,114L,148L,186L,228L,274L,324L,378L,436L,498L,564L,634L,708L,786L,868L,954L,1044L,1138L,1236L,1338L,1444L,1554L,1668L,1786L,1908L,2034L,2164L,2298L,2436L,2578L,2724L,2874L,3028L,3186L,3348L,3514L,3684L,3858L,4036L,4218L,4404L,4594L,4788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154575Inst : IEnumerable<long>
{
public static readonly long[] Value=A154575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154575.Bytes);
public long this[int i]=>Value[i];

public static A154575Inst Instance=new A154575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154576
{
public static readonly long[] Value={ 21L,41L,65L,93L,125L,161L,201L,245L,293L,345L,401L,461L,525L,593L,665L,741L,821L,905L,993L,1085L,1181L,1281L,1385L,1493L,1605L,1721L,1841L,1965L,2093L,2225L,2361L,2501L,2645L,2793L,2945L,3101L,3261L,3425L,3593L,3765L,3941L,4121L,4305L,4493L,4685L,4881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154576Inst : IEnumerable<long>
{
public static readonly long[] Value=A154576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154576.Bytes);
public long this[int i]=>Value[i];

public static A154576Inst Instance=new A154576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154577
{
public static readonly long[] Value={ 5L,41L,293L,401L,461L,593L,821L,1181L,1493L,1721L,3593L,4493L,5081L,7793L,12941L,16001L,16361L,17093L,21821L,28541L,29021L,31481L,33521L,36161L,39461L,45281L,48341L,54101L,56093L,65141L,66593L,74093L,75641L,76421L,83621L,92861L,98993L,101681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154577Inst : IEnumerable<long>
{
public static readonly long[] Value=A154577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154577.Bytes);
public long this[int i]=>Value[i];

public static A154577Inst Instance=new A154577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154578
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,8L,6L,7L,6L,0L,3L,5L,8L,9L,6L,3L,5L,8L,3L,5L,9L,8L,5L,2L,0L,2L,0L,3L,8L,3L,9L,3L,2L,0L,1L,9L,8L,1L,5L,3L,9L,6L,6L,1L,8L,3L,3L,3L,3L,0L,2L,4L,8L,4L,4L,5L,2L,6L,4L,4L,5L,1L,9L,7L,3L,9L,7L,7L,4L,6L,1L,3L,8L,0L,9L,5L,5L,1L,2L,9L,1L,1L,8L,2L,7L,7L,9L,6L,5L,5L,6L,8L,7L,9L,7L,6L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154578Inst : IEnumerable<long>
{
public static readonly long[] Value=A154578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154578.Bytes);
public long this[int i]=>Value[i];

public static A154578Inst Instance=new A154578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154579
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,23L,29L,37L,47L,53L,59L,67L,71L,73L,89L,97L,103L,107L,149L,167L,173L,197L,241L,269L,271L,281L,283L,347L,349L,359L,401L,439L,461L,463L,467L,487L,503L,521L,569L,593L,659L,683L,829L,839L,853L,863L,953L,1487L,1489L,1607L,1609L,1637L,2087L,2089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154579Inst : IEnumerable<long>
{
public static readonly long[] Value=A154579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154579.Bytes);
public long this[int i]=>Value[i];

public static A154579Inst Instance=new A154579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154580
{
public static readonly long[] Value={ 1L,1L,7L,6L,0L,9L,1L,2L,5L,9L,0L,5L,5L,6L,8L,1L,2L,4L,2L,0L,8L,1L,2L,8L,9L,0L,0L,8L,5L,3L,0L,6L,2L,2L,2L,8L,2L,4L,3L,1L,9L,3L,8L,9L,8L,2L,7L,2L,8L,5L,8L,7L,3L,2L,3L,5L,1L,9L,4L,3L,8L,1L,7L,9L,1L,7L,8L,1L,2L,0L,9L,6L,3L,5L,0L,9L,2L,3L,6L,6L,1L,3L,5L,5L,6L,0L,4L,1L,1L,0L,3L,5L,2L,9L,4L,3L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154580Inst : IEnumerable<long>
{
public static readonly long[] Value=A154580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154580.Bytes);
public long this[int i]=>Value[i];

public static A154580Inst Instance=new A154580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154581
{
public static readonly long[] Value={ 1L,1L,2L,9L,3L,4L,4L,6L,5L,1L,4L,6L,2L,5L,6L,5L,8L,6L,0L,6L,2L,2L,1L,1L,8L,8L,7L,1L,2L,1L,1L,7L,4L,9L,4L,4L,2L,4L,0L,9L,6L,0L,5L,0L,8L,8L,0L,3L,7L,8L,2L,5L,1L,9L,8L,2L,5L,9L,2L,2L,9L,0L,9L,2L,1L,0L,0L,8L,4L,5L,6L,6L,8L,2L,7L,6L,0L,0L,0L,2L,9L,5L,6L,6L,4L,3L,8L,3L,1L,6L,3L,1L,1L,3L,0L,0L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154581Inst : IEnumerable<long>
{
public static readonly long[] Value=A154581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154581.Bytes);
public long this[int i]=>Value[i];

public static A154581Inst Instance=new A154581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154582
{
public static readonly long[] Value={ 1L,0L,8L,9L,7L,9L,9L,5L,7L,1L,0L,7L,5L,7L,3L,7L,2L,8L,6L,5L,3L,9L,8L,6L,1L,1L,8L,5L,0L,5L,3L,4L,3L,6L,1L,9L,4L,6L,8L,7L,1L,5L,2L,8L,4L,9L,7L,4L,4L,5L,6L,2L,3L,5L,5L,6L,1L,3L,2L,7L,3L,0L,3L,9L,0L,3L,7L,6L,5L,2L,9L,7L,0L,0L,8L,1L,2L,7L,1L,5L,9L,7L,9L,6L,7L,5L,2L,8L,0L,6L,5L,9L,8L,3L,7L,7L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154582Inst : IEnumerable<long>
{
public static readonly long[] Value=A154582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154582.Bytes);
public long this[int i]=>Value[i];

public static A154582Inst Instance=new A154582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154583
{
public static readonly long[] Value={ 1L,0L,5L,5L,7L,9L,0L,9L,0L,4L,1L,0L,6L,6L,9L,8L,0L,3L,2L,6L,1L,9L,1L,4L,4L,0L,7L,0L,7L,4L,4L,8L,8L,2L,9L,9L,4L,9L,9L,2L,9L,9L,7L,0L,5L,3L,4L,0L,3L,2L,2L,8L,4L,9L,3L,3L,1L,7L,4L,0L,6L,1L,6L,7L,8L,5L,5L,9L,1L,8L,5L,9L,0L,8L,3L,8L,5L,5L,6L,9L,2L,7L,5L,1L,6L,8L,0L,8L,9L,5L,1L,0L,0L,3L,0L,4L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154583Inst : IEnumerable<long>
{
public static readonly long[] Value=A154583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154583.Bytes);
public long this[int i]=>Value[i];

public static A154583Inst Instance=new A154583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154584
{
public static readonly long[] Value={ 1L,0L,2L,6L,1L,4L,2L,9L,9L,8L,3L,7L,7L,7L,6L,1L,5L,5L,6L,5L,8L,1L,9L,5L,3L,2L,6L,2L,3L,9L,0L,4L,2L,1L,9L,1L,1L,4L,9L,3L,7L,2L,4L,9L,3L,1L,0L,4L,9L,3L,9L,0L,7L,6L,2L,0L,1L,5L,9L,3L,9L,0L,7L,1L,3L,0L,2L,9L,9L,5L,2L,5L,9L,5L,8L,4L,1L,9L,5L,4L,0L,8L,7L,9L,3L,0L,5L,1L,9L,9L,0L,4L,9L,6L,0L,4L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154584Inst : IEnumerable<long>
{
public static readonly long[] Value=A154584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154584.Bytes);
public long this[int i]=>Value[i];

public static A154584Inst Instance=new A154584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154585
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,2L,4L,0L,3L,4L,5L,4L,1L,10L,4L,3L,1L,2L,9L,2L,11L,12L,17L,11L,0L,13L,0L,1L,6L,7L,23L,8L,7L,20L,10L,9L,8L,25L,14L,13L,4L,3L,20L,13L,34L,35L,34L,26L,8L,13L,6L,5L,8L,25L,24L,1L,26L,27L,34L,33L,4L,37L,25L,6L,11L,12L,11L,16L,37L,38L,60L,59L,24L,25L,0L,19L,40L,41L,54L,14L,25L,26L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154585Inst : IEnumerable<long>
{
public static readonly long[] Value=A154585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154585.Bytes);
public long this[int i]=>Value[i];

public static A154585Inst Instance=new A154585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154586
{
public static readonly long[] Value={ 1L,4L,8L,25L,27L,75L,209L,3507L,8466L,16179L,29285L,33987L,175904L,326764L,1161207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154586Inst : IEnumerable<long>
{
public static readonly long[] Value=A154586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154586.Bytes);
public long this[int i]=>Value[i];

public static A154586Inst Instance=new A154586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154587
{
public static readonly BigInteger[] Value={ 5L,28L,71208L,74139L,9260197734L,12374540078L,7574780746329L,11101148723618L,102581905748236L,3325997869054417L,BigInteger.Parse("2886018916559052244845"),BigInteger.Parse("46437379006448216748610"),BigInteger.Parse("120197329614203475099994") };
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
public class A154587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154587Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154587.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154587Inst Instance=new A154587Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154588
{
public static readonly long[] Value={ 1L,28L,435L,10296L,415416L,1062153L,3703281L,426626655L,782002378L,102886232631L,1636197988776L,2749764593278L,61972139524851L,813577626225078L,1604393353172781L,3603538956517305L,44000970048906445L,83556903098276790L,208955344344897381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154588Inst : IEnumerable<long>
{
public static readonly long[] Value=A154588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154588.Bytes);
public long this[int i]=>Value[i];

public static A154588Inst Instance=new A154588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154589
{
public static readonly long[] Value={ 4L,-1L,-2L,-4L,-8L,-16L,-32L,-64L,-128L,-256L,-512L,-1024L,-2048L,-4096L,-8192L,-16384L,-32768L,-65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154589Inst : IEnumerable<long>
{
public static readonly long[] Value=A154589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154589.Bytes);
public long this[int i]=>Value[i];

public static A154589Inst Instance=new A154589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154590
{
public static readonly long[] Value={ 24L,46L,72L,102L,136L,174L,216L,262L,312L,366L,424L,486L,552L,622L,696L,774L,856L,942L,1032L,1126L,1224L,1326L,1432L,1542L,1656L,1774L,1896L,2022L,2152L,2286L,2424L,2566L,2712L,2862L,3016L,3174L,3336L,3502L,3672L,3846L,4024L,4206L,4392L,4582L,4776L,4974L,5176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154590Inst : IEnumerable<long>
{
public static readonly long[] Value=A154590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154590.Bytes);
public long this[int i]=>Value[i];

public static A154590Inst Instance=new A154590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154591
{
public static readonly long[] Value={ 27L,51L,79L,111L,147L,187L,231L,279L,331L,387L,447L,511L,579L,651L,727L,807L,891L,979L,1071L,1167L,1267L,1371L,1479L,1591L,1707L,1827L,1951L,2079L,2211L,2347L,2487L,2631L,2779L,2931L,3087L,3247L,3411L,3579L,3751L,3927L,4107L,4291L,4479L,4671L,4867L,5067L,5271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154591Inst : IEnumerable<long>
{
public static readonly long[] Value=A154591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154591.Bytes);
public long this[int i]=>Value[i];

public static A154591Inst Instance=new A154591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154592
{
public static readonly long[] Value={ 7L,79L,331L,727L,1951L,2347L,5479L,8287L,9907L,10771L,17827L,18979L,21391L,22651L,26647L,28051L,32479L,42307L,44071L,51487L,55411L,57427L,63691L,65851L,72547L,77191L,89431L,99871L,108079L,113731L,147391L,157327L,160711L,171079L,211867L,223747L,235951L,252727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154592Inst : IEnumerable<long>
{
public static readonly long[] Value=A154592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154592.Bytes);
public long this[int i]=>Value[i];

public static A154592Inst Instance=new A154592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154593
{
public static readonly long[] Value={ 1L,-1L,3L,9L,6L,9L,-73L,-75L,9L,27L,849L,1644L,774L,108L,81L,-12241L,-33849L,-28098L,-6426L,243L,243L,211929L,763314L,938007L,442044L,60183L,1458L,729L,-4280473L,-18995271L,-31035393L,-22471479L,-6681123L,-528525L,3645L,2187L,98806689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154593Inst : IEnumerable<long>
{
public static readonly long[] Value=A154593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154593.Bytes);
public long this[int i]=>Value[i];

public static A154593Inst Instance=new A154593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154594
{
public static readonly long[] Value={ 1L,-2L,-2L,4L,26L,4L,-8L,-186L,-240L,-8L,16L,1090L,4524L,2008L,16L,-32L,-5866L,-57992L,-85424L,-16288L,-32L,64L,30354L,616452L,2099504L,1423968L,130848L,64L,-128L,-154202L,-5902944L,-39122296L,-61925632L,-22159968L,-1048064L,-128L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154594Inst : IEnumerable<long>
{
public static readonly long[] Value=A154594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154594.Bytes);
public long this[int i]=>Value[i];

public static A154594Inst Instance=new A154594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154595
{
public static readonly long[] Value={ 1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L,3L,-1L,-3L,-3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154595Inst : IEnumerable<long>
{
public static readonly long[] Value=A154595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154595.Bytes);
public long this[int i]=>Value[i];

public static A154595Inst Instance=new A154595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154596
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,129L,3214L,162491L,16306117L,3231430542L,1254563121783L,953359099059949L,1417753660258148022L,BigInteger.Parse("4128222097278496550683"),BigInteger.Parse("23571703478682225135264061"),BigInteger.Parse("264268834213603744830353397238") };
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
public class A154596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154596Inst Instance=new A154596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154597
{
public static readonly long[] Value={ 1L,15L,226L,3405L,51301L,772920L,11645101L,175449435L,2643386626L,39826248825L,600037119001L,9040383033840L,136205782626601L,2052127122432855L,30918112619119426L,465823816409224245L,7018275358757483101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154597Inst : IEnumerable<long>
{
public static readonly long[] Value=A154597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154597.Bytes);
public long this[int i]=>Value[i];

public static A154597Inst Instance=new A154597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154598
{
public static readonly long[] Value={ 5L,19L,89L,271L,1889L,10529L,75329L,157951L,3885569L,11350529L,98690561L,65071999L,652963841L,6548416001L,253401579521L,160283668481L,1851643543553L,3450998226943L,23114453401601L,1194899749142527L,1101483715526657L,7093521158963201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154598Inst : IEnumerable<long>
{
public static readonly long[] Value=A154598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154598.Bytes);
public long this[int i]=>Value[i];

public static A154598Inst Instance=new A154598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154599
{
public static readonly long[] Value={ 30L,56L,86L,120L,158L,200L,246L,296L,350L,408L,470L,536L,606L,680L,758L,840L,926L,1016L,1110L,1208L,1310L,1416L,1526L,1640L,1758L,1880L,2006L,2136L,2270L,2408L,2550L,2696L,2846L,3000L,3158L,3320L,3486L,3656L,3830L,4008L,4190L,4376L,4566L,4760L,4958L,5160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154599Inst : IEnumerable<long>
{
public static readonly long[] Value=A154599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154599.Bytes);
public long this[int i]=>Value[i];

public static A154599Inst Instance=new A154599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154600
{
public static readonly long[] Value={ 33L,61L,93L,129L,169L,213L,261L,313L,369L,429L,493L,561L,633L,709L,789L,873L,961L,1053L,1149L,1249L,1353L,1461L,1573L,1689L,1809L,1933L,2061L,2193L,2329L,2469L,2613L,2761L,2913L,3069L,3229L,3393L,3561L,3733L,3909L,4089L,4273L,4461L,4653L,4849L,5049L,5253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154600Inst : IEnumerable<long>
{
public static readonly long[] Value=A154600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154600.Bytes);
public long this[int i]=>Value[i];

public static A154600Inst Instance=new A154600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154601
{
public static readonly long[] Value={ 61L,313L,709L,1249L,1933L,3229L,3733L,4273L,6793L,8269L,10753L,12589L,16693L,20149L,23929L,25261L,29473L,30949L,35593L,44053L,45853L,79549L,89413L,91969L,94561L,108061L,116593L,128473L,140929L,150649L,164113L,189061L,200293L,240073L,248461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154601Inst : IEnumerable<long>
{
public static readonly long[] Value=A154601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154601.Bytes);
public long this[int i]=>Value[i];

public static A154601Inst Instance=new A154601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154602
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,11L,19L,9L,1L,49L,104L,70L,16L,1L,257L,641L,550L,190L,25L,1L,1539L,4380L,4531L,2080L,425L,36L,1L,10299L,32803L,39515L,22491L,6265L,833L,49L,1L,75905L,266768L,365324L,247072L,87206L,16016L,1484L,64L,1L,609441L,2337505L,3575820L,2792476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154602Inst : IEnumerable<long>
{
public static readonly long[] Value=A154602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154602.Bytes);
public long this[int i]=>Value[i];

public static A154602Inst Instance=new A154602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154603
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,31L,110L,400L,1757L,7861L,41402L,220540L,1358183L,8405203L,59340710L,418689544L,3335855897L,26440317193L,234747589106L,2065458479476L,20224631361251L,195625329965671L,2094552876276830L,22092621409440256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154603Inst : IEnumerable<long>
{
public static readonly long[] Value=A154603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154603.Bytes);
public long this[int i]=>Value[i];

public static A154603Inst Instance=new A154603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154604
{
public static readonly BigInteger[] Value={ 1L,1L,3L,54L,9720L,26244000L,1488034800000L,2362404048480000000L,BigInteger.Parse("135019896025206528000000000"),BigInteger.Parse("347259290825980971841536000000000000"),BigInteger.Parse("49121618545275670528799969525760000000000000000") };
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
public class A154604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154604Inst Instance=new A154604Inst();

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