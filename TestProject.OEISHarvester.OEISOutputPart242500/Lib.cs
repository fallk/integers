using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A032508
{
public static readonly long[] Value={ 29L,85L,605L,1293L,1597L,27813L,89317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032508Inst : IEnumerable<long>
{
public static readonly long[] Value=A032508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032508.Bytes);
public long this[int i]=>Value[i];

public static A032508Inst Instance=new A032508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032573
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,121L,242L,363L,484L,1331L,1837L,2662L,3146L,3993L,14641L,16940L,93753L,139838L,144096L,154396L,177870L,196383L,268950L,292298L,363484L,1148136L,1630222L,1963830L,3615999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032573Inst : IEnumerable<long>
{
public static readonly long[] Value=A032573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032573.Bytes);
public long this[int i]=>Value[i];

public static A032573Inst Instance=new A032573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032574
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,4L,4L,4L,8L,7L,8L,9L,8L,16L,15L,19L,34L,34L,33L,31L,30L,35L,34L,37L,79L,68L,63L,78L,78L,81L,79L,78L,136L,171L,166L,167L,177L,376L,331L,364L,354L,343L,367L,366L,343L,342L,342L,351L,351L,375L,766L,754L,749L,640L,766L,686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032574Inst : IEnumerable<long>
{
public static readonly long[] Value=A032574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032574.Bytes);
public long this[int i]=>Value[i];

public static A032574Inst Instance=new A032574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032575
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,24L,36L,48L,144L,288L,292L,1116L,5584L,7852L,8968L,10230L,11160L,15164L,20460L,30690L,31020L,36651L,41250L,49233L,51480L,55840L,62040L,72270L,78520L,89680L,93060L,122760L,126393L,216480L,372240L,436384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032575Inst : IEnumerable<long>
{
public static readonly long[] Value=A032575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032575.Bytes);
public long this[int i]=>Value[i];

public static A032575Inst Instance=new A032575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032576
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,4L,10L,10L,10L,10L,23L,22L,19L,23L,23L,23L,21L,23L,21L,23L,22L,23L,23L,22L,22L,23L,46L,45L,49L,46L,49L,48L,49L,49L,49L,99L,107L,97L,113L,109L,107L,249L,186L,241L,229L,223L,219L,241L,244L,244L,241L,401L,519L,529L,541L,520L,1017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032576Inst : IEnumerable<long>
{
public static readonly long[] Value=A032576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032576.Bytes);
public long this[int i]=>Value[i];

public static A032576Inst Instance=new A032576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032577
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,13L,26L,39L,169L,221L,442L,663L,884L,2405L,2873L,2912L,5980L,26455L,28730L,29120L,31667L,42441L,48841L,52900L,74435L,84882L,104650L,132808L,139380L,413738L,20392554L,23490402L,25209381L,32287569L,234904020L,239235484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032577Inst : IEnumerable<long>
{
public static readonly long[] Value=A032577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032577.Bytes);
public long this[int i]=>Value[i];

public static A032577Inst Instance=new A032577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032578
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,4L,5L,5L,5L,5L,11L,10L,10L,11L,24L,23L,23L,27L,27L,25L,27L,27L,27L,62L,55L,53L,63L,335L,310L,300L,326L,713L,703L,690L,726L,704L,755L,762L,1691L,1611L,1587L,1665L,1574L,1716L,4122L,3719L,4097L,4057L,4005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032578Inst : IEnumerable<long>
{
public static readonly long[] Value=A032578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032578.Bytes);
public long this[int i]=>Value[i];

public static A032578Inst Instance=new A032578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032579
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,14L,28L,126L,385L,1260L,1484L,3850L,12480L,25326L,38160L,50323L,53158L,89768L,118413L,255920L,256046L,296858L,297000L,538440L,553553L,723680L,1616880L,1807840L,2935059L,3909703L,5362986L,5535530L,13068055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032579Inst : IEnumerable<long>
{
public static readonly long[] Value=A032579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032579.Bytes);
public long this[int i]=>Value[i];

public static A032579Inst Instance=new A032579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032580
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,5L,5L,12L,11L,12L,29L,29L,29L,33L,32L,31L,71L,69L,69L,64L,64L,76L,75L,78L,148L,141L,155L,165L,183L,180L,395L,335L,333L,323L,423L,372L,396L,432L,449L,1002L,948L,804L,993L,1072L,1072L,1065L,2173L,2501L,2512L,2618L,2556L,2545L,4637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032580Inst : IEnumerable<long>
{
public static readonly long[] Value=A032580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032580.Bytes);
public long this[int i]=>Value[i];

public static A032580Inst Instance=new A032580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032581
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,105L,150L,213L,318L,321L,426L,534L,639L,642L,747L,750L,855L,963L,1050L,1896L,1941L,2130L,2750L,3180L,3210L,4260L,5340L,6390L,6420L,7470L,7500L,8550L,9630L,12500L,14763L,29921L,54565L,87500L,125000L,604750L,849250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032581Inst : IEnumerable<long>
{
public static readonly long[] Value=A032581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032581.Bytes);
public long this[int i]=>Value[i];

public static A032581Inst Instance=new A032581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032582
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,6L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,15L,11L,11L,15L,13L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,34L,31L,31L,37L,37L,85L,97L,94L,216L,221L,211L,229L,235L,540L,486L,566L,571L,1456L,1421L,1350L,1116L,1077L,1342L,1215L,1421L,1415L,1486L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032582Inst : IEnumerable<long>
{
public static readonly long[] Value=A032582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032582.Bytes);
public long this[int i]=>Value[i];

public static A032582Inst Instance=new A032582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032583
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,27L,28L,30L,32L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,52L,54L,55L,56L,57L,58L,60L,62L,64L,65L,66L,68L,70L,72L,74L,76L,77L,78L,80L,81L,82L,84L,85L,86L,88L,90L,91L,92L,94L,95L,96L,98L,100L,102L,104L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032583Inst : IEnumerable<long>
{
public static readonly long[] Value=A032583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032583.Bytes);
public long this[int i]=>Value[i];

public static A032583Inst Instance=new A032583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032584
{
public static readonly long[] Value={ 27L,35L,39L,45L,55L,57L,65L,77L,81L,85L,91L,95L,117L,119L,121L,123L,125L,143L,145L,147L,153L,155L,161L,165L,175L,177L,183L,185L,187L,203L,207L,209L,213L,215L,217L,221L,225L,243L,245L,247L,249L,253L,255L,265L,275L,279L,287L,291L,295L,299L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032584Inst : IEnumerable<long>
{
public static readonly long[] Value=A032584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032584.Bytes);
public long this[int i]=>Value[i];

public static A032584Inst Instance=new A032584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032585
{
public static readonly long[] Value={ 1L,21L,31L,51L,111L,141L,151L,171L,201L,211L,231L,241L,261L,321L,331L,361L,391L,421L,451L,511L,541L,591L,601L,621L,631L,651L,741L,781L,801L,831L,841L,931L,961L,981L,991L,1011L,1021L,1041L,1101L,1201L,1231L,1251L,1261L,1281L,1291L,1401L,1441L,1471L,1491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032585Inst : IEnumerable<long>
{
public static readonly long[] Value=A032585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032585.Bytes);
public long this[int i]=>Value[i];

public static A032585Inst Instance=new A032585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032586
{
public static readonly long[] Value={ 3L,13L,33L,43L,63L,73L,93L,133L,163L,193L,223L,273L,283L,303L,393L,433L,463L,483L,553L,583L,613L,643L,673L,693L,723L,823L,873L,883L,903L,933L,993L,1023L,1053L,1093L,1123L,1183L,1203L,1233L,1263L,1303L,1323L,1473L,1503L,1533L,1543L,1563L,1663L,1693L,1723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032586Inst : IEnumerable<long>
{
public static readonly long[] Value=A032586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032586.Bytes);
public long this[int i]=>Value[i];

public static A032586Inst Instance=new A032586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032587
{
public static readonly long[] Value={ 15L,25L,75L,105L,115L,135L,195L,205L,235L,285L,385L,415L,475L,495L,535L,615L,645L,655L,685L,735L,745L,805L,855L,885L,895L,925L,975L,1095L,1105L,1155L,1245L,1275L,1285L,1365L,1395L,1435L,1455L,1485L,1495L,1545L,1575L,1585L,1645L,1675L,1705L,1765L,1915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032587Inst : IEnumerable<long>
{
public static readonly long[] Value=A032587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032587.Bytes);
public long this[int i]=>Value[i];

public static A032587Inst Instance=new A032587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032588
{
public static readonly long[] Value={ 7L,37L,67L,87L,127L,237L,267L,297L,307L,327L,357L,367L,427L,477L,487L,517L,537L,577L,717L,727L,777L,787L,867L,897L,927L,937L,957L,997L,1057L,1087L,1107L,1117L,1147L,1167L,1197L,1357L,1387L,1417L,1497L,1567L,1587L,1597L,1737L,1767L,1777L,1797L,1827L,1857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032588Inst : IEnumerable<long>
{
public static readonly long[] Value=A032588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032588.Bytes);
public long this[int i]=>Value[i];

public static A032588Inst Instance=new A032588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032605
{
public static readonly long[] Value={ 2L,5L,17L,23L,41L,47L,73L,97L,127L,137L,157L,191L,227L,233L,307L,331L,347L,367L,379L,401L,449L,487L,523L,571L,607L,631L,709L,727L,751L,761L,811L,877L,937L,967L,1009L,1019L,1129L,1171L,1187L,1229L,1259L,1297L,1367L,1409L,1453L,1483L,1489L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032605Inst : IEnumerable<long>
{
public static readonly long[] Value=A032605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032605.Bytes);
public long this[int i]=>Value[i];

public static A032605Inst Instance=new A032605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032606
{
public static readonly long[] Value={ 3L,7L,13L,21L,37L,49L,69L,75L,99L,133L,141L,189L,205L,219L,237L,283L,319L,327L,367L,399L,415L,463L,487L,529L,583L,615L,621L,645L,655L,693L,801L,831L,885L,897L,979L,991L,1023L,1087L,1105L,1167L,1203L,1219L,1285L,1303L,1339L,1365L,1471L,1563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032606Inst : IEnumerable<long>
{
public static readonly long[] Value=A032606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032606.Bytes);
public long this[int i]=>Value[i];

public static A032606Inst Instance=new A032606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032607
{
public static readonly long[] Value={ 13L,24L,35L,46L,57L,68L,79L,810L,911L,1012L,1113L,1214L,1315L,1416L,1517L,1618L,1719L,1820L,1921L,2022L,2123L,2224L,2325L,2426L,2527L,2628L,2729L,2830L,2931L,3032L,3133L,3234L,3335L,3436L,3537L,3638L,3739L,3840L,3941L,4042L,4143L,4244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032607Inst : IEnumerable<long>
{
public static readonly long[] Value=A032607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032607.Bytes);
public long this[int i]=>Value[i];

public static A032607Inst Instance=new A032607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032608
{
public static readonly long[] Value={ 14L,25L,36L,47L,58L,69L,710L,811L,912L,1013L,1114L,1215L,1316L,1417L,1518L,1619L,1720L,1821L,1922L,2023L,2124L,2225L,2326L,2427L,2528L,2629L,2730L,2831L,2932L,3033L,3134L,3235L,3336L,3437L,3538L,3639L,3740L,3841L,3942L,4043L,4144L,4245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032608Inst : IEnumerable<long>
{
public static readonly long[] Value=A032608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032608.Bytes);
public long this[int i]=>Value[i];

public static A032608Inst Instance=new A032608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032609
{
public static readonly long[] Value={ 15L,26L,37L,48L,59L,610L,711L,812L,913L,1014L,1115L,1216L,1317L,1418L,1519L,1620L,1721L,1822L,1923L,2024L,2125L,2226L,2327L,2428L,2529L,2630L,2731L,2832L,2933L,3034L,3135L,3236L,3337L,3438L,3539L,3640L,3741L,3842L,3943L,4044L,4145L,4246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032609Inst : IEnumerable<long>
{
public static readonly long[] Value=A032609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032609.Bytes);
public long this[int i]=>Value[i];

public static A032609Inst Instance=new A032609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032610
{
public static readonly long[] Value={ 16L,27L,38L,49L,510L,611L,712L,813L,914L,1015L,1116L,1217L,1318L,1419L,1520L,1621L,1722L,1823L,1924L,2025L,2126L,2227L,2328L,2429L,2530L,2631L,2732L,2833L,2934L,3035L,3136L,3237L,3338L,3439L,3540L,3641L,3742L,3843L,3944L,4045L,4146L,4247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032610Inst : IEnumerable<long>
{
public static readonly long[] Value=A032610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032610.Bytes);
public long this[int i]=>Value[i];

public static A032610Inst Instance=new A032610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032611
{
public static readonly long[] Value={ 17L,28L,39L,410L,511L,612L,713L,814L,915L,1016L,1117L,1218L,1319L,1420L,1521L,1622L,1723L,1824L,1925L,2026L,2127L,2228L,2329L,2430L,2531L,2632L,2733L,2834L,2935L,3036L,3137L,3238L,3339L,3440L,3541L,3642L,3743L,3844L,3945L,4046L,4147L,4248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032611Inst : IEnumerable<long>
{
public static readonly long[] Value=A032611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032611.Bytes);
public long this[int i]=>Value[i];

public static A032611Inst Instance=new A032611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032612
{
public static readonly long[] Value={ 18L,29L,310L,411L,512L,613L,714L,815L,916L,1017L,1118L,1219L,1320L,1421L,1522L,1623L,1724L,1825L,1926L,2027L,2128L,2229L,2330L,2431L,2532L,2633L,2734L,2835L,2936L,3037L,3138L,3239L,3340L,3441L,3542L,3643L,3744L,3845L,3946L,4047L,4148L,4249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032612Inst : IEnumerable<long>
{
public static readonly long[] Value=A032612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032612.Bytes);
public long this[int i]=>Value[i];

public static A032612Inst Instance=new A032612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032613
{
public static readonly long[] Value={ 19L,210L,311L,412L,513L,614L,715L,816L,917L,1018L,1119L,1220L,1321L,1422L,1523L,1624L,1725L,1826L,1927L,2028L,2129L,2230L,2331L,2432L,2533L,2634L,2735L,2836L,2937L,3038L,3139L,3240L,3341L,3442L,3543L,3644L,3745L,3846L,3947L,4048L,4149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032613Inst : IEnumerable<long>
{
public static readonly long[] Value=A032613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032613.Bytes);
public long this[int i]=>Value[i];

public static A032613Inst Instance=new A032613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032614
{
public static readonly long[] Value={ 110L,211L,312L,413L,514L,615L,716L,817L,918L,1019L,1120L,1221L,1322L,1423L,1524L,1625L,1726L,1827L,1928L,2029L,2130L,2231L,2332L,2433L,2534L,2635L,2736L,2837L,2938L,3039L,3140L,3241L,3342L,3443L,3544L,3645L,3746L,3847L,3948L,4049L,4150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032614Inst : IEnumerable<long>
{
public static readonly long[] Value=A032614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032614.Bytes);
public long this[int i]=>Value[i];

public static A032614Inst Instance=new A032614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032615
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032615Inst : IEnumerable<long>
{
public static readonly long[] Value=A032615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032615.Bytes);
public long this[int i]=>Value[i];

public static A032615Inst Instance=new A032615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032616
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,7L,11L,15L,20L,25L,31L,38L,45L,53L,62L,71L,81L,91L,103L,114L,127L,140L,154L,168L,183L,198L,215L,232L,249L,267L,286L,305L,325L,346L,367L,389L,412L,435L,459L,484L,509L,535L,561L,588L,616L,644L,673L,703L,733L,764L,795L,827L,860L,894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032616Inst : IEnumerable<long>
{
public static readonly long[] Value=A032616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032616.Bytes);
public long this[int i]=>Value[i];

public static A032616Inst Instance=new A032616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032617
{
public static readonly long[] Value={ 1L,7L,9L,27L,37L,45L,49L,51L,55L,61L,69L,75L,105L,109L,115L,117L,121L,151L,159L,181L,187L,195L,201L,211L,217L,225L,247L,271L,277L,285L,289L,291L,301L,309L,319L,321L,331L,337L,339L,357L,361L,367L,381L,391L,399L,405L,417L,421L,427L,429L,435L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032617Inst : IEnumerable<long>
{
public static readonly long[] Value=A032617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032617.Bytes);
public long this[int i]=>Value[i];

public static A032617Inst Instance=new A032617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032618
{
public static readonly long[] Value={ 4L,8L,10L,16L,44L,46L,56L,58L,68L,74L,86L,94L,98L,100L,104L,106L,136L,140L,148L,154L,158L,160L,166L,176L,184L,194L,206L,230L,244L,250L,254L,260L,266L,268L,274L,286L,296L,308L,310L,328L,338L,344L,346L,370L,380L,388L,410L,416L,430L,434L,436L,440L,448L,460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032618Inst : IEnumerable<long>
{
public static readonly long[] Value=A032618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032618.Bytes);
public long this[int i]=>Value[i];

public static A032618Inst Instance=new A032618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032619
{
public static readonly long[] Value={ 3L,5L,17L,27L,35L,39L,45L,47L,63L,65L,83L,93L,99L,113L,123L,147L,149L,173L,185L,203L,209L,213L,219L,227L,239L,249L,255L,263L,267L,285L,287L,303L,309L,317L,327L,329L,333L,363L,365L,399L,413L,419L,423L,435L,447L,459L,465L,467L,473L,489L,497L,509L,515L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032619Inst : IEnumerable<long>
{
public static readonly long[] Value=A032619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032619.Bytes);
public long this[int i]=>Value[i];

public static A032619Inst Instance=new A032619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032620
{
public static readonly long[] Value={ 12L,16L,18L,28L,46L,64L,76L,78L,82L,88L,102L,126L,132L,138L,148L,154L,178L,184L,186L,196L,208L,214L,226L,228L,234L,246L,264L,282L,288L,298L,316L,318L,322L,324L,328L,342L,348L,352L,372L,408L,418L,424L,432L,438L,442L,444L,456L,462L,468L,472L,474L,478L,484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032620Inst : IEnumerable<long>
{
public static readonly long[] Value=A032620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032620.Bytes);
public long this[int i]=>Value[i];

public static A032620Inst Instance=new A032620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032637
{
public static readonly long[] Value={ 0L,1L,3L,11L,35L,112L,353L,1111L,3490L,10966L,34451L,108231L,340019L,1068203L,3355859L,10542742L,33121003L,104052699L,326891197L,1026958985L,3226286805L,10135678925L,31842174452L,100035141333L,314269665113L,987307271166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032637Inst : IEnumerable<long>
{
public static readonly long[] Value=A032637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032637.Bytes);
public long this[int i]=>Value[i];

public static A032637Inst Instance=new A032637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032638
{
public static readonly long[] Value={ 0L,0L,2L,6L,17L,47L,128L,349L,948L,2579L,7011L,19058L,51806L,140824L,382800L,1040560L,2828536L,7688760L,20900217L,56812680L,154432878L,419792086L,1141113200L,3101867275L,8431749450L,22919871312L,62302669700L,169356214910L,460357921527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032638Inst : IEnumerable<long>
{
public static readonly long[] Value=A032638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032638.Bytes);
public long this[int i]=>Value[i];

public static A032638Inst Instance=new A032638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032639
{
public static readonly long[] Value={ 1L,7L,21L,31L,49L,63L,87L,111L,141L,159L,189L,219L,259L,267L,339L,367L,391L,415L,427L,463L,517L,553L,601L,639L,679L,717L,801L,819L,855L,873L,925L,991L,1039L,1087L,1117L,1147L,1275L,1303L,1323L,1387L,1417L,1471L,1519L,1563L,1611L,1659L,1675L,1711L,1857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032639Inst : IEnumerable<long>
{
public static readonly long[] Value=A032639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032639.Bytes);
public long this[int i]=>Value[i];

public static A032639Inst Instance=new A032639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032640
{
public static readonly long[] Value={ 3L,9L,21L,23L,51L,59L,63L,71L,75L,87L,89L,99L,105L,111L,117L,123L,129L,135L,143L,147L,153L,171L,173L,177L,191L,201L,237L,243L,255L,263L,285L,305L,309L,317L,327L,357L,363L,369L,371L,387L,389L,393L,431L,443L,459L,465L,467L,495L,497L,513L,521L,533L,561L,567L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032640Inst : IEnumerable<long>
{
public static readonly long[] Value=A032640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032640.Bytes);
public long this[int i]=>Value[i];

public static A032640Inst Instance=new A032640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032641
{
public static readonly long[] Value={ 6L,10L,18L,30L,40L,46L,52L,54L,60L,66L,76L,82L,114L,138L,144L,160L,162L,178L,196L,210L,214L,234L,240L,246L,252L,258L,264L,274L,306L,312L,318L,322L,358L,376L,382L,390L,418L,426L,454L,466L,468L,472L,484L,498L,502L,508L,510L,520L,528L,552L,558L,562L,588L,592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032641Inst : IEnumerable<long>
{
public static readonly long[] Value=A032641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032641.Bytes);
public long this[int i]=>Value[i];

public static A032641Inst Instance=new A032641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032642
{
public static readonly long[] Value={ 1L,7L,19L,25L,31L,49L,61L,65L,71L,77L,101L,103L,107L,121L,125L,133L,139L,149L,157L,169L,173L,193L,205L,221L,233L,245L,295L,349L,359L,371L,385L,391L,413L,425L,431L,445L,457L,463L,479L,481L,517L,527L,533L,553L,575L,583L,587L,593L,605L,611L,617L,637L,641L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032642Inst : IEnumerable<long>
{
public static readonly long[] Value=A032642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032642.Bytes);
public long this[int i]=>Value[i];

public static A032642Inst Instance=new A032642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032643
{
public static readonly long[] Value={ 2L,6L,14L,20L,24L,32L,48L,50L,66L,68L,78L,84L,108L,120L,128L,134L,146L,156L,162L,200L,210L,218L,224L,228L,254L,266L,270L,284L,290L,306L,312L,314L,318L,324L,330L,332L,344L,360L,378L,380L,390L,396L,402L,410L,438L,452L,456L,458L,476L,482L,492L,494L,510L,512L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032643Inst : IEnumerable<long>
{
public static readonly long[] Value=A032643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032643.Bytes);
public long this[int i]=>Value[i];

public static A032643Inst Instance=new A032643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032644
{
public static readonly long[] Value={ 1L,3L,15L,19L,21L,39L,55L,63L,73L,85L,99L,111L,117L,135L,159L,165L,201L,219L,261L,267L,273L,327L,333L,345L,357L,369L,381L,399L,423L,471L,483L,495L,513L,525L,537L,579L,585L,597L,603L,615L,621L,639L,675L,681L,687L,693L,699L,741L,789L,831L,837L,879L,885L,891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032644Inst : IEnumerable<long>
{
public static readonly long[] Value=A032644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032644.Bytes);
public long this[int i]=>Value[i];

public static A032644Inst Instance=new A032644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032645
{
public static readonly long[] Value={ 4L,14L,34L,38L,40L,56L,80L,110L,128L,134L,164L,170L,182L,188L,200L,218L,224L,308L,332L,362L,368L,416L,422L,452L,506L,578L,584L,602L,686L,740L,758L,764L,776L,782L,800L,848L,854L,866L,872L,890L,902L,908L,938L,974L,1004L,1018L,1022L,1028L,1034L,1054L,1064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032645Inst : IEnumerable<long>
{
public static readonly long[] Value=A032645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032645.Bytes);
public long this[int i]=>Value[i];

public static A032645Inst Instance=new A032645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032646
{
public static readonly long[] Value={ 5L,11L,17L,21L,33L,45L,51L,57L,59L,63L,87L,89L,93L,107L,117L,129L,137L,153L,179L,183L,191L,197L,207L,219L,225L,227L,245L,255L,263L,269L,287L,291L,299L,351L,371L,377L,407L,413L,423L,425L,435L,441L,485L,495L,513L,543L,551L,567L,569L,579L,641L,647L,659L,669L,675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032646Inst : IEnumerable<long>
{
public static readonly long[] Value=A032646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032646.Bytes);
public long this[int i]=>Value[i];

public static A032646Inst Instance=new A032646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032647
{
public static readonly long[] Value={ 6L,12L,28L,30L,46L,52L,64L,70L,72L,78L,82L,88L,126L,148L,160L,166L,184L,198L,210L,226L,228L,268L,286L,298L,300L,306L,334L,346L,364L,376L,394L,396L,412L,430L,444L,478L,486L,502L,516L,520L,522L,538L,540L,544L,556L,558L,568L,570L,586L,604L,622L,630L,634L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032647Inst : IEnumerable<long>
{
public static readonly long[] Value=A032647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032647.Bytes);
public long this[int i]=>Value[i];

public static A032647Inst Instance=new A032647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032648
{
public static readonly long[] Value={ 59L,65L,89L,97L,121L,131L,133L,143L,151L,161L,169L,179L,185L,187L,197L,205L,211L,221L,235L,247L,251L,253L,271L,277L,283L,295L,313L,319L,325L,331L,343L,359L,367L,391L,427L,433L,439L,457L,481L,499L,503L,509L,511L,517L,529L,563L,575L,577L,583L,613L,619L,629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032648Inst : IEnumerable<long>
{
public static readonly long[] Value=A032648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032648.Bytes);
public long this[int i]=>Value[i];

public static A032648Inst Instance=new A032648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032649
{
public static readonly long[] Value={ 2L,6L,18L,26L,30L,38L,42L,54L,62L,80L,84L,98L,126L,132L,158L,168L,212L,222L,240L,242L,258L,278L,288L,296L,306L,312L,314L,350L,368L,384L,386L,404L,410L,438L,456L,468L,474L,482L,492L,504L,512L,518L,530L,564L,576L,612L,638L,666L,672L,684L,690L,692L,698L,702L,708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032649Inst : IEnumerable<long>
{
public static readonly long[] Value=A032649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032649.Bytes);
public long this[int i]=>Value[i];

public static A032649Inst Instance=new A032649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032650
{
public static readonly long[] Value={ 33L,99L,2121L,2323L,5151L,5959L,6363L,7171L,7575L,8787L,8989L,9999L,105105L,111111L,117117L,123123L,129129L,135135L,143143L,147147L,153153L,171171L,173173L,177177L,191191L,201201L,237237L,243243L,255255L,263263L,285285L,305305L,309309L,317317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032650Inst : IEnumerable<long>
{
public static readonly long[] Value=A032650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032650.Bytes);
public long this[int i]=>Value[i];

public static A032650Inst Instance=new A032650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032651
{
public static readonly long[] Value={ 67L,1011L,1819L,3031L,4041L,4647L,5253L,5455L,6061L,6667L,7677L,8283L,114115L,138139L,144145L,160161L,162163L,178179L,196197L,210211L,214215L,234235L,240241L,246247L,252253L,258259L,264265L,274275L,306307L,312313L,318319L,322323L,358359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032651Inst : IEnumerable<long>
{
public static readonly long[] Value=A032651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032651.Bytes);
public long this[int i]=>Value[i];

public static A032651Inst Instance=new A032651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032652
{
public static readonly long[] Value={ 13L,79L,1921L,2527L,3133L,4951L,6163L,6567L,7173L,7779L,101103L,103105L,107109L,121123L,125127L,133135L,139141L,149151L,157159L,169171L,173175L,193195L,205207L,221223L,233235L,245247L,295297L,349351L,359361L,371373L,385387L,391393L,413415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032652Inst : IEnumerable<long>
{
public static readonly long[] Value=A032652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032652.Bytes);
public long this[int i]=>Value[i];

public static A032652Inst Instance=new A032652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032669
{
public static readonly long[] Value={ 1L,7L,13L,17L,19L,31L,41L,43L,47L,53L,59L,61L,73L,77L,83L,91L,101L,113L,121L,131L,133L,143L,151L,163L,173L,197L,199L,203L,211L,217L,221L,229L,247L,257L,263L,269L,271L,277L,287L,299L,301L,311L,317L,323L,329L,337L,343L,353L,359L,361L,367L,373L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032669Inst : IEnumerable<long>
{
public static readonly long[] Value=A032669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032669.Bytes);
public long this[int i]=>Value[i];

public static A032669Inst Instance=new A032669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032670
{
public static readonly long[] Value={ 1L,3L,9L,19L,27L,33L,39L,43L,51L,57L,61L,69L,73L,87L,97L,103L,109L,121L,127L,129L,151L,159L,177L,187L,193L,207L,211L,213L,219L,229L,237L,243L,247L,253L,283L,297L,307L,309L,321L,331L,333L,349L,351L,369L,393L,411L,417L,433L,451L,457L,459L,477L,481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032670Inst : IEnumerable<long>
{
public static readonly long[] Value=A032670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032670.Bytes);
public long this[int i]=>Value[i];

public static A032670Inst Instance=new A032670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032671
{
public static readonly long[] Value={ 3L,9L,11L,21L,23L,27L,29L,39L,53L,57L,59L,63L,77L,81L,83L,87L,101L,111L,117L,123L,147L,161L,167L,171L,179L,191L,209L,219L,221L,231L,233L,237L,243L,263L,269L,273L,287L,291L,293L,297L,311L,317L,329L,353L,363L,369L,377L,387L,389L,419L,423L,429L,431L,443L,447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032671Inst : IEnumerable<long>
{
public static readonly long[] Value=A032671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032671.Bytes);
public long this[int i]=>Value[i];

public static A032671Inst Instance=new A032671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032672
{
public static readonly long[] Value={ 7L,11L,19L,29L,37L,41L,47L,53L,67L,71L,77L,83L,91L,97L,103L,109L,127L,133L,137L,151L,157L,161L,173L,181L,187L,199L,203L,209L,221L,227L,239L,241L,257L,277L,281L,283L,293L,311L,319L,323L,337L,341L,343L,349L,371L,377L,391L,397L,403L,413L,419L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032672Inst : IEnumerable<long>
{
public static readonly long[] Value=A032672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032672.Bytes);
public long this[int i]=>Value[i];

public static A032672Inst Instance=new A032672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032673
{
public static readonly long[] Value={ 3L,5L,11L,15L,27L,29L,33L,35L,41L,51L,59L,63L,69L,71L,89L,93L,95L,101L,105L,107L,117L,123L,147L,155L,167L,179L,183L,189L,197L,201L,203L,209L,219L,231L,233L,245L,249L,251L,261L,263L,275L,281L,285L,291L,303L,309L,323L,329L,339L,357L,365L,369L,387L,389L,395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032673Inst : IEnumerable<long>
{
public static readonly long[] Value=A032673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032673.Bytes);
public long this[int i]=>Value[i];

public static A032673Inst Instance=new A032673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032674
{
public static readonly long[] Value={ 1L,5L,11L,19L,23L,31L,35L,37L,41L,59L,61L,67L,73L,83L,85L,89L,97L,113L,115L,121L,125L,127L,133L,163L,173L,187L,209L,211L,215L,217L,221L,239L,251L,253L,257L,271L,277L,281L,283L,301L,311L,317L,323L,335L,343L,355L,365L,379L,395L,403L,407L,409L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032674Inst : IEnumerable<long>
{
public static readonly long[] Value=A032674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032674.Bytes);
public long this[int i]=>Value[i];

public static A032674Inst Instance=new A032674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032675
{
public static readonly long[] Value={ 1L,3L,7L,19L,21L,27L,31L,39L,49L,57L,61L,67L,85L,91L,93L,99L,109L,111L,121L,123L,133L,153L,163L,171L,175L,183L,187L,199L,213L,223L,229L,235L,243L,259L,261L,289L,297L,301L,307L,313L,325L,339L,351L,355L,363L,381L,403L,405L,409L,411L,427L,433L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032675Inst : IEnumerable<long>
{
public static readonly long[] Value=A032675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032675.Bytes);
public long this[int i]=>Value[i];

public static A032675Inst Instance=new A032675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032676
{
public static readonly long[] Value={ 3L,9L,15L,21L,27L,29L,33L,51L,63L,75L,77L,83L,87L,89L,95L,105L,107L,129L,131L,161L,165L,173L,179L,189L,195L,201L,203L,207L,227L,237L,251L,255L,257L,263L,269L,285L,287L,315L,321L,329L,335L,363L,377L,383L,389L,399L,413L,431L,441L,443L,455L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032676Inst : IEnumerable<long>
{
public static readonly long[] Value=A032676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032676.Bytes);
public long this[int i]=>Value[i];

public static A032676Inst Instance=new A032676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032677
{
public static readonly long[] Value={ 1L,11L,17L,19L,29L,35L,37L,41L,53L,59L,77L,79L,83L,91L,103L,127L,137L,139L,149L,151L,157L,169L,179L,181L,191L,211L,217L,229L,233L,235L,253L,259L,277L,283L,293L,295L,299L,325L,335L,341L,343L,371L,377L,379L,385L,409L,419L,427L,433L,449L,455L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032677Inst : IEnumerable<long>
{
public static readonly long[] Value=A032677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032677.Bytes);
public long this[int i]=>Value[i];

public static A032677Inst Instance=new A032677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032678
{
public static readonly long[] Value={ 3L,7L,9L,13L,15L,19L,21L,31L,39L,43L,45L,51L,55L,73L,79L,85L,93L,99L,111L,115L,123L,141L,147L,159L,163L,175L,177L,195L,211L,229L,237L,243L,249L,253L,271L,273L,279L,301L,309L,331L,345L,351L,355L,363L,367L,369L,373L,379L,385L,399L,411L,415L,427L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032678Inst : IEnumerable<long>
{
public static readonly long[] Value=A032678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032678.Bytes);
public long this[int i]=>Value[i];

public static A032678Inst Instance=new A032678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032679
{
public static readonly long[] Value={ 3L,5L,9L,17L,23L,27L,29L,35L,39L,41L,45L,69L,77L,81L,87L,101L,111L,129L,135L,153L,167L,171L,173L,183L,191L,195L,197L,207L,215L,231L,233L,237L,245L,249L,279L,293L,299L,311L,321L,333L,339L,341L,345L,357L,359L,371L,377L,395L,401L,405L,419L,435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032679Inst : IEnumerable<long>
{
public static readonly long[] Value=A032679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032679.Bytes);
public long this[int i]=>Value[i];

public static A032679Inst Instance=new A032679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032680
{
public static readonly long[] Value={ 7L,19L,23L,31L,41L,55L,67L,73L,83L,85L,95L,97L,107L,109L,127L,131L,139L,151L,161L,169L,173L,175L,191L,193L,221L,223L,227L,233L,253L,257L,263L,269L,283L,289L,299L,325L,331L,347L,359L,365L,367L,379L,409L,413L,421L,445L,449L,467L,473L,475L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032680Inst : IEnumerable<long>
{
public static readonly long[] Value=A032680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032680.Bytes);
public long this[int i]=>Value[i];

public static A032680Inst Instance=new A032680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032681
{
public static readonly long[] Value={ 3L,9L,25L,27L,31L,33L,37L,57L,61L,75L,79L,81L,91L,93L,97L,115L,117L,121L,123L,135L,139L,145L,151L,177L,181L,211L,213L,223L,231L,235L,249L,253L,267L,273L,277L,285L,291L,303L,315L,331L,339L,349L,373L,387L,399L,403L,409L,421L,423L,429L,441L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032681Inst : IEnumerable<long>
{
public static readonly long[] Value=A032681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032681.Bytes);
public long this[int i]=>Value[i];

public static A032681Inst Instance=new A032681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032682
{
public static readonly long[] Value={ 0L,3L,5L,8L,9L,15L,17L,18L,20L,23L,29L,30L,32L,36L,38L,45L,47L,48L,51L,53L,57L,60L,62L,72L,74L,80L,81L,83L,86L,87L,90L,93L,95L,107L,113L,116L,117L,125L,126L,131L,132L,135L,141L,147L,149L,155L,162L,168L,170L,173L,180L,182L,183L,194L,197L,198L,201L,204L,207L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032682Inst : IEnumerable<long>
{
public static readonly long[] Value=A032682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032682.Bytes);
public long this[int i]=>Value[i];

public static A032682Inst Instance=new A032682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032683
{
public static readonly long[] Value={ 1L,5L,7L,8L,16L,20L,25L,31L,32L,34L,37L,41L,43L,46L,53L,58L,59L,61L,62L,64L,67L,73L,79L,80L,82L,83L,85L,86L,92L,94L,101L,103L,106L,112L,115L,118L,119L,122L,125L,133L,139L,151L,154L,157L,158L,164L,166L,172L,179L,187L,188L,196L,197L,200L,206L,208L,214L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032683Inst : IEnumerable<long>
{
public static readonly long[] Value=A032683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032683.Bytes);
public long this[int i]=>Value[i];

public static A032683Inst Instance=new A032683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032684
{
public static readonly long[] Value={ 2L,5L,8L,9L,12L,17L,18L,20L,23L,24L,29L,30L,41L,45L,47L,48L,50L,51L,53L,54L,57L,60L,68L,71L,72L,75L,81L,86L,87L,90L,92L,93L,114L,116L,123L,125L,128L,131L,132L,134L,138L,143L,152L,153L,159L,164L,170L,177L,180L,183L,186L,188L,191L,194L,198L,204L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032684Inst : IEnumerable<long>
{
public static readonly long[] Value=A032684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032684.Bytes);
public long this[int i]=>Value[i];

public static A032684Inst Instance=new A032684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032685
{
public static readonly long[] Value={ 1L,2L,10L,19L,20L,23L,31L,34L,41L,43L,47L,53L,61L,62L,64L,67L,68L,71L,73L,74L,76L,82L,83L,85L,92L,94L,100L,101L,107L,109L,112L,113L,115L,119L,122L,124L,130L,136L,145L,149L,152L,163L,190L,193L,196L,200L,211L,217L,218L,221L,226L,236L,239L,241L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032685Inst : IEnumerable<long>
{
public static readonly long[] Value=A032685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032685.Bytes);
public long this[int i]=>Value[i];

public static A032685Inst Instance=new A032685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032686
{
public static readonly long[] Value={ 1L,4L,5L,7L,10L,20L,23L,25L,26L,28L,29L,40L,44L,47L,49L,50L,61L,64L,70L,71L,73L,77L,80L,83L,92L,94L,101L,109L,118L,130L,134L,137L,139L,149L,152L,154L,158L,164L,172L,173L,178L,181L,191L,196L,199L,212L,214L,215L,220L,230L,232L,239L,241L,248L,262L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032686Inst : IEnumerable<long>
{
public static readonly long[] Value=A032686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032686.Bytes);
public long this[int i]=>Value[i];

public static A032686Inst Instance=new A032686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032687
{
public static readonly long[] Value={ 0L,9L,12L,13L,15L,16L,18L,21L,22L,24L,31L,36L,40L,43L,45L,60L,61L,63L,66L,75L,76L,79L,84L,87L,94L,100L,103L,109L,114L,126L,129L,130L,136L,138L,145L,157L,163L,171L,172L,177L,186L,189L,190L,195L,201L,205L,213L,217L,222L,237L,240L,243L,253L,256L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032687Inst : IEnumerable<long>
{
public static readonly long[] Value=A032687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032687.Bytes);
public long this[int i]=>Value[i];

public static A032687Inst Instance=new A032687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032688
{
public static readonly long[] Value={ 3L,23L,29L,32L,33L,38L,45L,51L,65L,75L,90L,96L,108L,110L,113L,116L,125L,132L,135L,147L,167L,183L,185L,186L,195L,204L,216L,218L,227L,236L,242L,246L,248L,254L,255L,257L,263L,275L,276L,278L,284L,293L,297L,300L,314L,315L,320L,323L,324L,326L,330L,338L,345L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032688Inst : IEnumerable<long>
{
public static readonly long[] Value=A032688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032688.Bytes);
public long this[int i]=>Value[i];

public static A032688Inst Instance=new A032688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032689
{
public static readonly long[] Value={ 1L,2L,7L,8L,16L,19L,20L,23L,35L,37L,43L,44L,50L,56L,67L,68L,71L,73L,82L,83L,89L,91L,94L,101L,103L,104L,115L,127L,134L,151L,154L,155L,157L,161L,169L,199L,212L,215L,218L,227L,232L,257L,260L,268L,272L,278L,289L,290L,299L,301L,308L,311L,317L,319L,322L,337L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032689Inst : IEnumerable<long>
{
public static readonly long[] Value=A032689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032689.Bytes);
public long this[int i]=>Value[i];

public static A032689Inst Instance=new A032689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032690
{
public static readonly long[] Value={ 7L,13L,24L,33L,34L,39L,40L,42L,54L,64L,78L,97L,99L,103L,105L,108L,112L,123L,126L,127L,129L,132L,133L,139L,142L,147L,150L,163L,172L,177L,205L,217L,219L,223L,229L,237L,240L,255L,256L,258L,259L,265L,268L,270L,273L,274L,277L,282L,286L,292L,309L,312L,313L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032690Inst : IEnumerable<long>
{
public static readonly long[] Value=A032690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032690.Bytes);
public long this[int i]=>Value[i];

public static A032690Inst Instance=new A032690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032691
{
public static readonly long[] Value={ 89L,107L,139L,141L,169L,189L,223L,249L,267L,313L,379L,383L,403L,453L,497L,587L,589L,633L,667L,751L,757L,763L,799L,859L,893L,899L,913L,959L,961L,977L,979L,981L,983L,989L,991L,1003L,1007L,1009L,1041L,1049L,1063L,1067L,1087L,1093L,1107L,1109L,1123L,1127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032691Inst : IEnumerable<long>
{
public static readonly long[] Value=A032691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032691.Bytes);
public long this[int i]=>Value[i];

public static A032691Inst Instance=new A032691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032692
{
public static readonly long[] Value={ 17L,117L,119L,123L,131L,143L,147L,157L,159L,173L,177L,191L,193L,197L,199L,201L,207L,227L,233L,239L,241L,247L,251L,261L,263L,279L,289L,291L,299L,303L,317L,321L,327L,331L,339L,341L,353L,357L,359L,363L,367L,369L,387L,407L,409L,411L,427L,429L,439L,443L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032692Inst : IEnumerable<long>
{
public static readonly long[] Value=A032692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032692.Bytes);
public long this[int i]=>Value[i];

public static A032692Inst Instance=new A032692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032693
{
public static readonly long[] Value={ 13L,21L,23L,29L,33L,37L,43L,49L,51L,59L,61L,69L,71L,79L,81L,93L,99L,101L,103L,111L,113L,121L,127L,133L,137L,161L,163L,167L,171L,179L,181L,211L,213L,219L,253L,257L,259L,269L,271L,277L,281L,287L,293L,301L,307L,309L,319L,329L,333L,337L,343L,347L,349L,351L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032693Inst : IEnumerable<long>
{
public static readonly long[] Value=A032693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032693.Bytes);
public long this[int i]=>Value[i];

public static A032693Inst Instance=new A032693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032694
{
public static readonly long[] Value={ 11L,19L,27L,31L,41L,47L,53L,67L,73L,87L,91L,97L,109L,129L,151L,153L,187L,203L,209L,217L,231L,243L,273L,283L,311L,323L,373L,389L,423L,433L,447L,451L,467L,481L,539L,549L,581L,583L,591L,607L,621L,623L,637L,643L,657L,659L,663L,669L,673L,677L,691L,693L,699L,753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032694Inst : IEnumerable<long>
{
public static readonly long[] Value=A032694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032694.Bytes);
public long this[int i]=>Value[i];

public static A032694Inst Instance=new A032694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032695
{
public static readonly long[] Value={ 1L,7L,9L,39L,63L,77L,83L,221L,229L,237L,521L,547L,689L,719L,733L,741L,803L,861L,907L,1283L,1647L,2003L,2051L,2073L,2467L,2727L,3003L,3063L,3331L,3487L,3597L,3609L,3629L,3719L,3773L,3857L,3997L,4421L,4449L,4499L,4747L,4919L,5083L,5439L,5541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032695Inst : IEnumerable<long>
{
public static readonly long[] Value=A032695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032695.Bytes);
public long this[int i]=>Value[i];

public static A032695Inst Instance=new A032695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032696
{
public static readonly long[] Value={ 3L,57L,297L,2189L,25697L,76721L,123747L,124443L,132653L,218207L,244099L,261023L,267787L,297059L,304389L,346623L,366989L,411971L,462751L,551057L,596897L,643181L,647193L,665967L,671573L,688143L,701207L,742197L,748563L,867003L,872313L,877331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032696Inst : IEnumerable<long>
{
public static readonly long[] Value=A032696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032696.Bytes);
public long this[int i]=>Value[i];

public static A032696Inst Instance=new A032696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032697
{
public static readonly long[] Value={ 13L,25L,43L,49L,53L,71L,103L,113L,125L,137L,141L,145L,149L,155L,157L,159L,165L,193L,199L,219L,239L,255L,267L,275L,287L,295L,297L,307L,313L,317L,333L,347L,349L,381L,383L,407L,417L,423L,429L,431L,437L,453L,457L,497L,499L,509L,511L,521L,537L,541L,555L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032697Inst : IEnumerable<long>
{
public static readonly long[] Value=A032697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032697.Bytes);
public long this[int i]=>Value[i];

public static A032697Inst Instance=new A032697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032698
{
public static readonly long[] Value={ 17L,45L,55L,57L,63L,69L,75L,81L,87L,99L,101L,105L,109L,117L,129L,131L,133L,135L,147L,153L,161L,167L,169L,171L,177L,181L,187L,189L,197L,201L,203L,207L,209L,213L,215L,217L,221L,227L,243L,245L,259L,261L,269L,271L,273L,279L,281L,289L,291L,293L,303L,309L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032698Inst : IEnumerable<long>
{
public static readonly long[] Value=A032698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032698.Bytes);
public long this[int i]=>Value[i];

public static A032698Inst Instance=new A032698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032699
{
public static readonly long[] Value={ 1L,5L,7L,11L,15L,21L,23L,33L,37L,39L,51L,59L,61L,67L,73L,77L,79L,89L,91L,95L,97L,107L,111L,115L,121L,127L,139L,151L,163L,175L,179L,183L,191L,195L,223L,229L,231L,235L,237L,251L,257L,263L,277L,283L,285L,299L,301L,325L,331L,335L,355L,363L,365L,377L,395L,399L,403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032699Inst : IEnumerable<long>
{
public static readonly long[] Value=A032699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032699.Bytes);
public long this[int i]=>Value[i];

public static A032699Inst Instance=new A032699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032700
{
public static readonly long[] Value={ 9L,29L,35L,83L,85L,93L,123L,173L,211L,233L,249L,339L,379L,419L,427L,471L,473L,487L,501L,551L,575L,587L,621L,625L,675L,687L,763L,773L,787L,801L,809L,841L,915L,951L,999L,1039L,1055L,1073L,1157L,1169L,1189L,1191L,1207L,1239L,1341L,1405L,1425L,1529L,1617L,1721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032700Inst : IEnumerable<long>
{
public static readonly long[] Value=A032700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032700.Bytes);
public long this[int i]=>Value[i];

public static A032700Inst Instance=new A032700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032701
{
public static readonly long[] Value={ 19L,27L,31L,41L,253L,409L,567L,663L,827L,833L,977L,1089L,1421L,1475L,2635L,3021L,3419L,3633L,3781L,3953L,4197L,4293L,4423L,4721L,5255L,5671L,6187L,6469L,8187L,8467L,8661L,8837L,8989L,9615L,9921L,10477L,13569L,15055L,16037L,17637L,23597L,24693L,25273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032701Inst : IEnumerable<long>
{
public static readonly long[] Value=A032701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032701.Bytes);
public long this[int i]=>Value[i];

public static A032701Inst Instance=new A032701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032702
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,11L,13L,14L,16L,22L,25L,28L,31L,34L,35L,37L,38L,41L,44L,52L,53L,55L,59L,62L,67L,71L,73L,74L,79L,80L,85L,86L,97L,100L,101L,103L,106L,110L,112L,119L,121L,122L,134L,139L,140L,148L,149L,152L,160L,161L,166L,170L,175L,182L,184L,185L,187L,188L,191L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032702Inst : IEnumerable<long>
{
public static readonly long[] Value=A032702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032702.Bytes);
public long this[int i]=>Value[i];

public static A032702Inst Instance=new A032702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032703
{
public static readonly long[] Value={ 1L,3L,12L,18L,19L,22L,25L,27L,30L,33L,36L,37L,39L,46L,49L,51L,54L,57L,58L,63L,67L,69L,70L,76L,82L,85L,88L,91L,93L,105L,108L,109L,112L,115L,118L,123L,127L,132L,139L,148L,151L,153L,154L,160L,172L,174L,175L,177L,189L,198L,199L,205L,214L,219L,225L,226L,232L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032703Inst : IEnumerable<long>
{
public static readonly long[] Value=A032703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032703.Bytes);
public long this[int i]=>Value[i];

public static A032703Inst Instance=new A032703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032704
{
public static readonly long[] Value={ 0L,2L,3L,6L,9L,11L,20L,21L,23L,24L,26L,27L,39L,42L,44L,45L,48L,56L,59L,62L,65L,69L,72L,75L,80L,83L,86L,87L,93L,95L,101L,105L,108L,113L,114L,116L,120L,122L,123L,128L,134L,135L,138L,141L,149L,152L,161L,162L,164L,165L,168L,176L,177L,180L,185L,191L,194L,198L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032704Inst : IEnumerable<long>
{
public static readonly long[] Value=A032704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032704.Bytes);
public long this[int i]=>Value[i];

public static A032704Inst Instance=new A032704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032705
{
public static readonly long[] Value={ 2L,4L,7L,10L,17L,23L,26L,28L,35L,38L,43L,44L,47L,50L,52L,53L,58L,59L,64L,65L,70L,71L,74L,79L,80L,82L,85L,86L,88L,98L,100L,103L,106L,107L,113L,115L,124L,134L,136L,142L,143L,146L,148L,151L,152L,155L,158L,163L,169L,172L,187L,194L,197L,199L,202L,205L,208L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032705Inst : IEnumerable<long>
{
public static readonly long[] Value=A032705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032705.Bytes);
public long this[int i]=>Value[i];

public static A032705Inst Instance=new A032705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032706
{
public static readonly long[] Value={ 0L,3L,4L,6L,9L,10L,12L,13L,15L,21L,22L,27L,30L,31L,36L,42L,45L,48L,49L,52L,55L,57L,58L,66L,69L,70L,76L,78L,79L,84L,87L,91L,96L,97L,99L,100L,103L,105L,109L,112L,114L,115L,121L,123L,126L,129L,133L,138L,144L,147L,151L,156L,163L,165L,168L,175L,178L,186L,187L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032706Inst : IEnumerable<long>
{
public static readonly long[] Value=A032706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032706.Bytes);
public long this[int i]=>Value[i];

public static A032706Inst Instance=new A032706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032707
{
public static readonly long[] Value={ 0L,5L,6L,12L,15L,21L,32L,33L,35L,41L,45L,48L,54L,56L,59L,62L,68L,69L,74L,84L,90L,95L,101L,108L,116L,117L,119L,126L,134L,141L,147L,155L,167L,171L,174L,176L,182L,186L,188L,194L,197L,203L,209L,210L,216L,221L,222L,225L,227L,234L,242L,243L,246L,248L,255L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032707Inst : IEnumerable<long>
{
public static readonly long[] Value=A032707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032707.Bytes);
public long this[int i]=>Value[i];

public static A032707Inst Instance=new A032707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032708
{
public static readonly long[] Value={ 1L,2L,8L,10L,11L,16L,17L,19L,22L,23L,29L,31L,43L,46L,50L,52L,58L,64L,68L,73L,74L,76L,82L,83L,86L,94L,95L,97L,100L,103L,104L,107L,110L,113L,118L,128L,133L,137L,140L,142L,155L,161L,167L,170L,176L,190L,193L,197L,202L,203L,205L,214L,217L,223L,224L,226L,230L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032708Inst : IEnumerable<long>
{
public static readonly long[] Value=A032708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032708.Bytes);
public long this[int i]=>Value[i];

public static A032708Inst Instance=new A032708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032709
{
public static readonly long[] Value={ 1L,4L,7L,9L,15L,16L,18L,22L,24L,28L,31L,34L,37L,39L,42L,43L,46L,49L,51L,52L,55L,60L,63L,66L,72L,78L,79L,81L,85L,87L,90L,93L,94L,108L,112L,114L,115L,129L,133L,138L,141L,154L,157L,159L,162L,163L,169L,171L,177L,178L,180L,181L,184L,192L,195L,196L,204L,205L,211L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032709Inst : IEnumerable<long>
{
public static readonly long[] Value=A032709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032709.Bytes);
public long this[int i]=>Value[i];

public static A032709Inst Instance=new A032709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032710
{
public static readonly long[] Value={ 0L,1L,6L,7L,9L,10L,12L,15L,16L,19L,21L,22L,28L,30L,37L,42L,43L,45L,48L,49L,52L,54L,55L,58L,61L,66L,69L,72L,73L,75L,78L,82L,87L,91L,93L,97L,99L,100L,108L,109L,111L,117L,121L,124L,127L,135L,138L,139L,142L,144L,148L,150L,159L,163L,174L,178L,181L,183L,186L,190L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032710Inst : IEnumerable<long>
{
public static readonly long[] Value=A032710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032710.Bytes);
public long this[int i]=>Value[i];

public static A032710Inst Instance=new A032710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032711
{
public static readonly long[] Value={ 2L,3L,6L,8L,9L,11L,14L,15L,20L,21L,24L,27L,29L,33L,38L,39L,42L,47L,50L,54L,59L,63L,66L,68L,69L,71L,75L,80L,83L,84L,90L,95L,96L,101L,102L,114L,116L,119L,128L,131L,132L,138L,143L,149L,150L,152L,156L,161L,167L,168L,171L,177L,180L,186L,189L,194L,200L,201L,206L,207L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032711Inst : IEnumerable<long>
{
public static readonly long[] Value=A032711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032711.Bytes);
public long this[int i]=>Value[i];

public static A032711Inst Instance=new A032711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032712
{
public static readonly long[] Value={ 3L,4L,6L,13L,15L,24L,25L,27L,28L,36L,37L,42L,46L,48L,49L,51L,52L,58L,60L,64L,66L,67L,70L,72L,73L,78L,79L,81L,90L,93L,94L,97L,99L,102L,111L,114L,118L,120L,121L,123L,124L,126L,133L,141L,144L,145L,151L,154L,159L,160L,181L,184L,186L,189L,190L,195L,198L,201L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032712Inst : IEnumerable<long>
{
public static readonly long[] Value=A032712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032712.Bytes);
public long this[int i]=>Value[i];

public static A032712Inst Instance=new A032712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032713
{
public static readonly long[] Value={ 0L,2L,6L,9L,11L,15L,23L,27L,30L,32L,33L,39L,41L,44L,48L,50L,56L,57L,62L,65L,68L,69L,74L,78L,81L,84L,90L,92L,95L,104L,113L,119L,120L,126L,128L,134L,138L,141L,147L,150L,156L,159L,161L,167L,168L,171L,180L,185L,189L,191L,197L,210L,215L,216L,218L,222L,225L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032713Inst : IEnumerable<long>
{
public static readonly long[] Value=A032713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032713.Bytes);
public long this[int i]=>Value[i];

public static A032713Inst Instance=new A032713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032714
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,11L,13L,14L,16L,17L,20L,26L,32L,34L,35L,37L,47L,55L,56L,65L,67L,70L,73L,76L,79L,80L,82L,83L,86L,88L,98L,104L,115L,122L,125L,128L,133L,134L,136L,140L,146L,148L,149L,154L,155L,158L,160L,161L,164L,167L,170L,172L,181L,184L,193L,200L,205L,214L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032714Inst : IEnumerable<long>
{
public static readonly long[] Value=A032714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032714.Bytes);
public long this[int i]=>Value[i];

public static A032714Inst Instance=new A032714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032715
{
public static readonly long[] Value={ 3L,4L,7L,10L,19L,21L,24L,25L,28L,33L,39L,43L,52L,57L,58L,60L,64L,67L,70L,72L,75L,79L,82L,85L,87L,88L,93L,96L,99L,102L,114L,115L,123L,126L,129L,133L,135L,136L,141L,144L,145L,147L,148L,150L,156L,159L,163L,166L,169L,171L,184L,193L,196L,198L,199L,204L,205L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032715Inst : IEnumerable<long>
{
public static readonly long[] Value=A032715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032715.Bytes);
public long this[int i]=>Value[i];

public static A032715Inst Instance=new A032715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032716
{
public static readonly long[] Value={ 2L,5L,6L,8L,12L,23L,24L,26L,27L,29L,35L,36L,42L,44L,51L,54L,56L,57L,62L,66L,69L,71L,75L,78L,80L,86L,89L,92L,93L,96L,101L,102L,104L,108L,116L,117L,120L,122L,123L,128L,129L,134L,135L,137L,146L,153L,155L,156L,170L,177L,185L,188L,194L,195L,197L,200L,201L,207L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032716Inst : IEnumerable<long>
{
public static readonly long[] Value=A032716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032716.Bytes);
public long this[int i]=>Value[i];

public static A032716Inst Instance=new A032716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032765
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,11L,16L,21L,26L,33L,40L,47L,56L,65L,74L,85L,96L,107L,120L,133L,146L,161L,176L,191L,208L,225L,242L,261L,280L,299L,320L,341L,362L,385L,408L,431L,456L,481L,506L,533L,560L,587L,616L,645L,674L,705L,736L,767L,800L,833L,866L,901L,936L,971L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032765Inst : IEnumerable<long>
{
public static readonly long[] Value=A032765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032765.Bytes);
public long this[int i]=>Value[i];

public static A032765Inst Instance=new A032765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032766
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,9L,10L,12L,13L,15L,16L,18L,19L,21L,22L,24L,25L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,57L,58L,60L,61L,63L,64L,66L,67L,69L,70L,72L,73L,75L,76L,78L,79L,81L,82L,84L,85L,87L,88L,90L,91L,93L,94L,96L,97L,99L,100L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032766Inst : IEnumerable<long>
{
public static readonly long[] Value=A032766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032766.Bytes);
public long this[int i]=>Value[i];

public static A032766Inst Instance=new A032766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A032767
{
public static readonly long[] Value={ 0L,2L,8L,20L,38L,64L,100L,148L,208L,282L,373L,480L,606L,753L,921L,1112L,1328L,1571L,1841L,2140L,2471L,2833L,3229L,3661L,4129L,4635L,5182L,5769L,6399L,7074L,7794L,8561L,9377L,10244L,11162L,12133L,13160L,14242L,15382L,16582L,17842L,19164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A032767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A032767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A032767Inst : IEnumerable<long>
{
public static readonly long[] Value=A032767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A032767.Bytes);
public long this[int i]=>Value[i];

public static A032767Inst Instance=new A032767Inst();

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