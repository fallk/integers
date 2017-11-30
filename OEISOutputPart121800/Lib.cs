using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A155764
{
public static readonly long[] Value={ 0L,1L,3L,9L,15L,18L,21L,27L,33L,39L,42L,45L,48L,75L,87L,93L,117L,120L,135L,138L,168L,183L,210L,228L,300L,333L,369L,393L,453L,525L,621L,720L,810L,846L,1086L,1281L,1305L,1515L,1590L,1617L,1722L,1794L,1833L,1851L,2010L,2064L,2085L,2112L,2217L,2352L,2754L,2784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155764Inst : IEnumerable<long>
{
public static readonly long[] Value=A155764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155764.Bytes);
public long this[int i]=>Value[i];

public static A155764Inst Instance=new A155764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155765
{
public static readonly long[] Value={ 2L,4L,8L,22L,46L,121L,128L,136L,146L,238L,265L,286L,341L,344L,526L,904L,1114L,1691L,1736L,1751L,1781L,2476L,3097L,3551L,5131L,8504L,10342L,18526L,22564L,24776L,40072L,68707L,125903L,174913L,181267L,371428L,827576L,936118L,1054141L,1159864L,1353559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155765Inst : IEnumerable<long>
{
public static readonly long[] Value=A155765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155765.Bytes);
public long this[int i]=>Value[i];

public static A155765Inst Instance=new A155765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155766
{
public static readonly long[] Value={ 2L,3L,7L,5L,23L,19L,19L,47L,43L,13L,107L,211L,37L,101L,73L,31L,191L,199L,103L,239L,271L,107L,569L,313L,179L,281L,397L,109L,491L,463L,191L,857L,919L,113L,503L,283L,491L,1619L,523L,199L,659L,691L,223L,821L,1321L,241L,1307L,1627L,293L,1373L,1621L,751L,2399L,823L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155766Inst : IEnumerable<long>
{
public static readonly long[] Value=A155766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155766.Bytes);
public long this[int i]=>Value[i];

public static A155766Inst Instance=new A155766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155767
{
public static readonly long[] Value={ 2L,5L,11L,11L,31L,29L,31L,61L,59L,31L,127L,233L,61L,127L,101L,61L,223L,233L,139L,277L,311L,149L,613L,359L,227L,331L,449L,163L,547L,521L,251L,919L,983L,179L,571L,353L,563L,1693L,599L,277L,739L,773L,307L,907L,1409L,331L,1399L,1721L,389L,1471L,1721L,853L,2503L,929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155767Inst : IEnumerable<long>
{
public static readonly long[] Value=A155767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155767.Bytes);
public long this[int i]=>Value[i];

public static A155767Inst Instance=new A155767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155768
{
public static readonly long[] Value={ 1L,2L,3L,4L,11L,13L,14L,16L,18L,20L,21L,23L,25L,82L,83L,98L,100L,115L,116L,117L,119L,132L,133L,135L,142L,147L,150L,160L,162L,164L,166L,717L,835L,843L,933L,956L,968L,970L,1055L,1062L,1066L,1076L,1088L,1090L,1092L,1093L,1166L,1167L,1179L,1190L,1191L,1199L,1202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155768Inst : IEnumerable<long>
{
public static readonly long[] Value=A155768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155768.Bytes);
public long this[int i]=>Value[i];

public static A155768Inst Instance=new A155768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155769
{
public static readonly long[] Value={ -41L,-37L,-29L,-17L,-1L,19L,43L,71L,103L,139L,179L,223L,271L,323L,379L,439L,503L,571L,643L,719L,799L,883L,971L,1063L,1159L,1259L,1363L,1471L,1583L,1699L,1819L,1943L,2071L,2203L,2339L,2479L,2623L,2771L,2923L,3079L,3239L,3403L,3571L,3743L,3919L,4099L,4283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155769Inst : IEnumerable<long>
{
public static readonly long[] Value=A155769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155769.Bytes);
public long this[int i]=>Value[i];

public static A155769Inst Instance=new A155769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155770
{
public static readonly long[] Value={ 19L,43L,71L,103L,139L,179L,223L,271L,379L,439L,503L,571L,643L,719L,883L,971L,1063L,1259L,1471L,1583L,1699L,2203L,2339L,3079L,3571L,3919L,4099L,4283L,4663L,5059L,5471L,5683L,6343L,6571L,6803L,7039L,7523L,8539L,8803L,9343L,9619L,11059L,11971L,12919L,13903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155770Inst : IEnumerable<long>
{
public static readonly long[] Value=A155770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155770.Bytes);
public long this[int i]=>Value[i];

public static A155770Inst Instance=new A155770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155771
{
public static readonly long[] Value={ 5L,6L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,21L,22L,23L,25L,27L,28L,29L,33L,34L,39L,42L,44L,45L,46L,48L,50L,52L,53L,56L,57L,58L,59L,61L,65L,66L,68L,69L,74L,77L,80L,83L,86L,87L,90L,91L,93L,95L,96L,99L,101L,103L,104L,106L,107L,110L,116L,121L,126L,128L,130L,131L,133L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155771Inst : IEnumerable<long>
{
public static readonly long[] Value=A155771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155771.Bytes);
public long this[int i]=>Value[i];

public static A155771Inst Instance=new A155771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155772
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,23L,29L,53L,59L,61L,83L,101L,103L,107L,131L,151L,179L,181L,191L,193L,199L,227L,239L,269L,281L,293L,313L,367L,383L,389L,419L,439L,467L,487L,503L,521L,541L,569L,587L,599L,601L,607L,617L,641L,647L,653L,673L,677L,691L,709L,733L,739L,757L,769L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155772Inst : IEnumerable<long>
{
public static readonly long[] Value=A155772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155772.Bytes);
public long this[int i]=>Value[i];

public static A155772Inst Instance=new A155772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155773
{
public static readonly long[] Value={ 1L,1L,7L,1L,2L,6L,7L,6L,4L,1L,1L,6L,5L,2L,4L,5L,5L,4L,1L,8L,6L,3L,9L,7L,9L,2L,0L,4L,3L,5L,0L,4L,8L,0L,7L,6L,1L,5L,3L,8L,1L,8L,7L,6L,6L,3L,3L,2L,9L,0L,3L,8L,4L,4L,6L,5L,5L,0L,4L,9L,6L,8L,1L,2L,0L,9L,0L,3L,8L,1L,3L,0L,7L,1L,7L,5L,7L,1L,8L,6L,1L,6L,7L,7L,1L,5L,7L,1L,1L,0L,6L,1L,8L,1L,3L,3L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155773Inst : IEnumerable<long>
{
public static readonly long[] Value=A155773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155773.Bytes);
public long this[int i]=>Value[i];

public static A155773Inst Instance=new A155773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155774
{
public static readonly long[] Value={ 7L,17L,19L,31L,37L,41L,73L,487L,619L,1487L,1489L,1597L,11699L,29629L,95443L,111119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155774Inst : IEnumerable<long>
{
public static readonly long[] Value=A155774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155774.Bytes);
public long this[int i]=>Value[i];

public static A155774Inst Instance=new A155774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155775
{
public static readonly long[] Value={ 9L,15L,33L,35L,39L,55L,57L,69L,75L,77L,91L,203L,205L,207L,209L,219L,237L,247L,249L,355L,365L,391L,405L,483L,633L,749L,1475L,1501L,1515L,1595L,1605L,1615L,1631L,2611L,2637L,2829L,11603L,11803L,13479L,20797L,20891L,95375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155775Inst : IEnumerable<long>
{
public static readonly long[] Value=A155775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155775.Bytes);
public long this[int i]=>Value[i];

public static A155775Inst Instance=new A155775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155776
{
public static readonly long[] Value={ 6L,8L,10L,12L,22L,24L,34L,52L,70L,72L,88L,92L,104L,204L,232L,278L,348L,350L,364L,376L,486L,644L,1478L,1504L,1830L,2622L,2646L,3694L,3704L,11602L,11706L,12560L,20884L,21698L,29630L,96140L,809912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155776Inst : IEnumerable<long>
{
public static readonly long[] Value=A155776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155776.Bytes);
public long this[int i]=>Value[i];

public static A155776Inst Instance=new A155776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155777
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,23L,31L,37L,47L,53L,67L,71L,73L,103L,107L,113L,127L,131L,137L,151L,157L,167L,173L,211L,223L,227L,233L,251L,257L,271L,277L,307L,311L,313L,317L,331L,337L,347L,353L,367L,373L,457L,467L,503L,521L,523L,541L,547L,557L,571L,577L,607L,617L,647L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155777Inst : IEnumerable<long>
{
public static readonly long[] Value=A155777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155777.Bytes);
public long this[int i]=>Value[i];

public static A155777Inst Instance=new A155777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155778
{
public static readonly long[] Value={ 3L,5L,23L,83L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155778Inst : IEnumerable<long>
{
public static readonly long[] Value=A155778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155778.Bytes);
public long this[int i]=>Value[i];

public static A155778Inst Instance=new A155778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155779
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,29L,31L,79L,89L,127L,1889L,3511L,8971L,13331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155779Inst : IEnumerable<long>
{
public static readonly long[] Value=A155779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155779.Bytes);
public long this[int i]=>Value[i];

public static A155779Inst Instance=new A155779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155780
{
public static readonly long[] Value={ 3L,5L,7L,23L,29L,31L,71L,1301L,4937L,6959L,47093L,74167L,345547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155780Inst : IEnumerable<long>
{
public static readonly long[] Value=A155780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155780.Bytes);
public long this[int i]=>Value[i];

public static A155780Inst Instance=new A155780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155781
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,2L,7L,3L,0L,8L,8L,8L,0L,8L,4L,0L,9L,7L,7L,0L,3L,5L,0L,5L,7L,2L,0L,5L,6L,3L,5L,6L,1L,4L,6L,1L,5L,7L,0L,7L,8L,3L,0L,3L,8L,4L,6L,5L,9L,9L,3L,2L,8L,2L,4L,1L,7L,0L,2L,0L,7L,4L,1L,6L,4L,5L,5L,1L,3L,2L,8L,8L,2L,4L,8L,0L,5L,5L,8L,5L,0L,6L,6L,3L,6L,7L,3L,6L,8L,6L,6L,9L,1L,5L,5L,3L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155781Inst : IEnumerable<long>
{
public static readonly long[] Value=A155781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155781.Bytes);
public long this[int i]=>Value[i];

public static A155781Inst Instance=new A155781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155782
{
public static readonly long[] Value={ 1L,1L,1L,4L,8L,5L,7L,9L,0L,4L,6L,5L,9L,3L,2L,4L,3L,1L,4L,0L,4L,9L,8L,4L,0L,7L,6L,1L,6L,8L,1L,4L,4L,8L,2L,3L,9L,6L,7L,5L,8L,0L,7L,8L,8L,1L,4L,2L,0L,4L,4L,2L,0L,1L,7L,8L,2L,8L,2L,0L,0L,4L,1L,1L,4L,3L,1L,5L,8L,2L,6L,5L,4L,9L,3L,0L,0L,0L,4L,5L,8L,8L,1L,7L,7L,3L,7L,2L,8L,2L,4L,8L,2L,1L,7L,2L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155782Inst : IEnumerable<long>
{
public static readonly long[] Value=A155782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155782.Bytes);
public long this[int i]=>Value[i];

public static A155782Inst Instance=new A155782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155783
{
public static readonly long[] Value={ 1L,0L,9L,1L,0L,0L,2L,3L,6L,3L,0L,3L,8L,7L,7L,2L,9L,7L,3L,2L,1L,0L,3L,6L,3L,4L,1L,1L,6L,9L,3L,6L,8L,5L,6L,9L,0L,1L,7L,2L,2L,1L,7L,3L,0L,6L,2L,8L,9L,7L,7L,0L,7L,2L,6L,4L,9L,5L,5L,0L,0L,1L,5L,5L,3L,0L,1L,9L,4L,1L,5L,8L,0L,9L,7L,6L,4L,2L,9L,7L,8L,0L,5L,4L,8L,7L,9L,7L,0L,3L,8L,6L,4L,9L,1L,4L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155783Inst : IEnumerable<long>
{
public static readonly long[] Value=A155783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155783.Bytes);
public long this[int i]=>Value[i];

public static A155783Inst Instance=new A155783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155784
{
public static readonly long[] Value={ 1L,0L,6L,9L,4L,2L,7L,2L,9L,5L,9L,5L,7L,3L,2L,5L,1L,4L,2L,7L,8L,0L,6L,0L,1L,2L,6L,8L,6L,1L,9L,1L,2L,9L,8L,9L,7L,1L,4L,2L,5L,9L,8L,0L,5L,6L,7L,2L,6L,6L,8L,1L,9L,3L,6L,1L,6L,1L,6L,0L,5L,4L,1L,5L,3L,0L,6L,1L,0L,1L,3L,5L,9L,2L,3L,2L,5L,0L,8L,3L,6L,8L,1L,0L,6L,0L,7L,3L,0L,6L,4L,3L,0L,0L,7L,0L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155784Inst : IEnumerable<long>
{
public static readonly long[] Value=A155784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155784.Bytes);
public long this[int i]=>Value[i];

public static A155784Inst Instance=new A155784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155785
{
public static readonly long[] Value={ 1L,22L,303L,323L,333L,343L,363L,393L,4004L,4014L,4024L,4034L,4044L,4054L,4064L,4074L,4084L,4094L,4104L,4114L,4124L,4134L,4144L,4154L,4164L,4174L,4184L,4194L,4204L,4214L,4224L,4234L,4244L,4254L,4264L,4274L,4284L,4294L,4304L,4314L,4324L,4334L,4344L,4354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155785Inst : IEnumerable<long>
{
public static readonly long[] Value=A155785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155785.Bytes);
public long this[int i]=>Value[i];

public static A155785Inst Instance=new A155785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155786
{
public static readonly long[] Value={ 23L,43L,67L,89L,211L,223L,233L,241L,251L,263L,271L,281L,283L,293L,433L,443L,463L,607L,617L,647L,677L,809L,827L,829L,839L,857L,859L,877L,887L,2003L,2011L,2053L,2063L,2081L,2083L,2111L,2113L,2131L,2141L,2143L,2153L,2161L,2203L,2213L,2221L,2243L,2251L,2273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155786Inst : IEnumerable<long>
{
public static readonly long[] Value=A155786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155786.Bytes);
public long this[int i]=>Value[i];

public static A155786Inst Instance=new A155786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155787
{
public static readonly long[] Value={ 1L,0L,4L,9L,7L,8L,9L,9L,5L,1L,5L,7L,6L,2L,3L,4L,8L,3L,2L,5L,5L,2L,7L,8L,9L,8L,6L,0L,8L,6L,9L,7L,1L,9L,5L,3L,0L,4L,0L,3L,2L,2L,4L,8L,4L,4L,9L,6L,3L,1L,9L,4L,8L,2L,1L,4L,9L,3L,8L,0L,1L,9L,2L,0L,0L,1L,2L,3L,8L,4L,7L,4L,0L,3L,0L,1L,6L,6L,6L,0L,1L,6L,2L,5L,6L,2L,2L,1L,5L,7L,3L,8L,6L,9L,8L,0L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155787Inst : IEnumerable<long>
{
public static readonly long[] Value=A155787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155787.Bytes);
public long this[int i]=>Value[i];

public static A155787Inst Instance=new A155787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155788
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,9L,7L,3L,1L,29L,24L,12L,4L,1L,97L,85L,46L,18L,5L,1L,333L,306L,177L,76L,25L,6L,1L,1165L,1115L,681L,315L,115L,33L,7L,1L,4135L,4100L,2622L,1288L,510L,164L,42L,8L,1L,14845L,15185L,10104L,5220L,2206L,774L,224L,52L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155788Inst : IEnumerable<long>
{
public static readonly long[] Value=A155788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155788.Bytes);
public long this[int i]=>Value[i];

public static A155788Inst Instance=new A155788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155789
{
public static readonly long[] Value={ 1L,0L,3L,1L,8L,1L,5L,3L,1L,9L,6L,2L,8L,4L,3L,0L,4L,4L,7L,3L,6L,8L,1L,3L,1L,2L,7L,4L,7L,6L,9L,3L,1L,1L,2L,4L,9L,4L,1L,2L,7L,4L,9L,3L,1L,2L,6L,5L,5L,2L,5L,1L,9L,0L,4L,7L,8L,3L,9L,9L,4L,4L,3L,5L,9L,6L,0L,9L,4L,1L,7L,8L,6L,4L,0L,8L,5L,4L,9L,8L,6L,4L,4L,1L,5L,8L,5L,2L,7L,9L,8L,3L,9L,4L,0L,3L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155789Inst : IEnumerable<long>
{
public static readonly long[] Value=A155789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155789.Bytes);
public long this[int i]=>Value[i];

public static A155789Inst Instance=new A155789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155790
{
public static readonly long[] Value={ 1L,0L,1L,5L,2L,7L,9L,9L,0L,5L,6L,6L,2L,2L,0L,9L,1L,2L,4L,2L,7L,3L,9L,5L,4L,5L,4L,2L,8L,6L,8L,7L,9L,3L,2L,9L,0L,1L,4L,3L,6L,9L,9L,0L,4L,1L,0L,0L,7L,9L,0L,9L,4L,6L,2L,2L,5L,2L,0L,3L,6L,6L,9L,8L,1L,4L,0L,8L,7L,7L,9L,5L,7L,1L,6L,7L,7L,1L,3L,0L,8L,2L,1L,6L,7L,6L,1L,4L,9L,6L,1L,0L,2L,8L,2L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155790Inst : IEnumerable<long>
{
public static readonly long[] Value=A155790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155790.Bytes);
public long this[int i]=>Value[i];

public static A155790Inst Instance=new A155790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155791
{
public static readonly long[] Value={ 9L,8L,5L,8L,2L,3L,0L,4L,4L,3L,0L,8L,2L,9L,2L,1L,3L,8L,4L,5L,9L,5L,6L,7L,9L,3L,1L,9L,0L,4L,0L,6L,1L,2L,9L,4L,2L,0L,5L,7L,9L,3L,3L,0L,4L,0L,8L,2L,6L,9L,4L,5L,2L,5L,4L,0L,6L,6L,3L,0L,8L,8L,7L,5L,2L,4L,5L,4L,1L,6L,5L,0L,4L,7L,3L,9L,0L,0L,8L,5L,5L,7L,7L,4L,1L,8L,1L,9L,9L,4L,3L,4L,0L,3L,9L,5L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155791Inst : IEnumerable<long>
{
public static readonly long[] Value=A155791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155791.Bytes);
public long this[int i]=>Value[i];

public static A155791Inst Instance=new A155791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155792
{
public static readonly long[] Value={ 9L,7L,2L,6L,2L,1L,1L,7L,5L,8L,4L,0L,7L,8L,0L,7L,0L,0L,6L,1L,1L,8L,3L,2L,7L,1L,7L,8L,0L,8L,8L,7L,6L,2L,8L,5L,0L,0L,6L,8L,3L,3L,7L,2L,5L,4L,9L,6L,1L,2L,5L,1L,0L,3L,2L,1L,7L,5L,5L,4L,9L,1L,2L,2L,9L,0L,8L,8L,1L,2L,7L,3L,5L,4L,3L,7L,0L,5L,8L,9L,1L,5L,4L,1L,8L,4L,2L,7L,7L,4L,7L,4L,7L,5L,8L,7L,3L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155792Inst : IEnumerable<long>
{
public static readonly long[] Value=A155792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155792.Bytes);
public long this[int i]=>Value[i];

public static A155792Inst Instance=new A155792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155793
{
public static readonly long[] Value={ 4L,5L,2L,3L,5L,6L,1L,9L,5L,6L,0L,5L,7L,0L,1L,2L,8L,7L,2L,2L,9L,4L,1L,4L,8L,2L,4L,4L,1L,6L,2L,6L,6L,8L,8L,4L,4L,4L,9L,8L,8L,2L,5L,1L,2L,5L,4L,4L,2L,5L,5L,5L,0L,5L,9L,4L,9L,4L,4L,4L,3L,7L,3L,2L,0L,1L,4L,7L,7L,8L,1L,4L,5L,5L,6L,2L,7L,6L,4L,6L,9L,6L,1L,1L,0L,7L,5L,4L,5L,2L,5L,8L,6L,2L,0L,8L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155793Inst : IEnumerable<long>
{
public static readonly long[] Value=A155793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155793.Bytes);
public long this[int i]=>Value[i];

public static A155793Inst Instance=new A155793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155794
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,6L,24L,6L,1L,1L,24L,720L,720L,24L,1L,1L,120L,40320L,362880L,40320L,120L,1L,1L,720L,3628800L,479001600L,479001600L,3628800L,720L,1L,1L,5040L,479001600L,1307674368000L,20922789888000L,1307674368000L,479001600L,5040L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155794Inst : IEnumerable<long>
{
public static readonly long[] Value=A155794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155794.Bytes);
public long this[int i]=>Value[i];

public static A155794Inst Instance=new A155794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155795
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,6L,1L,1L,24L,24L,24L,1L,1L,120L,0L,0L,120L,1L,1L,720L,0L,0L,0L,720L,1L,1L,5040L,0L,0L,0L,0L,5040L,1L,1L,40320L,0L,0L,0L,0L,0L,40320L,1L,1L,362880L,0L,0L,0L,0L,0L,0L,362880L,1L,1L,3628800L,0L,0L,0L,0L,0L,0L,0L,3628800L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155795Inst : IEnumerable<long>
{
public static readonly long[] Value=A155795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155795.Bytes);
public long this[int i]=>Value[i];

public static A155795Inst Instance=new A155795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155796
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-2L,-33L,1L,1L,-109L,-209L,1L,11L,-324L,-894L,1641L,1L,36L,-867L,-4262L,12951L,85926L,1L,92L,-2085L,-20516L,74369L,625164L,1435939L,1L,211L,-4419L,-93989L,344617L,4306671L,9337441L,-7280909L,1L,457L,-7652L,-402971L,1253140L,28570687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155796Inst : IEnumerable<long>
{
public static readonly long[] Value=A155796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155796.Bytes);
public long this[int i]=>Value[i];

public static A155796Inst Instance=new A155796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155797
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,6L,6L,0L,0L,0L,0L,28L,84L,28L,0L,0L,0L,0L,120L,792L,792L,120L,0L,0L,0L,0L,495L,6435L,12870L,6435L,495L,0L,0L,0L,0L,2002L,48620L,167960L,167960L,48620L,2002L,0L,0L,0L,0L,8008L,352716L,1961256L,3268760L,1961256L,352716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155797Inst : IEnumerable<long>
{
public static readonly long[] Value=A155797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155797.Bytes);
public long this[int i]=>Value[i];

public static A155797Inst Instance=new A155797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155798
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,7L,4L,1L,1L,5L,16L,16L,5L,1L,1L,6L,43L,104L,43L,6L,1L,1L,7L,141L,827L,827L,141L,7L,1L,1L,8L,523L,6491L,12940L,6491L,523L,8L,1L,1L,9L,2038L,48704L,168086L,168086L,48704L,2038L,9L,1L,1L,10L,8053L,352836L,1961466L,3269012L,1961466L,352836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155798Inst : IEnumerable<long>
{
public static readonly long[] Value=A155798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155798.Bytes);
public long this[int i]=>Value[i];

public static A155798Inst Instance=new A155798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155799
{
public static readonly long[] Value={ 9L,2L,5L,8L,5L,7L,2L,7L,4L,7L,1L,2L,8L,9L,3L,1L,2L,7L,9L,9L,8L,8L,8L,2L,1L,3L,8L,2L,0L,7L,1L,5L,8L,4L,1L,5L,2L,7L,8L,4L,5L,0L,2L,1L,8L,1L,9L,1L,9L,6L,6L,0L,2L,1L,5L,3L,2L,7L,6L,5L,6L,6L,2L,0L,2L,9L,5L,6L,7L,4L,4L,6L,8L,1L,0L,7L,1L,2L,4L,7L,5L,7L,0L,3L,9L,6L,4L,4L,8L,6L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155799Inst : IEnumerable<long>
{
public static readonly long[] Value=A155799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155799.Bytes);
public long this[int i]=>Value[i];

public static A155799Inst Instance=new A155799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155800
{
public static readonly long[] Value={ 2L,0L,3L,5L,7L,19L,17L,31L,97L,191L,127L,449L,769L,3329L,6143L,7937L,12799L,51199L,8191L,165887L,65537L,131071L,1179649L,2654209L,7995391L,524287L,10616831L,12910591L,167772161L,113246209L,169869311L,155189249L,1887436799L,3221225473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155800Inst : IEnumerable<long>
{
public static readonly long[] Value=A155800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155800.Bytes);
public long this[int i]=>Value[i];

public static A155800Inst Instance=new A155800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155801
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,31L,37L,43L,73L,101L,107L,127L,181L,257L,313L,443L,619L,757L,1093L,1193L,1297L,1453L,1571L,1619L,1787L,1831L,1879L,2801L,4889L,5113L,5189L,5557L,5869L,5981L,6211L,6827L,7607L,7759L,7919L,8191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155801Inst : IEnumerable<long>
{
public static readonly long[] Value=A155801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155801.Bytes);
public long this[int i]=>Value[i];

public static A155801Inst Instance=new A155801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155802
{
public static readonly long[] Value={ 3L,5L,7L,15L,65L,105L,135L,155L,235L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155802Inst : IEnumerable<long>
{
public static readonly long[] Value=A155802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155802.Bytes);
public long this[int i]=>Value[i];

public static A155802Inst Instance=new A155802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155803
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,9L,18L,36L,73L,146L,292L,585L,1170L,2340L,4681L,9362L,18724L,37449L,74898L,149796L,299593L,599186L,1198372L,2396745L,4793490L,9586980L,19173961L,38347922L,76695844L,153391689L,306783378L,613566756L,1227133513L,2454267026L,4908534052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155803Inst : IEnumerable<long>
{
public static readonly long[] Value=A155803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155803.Bytes);
public long this[int i]=>Value[i];

public static A155803Inst Instance=new A155803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155804
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,19L,161L,1606L,21022L,323485L,5874913L,122077756L,2871573596L,75437801539L,2193468714373L,70020045331510L,2437979768144026L,92073099488632441L,3753886179551636513L,BigInteger.Parse("164556499026975482008") };
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
public class A155804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155804Inst Instance=new A155804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155805
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,191L,2656L,47392L,1034335L,26721781L,798018616L,27058991246L,1027237384009L,43172232488959L,1990253576425960L,99871804451808040L,5419775866582473211L,BigInteger.Parse("316301430225674131433"),BigInteger.Parse("19756213549154356027408") };
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
public class A155805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155805Inst Instance=new A155805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155806
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,269L,4616L,102847L,2824816L,92355769L,3506278528L,151720849691L,7375146930944L,398113181435653L,23640909385071616L,1532325553233566743L,BigInteger.Parse("107698939845869111296"),BigInteger.Parse("8162300091585206125553"),BigInteger.Parse("663836705760309127184384") };
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
public class A155806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155806Inst Instance=new A155806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155807
{
public static readonly BigInteger[] Value={ 1L,1L,5L,55L,969L,23661L,741013L,28363707L,1284098609L,67149601273L,3984121444581L,264485848799679L,19426332734137849L,1564277403496216293L,BigInteger.Parse("137040382838351173301"),BigInteger.Parse("12977244383702330201731") };
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
public class A155807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155807Inst Instance=new A155807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155808
{
public static readonly long[] Value={ 2L,8L,5L,4L,0L,4L,9L,8L,3L,0L,2L,0L,0L,2L,7L,1L,1L,0L,7L,4L,0L,3L,6L,3L,1L,7L,6L,4L,9L,4L,9L,2L,0L,7L,8L,8L,2L,7L,6L,3L,1L,8L,1L,6L,3L,7L,0L,5L,0L,4L,8L,9L,7L,6L,7L,1L,7L,3L,5L,1L,1L,7L,6L,7L,6L,5L,4L,7L,8L,5L,1L,4L,5L,4L,9L,9L,4L,8L,3L,4L,0L,1L,5L,3L,2L,4L,3L,2L,9L,1L,5L,4L,3L,2L,1L,8L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155808Inst : IEnumerable<long>
{
public static readonly long[] Value=A155808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155808.Bytes);
public long this[int i]=>Value[i];

public static A155808Inst Instance=new A155808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155809
{
public static readonly long[] Value={ 0L,1953L,2310L,2583L,2688L,2730L,4095L,6510L,6993L,7245L,8967L,9870L,9975L,10332L,11613L,12327L,14868L,15057L,15603L,16758L,16800L,17052L,17157L,20160L,20643L,22008L,22533L,23058L,23877L,24150L,29925L,31122L,31710L,32655L,33432L,34020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155809Inst : IEnumerable<long>
{
public static readonly long[] Value=A155809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155809.Bytes);
public long this[int i]=>Value[i];

public static A155809Inst Instance=new A155809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155810
{
public static readonly BigInteger[] Value={ 1L,2L,1L,10L,6L,1L,188L,82L,14L,1L,16774L,4452L,490L,30L,1L,6745436L,1074934L,71108L,2602L,62L,1L,11466849412L,1082704500L,43173414L,951300L,13002L,126L,1L,80444398636280L,4411700155252L,104251164804L,1387446246L,11470404L,62538L,254L,1L,2306003967992402758L,72146891831948808L,989785148972932L,7803708940836L,38993810694L,129076164L,292810L,510L,1L,BigInteger.Parse("268654794629082985019564"),BigInteger.Parse("4724816968764733073446"),BigInteger.Parse("36967624172237518088"),169140002768370820L,500466007443108L,1001353593606L,1382564804L,1343434L,1022L,1L };
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
public class A155810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155810Inst Instance=new A155810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155811
{
public static readonly BigInteger[] Value={ 1L,6L,82L,4452L,1074934L,1082704500L,4411700155252L,72146891831948808L,BigInteger.Parse("4724816968764733073446"),BigInteger.Parse("1238218148763614236043117508"),BigInteger.Parse("1298203457233136135837147642852956") };
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
public class A155811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155811Inst Instance=new A155811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155812
{
public static readonly BigInteger[] Value={ 1L,3L,1L,45L,12L,1L,6687L,801L,39L,1L,10782369L,540720L,10764L,120L,1L,169490304819L,3499254081L,29275956L,129348L,363L,1L,25016281429306077L,206071208583660L,709664882337L,1321144632L,1459773L,1092L,1L,BigInteger.Parse("34185693516532070487615") };
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
public class A155812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155812Inst Instance=new A155812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155813
{
public static readonly BigInteger[] Value={ 1L,12L,801L,540720L,3499254081L,206071208583660L,BigInteger.Parse("109444624780070083617"),BigInteger.Parse("523382147212408702381556928"),BigInteger.Parse("22528830325874782877760713232652641"),BigInteger.Parse("8728012905287889947187989190298586968026540") };
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
public class A155813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155813Inst Instance=new A155813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155814
{
public static readonly long[] Value={ 79L,127L,203L,234L,243L,255L,324L,325L,326L,350L,361L,402L,406L,416L,430L,445L,447L,471L,490L,509L,513L,527L,531L,539L,548L,553L,561L,564L,572L,602L,604L,627L,630L,631L,633L,640L,653L,654L,656L,694L,695L,703L,704L,715L,720L,735L,783L,790L,791L,812L,813L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155814Inst : IEnumerable<long>
{
public static readonly long[] Value=A155814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155814.Bytes);
public long this[int i]=>Value[i];

public static A155814Inst Instance=new A155814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155815
{
public static readonly long[] Value={ 23L,97L,269L,587L,1123L,1973L,3257L,5119L,7727L,11273L,15973L,22067L,29819L,51473L,104369L,191123L,229637L,687787L,897473L,1018807L,1152119L,1631723L,2026069L,2488223L,2747023L,3025577L,3989723L,5614247L,7125947L,7692019L,8291237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155815Inst : IEnumerable<long>
{
public static readonly long[] Value=A155815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155815.Bytes);
public long this[int i]=>Value[i];

public static A155815Inst Instance=new A155815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155816
{
public static readonly long[] Value={ 7L,5L,3L,2L,1L,1L,8L,6L,4L,3L,2L,1L,1L,7L,5L,3L,2L,1L,1L,9L,6L,4L,3L,2L,1L,1L,8L,6L,4L,3L,2L,1L,1L,7L,5L,3L,2L,1L,1L,9L,6L,4L,3L,2L,1L,1L,8L,5L,4L,2L,2L,1L,1L,7L,5L,3L,2L,1L,1L,9L,6L,4L,3L,2L,1L,1L,8L,5L,4L,2L,2L,1L,1L,7L,5L,3L,2L,1L,1L,9L,6L,4L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155816Inst : IEnumerable<long>
{
public static readonly long[] Value=A155816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155816.Bytes);
public long this[int i]=>Value[i];

public static A155816Inst Instance=new A155816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155817
{
public static readonly BigInteger[] Value={ 1L,10L,2L,4L,100L,101L,11L,12L,13L,14L,30L,1000L,10000L,40L,41L,100000L,102L,43L,60L,110L,1000000L,1001L,61L,80L,111L,100000000000L,90L,10000000L,103L,104L,10001L,1110L,112L,201L,108L,91L,95L,160L,161L,BigInteger.Parse("100000000000000000000000000000000000"),170L,1000001L };
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
public class A155817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155817Inst Instance=new A155817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155818
{
public static readonly long[] Value={ 2L,2L,6L,1L,7L,8L,0L,9L,7L,8L,0L,2L,8L,5L,0L,6L,4L,3L,6L,1L,4L,7L,0L,7L,4L,1L,2L,2L,0L,8L,1L,3L,3L,4L,4L,2L,2L,2L,4L,9L,4L,1L,2L,5L,6L,2L,7L,2L,1L,2L,7L,7L,5L,2L,9L,7L,4L,7L,2L,2L,1L,8L,6L,6L,0L,0L,7L,3L,8L,9L,0L,7L,2L,7L,8L,1L,3L,8L,2L,3L,4L,8L,0L,5L,5L,3L,7L,7L,2L,6L,2L,9L,3L,1L,0L,4L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155818Inst : IEnumerable<long>
{
public static readonly long[] Value=A155818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155818.Bytes);
public long this[int i]=>Value[i];

public static A155818Inst Instance=new A155818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155819
{
public static readonly long[] Value={ 14L,32L,60L,136L,192L,316L,396L,568L,888L,1020L,1432L,1756L,1932L,2296L,2904L,3588L,3840L,4612L,5176L,5472L,6388L,7048L,8088L,9588L,10396L,10812L,11656L,12096L,12988L,16356L,17416L,19032L,19596L,22480L,23100L,24952L,26884L,28216L,30264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155819Inst : IEnumerable<long>
{
public static readonly long[] Value=A155819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155819.Bytes);
public long this[int i]=>Value[i];

public static A155819Inst Instance=new A155819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155820
{
public static readonly long[] Value={ 13L,31L,59L,191L,887L,1019L,1931L,2903L,5471L,8087L,9587L,19031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155820Inst : IEnumerable<long>
{
public static readonly long[] Value=A155820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155820.Bytes);
public long this[int i]=>Value[i];

public static A155820Inst Instance=new A155820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155821
{
public static readonly long[] Value={ 1L,9L,4L,8L,1L,9L,2L,0L,9L,3L,4L,6L,6L,3L,7L,9L,5L,6L,7L,4L,5L,1L,5L,9L,6L,0L,5L,8L,8L,8L,9L,2L,2L,7L,4L,2L,3L,9L,8L,4L,6L,4L,8L,3L,6L,4L,8L,9L,6L,3L,8L,8L,0L,0L,8L,1L,3L,9L,6L,5L,3L,0L,1L,2L,3L,0L,3L,0L,6L,3L,3L,5L,7L,5L,3L,0L,4L,9L,4L,5L,7L,7L,4L,0L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155821Inst : IEnumerable<long>
{
public static readonly long[] Value=A155821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155821.Bytes);
public long this[int i]=>Value[i];

public static A155821Inst Instance=new A155821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155822
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,4L,8L,9L,12L,21L,27L,37L,58L,78L,109L,164L,227L,319L,467L,656L,928L,1341L,1896L,2689L,3859L,5477L,7782L,11126L,15817L,22496L,32103L,45679L,65003L,92668L,131912L,187777L,267556L,380941L,542363L,772581L,1100098L,1566414L,2230997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155822Inst : IEnumerable<long>
{
public static readonly long[] Value=A155822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155822.Bytes);
public long this[int i]=>Value[i];

public static A155822Inst Instance=new A155822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155823
{
public static readonly long[] Value={ 1L,7L,4L,9L,9L,5L,2L,6L,4L,1L,4L,0L,0L,0L,2L,9L,4L,8L,1L,1L,6L,1L,6L,1L,0L,2L,0L,7L,7L,9L,7L,2L,9L,2L,6L,7L,3L,7L,6L,8L,0L,7L,7L,5L,9L,7L,7L,1L,2L,8L,6L,0L,4L,8L,5L,0L,8L,3L,2L,7L,0L,2L,0L,9L,0L,5L,9L,2L,4L,3L,9L,6L,5L,1L,3L,7L,2L,3L,5L,4L,1L,8L,7L,0L,9L,9L,5L,5L,3L,0L,4L,8L,4L,7L,0L,1L,4L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155823Inst : IEnumerable<long>
{
public static readonly long[] Value=A155823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155823.Bytes);
public long this[int i]=>Value[i];

public static A155823Inst Instance=new A155823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155824
{
public static readonly long[] Value={ 1L,6L,1L,1L,3L,2L,5L,2L,8L,0L,0L,7L,5L,9L,3L,1L,1L,7L,4L,9L,5L,2L,6L,9L,5L,5L,6L,1L,8L,6L,2L,5L,9L,4L,5L,1L,4L,2L,3L,1L,6L,0L,1L,2L,8L,4L,3L,9L,9L,0L,1L,9L,4L,2L,0L,9L,8L,4L,8L,0L,2L,5L,8L,4L,7L,2L,4L,1L,1L,6L,1L,7L,1L,8L,2L,1L,5L,1L,6L,4L,9L,3L,1L,2L,0L,8L,6L,1L,3L,3L,3L,4L,0L,9L,0L,3L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155824Inst : IEnumerable<long>
{
public static readonly long[] Value=A155824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155824.Bytes);
public long this[int i]=>Value[i];

public static A155824Inst Instance=new A155824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155825
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,12L,12L,0L,0L,216L,484L,216L,0L,0L,5760L,21000L,21000L,5760L,0L,0L,216000L,1117920L,1822500L,1117920L,216000L,0L,0L,10886400L,74088000L,171884160L,171884160L,74088000L,10886400L,0L,0L,711244800L,6059370240L,18531878400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155825Inst : IEnumerable<long>
{
public static readonly long[] Value=A155825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155825.Bytes);
public long this[int i]=>Value[i];

public static A155825Inst Instance=new A155825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155826
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,15L,15L,1L,1L,76L,249L,76L,1L,1L,485L,3516L,3516L,485L,1L,1L,3606L,46623L,101354L,46623L,3606L,1L,1L,30247L,617541L,2388107L,2388107L,617541L,30247L,1L,1L,282248L,8416315L,51483931L,91651662L,51483931L,8416315L,282248L,1L,1L,2903049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155826Inst : IEnumerable<long>
{
public static readonly long[] Value=A155826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155826.Bytes);
public long this[int i]=>Value[i];

public static A155826Inst Instance=new A155826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155827
{
public static readonly long[] Value={ 1L,5L,0L,7L,8L,5L,3L,9L,8L,5L,3L,5L,2L,3L,3L,7L,6L,2L,4L,0L,9L,8L,0L,4L,9L,4L,1L,4L,7L,2L,0L,8L,8L,9L,6L,1L,4L,8L,3L,2L,9L,4L,1L,7L,0L,8L,4L,8L,0L,8L,5L,1L,6L,8L,6L,4L,9L,8L,1L,4L,7L,9L,1L,0L,6L,7L,1L,5L,9L,2L,7L,1L,5L,1L,8L,7L,5L,8L,8L,2L,3L,2L,0L,3L,6L,9L,1L,8L,1L,7L,5L,2L,8L,7L,3L,6L,2L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155827Inst : IEnumerable<long>
{
public static readonly long[] Value=A155827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155827.Bytes);
public long this[int i]=>Value[i];

public static A155827Inst Instance=new A155827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155828
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,1L,3L,3L,1L,1L,7L,1L,1L,1L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,1L,3L,7L,1L,3L,1L,3L,3L,1L,1L,7L,1L,1L,3L,3L,1L,1L,3L,7L,3L,1L,1L,7L,1L,1L,3L,3L,3L,3L,1L,3L,3L,3L,1L,7L,1L,1L,3L,3L,3L,3L,1L,7L,1L,1L,1L,7L,3L,1L,3L,7L,1L,3L,3L,3L,3L,1L,3L,7L,1L,1L,3L,3L,1L,3L,1L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155828Inst : IEnumerable<long>
{
public static readonly long[] Value=A155828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155828.Bytes);
public long this[int i]=>Value[i];

public static A155828Inst Instance=new A155828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155829
{
public static readonly long[] Value={ 1L,4L,2L,7L,0L,2L,4L,9L,1L,5L,1L,0L,0L,1L,3L,5L,5L,5L,3L,7L,0L,1L,8L,1L,5L,8L,8L,2L,4L,7L,4L,6L,0L,3L,9L,4L,1L,3L,8L,1L,5L,9L,0L,8L,1L,8L,5L,2L,5L,2L,4L,4L,8L,8L,3L,5L,8L,6L,7L,5L,5L,8L,8L,3L,8L,2L,7L,3L,9L,2L,5L,7L,2L,7L,4L,9L,7L,4L,1L,7L,0L,0L,7L,6L,6L,2L,1L,6L,4L,5L,7L,7L,1L,6L,0L,9L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155829Inst : IEnumerable<long>
{
public static readonly long[] Value=A155829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155829.Bytes);
public long this[int i]=>Value[i];

public static A155829Inst Instance=new A155829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155830
{
public static readonly long[] Value={ 1L,3L,6L,1L,7L,2L,7L,8L,3L,6L,0L,1L,7L,5L,9L,2L,8L,7L,8L,8L,6L,7L,7L,7L,7L,1L,1L,2L,2L,5L,1L,1L,8L,9L,5L,4L,9L,6L,9L,7L,5L,1L,1L,0L,3L,4L,3L,3L,6L,0L,9L,6L,1L,8L,8L,2L,7L,5L,6L,0L,5L,4L,8L,6L,6L,1L,4L,6L,8L,8L,6L,3L,6L,3L,9L,6L,8L,0L,6L,4L,7L,2L,6L,7L,3L,5L,8L,4L,1L,9L,0L,8L,2L,7L,2L,1L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155830Inst : IEnumerable<long>
{
public static readonly long[] Value=A155830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155830.Bytes);
public long this[int i]=>Value[i];

public static A155830Inst Instance=new A155830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155831
{
public static readonly long[] Value={ 1L,3L,0L,7L,6L,0L,2L,6L,5L,1L,1L,6L,5L,8L,2L,5L,4L,9L,8L,4L,7L,8L,5L,0L,6L,0L,7L,3L,6L,4L,2L,6L,2L,7L,3L,6L,2L,1L,7L,7L,2L,9L,3L,7L,7L,3L,6L,1L,2L,0L,7L,4L,7L,3L,1L,3L,9L,9L,1L,7L,6L,4L,6L,7L,8L,5L,1L,2L,1L,6L,2L,5L,7L,0L,3L,7L,0L,3L,4L,5L,4L,5L,0L,7L,7L,2L,3L,6L,8L,1L,3L,0L,6L,3L,7L,5L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155831Inst : IEnumerable<long>
{
public static readonly long[] Value=A155831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155831.Bytes);
public long this[int i]=>Value[i];

public static A155831Inst Instance=new A155831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155832
{
public static readonly long[] Value={ 1L,2L,6L,1L,8L,1L,5L,6L,9L,6L,8L,5L,7L,9L,2L,9L,9L,4L,5L,6L,1L,3L,0L,1L,4L,0L,4L,4L,9L,9L,2L,0L,3L,3L,9L,8L,3L,2L,6L,4L,3L,4L,2L,5L,8L,7L,5L,0L,1L,4L,9L,9L,3L,1L,3L,9L,8L,6L,4L,2L,7L,6L,8L,2L,9L,3L,4L,3L,9L,2L,7L,3L,7L,0L,6L,1L,9L,3L,1L,5L,4L,6L,3L,8L,7L,2L,5L,0L,4L,2L,8L,0L,6L,3L,7L,3L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155832Inst : IEnumerable<long>
{
public static readonly long[] Value=A155832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155832.Bytes);
public long this[int i]=>Value[i];

public static A155832Inst Instance=new A155832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155833
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,31L,41L,43L,53L,61L,71L,73L,83L,97L,131L,151L,181L,191L,211L,241L,251L,271L,281L,311L,331L,353L,373L,383L,421L,431L,433L,443L,461L,463L,491L,521L,541L,563L,571L,593L,631L,641L,643L,653L,661L,673L,683L,691L,733L,743L,751L,761L,773L,787L,797L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155833Inst : IEnumerable<long>
{
public static readonly long[] Value=A155833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155833.Bytes);
public long this[int i]=>Value[i];

public static A155833Inst Instance=new A155833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155834
{
public static readonly long[] Value={ 1L,1L,6L,16L,6L,22L,127L,127L,22L,64L,701L,1436L,701L,64L,163L,3117L,11503L,11503L,3117L,163L,382L,12088L,74122L,131494L,74122L,12088L,382L,848L,42890L,413612L,1193930L,1193930L,413612L,42890L,848L,1816L,143562L,2094588L,9280734L,14992440L,9280734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155834Inst : IEnumerable<long>
{
public static readonly long[] Value=A155834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155834.Bytes);
public long this[int i]=>Value[i];

public static A155834Inst Instance=new A155834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155835
{
public static readonly long[] Value={ 4L,3L,3L,7L,8L,7L,6L,10L,10L,6L,15L,23L,28L,23L,15L,8L,20L,31L,31L,20L,8L,21L,43L,74L,90L,74L,43L,21L,10L,28L,61L,93L,93L,61L,28L,10L,27L,59L,132L,228L,276L,228L,132L,59L,27L,12L,36L,91L,187L,269L,269L,187L,91L,36L,12L,33L,75L,186L,410L,684L,814L,684L,410L,186L,75L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155835Inst : IEnumerable<long>
{
public static readonly long[] Value=A155835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155835.Bytes);
public long this[int i]=>Value[i];

public static A155835Inst Instance=new A155835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155836
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,4L,4L,0L,4L,6L,3L,4L,9L,2L,1L,0L,1L,16L,4L,16L,4L,16L,3L,16L,21L,16L,13L,16L,16L,16L,8L,0L,4L,18L,11L,16L,33L,16L,22L,16L,37L,16L,4L,20L,31L,6L,21L,16L,4L,16L,1L,16L,42L,52L,36L,16L,28L,54L,20L,16L,57L,16L,4L,0L,61L,16L,21L,52L,64L,16L,12L,16L,4L,16L,31L,24L,4L,16L,73L,16L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155836Inst : IEnumerable<long>
{
public static readonly long[] Value=A155836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155836.Bytes);
public long this[int i]=>Value[i];

public static A155836Inst Instance=new A155836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155837
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,9L,0L,3L,4L,4L,4L,2L,4L,8L,3L,6L,0L,2L,1L,5L,3L,1L,6L,0L,2L,6L,3L,7L,0L,8L,4L,7L,2L,5L,5L,6L,5L,0L,9L,5L,4L,9L,1L,6L,1L,3L,9L,2L,0L,8L,7L,7L,6L,5L,0L,1L,1L,0L,3L,9L,4L,2L,6L,0L,3L,0L,0L,1L,9L,1L,9L,9L,7L,8L,2L,6L,0L,3L,9L,8L,5L,9L,5L,1L,3L,4L,5L,7L,8L,9L,2L,8L,1L,1L,6L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155837Inst : IEnumerable<long>
{
public static readonly long[] Value=A155837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155837.Bytes);
public long this[int i]=>Value[i];

public static A155837Inst Instance=new A155837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155838
{
public static readonly long[] Value={ 2L,5L,13L,61681L,1235573L,27544452149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155838Inst : IEnumerable<long>
{
public static readonly long[] Value=A155838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155838.Bytes);
public long this[int i]=>Value[i];

public static A155838Inst Instance=new A155838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155839
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,2L,3L,0L,1L,0L,4L,7L,6L,0L,1L,0L,8L,18L,16L,10L,0L,1L,0L,16L,45L,51L,30L,15L,0L,1L,0L,32L,110L,152L,115L,50L,21L,0L,1L,0L,64L,264L,436L,396L,225L,77L,28L,0L,1L,0L,128L,624L,1212L,1300L,876L,399L,112L,36L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155839Inst : IEnumerable<long>
{
public static readonly long[] Value=A155839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155839.Bytes);
public long this[int i]=>Value[i];

public static A155839Inst Instance=new A155839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155840
{
public static readonly long[] Value={ 1L,1L,8L,8L,1L,1L,1L,4L,4L,4L,4L,7L,0L,3L,1L,2L,1L,8L,3L,0L,4L,5L,2L,3L,6L,7L,3L,1L,6L,5L,9L,5L,7L,0L,5L,8L,6L,9L,7L,4L,4L,1L,9L,1L,9L,2L,1L,8L,4L,0L,8L,8L,1L,4L,6L,7L,8L,5L,1L,6L,3L,4L,5L,8L,9L,3L,2L,4L,0L,0L,6L,0L,1L,9L,8L,6L,8L,4L,6L,7L,1L,5L,1L,0L,7L,0L,1L,3L,7L,4L,2L,2L,8L,7L,0L,5L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155840Inst : IEnumerable<long>
{
public static readonly long[] Value=A155840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155840.Bytes);
public long this[int i]=>Value[i];

public static A155840Inst Instance=new A155840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155841
{
public static readonly BigInteger[] Value={ 17L,47L,149L,2081L,8231L,140737488355469L,BigInteger.Parse("300613450595050653169853516389035139504087366260264943450533244356122755214669880763353471793250393988087678029") };
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
public class A155841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155841Inst Instance=new A155841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155842
{
public static readonly BigInteger[] Value={ 23L,163L,137438953657L,2305843009213694257L,BigInteger.Parse("862718293348820473429344482784628181556388621521298319395315527976057"),BigInteger.Parse("19239260838083241802870625048898248928261591440656956380834127638791856333738872368854622194768025215237611325257") };
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
public class A155842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155842Inst Instance=new A155842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155843
{
public static readonly BigInteger[] Value={ 191L,536871173L,2199023255921L,BigInteger.Parse("10384593717069655257060992658441209") };
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
public class A155843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155843Inst Instance=new A155843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155844
{
public static readonly BigInteger[] Value={ 47L,97L,131293L,140737488355939L,BigInteger.Parse("2361183241434822607771") };
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
public class A155844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155844Inst Instance=new A155844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155845
{
public static readonly BigInteger[] Value={ -2L,17L,107L,524231L,8388539L,BigInteger.Parse("162259276829213363391578010287807") };
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
public class A155845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155845Inst Instance=new A155845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155846
{
public static readonly long[] Value={ -7L,7L,1993L,130987L,536870767L,9007199254740727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155846Inst : IEnumerable<long>
{
public static readonly long[] Value=A155846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155846.Bytes);
public long this[int i]=>Value[i];

public static A155846Inst Instance=new A155846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155847
{
public static readonly long[] Value={ -13L,-3L,79L,8101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155847Inst : IEnumerable<long>
{
public static readonly long[] Value=A155847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155847.Bytes);
public long this[int i]=>Value[i];

public static A155847Inst Instance=new A155847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155848
{
public static readonly BigInteger[] Value={ -19L,-13L,1949L,BigInteger.Parse("2535301200456458802993406409843") };
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
public class A155848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155848Inst Instance=new A155848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155849
{
public static readonly BigInteger[] Value={ -37L,-43L,23L,130817L,BigInteger.Parse("2535301200456458802993406409237"),BigInteger.Parse("36499524940977561749129372845602330599145828057988479444633540143194201337669419092047302490538971198229138476588755258485509637771003503986021290557777713506015957394882119600662993537972820563") };
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
public class A155849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155849Inst Instance=new A155849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155850
{
public static readonly long[] Value={ 2L,4L,3L,5L,7L,15L,17L,31L,65L,129L,127L,449L,511L,2561L,1025L,7937L,12799L,20481L,8191L,28673L,65537L,131071L,458751L,360449L,966655L,524287L,4194303L,2097151L,29360129L,34865153L,67108865L,134217729L,33554431L,608174081L,268435457L,536870911L,4831838207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155850Inst : IEnumerable<long>
{
public static readonly long[] Value=A155850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155850.Bytes);
public long this[int i]=>Value[i];

public static A155850Inst Instance=new A155850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155851
{
public static readonly long[] Value={ 5L,23L,53L,233L,563L,1259L,2579L,2909L,12713L,22543L,28099L,31729L,39607L,41017L,42463L,87511L,110359L,115279L,117787L,138863L,141671L,213533L,242243L,257353L,265117L,269069L,289171L,310019L,318557L,327193L,331603L,354097L,372607L,441101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155851Inst : IEnumerable<long>
{
public static readonly long[] Value=A155851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155851.Bytes);
public long this[int i]=>Value[i];

public static A155851Inst Instance=new A155851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155852
{
public static readonly long[] Value={ 3L,509L,146749L,26444543L,187206119L,735187721L,1662266153L,2146936021L,2844048943L,4335869143L,5539721989L,5990371801L,6145377247L,6788645863L,10092092897L,19122368737L,20186509381L,25745240897L,32732349829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155852Inst : IEnumerable<long>
{
public static readonly long[] Value=A155852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155852.Bytes);
public long this[int i]=>Value[i];

public static A155852Inst Instance=new A155852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155853
{
public static readonly long[] Value={ 0L,2L,8L,16L,20L,28L,32L,40L,46L,50L,58L,62L,68L,76L,82L,98L,100L,106L,110L,112L,116L,128L,130L,140L,146L,152L,160L,166L,170L,172L,188L,190L,196L,208L,218L,232L,250L,256L,266L,272L,278L,280L,296L,298L,302L,308L,316L,326L,338L,340L,358L,368L,370L,380L,382L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155853Inst : IEnumerable<long>
{
public static readonly long[] Value=A155853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155853.Bytes);
public long this[int i]=>Value[i];

public static A155853Inst Instance=new A155853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155854
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155854Inst : IEnumerable<long>
{
public static readonly long[] Value=A155854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155854.Bytes);
public long this[int i]=>Value[i];

public static A155854Inst Instance=new A155854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155855
{
public static readonly long[] Value={ 1L,1L,5L,7L,8L,4L,1L,9L,8L,3L,3L,7L,7L,1L,7L,8L,3L,8L,5L,3L,5L,4L,7L,6L,4L,9L,2L,1L,7L,2L,0L,4L,3L,3L,9L,0L,0L,0L,5L,1L,9L,9L,6L,2L,0L,2L,6L,3L,8L,2L,4L,8L,1L,2L,7L,8L,1L,9L,8L,3L,3L,6L,9L,2L,4L,3L,6L,0L,8L,5L,8L,6L,3L,2L,8L,7L,7L,3L,4L,6L,3L,5L,9L,7L,6L,4L,9L,4L,8L,8L,4L,4L,3L,8L,2L,0L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155855Inst : IEnumerable<long>
{
public static readonly long[] Value=A155855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155855.Bytes);
public long this[int i]=>Value[i];

public static A155855Inst Instance=new A155855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155856
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,6L,10L,6L,1L,24L,42L,30L,10L,1L,120L,216L,168L,70L,15L,1L,720L,1320L,1080L,504L,140L,21L,1L,5040L,9360L,7920L,3960L,1260L,252L,28L,1L,40320L,75600L,65520L,34320L,11880L,2772L,420L,36L,1L,362880L,685440L,604800L,327600L,120120L,30888L,5544L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155856Inst : IEnumerable<long>
{
public static readonly long[] Value=A155856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155856.Bytes);
public long this[int i]=>Value[i];

public static A155856Inst Instance=new A155856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155857
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,590L,3786L,27821L,230869L,2137978L,21873854L,245151555L,2987967551L,39358156310L,557259550034L,8440866957273L,136211005966889L,2333068710452146L,42276699542130166L,808068680469402095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155857Inst : IEnumerable<long>
{
public static readonly long[] Value=A155857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155857.Bytes);
public long this[int i]=>Value[i];

public static A155857Inst Instance=new A155857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155858
{
public static readonly long[] Value={ 1L,1L,3L,9L,35L,168L,967L,6538L,50831L,446919L,4383861L,47451921L,561715093L,7217604520L,100031995789L,1487319385140L,23613262336093L,398673670050021L,7132188802005991L,134766129577134553L,2681929390235577831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155858Inst : IEnumerable<long>
{
public static readonly long[] Value=A155858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155858.Bytes);
public long this[int i]=>Value[i];

public static A155858Inst Instance=new A155858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155859
{
public static readonly BigInteger[] Value={ 4L,38L,377L,3766L,37655L,376544L,3765433L,37654322L,376543211L,3765432100L,37654320989L,376543209878L,3765432098767L,37654320987656L,376543209876545L,3765432098765434L,37654320987654323L,376543209876543212L,3765432098765432101L,BigInteger.Parse("37654320987654320990") };
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
public class A155859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155859Inst Instance=new A155859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155860
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,2L,3L,4L,5L,3L,5L,7L,4L,7L,9L,5L,6L,9L,5L,7L,11L,6L,6L,12L,5L,9L,13L,8L,10L,12L,4L,11L,15L,6L,10L,15L,5L,9L,16L,9L,9L,17L,8L,8L,17L,8L,10L,16L,8L,11L,13L,10L,10L,20L,7L,12L,23L,10L,10L,21L,9L,11L,18L,11L,8L,18L,9L,11L,20L,9L,13L,17L,9L,12L,19L,9L,13L,22L,6L,13L,21L,10L,10L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155860Inst : IEnumerable<long>
{
public static readonly long[] Value=A155860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155860.Bytes);
public long this[int i]=>Value[i];

public static A155860Inst Instance=new A155860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155861
{
public static readonly long[] Value={ 1L,2L,8L,26L,68L,134L,228L,352L,510L,704L,934L,1204L,1514L,1866L,2260L,2702L,3188L,3722L,4304L,4936L,5620L,6354L,7140L,7980L,8872L,9822L,10826L,11888L,13006L,14182L,15416L,16712L,18066L,19480L,20956L,22494L,24096L,25760L,27486L,29278L,31134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155861Inst : IEnumerable<long>
{
public static readonly long[] Value=A155861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155861.Bytes);
public long this[int i]=>Value[i];

public static A155861Inst Instance=new A155861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155862
{
public static readonly long[] Value={ 1L,4L,22L,130L,790L,4870L,30274L,189202L,1186702L,7461982L,47007034L,296527162L,1872479350L,11833642006L,74833075570L,473463268642L,2996771766046L,18974162475598L,120167557286314L,761214481604554L,4822871486667526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155862Inst : IEnumerable<long>
{
public static readonly long[] Value=A155862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155862.Bytes);
public long this[int i]=>Value[i];

public static A155862Inst Instance=new A155862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155863
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,24L,24L,1L,1L,60L,120L,60L,1L,1L,120L,360L,360L,120L,1L,1L,210L,840L,1260L,840L,210L,1L,1L,336L,1680L,3360L,3360L,1680L,336L,1L,1L,504L,3024L,7560L,10080L,7560L,3024L,504L,1L,1L,720L,5040L,15120L,25200L,25200L,15120L,5040L,720L,1L,1L,990L,7920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155863Inst : IEnumerable<long>
{
public static readonly long[] Value=A155863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155863.Bytes);
public long this[int i]=>Value[i];

public static A155863Inst Instance=new A155863Inst();

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