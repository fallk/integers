using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A085712
{
public static readonly long[] Value={ 6L,10L,22L,38L,58L,118L,122L,142L,158L,202L,262L,278L,362L,398L,542L,698L,758L,818L,898L,922L,1042L,1138L,1142L,1262L,1282L,1322L,1478L,1502L,1642L,1762L,1858L,1982L,2062L,2078L,2102L,2138L,2182L,2258L,2302L,2342L,2362L,2722L,2878L,2918L,2978L,2998L,3062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085712Inst : IEnumerable<long>
{
public static readonly long[] Value=A085712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085712.Bytes);
public long this[int i]=>Value[i];

public static A085712Inst Instance=new A085712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085711
{
public static readonly long[] Value={ 4L,8L,9L,14L,20L,21L,24L,25L,26L,27L,30L,32L,33L,36L,38L,44L,46L,49L,57L,62L,68L,69L,70L,74L,84L,85L,93L,94L,100L,102L,105L,106L,112L,116L,120L,121L,124L,125L,126L,128L,129L,133L,134L,135L,144L,145L,150L,152L,160L,162L,166L,169L,171L,174L,177L,178L,180L,182L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085711Inst : IEnumerable<long>
{
public static readonly long[] Value=A085711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085711.Bytes);
public long this[int i]=>Value[i];

public static A085711Inst Instance=new A085711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085710
{
public static readonly long[] Value={ 3L,4L,1L,2L,1L,4L,2L,1L,1L,2L,3L,2L,1L,1L,3L,2L,2L,3L,2L,1L,1L,5L,4L,1L,1L,7L,2L,2L,5L,3L,3L,1L,1L,1L,3L,4L,1L,1L,3L,3L,5L,2L,2L,3L,1L,2L,2L,1L,6L,1L,4L,4L,4L,1L,2L,1L,1L,5L,2L,2L,1L,3L,4L,1L,5L,2L,3L,1L,5L,2L,2L,2L,1L,5L,3L,1L,2L,3L,2L,2L,1L,3L,10L,1L,1L,1L,3L,2L,5L,1L,2L,1L,1L,1L,4L,3L,6L,3L,3L,2L,2L,2L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085710Inst : IEnumerable<long>
{
public static readonly long[] Value=A085710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085710.Bytes);
public long this[int i]=>Value[i];

public static A085710Inst Instance=new A085710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085709
{
public static readonly long[] Value={ 1L,3L,6L,3L,12L,10L,12L,14L,8L,18L,20L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085709Inst : IEnumerable<long>
{
public static readonly long[] Value=A085709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085709.Bytes);
public long this[int i]=>Value[i];

public static A085709Inst Instance=new A085709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085708
{
public static readonly long[] Value={ 0L,7L,140L,2100L,28000L,350000L,4200000L,49000000L,560000000L,6300000000L,70000000000L,770000000000L,8400000000000L,91000000000000L,980000000000000L,10500000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085708Inst : IEnumerable<long>
{
public static readonly long[] Value=A085708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085708.Bytes);
public long this[int i]=>Value[i];

public static A085708Inst Instance=new A085708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085707
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,3L,3L,0L,1L,6L,17L,17L,0L,1L,10L,55L,155L,155L,0L,1L,15L,135L,736L,2073L,2073L,0L,1L,21L,280L,2492L,13573L,38227L,38227L,0L,1L,28L,518L,6818L,60605L,330058L,929569L,929569L,0L,1L,36L,882L,16086L,211419L,1879038L,10233219L,28820619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085707Inst : IEnumerable<long>
{
public static readonly long[] Value=A085707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085707.Bytes);
public long this[int i]=>Value[i];

public static A085707Inst Instance=new A085707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085706
{
public static readonly long[] Value={ 5L,870L,1158L,24882L,35238L,37770L,39270L,46002L,47262L,48930L,51810L,55482L,59910L,62430L,65622L,69870L,76458L,85542L,88638L,90942L,91338L,91362L,91830L,93018L,93882L,94362L,95298L,97638L,98070L,99510L,101262L,103602L,112038L,116022L,118230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085706Inst : IEnumerable<long>
{
public static readonly long[] Value=A085706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085706.Bytes);
public long this[int i]=>Value[i];

public static A085706Inst Instance=new A085706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085705
{
public static readonly long[] Value={ 3L,5L,6L,9L,10L,13L,14L,15L,16L,17L,18L,19L,20L,21L,26L,29L,30L,31L,35L,36L,38L,40L,41L,44L,47L,51L,53L,54L,57L,62L,63L,64L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,83L,84L,86L,87L,92L,94L,96L,98L,99L,101L,102L,103L,105L,106L,107L,108L,109L,110L,112L,113L,116L,117L,119L,120L,122L,123L,124L,126L,127L,128L,129L,130L,132L,133L,136L,142L,143L,145L,147L,148L,149L,151L,154L,155L,156L,158L,159L,160L,161L,162L,164L,166L,167L,172L,174L,175L,177L,178L,181L,185L,186L,187L,189L,190L,191L,192L,195L,196L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085705Inst : IEnumerable<long>
{
public static readonly long[] Value=A085705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085705.Bytes);
public long this[int i]=>Value[i];

public static A085705Inst Instance=new A085705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085704
{
public static readonly long[] Value={ 7L,43L,59L,73L,163L,179L,223L,263L,269L,283L,379L,491L,569L,599L,613L,619L,643L,659L,739L,821L,953L,983L,1021L,1109L,1129L,1193L,1229L,1303L,1373L,1483L,1523L,1613L,1669L,1733L,1753L,1759L,1789L,1873L,1913L,1913L,1949L,1999L,2143L,2293L,2383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085704Inst : IEnumerable<long>
{
public static readonly long[] Value=A085704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085704.Bytes);
public long this[int i]=>Value[i];

public static A085704Inst Instance=new A085704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085703
{
public static readonly long[] Value={ 4L,21L,39L,49L,93L,161L,183L,201L,411L,543L,1003L,1043L,1387L,1389L,1527L,1589L,2509L,2519L,2559L,2881L,4143L,4613L,4821L,5251L,6821L,7123L,7671L,7679L,8373L,9993L,11463L,13201L,13349L,13647L,14349L,17617L,17753L,18931L,19253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085703Inst : IEnumerable<long>
{
public static readonly long[] Value=A085703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085703.Bytes);
public long this[int i]=>Value[i];

public static A085703Inst Instance=new A085703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085702
{
public static readonly long[] Value={ 4L,27L,30L,70L,84L,286L,308L,440L,528L,594L,646L,728L,884L,945L,1040L,1170L,1248L,1404L,1496L,1748L,1798L,1976L,3125L,3128L,3344L,3526L,3570L,3762L,3808L,4250L,4284L,5100L,5336L,5440L,5445L,5586L,6068L,6120L,6528L,6650L,7198L,7344L,7980L,8084L,8085L,8262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085702Inst : IEnumerable<long>
{
public static readonly long[] Value=A085702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085702.Bytes);
public long this[int i]=>Value[i];

public static A085702Inst Instance=new A085702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085701
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,12L,7L,8L,9L,10L,11L,12L,26L,56L,15L,16L,17L,18L,19L,20L,21L,22L,69L,24L,50L,52L,27L,28L,29L,30L,31L,64L,33L,34L,35L,36L,37L,76L,39L,40L,82L,84L,43L,44L,45L,46L,47L,48L,49L,100L,51L,52L,53L,54L,55L,56L,57L,58L,177L,60L,122L,124L,63L,64L,65L,66L,67L,136L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085701Inst : IEnumerable<long>
{
public static readonly long[] Value=A085701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085701.Bytes);
public long this[int i]=>Value[i];

public static A085701Inst Instance=new A085701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085700
{
public static readonly long[] Value={ 2L,4L,26L,112L,365L,449L,453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085700Inst : IEnumerable<long>
{
public static readonly long[] Value=A085700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085700.Bytes);
public long this[int i]=>Value[i];

public static A085700Inst Instance=new A085700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085683
{
public static readonly long[] Value={ 2L,4L,9L,15L,28L,36L,51L,59L,75L,102L,112L,141L,159L,169L,187L,218L,248L,262L,293L,313L,327L,357L,378L,412L,460L,483L,493L,515L,529L,553L,636L,658L,696L,706L,767L,781L,821L,857L,877L,918L,952L,972L,1032L,1048L,1071L,1085L,1167L,1239L,1266L,1280L,1306L,1342L,1364L,1422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085683Inst : IEnumerable<long>
{
public static readonly long[] Value=A085683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085683.Bytes);
public long this[int i]=>Value[i];

public static A085683Inst Instance=new A085683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085682
{
public static readonly long[] Value={ 2L,3L,7L,43L,79L,463L,1277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085682Inst : IEnumerable<long>
{
public static readonly long[] Value=A085682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085682.Bytes);
public long this[int i]=>Value[i];

public static A085682Inst Instance=new A085682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085681
{
public static readonly long[] Value={ 6L,10L,14L,20L,22L,26L,28L,34L,38L,44L,46L,52L,58L,62L,68L,74L,76L,82L,86L,88L,92L,94L,104L,106L,116L,118L,122L,124L,134L,136L,142L,146L,148L,152L,158L,164L,166L,172L,178L,184L,188L,194L,202L,206L,212L,214L,218L,226L,232L,236L,244L,248L,254L,262L,268L,272L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085681Inst : IEnumerable<long>
{
public static readonly long[] Value=A085681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085681.Bytes);
public long this[int i]=>Value[i];

public static A085681Inst Instance=new A085681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085680
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,7L,9L,11L,13L,15L,17L,20L,23L,26L,29L,32L,36L,40L,44L,48L,52L,57L,62L,67L,72L,77L,83L,89L,95L,101L,107L,114L,121L,128L,135L,142L,150L,158L,166L,174L,182L,191L,200L,209L,218L,227L,237L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085680Inst : IEnumerable<long>
{
public static readonly long[] Value=A085680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085680.Bytes);
public long this[int i]=>Value[i];

public static A085680Inst Instance=new A085680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085679
{
public static readonly long[] Value={ 1L,5L,7L,0L,7L,9L,6L,3L,2L,6L,7L,9L,4L,8L,9L,6L,6L,1L,9L,2L,3L,1L,3L,2L,1L,6L,9L,1L,6L,3L,9L,7L,5L,1L,4L,4L,2L,0L,9L,8L,5L,8L,4L,6L,9L,9L,6L,8L,7L,5L,4L,2L,9L,1L,0L,4L,8L,7L,4L,7L,2L,2L,9L,6L,1L,5L,3L,9L,0L,8L,2L,0L,3L,1L,4L,3L,1L,0L,4L,4L,9L,9L,3L,1L,4L,0L,1L,7L,4L,1L,2L,6L,7L,1L,0L,5L,8L,5L,3L,3L,9L,9L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085679Inst : IEnumerable<long>
{
public static readonly long[] Value=A085679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085679.Bytes);
public long this[int i]=>Value[i];

public static A085679Inst Instance=new A085679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085678
{
public static readonly long[] Value={ 1L,9L,7L,0L,0L,7L,1L,1L,1L,4L,0L,1L,7L,0L,4L,6L,9L,9L,3L,8L,8L,8L,8L,7L,9L,3L,5L,2L,2L,4L,3L,3L,2L,3L,1L,2L,5L,3L,1L,6L,9L,3L,7L,9L,8L,5L,3L,2L,3L,8L,4L,5L,7L,8L,9L,9L,5L,2L,8L,0L,2L,9L,9L,1L,3L,8L,5L,0L,6L,3L,8L,5L,0L,7L,8L,2L,4L,4L,1L,1L,9L,3L,4L,7L,4L,9L,7L,8L,0L,7L,6L,5L,6L,3L,0L,2L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085678Inst : IEnumerable<long>
{
public static readonly long[] Value=A085678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085678.Bytes);
public long this[int i]=>Value[i];

public static A085678Inst Instance=new A085678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085677
{
public static readonly long[] Value={ 6L,1L,3L,5L,2L,8L,6L,0L,8L,2L,3L,3L,6L,6L,3L,5L,6L,2L,2L,6L,4L,8L,5L,2L,9L,5L,1L,3L,0L,3L,7L,6L,2L,8L,0L,0L,1L,0L,7L,1L,9L,0L,4L,3L,9L,7L,0L,5L,3L,1L,8L,1L,8L,5L,2L,3L,0L,7L,8L,2L,1L,7L,4L,4L,7L,4L,5L,7L,3L,3L,8L,8L,7L,0L,1L,1L,9L,8L,9L,5L,3L,8L,7L,8L,5L,6L,0L,2L,6L,5L,2L,6L,0L,1L,7L,7L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085677Inst : IEnumerable<long>
{
public static readonly long[] Value=A085677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085677.Bytes);
public long this[int i]=>Value[i];

public static A085677Inst Instance=new A085677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085676
{
public static readonly long[] Value={ 7L,8L,9L,6L,7L,2L,4L,9L,3L,4L,2L,9L,3L,1L,0L,0L,8L,2L,7L,1L,0L,2L,8L,9L,5L,3L,9L,9L,1L,7L,4L,0L,7L,7L,5L,3L,9L,6L,0L,0L,8L,3L,4L,0L,4L,6L,2L,1L,4L,0L,2L,7L,1L,9L,1L,4L,5L,7L,8L,0L,8L,7L,3L,6L,2L,2L,1L,8L,9L,9L,9L,6L,9L,8L,0L,0L,6L,0L,9L,8L,9L,8L,6L,3L,3L,4L,3L,6L,7L,5L,7L,5L,8L,9L,6L,8L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085676Inst : IEnumerable<long>
{
public static readonly long[] Value=A085676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085676.Bytes);
public long this[int i]=>Value[i];

public static A085676Inst Instance=new A085676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085675
{
public static readonly long[] Value={ 4L,9L,0L,7L,3L,1L,5L,0L,2L,7L,2L,7L,5L,8L,1L,8L,2L,9L,5L,1L,5L,8L,8L,9L,1L,9L,7L,1L,6L,3L,6L,5L,1L,7L,1L,3L,0L,8L,7L,0L,6L,1L,8L,3L,7L,2L,6L,6L,2L,6L,5L,1L,8L,8L,3L,6L,4L,8L,0L,7L,5L,1L,3L,7L,3L,9L,1L,0L,7L,9L,9L,4L,7L,6L,6L,8L,9L,6L,7L,6L,0L,9L,5L,2L,1L,3L,8L,1L,4L,4L,6L,1L,0L,0L,2L,2L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085675Inst : IEnumerable<long>
{
public static readonly long[] Value=A085675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085675.Bytes);
public long this[int i]=>Value[i];

public static A085675Inst Instance=new A085675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085674
{
public static readonly long[] Value={ 4L,7L,5L,6L,3L,5L,3L,8L,9L,5L,3L,7L,9L,8L,9L,7L,0L,8L,7L,5L,5L,3L,5L,9L,4L,9L,5L,3L,1L,9L,7L,3L,7L,1L,2L,2L,3L,2L,7L,1L,4L,4L,8L,8L,4L,3L,1L,3L,3L,3L,1L,0L,7L,2L,2L,7L,6L,4L,6L,5L,2L,4L,4L,4L,6L,4L,5L,5L,2L,6L,3L,1L,9L,8L,2L,9L,0L,2L,9L,6L,1L,8L,9L,1L,3L,8L,8L,1L,7L,2L,0L,6L,2L,3L,3L,1L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085674Inst : IEnumerable<long>
{
public static readonly long[] Value=A085674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085674.Bytes);
public long this[int i]=>Value[i];

public static A085674Inst Instance=new A085674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085673
{
public static readonly long[] Value={ 6L,0L,9L,0L,3L,6L,2L,3L,7L,5L,4L,6L,2L,0L,0L,2L,9L,3L,6L,7L,1L,5L,4L,7L,6L,6L,6L,9L,5L,0L,6L,9L,2L,8L,2L,8L,3L,5L,0L,4L,0L,4L,9L,2L,6L,7L,1L,9L,0L,8L,9L,7L,5L,0L,9L,1L,1L,1L,0L,6L,8L,3L,2L,2L,4L,3L,8L,6L,6L,5L,6L,5L,3L,8L,3L,7L,3L,6L,7L,7L,0L,4L,4L,5L,6L,0L,7L,9L,1L,2L,5L,0L,0L,1L,7L,7L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085673Inst : IEnumerable<long>
{
public static readonly long[] Value=A085673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085673.Bytes);
public long this[int i]=>Value[i];

public static A085673Inst Instance=new A085673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085672
{
public static readonly long[] Value={ 8L,3L,8L,6L,5L,8L,5L,1L,4L,5L,5L,7L,5L,4L,9L,5L,5L,4L,3L,4L,2L,0L,6L,9L,1L,6L,1L,1L,1L,1L,8L,8L,7L,2L,7L,6L,6L,5L,6L,4L,9L,4L,7L,2L,0L,4L,8L,1L,2L,9L,7L,2L,5L,8L,7L,6L,3L,4L,7L,5L,3L,8L,4L,6L,6L,9L,1L,5L,7L,3L,4L,0L,6L,9L,9L,7L,1L,0L,3L,3L,2L,4L,5L,3L,9L,5L,0L,4L,0L,1L,5L,5L,7L,5L,6L,3L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085672Inst : IEnumerable<long>
{
public static readonly long[] Value=A085672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085672.Bytes);
public long this[int i]=>Value[i];

public static A085672Inst Instance=new A085672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085671
{
public static readonly long[] Value={ 1L,3L,1L,3L,2L,6L,1L,6L,8L,7L,5L,1L,8L,2L,2L,2L,8L,3L,4L,0L,4L,8L,9L,9L,5L,4L,9L,4L,9L,6L,7L,8L,5L,5L,6L,4L,1L,9L,1L,5L,2L,8L,0L,0L,8L,5L,6L,7L,0L,3L,4L,8L,3L,7L,4L,7L,1L,9L,0L,6L,3L,5L,1L,4L,8L,3L,7L,1L,9L,4L,9L,0L,1L,5L,0L,9L,1L,8L,7L,2L,2L,0L,9L,3L,6L,2L,0L,0L,4L,0L,6L,2L,7L,7L,2L,9L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085671Inst : IEnumerable<long>
{
public static readonly long[] Value=A085671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085671.Bytes);
public long this[int i]=>Value[i];

public static A085671Inst Instance=new A085671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085670
{
public static readonly long[] Value={ 6L,3L,3L,5L,1L,0L,7L,0L,0L,5L,5L,2L,1L,9L,6L,1L,9L,3L,1L,8L,5L,3L,2L,1L,5L,6L,9L,8L,8L,0L,3L,3L,2L,1L,6L,1L,4L,2L,7L,4L,0L,3L,4L,3L,2L,4L,1L,3L,2L,7L,2L,9L,4L,7L,7L,9L,8L,0L,4L,0L,9L,9L,4L,7L,9L,7L,1L,6L,1L,4L,0L,4L,5L,3L,1L,0L,6L,3L,0L,8L,1L,8L,9L,6L,3L,2L,2L,3L,8L,9L,4L,9L,3L,6L,0L,9L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085670Inst : IEnumerable<long>
{
public static readonly long[] Value=A085670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085670.Bytes);
public long this[int i]=>Value[i];

public static A085670Inst Instance=new A085670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085669
{
public static readonly long[] Value={ 8L,8L,4L,2L,1L,3L,8L,9L,2L,1L,0L,6L,6L,3L,5L,4L,7L,7L,0L,4L,2L,5L,3L,9L,2L,7L,7L,4L,0L,6L,7L,6L,4L,5L,0L,6L,4L,7L,8L,5L,1L,3L,2L,2L,6L,8L,3L,6L,2L,4L,6L,6L,5L,3L,0L,9L,7L,4L,9L,5L,7L,1L,6L,2L,5L,6L,2L,1L,3L,0L,7L,0L,7L,9L,8L,0L,3L,0L,8L,8L,3L,2L,1L,9L,0L,5L,3L,2L,2L,6L,2L,7L,0L,1L,7L,8L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085669Inst : IEnumerable<long>
{
public static readonly long[] Value=A085669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085669.Bytes);
public long this[int i]=>Value[i];

public static A085669Inst Instance=new A085669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085668
{
public static readonly long[] Value={ 1L,4L,2L,1L,0L,8L,0L,4L,1L,2L,7L,9L,4L,2L,9L,2L,6L,3L,3L,0L,5L,3L,7L,7L,2L,1L,9L,6L,3L,3L,3L,7L,1L,9L,4L,5L,8L,9L,8L,5L,7L,5L,8L,6L,8L,1L,6L,7L,8L,9L,4L,3L,7L,1L,4L,4L,0L,7L,9L,2L,5L,2L,4L,2L,2L,5L,3L,5L,9L,4L,0L,4L,4L,5L,9L,8L,3L,0L,5L,5L,6L,3L,7L,5L,5L,0L,6L,2L,3L,1L,3L,5L,7L,2L,1L,3L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085668Inst : IEnumerable<long>
{
public static readonly long[] Value=A085668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085668.Bytes);
public long this[int i]=>Value[i];

public static A085668Inst Instance=new A085668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085635
{
public static readonly long[] Value={ 2L,3L,4L,8L,12L,16L,32L,48L,80L,96L,112L,144L,240L,288L,336L,480L,560L,576L,720L,1008L,1440L,1680L,2016L,2640L,2880L,3600L,4032L,5040L,7920L,9360L,10080L,15840L,18480L,20160L,25200L,31680L,37440L,39600L,44352L,50400L,55440L,65520L,85680L,95760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085635Inst : IEnumerable<long>
{
public static readonly long[] Value=A085635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085635.Bytes);
public long this[int i]=>Value[i];

public static A085635Inst Instance=new A085635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085634
{
public static readonly long[] Value={ 5L,11L,17L,35L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085634Inst : IEnumerable<long>
{
public static readonly long[] Value=A085634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085634.Bytes);
public long this[int i]=>Value[i];

public static A085634Inst Instance=new A085634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085633
{
public static readonly long[] Value={ 1L,2L,4L,10L,25L,80L,267L,1078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085633Inst : IEnumerable<long>
{
public static readonly long[] Value=A085633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085633.Bytes);
public long this[int i]=>Value[i];

public static A085633Inst Instance=new A085633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085632
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,46L,162L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085632Inst : IEnumerable<long>
{
public static readonly long[] Value=A085632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085632.Bytes);
public long this[int i]=>Value[i];

public static A085632Inst Instance=new A085632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085631
{
public static readonly long[] Value={ 1L,4L,8L,252L,2112L,4224L,8448L,29592L,6547456L,27011072L,291080192L,276444444672L,2789387839872L,6399369639936L,631367020763136L,2306938998396032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085631Inst : IEnumerable<long>
{
public static readonly long[] Value=A085631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085631.Bytes);
public long this[int i]=>Value[i];

public static A085631Inst Instance=new A085631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085630
{
public static readonly long[] Value={ 0L,9L,36L,95L,197L,356L,579L,882L,1272L,1767L,2381L,3113L,3984L,5002L,6187L,7545L,9081L,10815L,12759L,14927L,17323L,19960L,22853L,26015L,29458L,33188L,37222L,41568L,46245L,51254L,56618L,62338L,68437L,74917L,81793L,89083L,96786L,104926L,113511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085630Inst : IEnumerable<long>
{
public static readonly long[] Value=A085630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085630.Bytes);
public long this[int i]=>Value[i];

public static A085630Inst Instance=new A085630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085629
{
public static readonly long[] Value={ 1L,4L,8L,16L,32L,64L,128L,144L,216L,288L,2048L,432L,8192L,1152L,864L,1296L,131072L,1728L,524288L,2592L,3456L,18432L,8388608L,5184L,7776L,73728L,13824L,10368L,536870912L,15552L,2147483648L,20736L,55296L,1179648L,31104L,41472L,137438953472L,4718592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085629Inst : IEnumerable<long>
{
public static readonly long[] Value=A085629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085629.Bytes);
public long this[int i]=>Value[i];

public static A085629Inst Instance=new A085629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085628
{
public static readonly BigInteger[] Value={ 1L,2L,12L,152L,3504L,135392L,8321472L,784621952L,110521185024L,22789653765632L,6769730814753792L,2859584874712881152L,BigInteger.Parse("1699286839524775931904"),BigInteger.Parse("1407801166901961190203392"),BigInteger.Parse("1613567168628788544015286272"),BigInteger.Parse("2541721059997800475952740401152"),BigInteger.Parse("5470980000021882982488097199161344") };
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
public class A085628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085628Inst Instance=new A085628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085627
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,15L,16L,18L,20L,24L,25L,28L,30L,32L,35L,36L,40L,42L,45L,48L,50L,54L,96L,96L,105L,108L,112L,120L,120L,128L,135L,140L,144L,160L,168L,180L,192L,200L,200L,216L,224L,225L,240L,240L,252L,264L,270L,280L,280L,300L,315L,330L,576L,560L,360L,600L,576L,648L,640L,675L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085627Inst : IEnumerable<long>
{
public static readonly long[] Value=A085627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085627.Bytes);
public long this[int i]=>Value[i];

public static A085627Inst Instance=new A085627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085626
{
public static readonly long[] Value={ 2L,5L,11L,19L,29L,41L,59L,79L,101L,127L,157L,191L,227L,269L,313L,359L,409L,461L,521L,587L,659L,733L,809L,887L,967L,1049L,1151L,1259L,1373L,1489L,1607L,1733L,1861L,1993L,2129L,2267L,2411L,2557L,2707L,2861L,3019L,3181L,3347L,3517L,3691L,3877L,4073L,4271L,4481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085626Inst : IEnumerable<long>
{
public static readonly long[] Value=A085626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085626.Bytes);
public long this[int i]=>Value[i];

public static A085626Inst Instance=new A085626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085625
{
public static readonly long[] Value={ 25L,50L,65L,85L,100L,125L,130L,145L,169L,170L,185L,200L,205L,221L,225L,250L,260L,265L,289L,290L,305L,338L,340L,365L,370L,377L,400L,410L,442L,445L,450L,481L,485L,493L,500L,505L,520L,530L,533L,545L,565L,578L,580L,585L,610L,629L,676L,680L,685L,689L,697L,730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085625Inst : IEnumerable<long>
{
public static readonly long[] Value=A085625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085625.Bytes);
public long this[int i]=>Value[i];

public static A085625Inst Instance=new A085625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085624
{
public static readonly long[] Value={ 2L,4L,5L,8L,8L,10L,11L,14L,14L,16L,17L,20L,20L,22L,23L,26L,26L,28L,29L,32L,32L,34L,35L,38L,38L,40L,41L,44L,44L,46L,47L,50L,50L,52L,53L,56L,56L,58L,59L,62L,62L,64L,65L,68L,68L,70L,71L,74L,74L,76L,77L,80L,80L,82L,83L,86L,86L,88L,89L,92L,92L,94L,95L,98L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085624Inst : IEnumerable<long>
{
public static readonly long[] Value=A085624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085624.Bytes);
public long this[int i]=>Value[i];

public static A085624Inst Instance=new A085624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085623
{
public static readonly long[] Value={ 0L,2L,0L,4L,6L,10L,4L,12L,18L,4L,14L,18L,20L,16L,30L,32L,30L,20L,28L,34L,32L,40L,46L,54L,46L,48L,64L,62L,66L,40L,68L,66L,72L,90L,68L,70L,84L,92L,90L,100L,90L,80L,98L,102L,88L,88L,108L,108L,106L,126L,116L,126L,112L,134L,136L,150L,116L,142L,146L,144L,146L,136L,156L,158L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085623Inst : IEnumerable<long>
{
public static readonly long[] Value=A085623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085623.Bytes);
public long this[int i]=>Value[i];

public static A085623Inst Instance=new A085623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085622
{
public static readonly long[] Value={ 1L,4L,12L,28L,56L,88L,132L,180L,240L,304L,380L,460L,552L,648L,756L,868L,992L,1120L,1260L,1404L,1560L,1720L,1892L,2068L,2256L,2448L,2652L,2860L,3080L,3304L,3540L,3780L,4032L,4288L,4556L,4828L,5112L,5400L,5700L,6004L,6320L,6640L,6972L,7308L,7656L,8008L,8372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085622Inst : IEnumerable<long>
{
public static readonly long[] Value=A085622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085622.Bytes);
public long this[int i]=>Value[i];

public static A085622Inst Instance=new A085622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085621
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,11L,13L,15L,16L,17L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085621Inst : IEnumerable<long>
{
public static readonly long[] Value=A085621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085621.Bytes);
public long this[int i]=>Value[i];

public static A085621Inst Instance=new A085621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085620
{
public static readonly long[] Value={ 2L,2L,4L,8L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085620Inst : IEnumerable<long>
{
public static readonly long[] Value=A085620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085620.Bytes);
public long this[int i]=>Value[i];

public static A085620Inst Instance=new A085620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085539
{
public static readonly long[] Value={ 0L,0L,32L,486L,3072L,12500L,38880L,100842L,229376L,472392L,900000L,1610510L,2737152L,4455516L,6991712L,10631250L,15728640L,22717712L,32122656L,44569782L,60800000L,81682020L,108226272L,141599546L,183140352L,234375000L,297034400L,373071582L,464679936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085539Inst : IEnumerable<long>
{
public static readonly long[] Value=A085539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085539.Bytes);
public long this[int i]=>Value[i];

public static A085539Inst Instance=new A085539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085538
{
public static readonly long[] Value={ 0L,0L,16L,162L,768L,2500L,6480L,14406L,28672L,52488L,90000L,146410L,228096L,342732L,499408L,708750L,983040L,1336336L,1784592L,2345778L,3040000L,3889620L,4919376L,6156502L,7630848L,9375000L,11424400L,13817466L,16595712L,19803868L,23490000L,27705630L,32505856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085538Inst : IEnumerable<long>
{
public static readonly long[] Value=A085538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085538.Bytes);
public long this[int i]=>Value[i];

public static A085538Inst Instance=new A085538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085537
{
public static readonly long[] Value={ 0L,0L,8L,54L,192L,500L,1080L,2058L,3584L,5832L,9000L,13310L,19008L,26364L,35672L,47250L,61440L,78608L,99144L,123462L,152000L,185220L,223608L,267674L,317952L,375000L,439400L,511758L,592704L,682892L,783000L,893730L,1015808L,1149984L,1297032L,1457750L,1632960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085537Inst : IEnumerable<long>
{
public static readonly long[] Value=A085537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085537.Bytes);
public long this[int i]=>Value[i];

public static A085537Inst Instance=new A085537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085536
{
public static readonly BigInteger[] Value={ 1L,27L,46656L,387420489L,8916100448256L,437893890380859375L,BigInteger.Parse("39346408075296537575424"),BigInteger.Parse("5842587018385982521381124421"),BigInteger.Parse("1333735776850284124449081472843776"),BigInteger.Parse("443426488243037769948249630619149892803"),BigInteger.Parse("205891132094649000000000000000000000000000000"),BigInteger.Parse("129110040087761027839616029934664535539337183380513") };
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
public class A085536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085536Inst Instance=new A085536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085535
{
public static readonly BigInteger[] Value={ 2L,64L,7776L,2097152L,1000000000L,743008370688L,793714773254144L,1152921504606846976L,BigInteger.Parse("2185911559738696531968"),BigInteger.Parse("5242880000000000000000000"),BigInteger.Parse("15519448971100888972574851072"),BigInteger.Parse("55572324035428505185378394701824"),BigInteger.Parse("236773830007967588876795164938469376") };
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
public class A085535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085535Inst Instance=new A085535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085534
{
public static readonly BigInteger[] Value={ 1L,4L,256L,46656L,16777216L,10000000000L,8916100448256L,11112006825558016L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("39346408075296537575424"),BigInteger.Parse("104857600000000000000000000"),BigInteger.Parse("341427877364219557396646723584"),BigInteger.Parse("1333735776850284124449081472843776"),BigInteger.Parse("6156119580207157310796674288400203776") };
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
public class A085534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085534Inst Instance=new A085534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085533
{
public static readonly BigInteger[] Value={ 0L,8L,1024L,279936L,134217728L,100000000000L,106993205379072L,155568095557812224L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("708235345355337676357632"),BigInteger.Parse("2097152000000000000000000000"),BigInteger.Parse("7511413302012830262726227918848"),BigInteger.Parse("32009658644406818986777955348250624"),BigInteger.Parse("160059109085386090080713531498405298176") };
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
public class A085533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085533Inst Instance=new A085533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085532
{
public static readonly BigInteger[] Value={ 0L,4L,64L,1296L,32768L,1000000L,35831808L,1475789056L,68719476736L,3570467226624L,204800000000000L,12855002631049216L,876488338465357824L,BigInteger.Parse("64509974703297150976"),BigInteger.Parse("5097655355238390956032"),BigInteger.Parse("430467210000000000000000"),BigInteger.Parse("38685626227668133590597632") };
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
public class A085532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085532Inst Instance=new A085532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085531
{
public static readonly BigInteger[] Value={ 1L,3L,125L,16807L,4782969L,2357947691L,1792160394037L,1946195068359375L,2862423051509815793L,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("13248496640331026125580781"),BigInteger.Parse("39471584120695485887249589623"),BigInteger.Parse("142108547152020037174224853515625"),BigInteger.Parse("608266787713357709119683992618861307") };
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
public class A085531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085531Inst Instance=new A085531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085530
{
public static readonly BigInteger[] Value={ 1L,9L,625L,117649L,43046721L,25937424601L,23298085122481L,29192926025390625L,BigInteger.Parse("48661191875666868481"),BigInteger.Parse("104127350297911241532841"),BigInteger.Parse("278218429446951548637196401"),BigInteger.Parse("907846434775996175406740561329"),BigInteger.Parse("3552713678800500929355621337890625"),BigInteger.Parse("16423203268260658146231467800709255289") };
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
public class A085530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085530Inst Instance=new A085530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085529
{
public static readonly BigInteger[] Value={ 1L,27L,3125L,823543L,387420489L,285311670611L,302875106592253L,437893890380859375L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("1978419655660313589123979"),BigInteger.Parse("5842587018385982521381124421"),BigInteger.Parse("20880467999847912034355032910567"),BigInteger.Parse("88817841970012523233890533447265625"),BigInteger.Parse("443426488243037769948249630619149892803") };
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
public class A085529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085529Inst Instance=new A085529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085528
{
public static readonly BigInteger[] Value={ 1L,9L,125L,2401L,59049L,1771561L,62748517L,2562890625L,118587876497L,6131066257801L,350277500542221L,21914624432020321L,1490116119384765625L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("8629188747598184440949"),BigInteger.Parse("727423121747185263828481"),BigInteger.Parse("65273511648264442971824673") };
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
public class A085528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085528Inst Instance=new A085528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085527
{
public static readonly BigInteger[] Value={ 1L,3L,25L,343L,6561L,161051L,4826809L,170859375L,6975757441L,322687697779L,16679880978201L,952809757913927L,59604644775390625L,4052555153018976267L,BigInteger.Parse("297558232675799463481"),BigInteger.Parse("23465261991844685929951"),BigInteger.Parse("1977985201462558877934081"),BigInteger.Parse("177482997121587371826171875") };
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
public class A085527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085527Inst Instance=new A085527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085526
{
public static readonly BigInteger[] Value={ 0L,1L,32L,2187L,262144L,48828125L,13060694016L,4747561509943L,2251799813685248L,1350851717672992089L,BigInteger.Parse("1000000000000000000000"),BigInteger.Parse("895430243255237372246531"),BigInteger.Parse("953962166440690129601298432"),BigInteger.Parse("1192533292512492016559195008117"),BigInteger.Parse("1728673739677471101567216945987584"),BigInteger.Parse("2876265888493261300027370452880859375") };
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
public class A085526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085526Inst Instance=new A085526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085525
{
public static readonly BigInteger[] Value={ 0L,1L,64L,6561L,1048576L,244140625L,78364164096L,33232930569601L,18014398509481984L,12157665459056928801UL,BigInteger.Parse("10000000000000000000000"),BigInteger.Parse("9849732675807611094711841"),BigInteger.Parse("11447545997288281555215581184"),BigInteger.Parse("15502932802662396215269535105521"),BigInteger.Parse("24201432355484595421941037243826176") };
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
public class A085525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085525Inst Instance=new A085525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085524
{
public static readonly BigInteger[] Value={ 0L,1L,8L,243L,16384L,1953125L,362797056L,96889010407L,35184372088832L,16677181699666569L,10000000000000000000UL,BigInteger.Parse("7400249944258160101211"),BigInteger.Parse("6624737266949237011120128"),BigInteger.Parse("7056410014866816666030739693"),BigInteger.Parse("8819763977946281130444984418304"),BigInteger.Parse("12783403948858939111232757568359375") };
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
public class A085524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085524Inst Instance=new A085524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085523
{
public static readonly BigInteger[] Value={ 1L,5L,325L,333125L,5458253125L,1430853765453125L,BigInteger.Parse("6001437102708869453125"),BigInteger.Parse("402749632331680654432389453125"),BigInteger.Parse("432449125237897791207428190509189453125"),BigInteger.Parse("7429419400754766057344059513229133345069189453125"),BigInteger.Parse("2042183254696046247075864924725939712088925233082669189453125"),BigInteger.Parse("8981616938352999804189736540441162599045265812868432152715194669189453125") };
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
public class A085523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085523Inst Instance=new A085523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085522
{
public static readonly BigInteger[] Value={ 1L,4L,112L,27328L,59793664L,1176978482176L,208499384160514048L,BigInteger.Parse("332415572152327399063552"),BigInteger.Parse("4769800462581107835042193801216"),BigInteger.Parse("615972813985000129119033854408817639424"),BigInteger.Parse("715921467030297180050077834366890661741232914432"),BigInteger.Parse("7488791411462749472408996555169086045062585935389029040128") };
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
public class A085522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085522Inst Instance=new A085522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085521
{
public static readonly BigInteger[] Value={ 1L,3L,27L,891L,114939L,58963707L,120816635643L,989850695823099L,BigInteger.Parse("32436417451427131131"),BigInteger.Parse("4251538544610908358733563"),BigInteger.Parse("2229034892015508532492061011707"),BigInteger.Parse("4674627210894999765441323226884370171"),BigInteger.Parse("39213619892958693087378972992951269575782139"),BigInteger.Parse("1315790781385749638968020894900792847245520205672187") };
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
public class A085521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085521Inst Instance=new A085521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085520
{
public static readonly long[] Value={ 12L,13L,15L,17L,20L,21L,24L,26L,28L,29L,30L,31L,34L,36L,38L,39L,42L,43L,45L,47L,50L,51L,54L,56L,58L,59L,62L,63L,65L,67L,70L,71L,74L,76L,78L,79L,82L,83L,85L,87L,92L,93L,95L,97L,121L,124L,126L,128L,129L,130L,131L,134L,136L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085520Inst : IEnumerable<long>
{
public static readonly long[] Value=A085520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085520.Bytes);
public long this[int i]=>Value[i];

public static A085520Inst Instance=new A085520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085519
{
public static readonly long[] Value={ 1L,0L,0L,44L,45L,28L,10L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085519Inst : IEnumerable<long>
{
public static readonly long[] Value=A085519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085519.Bytes);
public long this[int i]=>Value[i];

public static A085519Inst Instance=new A085519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085518
{
public static readonly long[] Value={ 1L,0L,0L,45L,41L,34L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085518Inst : IEnumerable<long>
{
public static readonly long[] Value=A085518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085518.Bytes);
public long this[int i]=>Value[i];

public static A085518Inst Instance=new A085518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085517
{
public static readonly long[] Value={ 1L,0L,0L,48L,30L,48L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085517Inst : IEnumerable<long>
{
public static readonly long[] Value=A085517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085517.Bytes);
public long this[int i]=>Value[i];

public static A085517Inst Instance=new A085517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085516
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,11L,13L,15L,14L,16L,18L,20L,17L,22L,19L,21L,25L,23L,24L,27L,26L,28L,29L,30L,31L,32L,35L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085516Inst : IEnumerable<long>
{
public static readonly long[] Value=A085516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085516.Bytes);
public long this[int i]=>Value[i];

public static A085516Inst Instance=new A085516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085515
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,5L,7L,8L,10L,11L,9L,13L,12L,15L,16L,14L,17L,18L,21L,19L,20L,23L,22L,25L,24L,26L,31L,27L,28L,30L,29L,32L,34L,33L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085515Inst : IEnumerable<long>
{
public static readonly long[] Value=A085515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085515.Bytes);
public long this[int i]=>Value[i];

public static A085515Inst Instance=new A085515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085514
{
public static readonly long[] Value={ 1L,9L,10L,11L,14L,15L,18L,26L,29L,30L,31L,34L,35L,37L,38L,42L,43L,44L,48L,52L,53L,54L,55L,57L,59L,62L,63L,64L,67L,69L,70L,71L,73L,74L,75L,76L,82L,84L,85L,86L,90L,92L,93L,94L,95L,96L,98L,100L,101L,102L,103L,105L,106L,108L,111L,112L,116L,117L,122L,125L,126L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085514Inst : IEnumerable<long>
{
public static readonly long[] Value=A085514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085514.Bytes);
public long this[int i]=>Value[i];

public static A085514Inst Instance=new A085514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085513
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,1L,0L,2L,1L,1L,1L,3L,2L,2L,2L,2L,2L,4L,3L,3L,1L,2L,1L,3L,1L,2L,1L,3L,2L,2L,0L,1L,0L,2L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,2L,1L,1L,0L,1L,0L,2L,0L,1L,0L,2L,1L,1L,2L,3L,2L,4L,2L,3L,2L,4L,3L,3L,1L,2L,1L,3L,1L,2L,1L,3L,2L,2L,1L,2L,1L,3L,1L,2L,1L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085513Inst : IEnumerable<long>
{
public static readonly long[] Value=A085513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085513.Bytes);
public long this[int i]=>Value[i];

public static A085513Inst Instance=new A085513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085512
{
public static readonly long[] Value={ 1L,6L,7L,15L,18L,19L,22L,174L,427L,484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085512Inst : IEnumerable<long>
{
public static readonly long[] Value=A085512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085512.Bytes);
public long this[int i]=>Value[i];

public static A085512Inst Instance=new A085512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085511
{
public static readonly BigInteger[] Value={ 0L,-1L,6L,0L,-96L,1856L,-19866L,194701L,-143840L,-12421376L,-2242688L,7161224400L,-182262318208L,4419601227184L,-105598371081024L,1963290383833664L,-34552138617760368L,6240219707831587L,4597964531722783442L,BigInteger.Parse("255030441797039438464"),BigInteger.Parse("-20656928385327220865224") };
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
public class A085511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085511Inst Instance=new A085511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085510
{
public static readonly BigInteger[] Value={ 0L,1L,2L,16L,150L,2757L,56252L,1843637L,71277004L,3592359440L,197924252436L,14915743198773L,1183551535975484L,123024814715081453L,13742505172992983210UL,BigInteger.Parse("1747020721154054373156"),BigInteger.Parse("240574984100927602314902") };
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
public class A085510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085510Inst Instance=new A085510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085509
{
public static readonly long[] Value={ 1L,2L,13L,22L,23L,43L,121L,122L,157L,158L,214L,619L,5471L,5557L,5561L,5791L,5818L,5819L,5821L,5822L,38299L,38357L,38362L,38363L,38366L,58711L,58714L,58966L,58967L,154213L,154214L,154219L,154222L,154223L,154534L,154537L,154538L,154543L,154997L,351742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085509Inst : IEnumerable<long>
{
public static readonly long[] Value=A085509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085509.Bytes);
public long this[int i]=>Value[i];

public static A085509Inst Instance=new A085509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085508
{
public static readonly long[] Value={ 4L,7L,1L,8L,6L,1L,6L,5L,3L,4L,5L,2L,6L,8L,1L,7L,8L,4L,8L,7L,4L,4L,6L,8L,7L,9L,3L,6L,1L,1L,3L,1L,6L,1L,4L,9L,0L,7L,7L,0L,1L,2L,6L,2L,1L,7L,3L,9L,4L,4L,3L,2L,4L,3L,6L,3L,1L,4L,6L,0L,2L,6L,6L,8L,8L,8L,0L,0L,6L,8L,0L,5L,2L,4L,1L,8L,5L,9L,6L,5L,6L,9L,0L,2L,4L,4L,8L,6L,5L,5L,6L,2L,4L,5L,9L,4L,8L,4L,0L,9L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085508Inst : IEnumerable<long>
{
public static readonly long[] Value=A085508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085508.Bytes);
public long this[int i]=>Value[i];

public static A085508Inst Instance=new A085508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085507
{
public static readonly long[] Value={ 0L,0L,1L,4L,13L,41L,136L,505L,2171L,10693L,58246L,340242L,2095435L,13492077L,90267633L,623383765L,4414350135L,31899350954L,235002008725L,1773013299342L,13855253098226L,114135759054965L,1010686200326760L,9744658443894282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085507Inst : IEnumerable<long>
{
public static readonly long[] Value=A085507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085507.Bytes);
public long this[int i]=>Value[i];

public static A085507Inst Instance=new A085507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085506
{
public static readonly long[] Value={ 1L,5L,133L,18905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085506Inst : IEnumerable<long>
{
public static readonly long[] Value=A085506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085506.Bytes);
public long this[int i]=>Value[i];

public static A085506Inst Instance=new A085506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085505
{
public static readonly long[] Value={ 4L,23L,67L,138L,239L,371L,534L,728L,954L,1212L,1501L,1822L,2175L,2560L,2977L,3425L,3906L,4419L,4963L,5539L,6148L,6788L,7461L,8165L,8901L,9669L,10470L,11302L,12166L,13062L,13990L,14951L,15943L,16967L,18023L,19111L,20231L,21384L,22568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085505Inst : IEnumerable<long>
{
public static readonly long[] Value=A085505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085505.Bytes);
public long this[int i]=>Value[i];

public static A085505Inst Instance=new A085505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085504
{
public static readonly long[] Value={ 0L,1L,18L,81L,405L,1944L,9477L,45927L,223074L,1082565L,5255361L,25509168L,123825753L,601059771L,2917611090L,14162371209L,68745613437L,333698181192L,1619805064509L,7862698824255L,38166342053346L,185263315578333L,899287025215113L,4365230915850336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085504Inst : IEnumerable<long>
{
public static readonly long[] Value=A085504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085504.Bytes);
public long this[int i]=>Value[i];

public static A085504Inst Instance=new A085504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085503
{
public static readonly long[] Value={ 1L,1L,1L,1L,66L,1L,1L,1191L,1191L,1L,1L,14608L,156190L,14608L,1L,1L,152637L,9738114L,9738114L,152637L,1L,1L,1479726L,423281535L,2275172004L,423281535L,1479726L,1L,1L,13824739L,15041229521L,311387598411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085503Inst : IEnumerable<long>
{
public static readonly long[] Value=A085503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085503.Bytes);
public long this[int i]=>Value[i];

public static A085503Inst Instance=new A085503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085502
{
public static readonly long[] Value={ 1L,293L,2728L,12318L,38835L,98411L,215138L,422668L,765813L,1302145L,2103596L,3258058L,4870983L,7066983L,9991430L,13812056L,18720553L,24934173L,32697328L,42283190L,53995291L,68169123L,85173738L,105413348L,129328925L,157399801L,190145268L,228126178L,271946543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085502Inst : IEnumerable<long>
{
public static readonly long[] Value=A085502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085502.Bytes);
public long this[int i]=>Value[i];

public static A085502Inst Instance=new A085502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085501
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085501Inst : IEnumerable<long>
{
public static readonly long[] Value=A085501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085501.Bytes);
public long this[int i]=>Value[i];

public static A085501Inst Instance=new A085501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085500
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,11L,15L,16L,18L,21L,23L,24L,30L,62L,66L,99L,154L,189L,217L,1059L,1183L,1532L,1663L,1831L,2225L,2810L,3385L,14357L,29040L,30802L,31545L,40933L,103520L,104071L,118505L,149689L,325852L,733588L,983015L,1094421L,1319945L,2850174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085500Inst : IEnumerable<long>
{
public static readonly long[] Value=A085500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085500.Bytes);
public long this[int i]=>Value[i];

public static A085500Inst Instance=new A085500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085499
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,31L,53L,103L,127L,271L,367L,463L,499L,859L,967L,1013L,1483L,1951L,3229L,3533L,3769L,3833L,4373L,5477L,6101L,7069L,7457L,8191L,8501L,9041L,9521L,11527L,11621L,11777L,13121L,14551L,17791L,20071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085499Inst : IEnumerable<long>
{
public static readonly long[] Value=A085499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085499.Bytes);
public long this[int i]=>Value[i];

public static A085499Inst Instance=new A085499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085498
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,23L,29L,31L,41L,47L,53L,59L,71L,79L,83L,89L,103L,107L,127L,131L,139L,149L,167L,179L,191L,197L,199L,223L,227L,233L,239L,251L,263L,269L,271L,293L,307L,311L,347L,349L,359L,367L,379L,383L,389L,419L,431L,439L,449L,461L,463L,467L,479L,499L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085498Inst : IEnumerable<long>
{
public static readonly long[] Value=A085498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085498.Bytes);
public long this[int i]=>Value[i];

public static A085498Inst Instance=new A085498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085497
{
public static readonly long[] Value={ 2L,13L,37L,43L,61L,67L,73L,97L,101L,109L,113L,137L,151L,157L,163L,173L,181L,193L,211L,229L,241L,257L,277L,281L,283L,313L,317L,331L,337L,353L,373L,397L,401L,409L,421L,433L,443L,457L,487L,491L,523L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085497Inst : IEnumerable<long>
{
public static readonly long[] Value=A085497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085497.Bytes);
public long this[int i]=>Value[i];

public static A085497Inst Instance=new A085497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085496
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,0L,1L,1L,5L,3L,1L,0L,2L,0L,10L,1L,31L,0L,0L,26L,0L,6L,23L,20L,0L,0L,1L,13L,0L,0L,1L,15L,0L,14L,9L,0L,0L,0L,190L,0L,713L,0L,42L,0L,7L,9L,0L,9L,6L,0L,6L,2148L,0L,509L,0L,120L,109L,1L,0L,0L,0L,4L,6L,100L,0L,0L,0L,0L,2L,4L,0L,21897L,1L,0L,3L,85L,79L,0L,0L,0L,19172L,0L,1130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085496Inst : IEnumerable<long>
{
public static readonly long[] Value=A085496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085496.Bytes);
public long this[int i]=>Value[i];

public static A085496Inst Instance=new A085496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085495
{
public static readonly BigInteger[] Value={ 2L,12L,48L,1152L,3840L,103680L,2903040L,696729600L,1393459200L,8360755200L,81749606400L,1961990553600L,51011754393600L,1428329123020800L,42849873690624000L,1371195958099968000L,BigInteger.Parse("46620662575398912000") };
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
public class A085495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085495Inst Instance=new A085495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085494
{
public static readonly long[] Value={ 1L,3L,5L,7L,15L,17L,19L,27L,31L,53L,63L,65L,69L,77L,87L,99L,103L,127L,161L,195L,255L,271L,303L,367L,413L,463L,485L,495L,499L,511L,579L,649L,725L,819L,859L,867L,967L,1013L,1023L,1035L,1147L,1183L,1311L,1315L,1351L,1371L,1375L,1457L,1483L,1503L,1695L,1887L,1951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085494Inst : IEnumerable<long>
{
public static readonly long[] Value=A085494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085494.Bytes);
public long this[int i]=>Value[i];

public static A085494Inst Instance=new A085494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085493
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,15L,17L,19L,23L,27L,29L,31L,35L,39L,41L,47L,53L,55L,59L,63L,65L,69L,71L,77L,79L,83L,87L,89L,95L,99L,103L,107L,111L,119L,125L,127L,131L,139L,143L,149L,155L,159L,161L,167L,175L,179L,191L,195L,197L,199L,203L,207L,209L,215L,219L,223L,227L,233L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085493Inst : IEnumerable<long>
{
public static readonly long[] Value=A085493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085493.Bytes);
public long this[int i]=>Value[i];

public static A085493Inst Instance=new A085493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085492
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,10L,12L,13L,14L,16L,18L,20L,21L,22L,24L,25L,26L,28L,30L,32L,33L,34L,36L,37L,38L,40L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,54L,56L,57L,58L,60L,61L,62L,64L,66L,67L,68L,70L,72L,73L,74L,75L,76L,78L,80L,81L,82L,84L,85L,86L,88L,90L,91L,92L,93L,94L,96L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085492Inst : IEnumerable<long>
{
public static readonly long[] Value=A085492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085492.Bytes);
public long this[int i]=>Value[i];

public static A085492Inst Instance=new A085492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085475
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,5L,1L,0L,1L,10L,9L,1L,0L,1L,15L,31L,13L,1L,0L,1L,21L,69L,64L,17L,1L,0L,1L,28L,126L,195L,109L,21L,1L,0L,1L,36L,210L,456L,425L,166L,25L,1L,0L,1L,45L,330L,923L,1231L,791L,235L,29L,1L,0L,1L,55L,495L,1716L,2975L,2751L,1325L,316L,33L,1L,0L,1L,66L,715L,3003L,6427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085475Inst : IEnumerable<long>
{
public static readonly long[] Value=A085475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085475.Bytes);
public long this[int i]=>Value[i];

public static A085475Inst Instance=new A085475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085474
{
public static readonly long[] Value={ 1L,15L,69L,195L,425L,791L,1325L,2059L,3025L,4255L,5781L,7635L,9849L,12455L,15485L,18971L,22945L,27439L,32485L,38115L,44361L,51255L,58829L,67115L,76145L,85951L,96565L,108019L,120345L,133575L,147741L,162875L,179009L,196175L,214405L,233731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085474Inst : IEnumerable<long>
{
public static readonly long[] Value=A085474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085474.Bytes);
public long this[int i]=>Value[i];

public static A085474Inst Instance=new A085474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085473
{
public static readonly long[] Value={ 1L,10L,31L,64L,109L,166L,235L,316L,409L,514L,631L,760L,901L,1054L,1219L,1396L,1585L,1786L,1999L,2224L,2461L,2710L,2971L,3244L,3529L,3826L,4135L,4456L,4789L,5134L,5491L,5860L,6241L,6634L,7039L,7456L,7885L,8326L,8779L,9244L,9721L,10210L,10711L,11224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085473Inst : IEnumerable<long>
{
public static readonly long[] Value=A085473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085473.Bytes);
public long this[int i]=>Value[i];

public static A085473Inst Instance=new A085473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085472
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,3L,2L,2L,5L,5L,5L,2L,3L,7L,9L,9L,7L,3L,4L,10L,14L,17L,14L,10L,4L,5L,14L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085472Inst : IEnumerable<long>
{
public static readonly long[] Value=A085472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085472.Bytes);
public long this[int i]=>Value[i];

public static A085472Inst Instance=new A085472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085471
{
public static readonly long[] Value={ 1L,-1L,1L,-4L,-1L,3L,-17L,-7L,-3L,15L,-94L,-56L,-58L,-15L,105L,-657L,-578L,-982L,-503L,-105L,945L,-5584L,-7291L,-16824L,-12901L,-5464L,-945L,10395L,-55757L,-106209L,-303361L,-313199L,-202071L,-70411L,-10395L,135135L,-634722L,-1728758L,-5846866L,-7692464L,-6715286L,-3535066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085471Inst : IEnumerable<long>
{
public static readonly long[] Value=A085471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085471.Bytes);
public long this[int i]=>Value[i];

public static A085471Inst Instance=new A085471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085470
{
public static readonly long[] Value={ 2L,-1L,8L,-3L,-5L,41L,-31L,11L,-33L,286L,-344L,250L,-63L,-279L,2577L,-4418L,4822L,-2423L,489L,-2895L,28624L,-64891L,93624L,-70501L,28504L,-4785L,-35685L,378317L,-1073889L,1916161L,-1925999L,1169751L,-392971L,56475L,-509985L,5795682L,-19792118L,41973586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085470Inst : IEnumerable<long>
{
public static readonly long[] Value=A085470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085470.Bytes);
public long this[int i]=>Value[i];

public static A085470Inst Instance=new A085470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085469
{
public static readonly long[] Value={ 1L,7L,4L,7L,5L,6L,4L,5L,9L,4L,6L,3L,3L,1L,8L,2L,1L,9L,0L,6L,3L,6L,2L,1L,2L,0L,3L,5L,5L,4L,4L,3L,9L,7L,4L,0L,3L,4L,8L,5L,1L,6L,1L,4L,3L,6L,6L,2L,4L,7L,4L,1L,7L,5L,8L,1L,5L,2L,8L,2L,5L,3L,5L,0L,7L,6L,5L,0L,4L,0L,6L,2L,3L,5L,3L,2L,7L,6L,1L,1L,7L,9L,8L,9L,0L,7L,5L,8L,3L,6L,2L,6L,9L,4L,6L,0L,7L,8L,8L,9L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085469Inst : IEnumerable<long>
{
public static readonly long[] Value=A085469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085469.Bytes);
public long this[int i]=>Value[i];

public static A085469Inst Instance=new A085469Inst();

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