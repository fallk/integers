using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A070815
{
public static readonly long[] Value={ 257L,514L,771L,1028L,1285L,1542L,2056L,2570L,3084L,3855L,4112L,4369L,5140L,6168L,7710L,8224L,8738L,10280L,12336L,13107L,15420L,16448L,17476L,20560L,21845L,24672L,26214L,30840L,32896L,34952L,41120L,43690L,49344L,52428L,61680L,65535L,65792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070815Inst : IEnumerable<long>
{
public static readonly long[] Value=A070815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070815.Bytes);
public long this[int i]=>Value[i];

public static A070815Inst Instance=new A070815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070814
{
public static readonly long[] Value={ 17L,34L,51L,68L,85L,102L,136L,170L,204L,255L,272L,340L,408L,510L,544L,680L,816L,1020L,1088L,1360L,1632L,2040L,2176L,2720L,3264L,4080L,4352L,5440L,6528L,8160L,8704L,10880L,13056L,16320L,17408L,21760L,26112L,32640L,34816L,43520L,52224L,65280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070814Inst : IEnumerable<long>
{
public static readonly long[] Value=A070814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070814.Bytes);
public long this[int i]=>Value[i];

public static A070814Inst Instance=new A070814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070813
{
public static readonly long[] Value={ 0L,2L,14L,254L,65534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070813Inst : IEnumerable<long>
{
public static readonly long[] Value=A070813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070813.Bytes);
public long this[int i]=>Value[i];

public static A070813Inst Instance=new A070813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070812
{
public static readonly long[] Value={ 0L,-1L,2L,0L,3L,-1L,-1L,2L,5L,0L,9L,3L,2L,-1L,14L,-1L,15L,2L,3L,5L,11L,0L,-1L,9L,-1L,3L,21L,2L,25L,-1L,5L,14L,3L,-1L,33L,15L,9L,2L,35L,3L,35L,5L,1L,11L,23L,0L,-1L,-1L,14L,9L,39L,-1L,5L,3L,15L,21L,29L,2L,55L,25L,3L,-1L,9L,5L,55L,14L,11L,3L,63L,-1L,69L,33L,-1L,15L,5L,9L,65L,2L,-1L,35L,41L,3L,14L,35L,21L,5L,77L,1L,9L,11L,25L,23L,15L,0L,93L,-1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070812Inst : IEnumerable<long>
{
public static readonly long[] Value=A070812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070812.Bytes);
public long this[int i]=>Value[i];

public static A070812Inst Instance=new A070812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070811
{
public static readonly long[] Value={ 1L,15L,21L,26L,27L,30L,33L,34L,35L,45L,49L,51L,52L,54L,57L,60L,63L,66L,68L,69L,70L,74L,75L,78L,81L,82L,85L,86L,87L,90L,91L,93L,95L,98L,99L,102L,104L,105L,106L,108L,110L,111L,114L,115L,117L,119L,120L,121L,122L,123L,125L,126L,129L,130L,132L,133L,135L,136L,138L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070811Inst : IEnumerable<long>
{
public static readonly long[] Value=A070811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070811.Bytes);
public long this[int i]=>Value[i];

public static A070811Inst Instance=new A070811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070810
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,16L,18L,20L,22L,24L,25L,28L,32L,36L,38L,39L,40L,42L,44L,46L,48L,50L,55L,56L,58L,62L,64L,65L,72L,76L,77L,80L,84L,88L,92L,94L,96L,100L,112L,116L,118L,124L,128L,134L,144L,152L,158L,160L,165L,168L,176L,184L,188L,192L,200L,202L,224L,232L,235L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070810Inst : IEnumerable<long>
{
public static readonly long[] Value=A070810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070810.Bytes);
public long this[int i]=>Value[i];

public static A070810Inst Instance=new A070810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070809
{
public static readonly long[] Value={ 1L,22L,25L,27L,33L,38L,44L,46L,49L,50L,54L,55L,57L,62L,63L,66L,69L,74L,75L,76L,77L,81L,82L,86L,88L,91L,92L,93L,94L,95L,98L,99L,100L,106L,108L,110L,111L,114L,115L,117L,118L,121L,122L,123L,124L,125L,126L,129L,132L,133L,134L,135L,138L,141L,142L,143L,146L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070809Inst : IEnumerable<long>
{
public static readonly long[] Value=A070809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070809.Bytes);
public long this[int i]=>Value[i];

public static A070809Inst Instance=new A070809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070808
{
public static readonly long[] Value={ 1L,2L,42L,407L,6890L,88502L,1385727L,19762290L,303169770L,4514031830L,69135179542L,1050132147077L,16141218975167L,247800513084152L,3825796483371170L,59118992260132532L,916434202205565162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070808Inst : IEnumerable<long>
{
public static readonly long[] Value=A070808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070808.Bytes);
public long this[int i]=>Value[i];

public static A070808Inst Instance=new A070808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070807
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,26L,28L,30L,32L,34L,35L,36L,39L,40L,42L,45L,48L,51L,52L,56L,58L,60L,64L,65L,68L,70L,72L,78L,80L,84L,85L,87L,90L,96L,102L,104L,105L,112L,116L,119L,120L,128L,130L,136L,140L,144L,145L,153L,156L,160L,168L,170L,174L,180L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070807Inst : IEnumerable<long>
{
public static readonly long[] Value=A070807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070807.Bytes);
public long this[int i]=>Value[i];

public static A070807Inst Instance=new A070807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070806
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,29L,97L,113L,193L,257L,449L,509L,769L,7937L,12289L,65537L,114689L,520193L,786433L,7340033L,8388593L,33292289L,33550337L,469762049L,2130706433L,3221225473L,8588886017L,137438691329L,206158430209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070806Inst : IEnumerable<long>
{
public static readonly long[] Value=A070806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070806.Bytes);
public long this[int i]=>Value[i];

public static A070806Inst Instance=new A070806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070805
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,31L,61L,113L,239L,467L,941L,1879L,3761L,7523L,15031L,30071L,60149L,120299L,240599L,481181L,962363L,1924721L,3849437L,7698893L,15397783L,30795571L,61591147L,123182281L,246364571L,492729101L,985458239L,1970916449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070805Inst : IEnumerable<long>
{
public static readonly long[] Value=A070805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070805.Bytes);
public long this[int i]=>Value[i];

public static A070805Inst Instance=new A070805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070804
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,2L,3L,2L,4L,2L,5L,3L,4L,4L,6L,3L,7L,4L,5L,4L,8L,4L,8L,5L,7L,5L,9L,4L,10L,6L,8L,6L,9L,5L,11L,7L,9L,6L,12L,5L,13L,8L,9L,8L,14L,6L,13L,8L,11L,9L,15L,7L,12L,9L,11L,9L,16L,6L,17L,10L,11L,11L,15L,8L,18L,11L,14L,9L,19L,9L,20L,11L,12L,11L,17L,9L,21L,11L,16L,12L,22L,9L,18L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070804Inst : IEnumerable<long>
{
public static readonly long[] Value=A070804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070804.Bytes);
public long this[int i]=>Value[i];

public static A070804Inst Instance=new A070804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070755
{
public static readonly long[] Value={ 1L,10L,35L,165L,286L,455L,969L,1330L,1771L,4495L,6545L,7770L,9139L,12341L,14190L,16215L,23426L,32509L,35990L,39711L,47905L,52394L,57155L,79079L,98770L,105995L,121485L,129766L,138415L,176851L,198485L,221815L,246905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070755Inst : IEnumerable<long>
{
public static readonly long[] Value=A070755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070755.Bytes);
public long this[int i]=>Value[i];

public static A070755Inst Instance=new A070755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070754
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,47L,53L,59L,71L,83L,89L,97L,101L,103L,107L,109L,127L,139L,151L,179L,191L,197L,223L,227L,229L,233L,239L,241L,271L,277L,283L,311L,317L,347L,353L,359L,367L,373L,379L,397L,409L,421L,449L,461L,467L,479L,491L,499L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070754Inst : IEnumerable<long>
{
public static readonly long[] Value=A070754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070754.Bytes);
public long this[int i]=>Value[i];

public static A070754Inst Instance=new A070754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070753
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,31L,37L,41L,43L,61L,67L,73L,79L,113L,131L,137L,149L,157L,163L,167L,173L,181L,193L,199L,211L,251L,257L,263L,269L,281L,293L,307L,313L,331L,337L,349L,383L,389L,401L,419L,431L,433L,439L,443L,457L,463L,487L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070753Inst : IEnumerable<long>
{
public static readonly long[] Value=A070753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070753.Bytes);
public long this[int i]=>Value[i];

public static A070753Inst Instance=new A070753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070752
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,9L,13L,14L,15L,19L,20L,21L,26L,27L,28L,32L,33L,34L,38L,39L,40L,44L,45L,46L,47L,51L,52L,53L,57L,58L,59L,63L,64L,65L,70L,71L,72L,76L,77L,78L,82L,83L,84L,88L,89L,90L,91L,95L,96L,97L,101L,102L,103L,107L,108L,109L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070752Inst : IEnumerable<long>
{
public static readonly long[] Value=A070752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070752.Bytes);
public long this[int i]=>Value[i];

public static A070752Inst Instance=new A070752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070751
{
public static readonly long[] Value={ 4L,5L,6L,10L,11L,12L,16L,17L,18L,22L,23L,24L,25L,29L,30L,31L,35L,36L,37L,41L,42L,43L,48L,49L,50L,54L,55L,56L,60L,61L,62L,66L,67L,68L,69L,73L,74L,75L,79L,80L,81L,85L,86L,87L,92L,93L,94L,98L,99L,100L,104L,105L,106L,110L,111L,112L,113L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070751Inst : IEnumerable<long>
{
public static readonly long[] Value=A070751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070751.Bytes);
public long this[int i]=>Value[i];

public static A070751Inst Instance=new A070751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070750
{
public static readonly long[] Value={ 0L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070750Inst : IEnumerable<long>
{
public static readonly long[] Value=A070750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070750.Bytes);
public long this[int i]=>Value[i];

public static A070750Inst Instance=new A070750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070749
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-1L,0L,-1L,0L,-1L,-1L,0L,-1L,0L,-1L,0L,0L,1L,-1L,-1L,1L,-1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,-1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,0L,0L,1L,0L,0L,0L,1L,0L,-1L,-1L,-1L,1L,1L,-1L,0L,-1L,-1L,0L,-1L,0L,-1L,-1L,1L,0L,1L,1L,1L,1L,1L,0L,-1L,1L,-1L,1L,-1L,0L,-1L,-1L,-1L,0L,0L,-1L,1L,-1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,-1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070749Inst : IEnumerable<long>
{
public static readonly long[] Value=A070749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070749.Bytes);
public long this[int i]=>Value[i];

public static A070749Inst Instance=new A070749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070748
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070748Inst : IEnumerable<long>
{
public static readonly long[] Value=A070748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070748.Bytes);
public long this[int i]=>Value[i];

public static A070748Inst Instance=new A070748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070747
{
public static readonly long[] Value={ 0L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070747Inst : IEnumerable<long>
{
public static readonly long[] Value=A070747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070747.Bytes);
public long this[int i]=>Value[i];

public static A070747Inst Instance=new A070747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070746
{
public static readonly long[] Value={ 1L,7L,709L,2203L,4481L,5107L,11489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070746Inst : IEnumerable<long>
{
public static readonly long[] Value=A070746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070746.Bytes);
public long this[int i]=>Value[i];

public static A070746Inst Instance=new A070746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070745
{
public static readonly long[] Value={ 3L,6L,10L,14L,15L,17L,21L,24L,28L,29L,35L,36L,42L,43L,45L,48L,55L,57L,60L,62L,63L,66L,76L,78L,80L,81L,90L,91L,99L,105L,112L,118L,119L,120L,123L,127L,129L,132L,136L,140L,141L,143L,147L,153L,154L,155L,161L,162L,165L,168L,171L,172L,179L,185L,190L,192L,195L,209L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070745Inst : IEnumerable<long>
{
public static readonly long[] Value=A070745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070745.Bytes);
public long this[int i]=>Value[i];

public static A070745Inst Instance=new A070745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070744
{
public static readonly long[] Value={ 18L,32L,36L,37L,38L,39L,40L,54L,80L,82L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070744Inst : IEnumerable<long>
{
public static readonly long[] Value=A070744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070744.Bytes);
public long this[int i]=>Value[i];

public static A070744Inst Instance=new A070744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070743
{
public static readonly long[] Value={ 1L,3L,5L,122L,160L,190L,739L,10000L,10058L,10151L,1003346L,1304392L,1702190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070743Inst : IEnumerable<long>
{
public static readonly long[] Value=A070743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070743.Bytes);
public long this[int i]=>Value[i];

public static A070743Inst Instance=new A070743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070742
{
public static readonly long[] Value={ 18L,17L,32L,16L,36L,31L,30L,15L,23L,35L,34L,30L,33L,29L,29L,14L,32L,22L,28L,34L,30L,33L,29L,29L,14L,32L,22L,28L,27L,30L,33L,29L,29L,14L,32L,22L,28L,27L,28L,33L,29L,29L,14L,32L,22L,28L,27L,28L,26L,29L,29L,14L,32L,22L,28L,27L,28L,26L,13L,29L,14L,32L,22L,28L,27L,28L,26L,13L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070742Inst : IEnumerable<long>
{
public static readonly long[] Value=A070742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070742.Bytes);
public long this[int i]=>Value[i];

public static A070742Inst Instance=new A070742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070741
{
public static readonly long[] Value={ 14L,57L,78L,148L,224L,252L,305L,490L,546L,585L,620L,639L,889L,897L,912L,1134L,1248L,1290L,1352L,1526L,1953L,2212L,2345L,2368L,2394L,2470L,2678L,2710L,3096L,3474L,3584L,3641L,3880L,4032L,4088L,4617L,4764L,4880L,5436L,5985L,6097L,6318L,6489L,6552L,6570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070741Inst : IEnumerable<long>
{
public static readonly long[] Value=A070741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070741.Bytes);
public long this[int i]=>Value[i];

public static A070741Inst Instance=new A070741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070740
{
public static readonly long[] Value={ 24L,36L,40320L,7200L,479001600L,25401600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070740Inst : IEnumerable<long>
{
public static readonly long[] Value=A070740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070740.Bytes);
public long this[int i]=>Value[i];

public static A070740Inst Instance=new A070740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070739
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,37L,41L,67L,73L,97L,131L,137L,193L,257L,521L,577L,641L,769L,1033L,1153L,2053L,2081L,2113L,4099L,4129L,8209L,12289L,16417L,18433L,32771L,32801L,32833L,40961L,65537L,65539L,133121L,147457L,163841L,262147L,262153L,262657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070739Inst : IEnumerable<long>
{
public static readonly long[] Value=A070739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070739.Bytes);
public long this[int i]=>Value[i];

public static A070739Inst Instance=new A070739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070738
{
public static readonly long[] Value={ 1L,4L,8L,16L,18L,28L,30L,32L,36L,50L,54L,56L,64L,72L,75L,100L,102L,104L,108L,128L,144L,162L,200L,204L,208L,216L,234L,245L,250L,256L,288L,294L,306L,324L,400L,405L,408L,432L,486L,500L,512L,567L,576L,588L,612L,648L,693L,800L,864L,882L,900L,972L,990L,1000L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070738Inst : IEnumerable<long>
{
public static readonly long[] Value=A070738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070738.Bytes);
public long this[int i]=>Value[i];

public static A070738Inst Instance=new A070738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070737
{
public static readonly long[] Value={ 3L,4L,6L,6L,1068630L,6770610L,2981997480L,339126523890L,120351747887280L,13533264289711320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070737Inst : IEnumerable<long>
{
public static readonly long[] Value=A070737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070737.Bytes);
public long this[int i]=>Value[i];

public static A070737Inst Instance=new A070737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070736
{
public static readonly long[] Value={ 1L,8L,33L,96L,231L,484L,915L,1608L,2664L,4208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070736Inst : IEnumerable<long>
{
public static readonly long[] Value=A070736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070736.Bytes);
public long this[int i]=>Value[i];

public static A070736Inst Instance=new A070736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070735
{
public static readonly long[] Value={ 1L,6L,18L,44L,89L,162L,271L,428L,642L,930L,1304L,1781L,2377L,3111L,4002L,5073L,6344L,7842L,9587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070735Inst : IEnumerable<long>
{
public static readonly long[] Value=A070735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070735.Bytes);
public long this[int i]=>Value[i];

public static A070735Inst Instance=new A070735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070734
{
public static readonly long[] Value={ 3L,24L,60L,720L,2520L,40320L,181440L,3628800L,19958400L,479001600L,3113510400L,87178291200L,653837184000L,20922789888000L,177843714048000L,6402373705728000L,60822550204416000L,2432902008176640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070734Inst : IEnumerable<long>
{
public static readonly long[] Value=A070734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070734.Bytes);
public long this[int i]=>Value[i];

public static A070734Inst Instance=new A070734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070733
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,20L,90L,630L,3360L,30240L,226800L,2494800L,23950080L,311351040L,3632428800L,54486432000L,747242496000L,12703122432000L,200074178304000L,3801409387776000L,67580611338240000L,1419192838103040000L,BigInteger.Parse("28100018194440192000"),BigInteger.Parse("646300418472124416000") };
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
public class A070733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070733Inst Instance=new A070733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070732
{
public static readonly long[] Value={ 1L,3L,12L,12L,30L,36L,56L,48L,108L,90L,132L,144L,182L,168L,360L,192L,306L,324L,380L,360L,672L,396L,552L,576L,750L,546L,972L,672L,870L,1080L,992L,768L,1584L,918L,1680L,1296L,1406L,1140L,2184L,1440L,1722L,2016L,1892L,1584L,3240L,1656L,2256L,2304L,2744L,2250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070732Inst : IEnumerable<long>
{
public static readonly long[] Value=A070732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070732.Bytes);
public long this[int i]=>Value[i];

public static A070732Inst Instance=new A070732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070731
{
public static readonly BigInteger[] Value={ 1L,3L,56L,3360L,833280L,959938560L,3901190307840L,63667425823948800L,BigInteger.Parse("4759267415191820697600"),BigInteger.Parse("1246395024829755538853068800") };
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
public class A070731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070731Inst Instance=new A070731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070730
{
public static readonly long[] Value={ 1L,2L,10L,5L,20L,100L,50L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070730Inst : IEnumerable<long>
{
public static readonly long[] Value=A070730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070730.Bytes);
public long this[int i]=>Value[i];

public static A070730Inst Instance=new A070730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070729
{
public static readonly long[] Value={ 5L,1L,20L,100L,10L,2L,50L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070729Inst : IEnumerable<long>
{
public static readonly long[] Value=A070729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070729.Bytes);
public long this[int i]=>Value[i];

public static A070729Inst Instance=new A070729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070728
{
public static readonly long[] Value={ 0L,1L,32L,27L,16L,29L,0L,7L,32L,9L,16L,35L,0L,37L,32L,15L,16L,17L,0L,43L,32L,45L,16L,23L,0L,25L,32L,3L,16L,5L,0L,31L,32L,33L,16L,11L,0L,13L,32L,39L,16L,41L,0L,19L,32L,21L,16L,47L,0L,1L,32L,27L,16L,29L,0L,7L,32L,9L,16L,35L,0L,37L,32L,15L,16L,17L,0L,43L,32L,45L,16L,23L,0L,25L,32L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070728Inst : IEnumerable<long>
{
public static readonly long[] Value=A070728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070728.Bytes);
public long this[int i]=>Value[i];

public static A070728Inst Instance=new A070728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070727
{
public static readonly long[] Value={ 0L,1L,34L,25L,28L,11L,4L,9L,12L,14L,45L,31L,42L,39L,24L,40L,32L,3L,6L,30L,26L,37L,20L,29L,18L,27L,10L,21L,17L,41L,44L,15L,7L,23L,8L,5L,16L,2L,33L,35L,38L,43L,36L,19L,22L,13L,46L,0L,1L,34L,25L,28L,11L,4L,9L,12L,14L,45L,31L,42L,39L,24L,40L,32L,3L,6L,30L,26L,37L,20L,29L,18L,27L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070727Inst : IEnumerable<long>
{
public static readonly long[] Value=A070727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070727.Bytes);
public long this[int i]=>Value[i];

public static A070727Inst Instance=new A070727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070726
{
public static readonly long[] Value={ 0L,1L,36L,25L,8L,17L,26L,5L,12L,27L,14L,7L,16L,9L,42L,11L,18L,43L,6L,15L,44L,33L,22L,23L,24L,13L,2L,31L,40L,3L,28L,35L,4L,37L,30L,39L,32L,19L,34L,41L,20L,29L,38L,21L,10L,45L,0L,1L,36L,25L,8L,17L,26L,5L,12L,27L,14L,7L,16L,9L,42L,11L,18L,43L,6L,15L,44L,33L,22L,23L,24L,13L,2L,31L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070726Inst : IEnumerable<long>
{
public static readonly long[] Value=A070726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070726.Bytes);
public long this[int i]=>Value[i];

public static A070726Inst Instance=new A070726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070725
{
public static readonly long[] Value={ 0L,1L,38L,27L,4L,5L,36L,43L,17L,9L,10L,11L,18L,22L,14L,0L,16L,8L,27L,19L,20L,36L,13L,32L,9L,25L,26L,18L,37L,29L,0L,31L,23L,27L,34L,35L,36L,28L,2L,9L,40L,41L,18L,7L,44L,0L,1L,38L,27L,4L,5L,36L,43L,17L,9L,10L,11L,18L,22L,14L,0L,16L,8L,27L,19L,20L,36L,13L,32L,9L,25L,26L,18L,37L,29L,0L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070725Inst : IEnumerable<long>
{
public static readonly long[] Value=A070725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070725.Bytes);
public long this[int i]=>Value[i];

public static A070725Inst Instance=new A070725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070724
{
public static readonly long[] Value={ 0L,1L,40L,31L,16L,25L,8L,39L,24L,37L,32L,11L,12L,29L,20L,27L,36L,41L,28L,35L,4L,21L,0L,23L,40L,9L,16L,3L,8L,17L,24L,15L,32L,33L,12L,7L,20L,5L,36L,19L,28L,13L,4L,43L,0L,1L,40L,31L,16L,25L,8L,39L,24L,37L,32L,11L,12L,29L,20L,27L,36L,41L,28L,35L,4L,21L,0L,23L,40L,9L,16L,3L,8L,17L,24L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070724Inst : IEnumerable<long>
{
public static readonly long[] Value=A070724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070724.Bytes);
public long this[int i]=>Value[i];

public static A070724Inst Instance=new A070724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070707
{
public static readonly long[] Value={ 0L,1L,24L,3L,4L,21L,20L,19L,18L,9L,10L,15L,12L,13L,14L,11L,16L,17L,8L,7L,6L,5L,22L,23L,2L,25L,0L,1L,24L,3L,4L,21L,20L,19L,18L,9L,10L,15L,12L,13L,14L,11L,16L,17L,8L,7L,6L,5L,22L,23L,2L,25L,0L,1L,24L,3L,4L,21L,20L,19L,18L,9L,10L,15L,12L,13L,14L,11L,16L,17L,8L,7L,6L,5L,22L,23L,2L,25L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070707Inst : IEnumerable<long>
{
public static readonly long[] Value=A070707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070707.Bytes);
public long this[int i]=>Value[i];

public static A070707Inst Instance=new A070707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070706
{
public static readonly long[] Value={ 0L,1L,3L,12L,9L,0L,11L,18L,2L,19L,0L,21L,8L,17L,4L,0L,6L,23L,7L,14L,0L,16L,13L,22L,24L,0L,1L,3L,12L,9L,0L,11L,18L,2L,19L,0L,21L,8L,17L,4L,0L,6L,23L,7L,14L,0L,16L,13L,22L,24L,0L,1L,3L,12L,9L,0L,11L,18L,2L,19L,0L,21L,8L,17L,4L,0L,6L,23L,7L,14L,0L,16L,13L,22L,24L,0L,1L,3L,12L,9L,0L,11L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070706Inst : IEnumerable<long>
{
public static readonly long[] Value=A070706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070706.Bytes);
public long this[int i]=>Value[i];

public static A070706Inst Instance=new A070706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070705
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,3L,1L,4L,8L,5L,14L,15L,5L,18L,1L,20L,16L,2L,15L,15L,8L,21L,29L,21L,16L,32L,29L,23L,22L,30L,54L,71L,37L,7L,37L,43L,45L,30L,36L,77L,100L,72L,64L,7L,56L,33L,42L,54L,132L,18L,90L,156L,91L,29L,86L,149L,139L,111L,112L,96L,62L,5L,204L,103L,41L,197L,81L,218L,128L,238L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070705Inst : IEnumerable<long>
{
public static readonly long[] Value=A070705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070705.Bytes);
public long this[int i]=>Value[i];

public static A070705Inst Instance=new A070705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070704
{
public static readonly long[] Value={ 0L,1L,13L,2L,8L,17L,3L,5L,12L,4L,14L,7L,16L,9L,19L,11L,18L,20L,6L,15L,21L,10L,22L,0L,1L,13L,2L,8L,17L,3L,5L,12L,4L,14L,7L,16L,9L,19L,11L,18L,20L,6L,15L,21L,10L,22L,0L,1L,13L,2L,8L,17L,3L,5L,12L,4L,14L,7L,16L,9L,19L,11L,18L,20L,6L,15L,21L,10L,22L,0L,1L,13L,2L,8L,17L,3L,5L,12L,4L,14L,7L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070704Inst : IEnumerable<long>
{
public static readonly long[] Value=A070704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070704.Bytes);
public long this[int i]=>Value[i];

public static A070704Inst Instance=new A070704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070703
{
public static readonly long[] Value={ 0L,1L,18L,9L,16L,3L,8L,17L,2L,15L,10L,11L,12L,7L,20L,5L,14L,19L,6L,13L,4L,21L,0L,1L,18L,9L,16L,3L,8L,17L,2L,15L,10L,11L,12L,7L,20L,5L,14L,19L,6L,13L,4L,21L,0L,1L,18L,9L,16L,3L,8L,17L,2L,15L,10L,11L,12L,7L,20L,5L,14L,19L,6L,13L,4L,21L,0L,1L,18L,9L,16L,3L,8L,17L,2L,15L,10L,11L,12L,7L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070703Inst : IEnumerable<long>
{
public static readonly long[] Value=A070703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070703.Bytes);
public long this[int i]=>Value[i];

public static A070703Inst Instance=new A070703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070702
{
public static readonly long[] Value={ 0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070702Inst : IEnumerable<long>
{
public static readonly long[] Value=A070702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070702.Bytes);
public long this[int i]=>Value[i];

public static A070702Inst Instance=new A070702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070701
{
public static readonly long[] Value={ 0L,1L,14L,2L,6L,16L,9L,7L,8L,4L,15L,11L,12L,10L,3L,13L,17L,5L,18L,0L,1L,14L,2L,6L,16L,9L,7L,8L,4L,15L,11L,12L,10L,3L,13L,17L,5L,18L,0L,1L,14L,2L,6L,16L,9L,7L,8L,4L,15L,11L,12L,10L,3L,13L,17L,5L,18L,0L,1L,14L,2L,6L,16L,9L,7L,8L,4L,15L,11L,12L,10L,3L,13L,17L,5L,18L,0L,1L,14L,2L,6L,16L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070701Inst : IEnumerable<long>
{
public static readonly long[] Value=A070701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070701.Bytes);
public long this[int i]=>Value[i];

public static A070701Inst Instance=new A070701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070700
{
public static readonly long[] Value={ 0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L,0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L,0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L,0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L,0L,1L,2L,9L,4L,5L,0L,7L,8L,9L,10L,11L,0L,13L,14L,9L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070700Inst : IEnumerable<long>
{
public static readonly long[] Value=A070700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070700.Bytes);
public long this[int i]=>Value[i];

public static A070700Inst Instance=new A070700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070699
{
public static readonly long[] Value={ 0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L,1L,9L,11L,13L,10L,14L,12L,15L,2L,5L,3L,7L,4L,6L,8L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070699Inst : IEnumerable<long>
{
public static readonly long[] Value=A070699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070699.Bytes);
public long this[int i]=>Value[i];

public static A070699Inst Instance=new A070699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070698
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,29L,39L,49L,59L,69L,79L,89L,99L,101L,102L,103L,104L,105L,106L,107L,108L,109L,119L,129L,139L,149L,159L,169L,179L,189L,199L,299L,399L,499L,599L,699L,799L,899L,999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070698Inst : IEnumerable<long>
{
public static readonly long[] Value=A070698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070698.Bytes);
public long this[int i]=>Value[i];

public static A070698Inst Instance=new A070698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070697
{
public static readonly long[] Value={ 0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070697Inst : IEnumerable<long>
{
public static readonly long[] Value=A070697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070697.Bytes);
public long this[int i]=>Value[i];

public static A070697Inst Instance=new A070697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070696
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070696Inst : IEnumerable<long>
{
public static readonly long[] Value=A070696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070696.Bytes);
public long this[int i]=>Value[i];

public static A070696Inst Instance=new A070696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070695
{
public static readonly long[] Value={ 0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L,11L,3L,4L,8L,7L,6L,5L,9L,10L,2L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070695Inst : IEnumerable<long>
{
public static readonly long[] Value=A070695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070695.Bytes);
public long this[int i]=>Value[i];

public static A070695Inst Instance=new A070695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070694
{
public static readonly long[] Value={ 1L,2L,337536L,585106L,602056L,2071960L,11861410L,20706120L,54020170L,72696726L,87584646L,89445636L,95895930L,98583340L,98595070L,112204200L,205739220L,279448296L,292582836L,337969690L,349672456L,432972780L,437874186L,474186576L,479631880L,483333426L,621777466L,643697776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070694Inst : IEnumerable<long>
{
public static readonly long[] Value=A070694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070694.Bytes);
public long this[int i]=>Value[i];

public static A070694Inst Instance=new A070694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070693
{
public static readonly long[] Value={ 0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L,0L,1L,7L,9L,5L,3L,8L,6L,2L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070693Inst : IEnumerable<long>
{
public static readonly long[] Value=A070693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070693.Bytes);
public long this[int i]=>Value[i];

public static A070693Inst Instance=new A070693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070692
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070692Inst : IEnumerable<long>
{
public static readonly long[] Value=A070692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070692.Bytes);
public long this[int i]=>Value[i];

public static A070692Inst Instance=new A070692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070675
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,3L,8L,9L,2L,5L,12L,13L,4L,7L,16L,17L,18L,9L,8L,3L,22L,5L,4L,25L,26L,13L,28L,11L,2L,15L,2L,33L,6L,17L,36L,37L,14L,9L,4L,13L,42L,3L,19L,45L,46L,7L,48L,9L,16L,25L,52L,53L,4L,13L,20L,57L,58L,11L,3L,15L,8L,31L,14L,5L,66L,33L,22L,29L,5L,17L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070675Inst : IEnumerable<long>
{
public static readonly long[] Value=A070675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070675.Bytes);
public long this[int i]=>Value[i];

public static A070675Inst Instance=new A070675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070674
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,3L,9L,1L,1L,1L,7L,4L,1L,4L,1L,1L,1L,1L,3L,4L,9L,1L,1L,5L,1L,1L,1L,11L,13L,7L,5L,16L,1L,1L,25L,6L,1L,16L,1L,1L,1L,18L,1L,1L,9L,1L,7L,1L,9L,4L,1L,1L,1L,13L,5L,4L,1L,16L,1L,29L,1L,1L,11L,1L,25L,2L,7L,1L,5L,23L,55L,23L,1L,10L,1L,1L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070674Inst : IEnumerable<long>
{
public static readonly long[] Value=A070674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070674.Bytes);
public long this[int i]=>Value[i];

public static A070674Inst Instance=new A070674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070673
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,6L,3L,8L,3L,10L,5L,5L,13L,2L,3L,2L,17L,18L,3L,8L,21L,22L,5L,7L,5L,26L,13L,12L,7L,30L,3L,10L,9L,6L,17L,6L,37L,5L,3L,3L,13L,42L,21L,8L,45L,46L,5L,48L,7L,2L,5L,23L,53L,12L,13L,20L,17L,58L,7L,11L,61L,8L,7L,8L,23L,66L,9L,22L,13L,70L,17L,10L,31L,7L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070673Inst : IEnumerable<long>
{
public static readonly long[] Value=A070673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070673.Bytes);
public long this[int i]=>Value[i];

public static A070673Inst Instance=new A070673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070672
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,20L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,7L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070672Inst : IEnumerable<long>
{
public static readonly long[] Value=A070672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070672.Bytes);
public long this[int i]=>Value[i];

public static A070672Inst Instance=new A070672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070671
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,2L,3L,2L,9L,10L,5L,3L,3L,4L,7L,16L,5L,7L,9L,2L,21L,22L,5L,24L,3L,8L,3L,28L,11L,5L,15L,10L,33L,4L,5L,10L,7L,4L,9L,40L,5L,6L,21L,4L,45L,46L,7L,18L,49L,16L,3L,52L,17L,21L,3L,7L,57L,58L,11L,13L,5L,2L,31L,4L,23L,29L,33L,22L,9L,70L,5L,8L,11L,26L,7L,10L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070671Inst : IEnumerable<long>
{
public static readonly long[] Value=A070671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070671.Bytes);
public long this[int i]=>Value[i];

public static A070671Inst Instance=new A070671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070670
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,6L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,10L,1L,1L,5L,1L,1L,1L,1L,1L,11L,1L,1L,1L,1L,16L,1L,1L,1L,1L,1L,9L,33L,1L,1L,1L,25L,1L,1L,1L,1L,5L,1L,1L,1L,16L,1L,15L,1L,1L,1L,1L,37L,1L,1L,1L,1L,1L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070670Inst : IEnumerable<long>
{
public static readonly long[] Value=A070670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070670.Bytes);
public long this[int i]=>Value[i];

public static A070670Inst Instance=new A070670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070669
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,6L,3L,8L,3L,10L,5L,5L,13L,2L,3L,4L,17L,18L,3L,8L,21L,22L,5L,7L,5L,26L,13L,12L,7L,30L,7L,10L,13L,6L,17L,6L,37L,5L,3L,9L,13L,42L,21L,8L,45L,46L,5L,48L,7L,4L,5L,23L,53L,12L,13L,20L,17L,58L,7L,11L,61L,8L,15L,8L,23L,66L,13L,22L,13L,70L,17L,27L,31L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070669Inst : IEnumerable<long>
{
public static readonly long[] Value=A070669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070669.Bytes);
public long this[int i]=>Value[i];

public static A070669Inst Instance=new A070669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070668
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,3L,9L,1L,1L,1L,7L,7L,1L,4L,1L,1L,1L,1L,3L,10L,9L,1L,1L,5L,1L,1L,1L,11L,13L,10L,7L,16L,1L,1L,25L,6L,1L,16L,1L,1L,1L,18L,1L,1L,9L,1L,19L,1L,9L,7L,1L,1L,1L,13L,5L,4L,1L,16L,1L,29L,1L,1L,11L,1L,25L,8L,47L,1L,45L,23L,55L,23L,1L,28L,1L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070668Inst : IEnumerable<long>
{
public static readonly long[] Value=A070668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070668.Bytes);
public long this[int i]=>Value[i];

public static A070668Inst Instance=new A070668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070667
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,3L,8L,9L,10L,5L,12L,13L,4L,7L,16L,17L,18L,9L,8L,21L,22L,5L,24L,25L,26L,13L,28L,11L,30L,15L,10L,33L,6L,17L,36L,37L,14L,9L,40L,13L,42L,21L,19L,45L,46L,7L,48L,49L,16L,25L,52L,53L,21L,13L,20L,57L,58L,11L,60L,61L,8L,31L,14L,23L,66L,33L,22L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070667Inst : IEnumerable<long>
{
public static readonly long[] Value=A070667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070667.Bytes);
public long this[int i]=>Value[i];

public static A070667Inst Instance=new A070667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070666
{
public static readonly long[] Value={ 0L,1L,21L,41L,11L,16L,1L,1L,16L,4L,35L,4L,21L,16L,21L,11L,35L,35L,41L,11L,4L,41L,41L,4L,11L,41L,35L,35L,11L,21L,16L,21L,4L,35L,4L,16L,1L,1L,16L,11L,41L,21L,1L,0L,1L,21L,41L,11L,16L,1L,1L,16L,4L,35L,4L,21L,16L,21L,11L,35L,35L,41L,11L,4L,41L,41L,4L,11L,41L,35L,35L,11L,21L,16L,21L,4L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070666Inst : IEnumerable<long>
{
public static readonly long[] Value=A070666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070666.Bytes);
public long this[int i]=>Value[i];

public static A070666Inst Instance=new A070666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070665
{
public static readonly long[] Value={ 0L,1L,22L,15L,22L,1L,36L,7L,22L,15L,22L,1L,36L,1L,28L,15L,22L,1L,36L,1L,22L,21L,22L,1L,36L,1L,22L,15L,28L,1L,36L,1L,22L,15L,22L,7L,36L,1L,22L,15L,22L,1L,0L,1L,22L,15L,22L,1L,36L,7L,22L,15L,22L,1L,36L,1L,28L,15L,22L,1L,36L,1L,22L,21L,22L,1L,36L,1L,22L,15L,28L,1L,36L,1L,22L,15L,22L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070665Inst : IEnumerable<long>
{
public static readonly long[] Value=A070665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070665.Bytes);
public long this[int i]=>Value[i];

public static A070665Inst Instance=new A070665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070664
{
public static readonly long[] Value={ 0L,1L,23L,32L,37L,4L,39L,20L,31L,40L,10L,33L,36L,2L,9L,5L,16L,8L,18L,21L,25L,25L,21L,18L,8L,16L,5L,9L,2L,36L,33L,10L,40L,31L,20L,39L,4L,37L,32L,23L,1L,0L,1L,23L,32L,37L,4L,39L,20L,31L,40L,10L,33L,36L,2L,9L,5L,16L,8L,18L,21L,25L,25L,21L,18L,8L,16L,5L,9L,2L,36L,33L,10L,40L,31L,20L,39L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070664Inst : IEnumerable<long>
{
public static readonly long[] Value=A070664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070664.Bytes);
public long this[int i]=>Value[i];

public static A070664Inst Instance=new A070664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070663
{
public static readonly long[] Value={ 0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L,16L,25L,16L,9L,24L,1L,0L,1L,24L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070663Inst : IEnumerable<long>
{
public static readonly long[] Value=A070663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070663.Bytes);
public long this[int i]=>Value[i];

public static A070663Inst Instance=new A070663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070662
{
public static readonly long[] Value={ 0L,1L,25L,27L,1L,25L,12L,25L,25L,27L,1L,25L,27L,13L,1L,12L,1L,1L,12L,25L,25L,12L,1L,1L,12L,1L,13L,27L,25L,1L,27L,25L,25L,12L,25L,1L,27L,25L,1L,0L,1L,25L,27L,1L,25L,12L,25L,25L,27L,1L,25L,27L,13L,1L,12L,1L,1L,12L,25L,25L,12L,1L,1L,12L,1L,13L,27L,25L,1L,27L,25L,25L,12L,25L,1L,27L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070662Inst : IEnumerable<long>
{
public static readonly long[] Value=A070662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070662.Bytes);
public long this[int i]=>Value[i];

public static A070662Inst Instance=new A070662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070661
{
public static readonly long[] Value={ 0L,1L,26L,7L,30L,7L,30L,1L,20L,11L,30L,1L,20L,11L,26L,11L,26L,7L,20L,19L,20L,7L,26L,11L,26L,11L,20L,1L,30L,11L,20L,1L,30L,7L,30L,7L,26L,1L,0L,1L,26L,7L,30L,7L,30L,1L,20L,11L,30L,1L,20L,11L,26L,11L,26L,7L,20L,19L,20L,7L,26L,11L,26L,11L,20L,1L,30L,11L,20L,1L,30L,7L,30L,7L,26L,1L,0L,1L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070661Inst : IEnumerable<long>
{
public static readonly long[] Value=A070661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070661.Bytes);
public long this[int i]=>Value[i];

public static A070661Inst Instance=new A070661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070660
{
public static readonly long[] Value={ 0L,1L,27L,26L,26L,11L,36L,26L,36L,10L,1L,1L,10L,11L,36L,27L,10L,27L,11L,11L,27L,10L,27L,36L,11L,10L,1L,1L,10L,36L,26L,36L,11L,26L,26L,27L,1L,0L,1L,27L,26L,26L,11L,36L,26L,36L,10L,1L,1L,10L,11L,36L,27L,10L,27L,11L,11L,27L,10L,27L,36L,11L,10L,1L,1L,10L,36L,26L,36L,11L,26L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070660Inst : IEnumerable<long>
{
public static readonly long[] Value=A070660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070660.Bytes);
public long this[int i]=>Value[i];

public static A070660Inst Instance=new A070660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070643
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070643Inst : IEnumerable<long>
{
public static readonly long[] Value=A070643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070643.Bytes);
public long this[int i]=>Value[i];

public static A070643Inst Instance=new A070643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070642
{
public static readonly long[] Value={ 0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L,7L,11L,7L,7L,1L,0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L,7L,11L,7L,7L,1L,0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L,7L,11L,7L,7L,1L,0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L,7L,11L,7L,7L,1L,0L,1L,7L,7L,11L,7L,11L,1L,1L,11L,11L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070642Inst : IEnumerable<long>
{
public static readonly long[] Value=A070642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070642.Bytes);
public long this[int i]=>Value[i];

public static A070642Inst Instance=new A070642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070641
{
public static readonly long[] Value={ 0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L,0L,1L,10L,9L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070641Inst : IEnumerable<long>
{
public static readonly long[] Value=A070641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070641.Bytes);
public long this[int i]=>Value[i];

public static A070641Inst Instance=new A070641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070640
{
public static readonly long[] Value={ 0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L,15L,16L,2L,8L,9L,4L,4L,9L,8L,2L,16L,15L,13L,1L,0L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070640Inst : IEnumerable<long>
{
public static readonly long[] Value=A070640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070640.Bytes);
public long this[int i]=>Value[i];

public static A070640Inst Instance=new A070640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070639
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,20L,19L,31L,33L,48L,43L,73L,59L,90L,88L,111L,97L,159L,121L,182L,165L,208L,173L,277L,211L,290L,263L,338L,271L,445L,309L,435L,396L,490L,414L,608L,433L,610L,544L,695L,531L,844L,585L,818L,745L,880L,697L,1080L,773L,1085L,918L,1126L,883L,1364L,995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070639Inst : IEnumerable<long>
{
public static readonly long[] Value=A070639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070639.Bytes);
public long this[int i]=>Value[i];

public static A070639Inst Instance=new A070639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070638
{
public static readonly long[] Value={ 0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070638Inst : IEnumerable<long>
{
public static readonly long[] Value=A070638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070638.Bytes);
public long this[int i]=>Value[i];

public static A070638Inst Instance=new A070638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070637
{
public static readonly long[] Value={ 0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L,1L,8L,1L,8L,7L,8L,1L,8L,1L,8L,1L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070637Inst : IEnumerable<long>
{
public static readonly long[] Value=A070637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070637.Bytes);
public long this[int i]=>Value[i];

public static A070637Inst Instance=new A070637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070636
{
public static readonly long[] Value={ 0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L,12L,12L,12L,1L,1L,12L,1L,0L,1L,12L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070636Inst : IEnumerable<long>
{
public static readonly long[] Value=A070636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070636.Bytes);
public long this[int i]=>Value[i];

public static A070636Inst Instance=new A070636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070635
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,4L,3L,2L,1L,0L,9L,0L,0L,2L,3L,0L,4L,2L,0L,8L,7L,0L,3L,2L,3L,6L,3L,0L,7L,5L,3L,0L,1L,0L,1L,4L,0L,6L,3L,0L,10L,0L,3L,3L,5L,0L,5L,1L,9L,6L,3L,0L,5L,6L,0L,4L,10L,6L,2L,12L,9L,0L,7L,0L,3L,8L,3L,11L,7L,3L,15L,0L,0L,2L,6L,0L,7L,2L,12L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070635Inst : IEnumerable<long>
{
public static readonly long[] Value=A070635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070635.Bytes);
public long this[int i]=>Value[i];

public static A070635Inst Instance=new A070635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070634
{
public static readonly long[] Value={ 0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L,9L,3L,4L,5L,5L,4L,3L,9L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070634Inst : IEnumerable<long>
{
public static readonly long[] Value=A070634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070634.Bytes);
public long this[int i]=>Value[i];

public static A070634Inst Instance=new A070634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070633
{
public static readonly long[] Value={ 2L,5L,2L,9L,2L,9L,2L,14L,2L,7L,2L,19L,2L,5L,2L,20L,2L,13L,2L,16L,2L,7L,2L,34L,2L,5L,2L,11L,2L,13L,2L,27L,2L,5L,2L,31L,2L,5L,2L,30L,2L,13L,2L,14L,2L,7L,2L,51L,2L,7L,2L,11L,2L,15L,2L,19L,2L,7L,2L,37L,2L,5L,2L,35L,2L,13L,2L,9L,2L,9L,2L,63L,2L,5L,2L,9L,2L,11L,2L,46L,2L,7L,2L,31L,2L,5L,2L,25L,2L,17L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070633Inst : IEnumerable<long>
{
public static readonly long[] Value=A070633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070633.Bytes);
public long this[int i]=>Value[i];

public static A070633Inst Instance=new A070633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070632
{
public static readonly BigInteger[] Value={ 1L,19L,1657009L,BigInteger.Parse("9950006745799417075771"),BigInteger.Parse("19389268200585836264288587113776883575610248525384021488302948711030121") };
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
public class A070632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070632Inst Instance=new A070632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070631
{
public static readonly long[] Value={ 0L,1L,32L,3L,16L,5L,0L,7L,32L,9L,16L,11L,0L,13L,32L,15L,16L,17L,0L,19L,32L,21L,16L,23L,0L,25L,32L,27L,16L,29L,0L,31L,32L,33L,16L,35L,0L,37L,32L,39L,16L,41L,0L,43L,32L,45L,16L,47L,0L,1L,32L,3L,16L,5L,0L,7L,32L,9L,16L,11L,0L,13L,32L,15L,16L,17L,0L,19L,32L,21L,16L,23L,0L,25L,32L,27L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070631Inst : IEnumerable<long>
{
public static readonly long[] Value=A070631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070631.Bytes);
public long this[int i]=>Value[i];

public static A070631Inst Instance=new A070631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070630
{
public static readonly long[] Value={ 0L,1L,32L,8L,37L,23L,21L,28L,9L,17L,31L,29L,14L,40L,3L,43L,6L,34L,27L,45L,5L,36L,35L,22L,25L,12L,11L,42L,2L,20L,13L,41L,4L,44L,7L,33L,18L,16L,30L,38L,19L,26L,24L,10L,39L,15L,46L,0L,1L,32L,8L,37L,23L,21L,28L,9L,17L,31L,29L,14L,40L,3L,43L,6L,34L,27L,45L,5L,36L,35L,22L,25L,12L,11L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070630Inst : IEnumerable<long>
{
public static readonly long[] Value=A070630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070630.Bytes);
public long this[int i]=>Value[i];

public static A070630Inst Instance=new A070630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070629
{
public static readonly long[] Value={ 0L,1L,32L,13L,12L,43L,2L,17L,16L,31L,42L,5L,18L,27L,38L,7L,6L,21L,26L,11L,10L,37L,22L,23L,24L,9L,36L,35L,20L,25L,40L,39L,8L,19L,28L,41L,4L,15L,30L,29L,44L,3L,34L,33L,14L,45L,0L,1L,32L,13L,12L,43L,2L,17L,16L,31L,42L,5L,18L,27L,38L,7L,6L,21L,26L,11L,10L,37L,22L,23L,24L,9L,36L,35L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070629Inst : IEnumerable<long>
{
public static readonly long[] Value=A070629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070629.Bytes);
public long this[int i]=>Value[i];

public static A070629Inst Instance=new A070629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070628
{
public static readonly long[] Value={ 0L,1L,32L,18L,34L,20L,36L,22L,8L,9L,10L,41L,27L,43L,29L,0L,31L,17L,18L,19L,5L,36L,7L,38L,9L,40L,26L,27L,28L,14L,0L,16L,2L,18L,4L,35L,36L,37L,23L,9L,25L,11L,27L,13L,44L,0L,1L,32L,18L,34L,20L,36L,22L,8L,9L,10L,41L,27L,43L,29L,0L,31L,17L,18L,19L,5L,36L,7L,38L,9L,40L,26L,27L,28L,14L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070628Inst : IEnumerable<long>
{
public static readonly long[] Value=A070628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070628.Bytes);
public long this[int i]=>Value[i];

public static A070628Inst Instance=new A070628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070515
{
public static readonly long[] Value={ 0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L,5L,4L,3L,9L,9L,3L,4L,5L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070515Inst : IEnumerable<long>
{
public static readonly long[] Value=A070515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070515.Bytes);
public long this[int i]=>Value[i];

public static A070515Inst Instance=new A070515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070514
{
public static readonly long[] Value={ 0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L,1L,6L,1L,6L,5L,6L,1L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070514Inst : IEnumerable<long>
{
public static readonly long[] Value=A070514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070514.Bytes);
public long this[int i]=>Value[i];

public static A070514Inst Instance=new A070514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070513
{
public static readonly long[] Value={ 0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070513Inst : IEnumerable<long>
{
public static readonly long[] Value=A070513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070513.Bytes);
public long this[int i]=>Value[i];

public static A070513Inst Instance=new A070513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070512
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L,4L,4L,2L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070512Inst : IEnumerable<long>
{
public static readonly long[] Value=A070512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070512.Bytes);
public long this[int i]=>Value[i];

public static A070512Inst Instance=new A070512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070511
{
public static readonly long[] Value={ 0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070511Inst : IEnumerable<long>
{
public static readonly long[] Value=A070511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070511.Bytes);
public long this[int i]=>Value[i];

public static A070511Inst Instance=new A070511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070510
{
public static readonly long[] Value={ 0L,1L,8L,27L,16L,29L,24L,7L,32L,9L,40L,35L,0L,37L,8L,15L,16L,17L,24L,43L,32L,45L,40L,23L,0L,25L,8L,3L,16L,5L,24L,31L,32L,33L,40L,11L,0L,13L,8L,39L,16L,41L,24L,19L,32L,21L,40L,47L,0L,1L,8L,27L,16L,29L,24L,7L,32L,9L,40L,35L,0L,37L,8L,15L,16L,17L,24L,43L,32L,45L,40L,23L,0L,25L,8L,3L,16L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070510Inst : IEnumerable<long>
{
public static readonly long[] Value=A070510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070510.Bytes);
public long this[int i]=>Value[i];

public static A070510Inst Instance=new A070510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070509
{
public static readonly long[] Value={ 0L,1L,8L,27L,17L,31L,28L,14L,42L,24L,13L,15L,36L,35L,18L,38L,7L,25L,4L,44L,10L,2L,26L,41L,6L,21L,45L,37L,3L,43L,22L,40L,9L,29L,12L,11L,32L,34L,23L,5L,33L,19L,16L,30L,20L,39L,46L,0L,1L,8L,27L,17L,31L,28L,14L,42L,24L,13L,15L,36L,35L,18L,38L,7L,25L,4L,44L,10L,2L,26L,41L,6L,21L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070509Inst : IEnumerable<long>
{
public static readonly long[] Value=A070509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070509.Bytes);
public long this[int i]=>Value[i];

public static A070509Inst Instance=new A070509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070508
{
public static readonly long[] Value={ 0L,1L,8L,27L,18L,33L,32L,21L,6L,39L,34L,43L,26L,35L,30L,17L,2L,37L,36L,5L,42L,15L,22L,23L,24L,31L,4L,41L,10L,9L,44L,29L,16L,11L,20L,3L,12L,7L,40L,25L,14L,13L,28L,19L,38L,45L,0L,1L,8L,27L,18L,33L,32L,21L,6L,39L,34L,43L,26L,35L,30L,17L,2L,37L,36L,5L,42L,15L,22L,23L,24L,31L,4L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070508Inst : IEnumerable<long>
{
public static readonly long[] Value=A070508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070508.Bytes);
public long this[int i]=>Value[i];

public static A070508Inst Instance=new A070508Inst();

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