using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A261082
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,16L,24L,35L,52L,77L,114L,170L,255L,385L,584L,889L,1358L,2081L,3199L,4932L,7625L,11818L,18357L,28568L,44530L,69504L,108607L,169869L,265899L,416507L,652845L,1023946L,1607064L,2524042L,3967246L,6240680L,9825202L,15481988L,24416684L,38539840L,60880090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261082Inst : IEnumerable<long>
{
public static readonly long[] Value=A261082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261082.Bytes);
public long this[int i]=>Value[i];

public static A261082Inst Instance=new A261082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261083
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,2L,1L,2L,2L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,2L,3L,1L,1L,2L,4L,1L,1L,1L,0L,1L,2L,3L,1L,1L,2L,3L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,2L,3L,1L,1L,2L,3L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,1L,1L,2L,1L,1L,1L,0L,1L,2L,3L,1L,1L,2L,3L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,1L,1L,2L,2L,3L,3L,3L,3L,2L,3L,4L,4L,4L,4L,5L,1L,1L,1L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261083Inst : IEnumerable<long>
{
public static readonly long[] Value=A261083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261083.Bytes);
public long this[int i]=>Value[i];

public static A261083Inst Instance=new A261083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261084
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,0L,0L,1L,1L,2L,1L,2L,3L,0L,0L,1L,1L,2L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,2L,0L,0L,0L,1L,1L,0L,1L,2L,3L,3L,3L,4L,0L,0L,1L,1L,2L,0L,0L,0L,1L,1L,0L,1L,2L,3L,3L,3L,4L,2L,2L,1L,2L,3L,2L,3L,3L,0L,0L,1L,1L,2L,0L,0L,0L,1L,1L,0L,1L,2L,3L,3L,3L,4L,2L,2L,1L,2L,3L,2L,3L,3L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261084Inst : IEnumerable<long>
{
public static readonly long[] Value=A261084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261084.Bytes);
public long this[int i]=>Value[i];

public static A261084Inst Instance=new A261084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261085
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,6L,7L,8L,10L,11L,13L,14L,15L,15L,17L,19L,20L,22L,23L,24L,26L,16L,18L,20L,21L,22L,22L,23L,24L,23L,24L,25L,26L,28L,29L,31L,33L,33L,34L,36L,37L,39L,40L,40L,41L,44L,47L,34L,35L,49L,51L,52L,54L,54L,55L,57L,58L,59L,58L,59L,62L,48L,49L,50L,66L,69L,71L,73L,74L,74L,76L,55L,57L,59L,60L,61L,63L,63L,65L,68L,69L,71L,72L,74L,62L,64L,65L,66L,67L,67L,70L,72L,73L,75L,76L,77L,80L,81L,75L,77L,79L,79L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261085Inst : IEnumerable<long>
{
public static readonly long[] Value=A261085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261085.Bytes);
public long this[int i]=>Value[i];

public static A261085Inst Instance=new A261085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261086
{
public static readonly long[] Value={ 23L,31L,49L,60L,63L,73L,86L,100L,115L,123L,147L,150L,163L,182L,199L,225L,230L,236L,241L,262L,277L,284L,302L,307L,325L,329L,342L,346L,358L,367L,372L,392L,395L,412L,421L,427L,442L,458L,466L,468L,486L,494L,503L,514L,519L,528L,536L,542L,550L,553L,555L,563L,584L,604L,610L,627L,630L,642L,643L,646L,653L,660L,680L,685L,719L,723L,736L,738L,740L,745L,767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261086Inst : IEnumerable<long>
{
public static readonly long[] Value=A261086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261086.Bytes);
public long this[int i]=>Value[i];

public static A261086Inst Instance=new A261086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261087
{
public static readonly long[] Value={ 83L,127L,227L,281L,307L,367L,443L,541L,631L,677L,853L,863L,967L,1091L,1217L,1427L,1451L,1487L,1523L,1667L,1787L,1861L,1997L,2027L,2153L,2207L,2297L,2339L,2411L,2477L,2543L,2693L,2711L,2837L,2909L,2963L,3089L,3251L,3313L,3323L,3467L,3533L,3593L,3677L,3719L,3797L,3863L,3917L,3989L,4007L,4019L,4091L,4259L,4447L,4493L,4643L,4657L,4783L,4787L,4799L,4877L,4937L,5087L,5119L,5441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261087Inst : IEnumerable<long>
{
public static readonly long[] Value=A261087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261087.Bytes);
public long this[int i]=>Value[i];

public static A261087Inst Instance=new A261087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261088
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,10L,10L,19L,15L,19L,21L,24L,28L,39L,33L,53L,44L,49L,53L,60L,61L,69L,72L,79L,82L,92L,93L,117L,108L,115L,115L,140L,121L,174L,146L,205L,155L,233L,217L,267L,192L,295L,209L,225L,222L,238L,249L,267L,270L,299L,290L,336L,313L,373L,328L,411L,347L,451L,380L,486L,400L,534L,422L,447L,441L,460L,460L,511L,479L,496L,504L,545L,529L,602L,553L,579L,577L,626L,612L,681L,632L,747L,665L,796L,695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261088Inst : IEnumerable<long>
{
public static readonly long[] Value=A261088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261088.Bytes);
public long this[int i]=>Value[i];

public static A261088Inst Instance=new A261088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261089
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,13L,17L,19L,23L,27L,29L,31L,35L,37L,41L,43L,51L,53L,57L,59L,61L,65L,67L,71L,73L,77L,79L,143L,149L,151L,155L,157L,161L,163L,173L,177L,179L,181L,185L,191L,193L,199L,203L,209L,211L,215L,219L,223L,231L,233L,237L,239L,241L,249L,251L,263L,267L,269L,271L,277L,285L,291L,293L,299L,303L,315L,317L,321L,327L,331L,335L,337L,341L,347L,349L,357L,359L,369L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261089Inst : IEnumerable<long>
{
public static readonly long[] Value=A261089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261089.Bytes);
public long this[int i]=>Value[i];

public static A261089Inst Instance=new A261089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261090
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,2L,3L,3L,6L,8L,12L,19L,29L,45L,69L,106L,164L,254L,395L,615L,960L,1500L,2346L,3672L,5751L,9012L,14129L,22159L,34768L,54578L,85730L,134763L,212017L,333860L,526226L,830230L,1311088L,2072264L,3277910L,5188460L,8217094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261090Inst : IEnumerable<long>
{
public static readonly long[] Value=A261090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261090.Bytes);
public long this[int i]=>Value[i];

public static A261090Inst Instance=new A261090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261091
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,5L,8L,11L,17L,25L,37L,56L,85L,130L,199L,305L,469L,723L,1118L,1733L,2693L,4193L,6539L,10211L,15962L,24974L,39103L,61262L,96030L,150608L,236338L,371101L,583118L,916978L,1443204L,2273434L,3584522L,5656786L,8934696L,14123156L,22340250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261091Inst : IEnumerable<long>
{
public static readonly long[] Value=A261091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261091.Bytes);
public long this[int i]=>Value[i];

public static A261091Inst Instance=new A261091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261092
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261092Inst : IEnumerable<long>
{
public static readonly long[] Value=A261092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261092.Bytes);
public long this[int i]=>Value[i];

public static A261092Inst Instance=new A261092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261093
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,7L,7L,7L,8L,9L,10L,10L,11L,12L,12L,12L,13L,14L,15L,15L,16L,17L,17L,18L,19L,20L,20L,20L,20L,21L,22L,23L,23L,24L,25L,25L,26L,27L,28L,28L,28L,29L,30L,31L,31L,32L,33L,33L,33L,33L,34L,35L,36L,36L,37L,38L,38L,39L,40L,41L,41L,41L,42L,43L,44L,44L,45L,46L,46L,46L,47L,48L,49L,49L,50L,51L,51L,52L,53L,54L,54L,54L,54L,54L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261093Inst : IEnumerable<long>
{
public static readonly long[] Value=A261093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261093.Bytes);
public long this[int i]=>Value[i];

public static A261093Inst Instance=new A261093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261094
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,4L,0L,5L,6L,7L,0L,0L,8L,9L,10L,0L,11L,12L,0L,0L,13L,14L,15L,0L,16L,17L,0L,18L,19L,20L,0L,0L,0L,21L,22L,23L,0L,24L,25L,0L,26L,27L,28L,0L,0L,29L,30L,31L,0L,32L,33L,0L,0L,0L,34L,35L,36L,0L,37L,38L,0L,39L,40L,41L,0L,0L,42L,43L,44L,0L,45L,46L,0L,0L,47L,48L,49L,0L,50L,51L,0L,52L,53L,54L,0L,0L,0L,0L,55L,56L,57L,0L,58L,59L,0L,60L,61L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261094Inst : IEnumerable<long>
{
public static readonly long[] Value=A261094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261094.Bytes);
public long this[int i]=>Value[i];

public static A261094Inst Instance=new A261094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261095
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,1L,4L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,1L,4L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,1L,5L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,1L,4L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,1L,5L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,1L,4L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261095Inst : IEnumerable<long>
{
public static readonly long[] Value=A261095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261095.Bytes);
public long this[int i]=>Value[i];

public static A261095Inst Instance=new A261095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261096
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,3L,4L,3L,3L,4L,5L,0L,2L,4L,5L,2L,1L,5L,5L,5L,6L,3L,5L,4L,1L,4L,6L,7L,7L,4L,0L,0L,3L,7L,7L,8L,6L,12L,1L,3L,2L,8L,6L,8L,9L,10L,13L,13L,2L,1L,9L,10L,9L,9L,10L,11L,14L,12L,18L,0L,10L,11L,6L,8L,10L,11L,8L,15L,16L,19L,19L,11L,8L,7L,11L,11L,11L,12L,9L,16L,17L,20L,18L,0L,9L,11L,10L,7L,10L,12L,13L,18L,17L,14L,21L,22L,1L,1L,10L,6L,6L,9L,13L,13L,14L,19L,6L,15L,22L,23L,2L,0L,14L,7L,9L,8L,14L,12L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261096Inst : IEnumerable<long>
{
public static readonly long[] Value=A261096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261096.Bytes);
public long this[int i]=>Value[i];

public static A261096Inst Instance=new A261096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261097
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,3L,3L,4L,3L,4L,2L,0L,5L,4L,5L,5L,5L,1L,2L,5L,6L,4L,1L,4L,5L,3L,6L,7L,7L,3L,0L,0L,4L,7L,7L,8L,6L,8L,2L,3L,1L,12L,6L,8L,9L,9L,10L,9L,1L,2L,13L,13L,10L,9L,10L,8L,6L,11L,10L,0L,18L,12L,14L,11L,10L,11L,11L,11L,7L,8L,11L,19L,19L,16L,15L,8L,11L,12L,10L,7L,10L,11L,9L,0L,18L,20L,17L,16L,9L,12L,13L,13L,9L,6L,6L,10L,1L,1L,22L,21L,14L,17L,18L,13L,14L,12L,14L,8L,9L,7L,14L,0L,2L,23L,22L,15L,6L,19L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261097Inst : IEnumerable<long>
{
public static readonly long[] Value=A261097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261097.Bytes);
public long this[int i]=>Value[i];

public static A261097Inst Instance=new A261097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261098
{
public static readonly long[] Value={ 1L,0L,4L,5L,2L,3L,7L,6L,10L,11L,8L,9L,18L,19L,20L,21L,22L,23L,12L,13L,14L,15L,16L,17L,25L,24L,28L,29L,26L,27L,31L,30L,34L,35L,32L,33L,42L,43L,44L,45L,46L,47L,36L,37L,38L,39L,40L,41L,49L,48L,52L,53L,50L,51L,55L,54L,58L,59L,56L,57L,66L,67L,68L,69L,70L,71L,60L,61L,62L,63L,64L,65L,96L,97L,98L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261098Inst : IEnumerable<long>
{
public static readonly long[] Value=A261098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261098.Bytes);
public long this[int i]=>Value[i];

public static A261098Inst Instance=new A261098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261099
{
public static readonly long[] Value={ 0L,0L,0L,4L,3L,0L,0L,0L,12L,16L,23L,19L,8L,23L,0L,20L,0L,7L,16L,11L,15L,0L,7L,0L,0L,0L,0L,4L,3L,0L,48L,48L,60L,64L,71L,67L,86L,93L,74L,94L,74L,85L,116L,111L,119L,99L,108L,99L,30L,30L,86L,89L,112L,111L,0L,0L,78L,82L,107L,103L,0L,20L,26L,46L,96L,103L,15L,0L,41L,29L,78L,73L,60L,115L,38L,119L,38L,63L,56L,107L,0L,104L,0L,55L,26L,100L,0L,104L,19L,42L,33L,56L,11L,52L,0L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261099Inst : IEnumerable<long>
{
public static readonly long[] Value=A261099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261099.Bytes);
public long this[int i]=>Value[i];

public static A261099Inst Instance=new A261099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261100
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261100Inst : IEnumerable<long>
{
public static readonly long[] Value=A261100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261100.Bytes);
public long this[int i]=>Value[i];

public static A261100Inst Instance=new A261100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261101
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,5L,5L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261101Inst : IEnumerable<long>
{
public static readonly long[] Value=A261101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261101.Bytes);
public long this[int i]=>Value[i];

public static A261101Inst Instance=new A261101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261102
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,7L,6L,10L,9L,8L,15L,14L,13L,12L,11L,23L,22L,21L,20L,19L,18L,17L,16L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,113L,112L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261102Inst : IEnumerable<long>
{
public static readonly long[] Value=A261102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261102.Bytes);
public long this[int i]=>Value[i];

public static A261102Inst Instance=new A261102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261103
{
public static readonly long[] Value={ 0L,1L,3L,7L,11L,9L,13L,15L,19L,19L,25L,27L,27L,33L,37L,47L,43L,49L,49L,55L,57L,56L,58L,58L,71L,75L,83L,23L,25L,31L,35L,37L,49L,51L,49L,53L,57L,61L,65L,63L,77L,75L,79L,85L,87L,87L,91L,91L,99L,109L,109L,115L,117L,117L,123L,127L,127L,133L,139L,141L,141L,143L,149L,147L,159L,151L,157L,165L,167L,179L,187L,193L,205L,211L,213L,209L,215L,213L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261103Inst : IEnumerable<long>
{
public static readonly long[] Value=A261103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261103.Bytes);
public long this[int i]=>Value[i];

public static A261103Inst Instance=new A261103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261104
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,3L,4L,4L,4L,4L,5L,4L,5L,5L,5L,5L,6L,5L,6L,5L,6L,6L,6L,6L,7L,6L,7L,6L,7L,7L,7L,7L,7L,8L,7L,8L,7L,8L,8L,8L,8L,8L,8L,9L,8L,9L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,9L,10L,9L,10L,10L,10L,10L,10L,10L,10L,10L,11L,10L,11L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,11L,12L,11L,12L,12L,12L,12L,12L,12L,12L,12L,13L,12L,13L,12L,13L,13L,13L,13L,13L,13L,13L,13L,14L,13L,14L,13L,14L,14L,14L,14L,14L,14L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261104Inst : IEnumerable<long>
{
public static readonly long[] Value=A261104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261104.Bytes);
public long this[int i]=>Value[i];

public static A261104Inst Instance=new A261104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261105
{
public static readonly BigInteger[] Value={ 28L,52L,278L,1498L,13040L,127038L,2037285L,35551388L,1021480084L,32245216400L,1673092329256L,95096605137684L,8890756299113053L,911310851213791400L,BigInteger.Parse("153607181860224749014"),BigInteger.Parse("28380233483547958852746"),BigInteger.Parse("8623267987086739769774234") };
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
public class A261105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261105Inst Instance=new A261105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261106
{
public static readonly long[] Value={ 28L,33L,63L,97L,183L,289L,547L,865L,1639L,2593L,4915L,7777L,14743L,23329L,44227L,69985L,132679L,209953L,398035L,629857L,1194103L,1889569L,3582307L,5668705L,10746919L,17006113L,32240755L,51018337L,96722263L,153055009L,290166787L,459165025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261106Inst : IEnumerable<long>
{
public static readonly long[] Value=A261106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261106.Bytes);
public long this[int i]=>Value[i];

public static A261106Inst Instance=new A261106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261107
{
public static readonly long[] Value={ 33L,52L,106L,206L,402L,790L,1546L,3026L,5928L,11610L,22736L,44526L,87200L,170774L,334446L,654980L,1282716L,2512082L,4919682L,9634740L,18868742L,36952682L,72368406L,141726816L,277558826L,543573226L,1064537776L,2084798554L,4082884696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261107Inst : IEnumerable<long>
{
public static readonly long[] Value=A261107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261107.Bytes);
public long this[int i]=>Value[i];

public static A261107Inst Instance=new A261107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261108
{
public static readonly long[] Value={ 63L,106L,278L,566L,1408L,2902L,7284L,14942L,37432L,76838L,192624L,395390L,990928L,2034038L,5098214L,10464850L,26228746L,53838574L,134940686L,276986458L,694234628L,1425023498L,3571661670L,7331384958L,18375286712L,37718103630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261108Inst : IEnumerable<long>
{
public static readonly long[] Value=A261108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261108.Bytes);
public long this[int i]=>Value[i];

public static A261108Inst Instance=new A261108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261109
{
public static readonly long[] Value={ 97L,206L,566L,1498L,3908L,10268L,27030L,70980L,186290L,489516L,1286458L,3379154L,8876106L,23319066L,61261972L,160934256L,422777430L,1110660098L,2917747758L,7665011686L,20136272074L,52898777022L,138967021622L,365071414304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261109Inst : IEnumerable<long>
{
public static readonly long[] Value=A261109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261109.Bytes);
public long this[int i]=>Value[i];

public static A261109Inst Instance=new A261109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261110
{
public static readonly long[] Value={ 183L,402L,1408L,3908L,13040L,35934L,121313L,333722L,1122579L,3092874L,10415091L,28671638L,96526178L,265814264L,894920841L,2464173816L,8296223239L,22844373272L,76910486512L,211778585434L,713000156702L,1963298223048L,6609877528867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261110Inst : IEnumerable<long>
{
public static readonly long[] Value=A261110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261110.Bytes);
public long this[int i]=>Value[i];

public static A261110Inst Instance=new A261110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261111
{
public static readonly long[] Value={ 289L,790L,2902L,10268L,35934L,127038L,449132L,1582692L,5580762L,19696792L,69493124L,245136960L,864834010L,3051137218L,10764053222L,37974619476L,133971821170L,472641282700L,1667438793734L,5882591495818L,20753304044252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261111Inst : IEnumerable<long>
{
public static readonly long[] Value=A261111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261111.Bytes);
public long this[int i]=>Value[i];

public static A261111Inst Instance=new A261111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261112
{
public static readonly long[] Value={ 547L,1546L,7284L,27030L,121313L,449132L,2037285L,7510472L,33972401L,125487988L,568045019L,2096976610L,9490614285L,35040037216L,158593916209L,585528496338L,2650104686942L,9784190038600L,44283559200132L,163495032625670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261112Inst : IEnumerable<long>
{
public static readonly long[] Value=A261112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261112.Bytes);
public long this[int i]=>Value[i];

public static A261112Inst Instance=new A261112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261113
{
public static readonly long[] Value={ 28L,33L,33L,63L,52L,63L,97L,106L,106L,97L,183L,206L,278L,206L,183L,289L,402L,566L,566L,402L,289L,547L,790L,1408L,1498L,1408L,790L,547L,865L,1546L,2902L,3908L,3908L,2902L,1546L,865L,1639L,3026L,7284L,10268L,13040L,10268L,7284L,3026L,1639L,2593L,5928L,14942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261113Inst : IEnumerable<long>
{
public static readonly long[] Value=A261113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261113.Bytes);
public long this[int i]=>Value[i];

public static A261113Inst Instance=new A261113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261114
{
public static readonly long[] Value={ 2L,2L,5L,4L,6L,3L,2L,6L,4L,3L,7L,5L,1L,6L,0L,7L,5L,1L,7L,4L,6L,6L,0L,9L,1L,7L,6L,1L,9L,4L,2L,3L,6L,2L,4L,8L,7L,3L,6L,0L,2L,8L,6L,2L,4L,2L,7L,9L,1L,0L,8L,1L,6L,9L,7L,0L,1L,4L,3L,0L,0L,8L,6L,5L,2L,0L,9L,2L,7L,1L,9L,4L,4L,7L,4L,0L,9L,3L,0L,9L,8L,8L,9L,0L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261114Inst : IEnumerable<long>
{
public static readonly long[] Value=A261114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261114.Bytes);
public long this[int i]=>Value[i];

public static A261114Inst Instance=new A261114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261115
{
public static readonly long[] Value={ 1L,2L,0L,0L,3L,2L,0L,0L,3L,4L,0L,0L,2L,2L,0L,0L,2L,2L,0L,0L,3L,2L,0L,0L,4L,2L,0L,0L,1L,6L,0L,0L,2L,2L,0L,0L,4L,2L,0L,0L,2L,0L,0L,0L,4L,2L,0L,0L,1L,4L,0L,0L,2L,4L,0L,0L,2L,4L,0L,0L,1L,2L,0L,0L,8L,0L,0L,0L,2L,4L,0L,0L,2L,2L,0L,0L,2L,2L,0L,0L,0L,2L,0L,0L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261115Inst : IEnumerable<long>
{
public static readonly long[] Value=A261115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261115.Bytes);
public long this[int i]=>Value[i];

public static A261115Inst Instance=new A261115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261116
{
public static readonly long[] Value={ 0L,1L,3L,5L,20L,29L,119L,169L,696L,985L,4059L,5741L,23660L,33461L,137903L,195025L,803760L,1136689L,4684659L,6625109L,27304196L,38613965L,159140519L,225058681L,927538920L,1311738121L,5406093003L,7645370045L,31509019100L,44560482149L,183648021599L,259717522849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261116Inst : IEnumerable<long>
{
public static readonly long[] Value=A261116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261116.Bytes);
public long this[int i]=>Value[i];

public static A261116Inst Instance=new A261116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261117
{
public static readonly long[] Value={ 8L,7L,110L,40L,1497L,894L,315L,48L,166107L,95853L,63609L,71589L,492348L,209628L,388440L,48853L,6118793L,2684186L,25787045L,49643800L,54302036L,3969770538L,17592956651L,7347360617L,991255542L,8249087392L,11518171450L,51385581002L,2268777293L,21252616802L,2822082710511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261117Inst : IEnumerable<long>
{
public static readonly long[] Value=A261117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261117.Bytes);
public long this[int i]=>Value[i];

public static A261117Inst Instance=new A261117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261118
{
public static readonly long[] Value={ 1L,2L,1L,0L,0L,2L,3L,2L,2L,0L,0L,2L,3L,2L,0L,0L,0L,0L,2L,4L,1L,0L,0L,2L,2L,2L,4L,0L,0L,0L,3L,4L,0L,0L,0L,0L,4L,2L,0L,0L,0L,4L,1L,2L,2L,0L,0L,2L,2L,2L,0L,0L,0L,0L,4L,0L,3L,0L,0L,2L,2L,6L,2L,0L,0L,2L,4L,2L,0L,0L,0L,0L,1L,2L,2L,0L,0L,2L,2L,2L,2L,0L,0L,0L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261118Inst : IEnumerable<long>
{
public static readonly long[] Value=A261118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261118.Bytes);
public long this[int i]=>Value[i];

public static A261118Inst Instance=new A261118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261119
{
public static readonly long[] Value={ 1L,2L,2L,2L,0L,0L,1L,2L,4L,0L,0L,0L,0L,4L,2L,2L,0L,0L,3L,2L,2L,2L,0L,0L,2L,2L,2L,0L,0L,0L,0L,2L,2L,2L,0L,0L,3L,2L,4L,2L,0L,0L,0L,6L,2L,0L,0L,0L,0L,2L,4L,0L,0L,0L,2L,2L,2L,4L,0L,0L,1L,0L,2L,0L,0L,0L,0L,2L,6L,2L,0L,0L,2L,4L,0L,2L,0L,0L,4L,4L,0L,0L,0L,0L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261119Inst : IEnumerable<long>
{
public static readonly long[] Value=A261119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261119.Bytes);
public long this[int i]=>Value[i];

public static A261119Inst Instance=new A261119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261120
{
public static readonly long[] Value={ 2L,17L,134L,989L,7082L,50057L,351854L,2467349L,17284562L,121031297L,847337174L,5931714509L,41523064442L,290664639737L,2034662044094L,14242663006469L,99698727138722L,697891348251377L,4885240212600614L,34196683812727229L,239376793662659402L,1675637576559322217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261120Inst : IEnumerable<long>
{
public static readonly long[] Value=A261120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261120.Bytes);
public long this[int i]=>Value[i];

public static A261120Inst Instance=new A261120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261121
{
public static readonly BigInteger[] Value={ 0L,0L,0L,35L,148931620L,BigInteger.Parse("145695442998205937771172926213510853765") };
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
public class A261121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261121Inst Instance=new A261121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261122
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,1L,-2L,-1L,2L,1L,-1L,-2L,2L,1L,0L,-2L,2L,1L,0L,-1L,0L,2L,-2L,-2L,0L,1L,-3L,0L,1L,2L,-2L,-2L,2L,1L,-2L,0L,4L,1L,0L,0L,0L,2L,0L,-2L,0L,2L,-2L,0L,0L,1L,-3L,-3L,0L,0L,-2L,-1L,4L,2L,0L,-2L,2L,2L,0L,-2L,2L,1L,0L,-2L,0L,0L,0L,-4L,0L,1L,-2L,0L,3L,0L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261122Inst : IEnumerable<long>
{
public static readonly long[] Value=A261122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261122.Bytes);
public long this[int i]=>Value[i];

public static A261122Inst Instance=new A261122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261123
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261123Inst : IEnumerable<long>
{
public static readonly long[] Value=A261123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261123.Bytes);
public long this[int i]=>Value[i];

public static A261123Inst Instance=new A261123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261124
{
public static readonly long[] Value={ 2L,1L,9L,1L,8L,3L,7L,4L,0L,3L,1L,9L,7L,1L,2L,6L,3L,0L,6L,4L,7L,8L,6L,9L,9L,5L,0L,2L,8L,5L,7L,5L,3L,6L,4L,9L,1L,1L,0L,6L,1L,8L,3L,5L,0L,7L,5L,8L,2L,4L,5L,0L,3L,8L,1L,5L,6L,3L,4L,4L,9L,2L,7L,7L,9L,1L,6L,4L,2L,8L,1L,3L,0L,3L,1L,8L,2L,8L,4L,1L,1L,5L,0L,4L,3L,0L,0L,7L,6L,4L,3L,6L,3L,8L,8L,8L,7L,3L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261124Inst : IEnumerable<long>
{
public static readonly long[] Value=A261124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261124.Bytes);
public long this[int i]=>Value[i];

public static A261124Inst Instance=new A261124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261125
{
public static readonly BigInteger[] Value={ 1L,2L,48L,1935360L,BigInteger.Parse("40493130637639680000"),BigInteger.Parse("10654991354747516157752604498631700563938508800000000000") };
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
public class A261125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261125Inst Instance=new A261125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261126
{
public static readonly long[] Value={ 2L,2L,1L,2L,1L,1L,2L,2L,2L,1L,1L,3L,2L,3L,2L,2L,3L,3L,3L,3L,2L,4L,3L,4L,3L,3L,4L,4L,4L,4L,3L,5L,4L,5L,4L,4L,5L,5L,5L,5L,2L,4L,3L,4L,3L,3L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261126Inst : IEnumerable<long>
{
public static readonly long[] Value=A261126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261126.Bytes);
public long this[int i]=>Value[i];

public static A261126Inst Instance=new A261126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261127
{
public static readonly long[] Value={ 0L,3L,10L,105L,120L,136L,190L,210L,300L,406L,703L,780L,820L,1081L,1128L,1431L,1540L,1653L,1770L,1891L,1953L,2080L,2211L,2628L,2701L,2850L,3003L,3160L,3403L,3570L,4560L,4656L,5050L,5460L,7021L,7260L,7503L,8646L,8911L,9453L,10011L,10153L,11026L,12403L,14028L,15400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261127Inst : IEnumerable<long>
{
public static readonly long[] Value=A261127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261127.Bytes);
public long this[int i]=>Value[i];

public static A261127Inst Instance=new A261127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261128
{
public static readonly BigInteger[] Value={ 7L,7L,127L,55987L,199411801L,3011076302521L,139507830379527121L,BigInteger.Parse("16393413624509530430641"),BigInteger.Parse("4296688920209982460579470721"),BigInteger.Parse("2283386315992292963858620174289281"),BigInteger.Parse("2283380652830226414943490202201665068801"),BigInteger.Parse("4045147099313653802803680147635052518194156801") };
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
public class A261128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261128Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261128.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261128.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261128Inst Instance=new A261128Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261129
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,3L,3L,3L,4L,4L,2L,3L,3L,3L,2L,2L,3L,3L,2L,2L,3L,3L,3L,3L,4L,4L,2L,2L,3L,3L,3L,3L,4L,4L,3L,3L,4L,4L,4L,4L,5L,5L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,3L,3L,3L,4L,4L,2L,4L,4L,4L,3L,3L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261129Inst : IEnumerable<long>
{
public static readonly long[] Value=A261129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261129.Bytes);
public long this[int i]=>Value[i];

public static A261129Inst Instance=new A261129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261130
{
public static readonly long[] Value={ 1L,2L,3L,5L,35L,7L,77L,143L,143L,2431L,46189L,4199L,96577L,7429L,7429L,215441L,6678671L,392863L,392863L,765049L,765049L,31367009L,1348781387L,58642669L,2756205443L,2756205443L,2756205443L,146078888479L,146078888479L,5037203051L,297194980009L,584803025179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261130Inst : IEnumerable<long>
{
public static readonly long[] Value=A261130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261130.Bytes);
public long this[int i]=>Value[i];

public static A261130Inst Instance=new A261130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261131
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,4L,5L,7L,8L,10L,11L,13L,13L,15L,14L,15L,14L,14L,12L,12L,9L,9L,8L,7L,6L,6L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,5L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,5L,8L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261131Inst : IEnumerable<long>
{
public static readonly long[] Value=A261131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261131.Bytes);
public long this[int i]=>Value[i];

public static A261131Inst Instance=new A261131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261132
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,13L,15L,16L,17L,17L,18L,17L,17L,16L,15L,13L,12L,11L,10L,9L,8L,7L,7L,6L,6L,6L,6L,5L,7L,6L,6L,6L,6L,6L,6L,6L,6L,6L,5L,8L,7L,7L,7L,7L,7L,7L,7L,7L,7L,5L,9L,7L,7L,7L,7L,7L,7L,7L,7L,7L,5L,11L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L,12L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261132Inst : IEnumerable<long>
{
public static readonly long[] Value=A261132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261132.Bytes);
public long this[int i]=>Value[i];

public static A261132Inst Instance=new A261132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261133
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,22L,22L,23L,23L,24L,25L,25L,26L,26L,27L,28L,28L,29L,29L,30L,31L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,38L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261133Inst : IEnumerable<long>
{
public static readonly long[] Value=A261133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261133.Bytes);
public long this[int i]=>Value[i];

public static A261133Inst Instance=new A261133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261134
{
public static readonly long[] Value={ 1L,2L,4L,9L,23L,66L,209L,722L,2697L,10825L,46429L,211799L,1023304L,5217048L,27974458L,157310519L,925326848L,5680341820L,36315837763L,241348819913L,1664484383610L,11893800649953L,87931422125632L,671699288516773L,5295185052962371L,43029828113547685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261134Inst : IEnumerable<long>
{
public static readonly long[] Value=A261134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261134.Bytes);
public long this[int i]=>Value[i];

public static A261134Inst Instance=new A261134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261135
{
public static readonly BigInteger[] Value={ 1L,22L,475L,20188L,1472229L,112441134L,8415721847L,1234163177336L,336405959636873L,95454487901599898L,BigInteger.Parse("26891544907776231851"),BigInteger.Parse("7513814442828887530172"),BigInteger.Parse("2084725487959034609380301"),BigInteger.Parse("574954374994698424018451678"),BigInteger.Parse("157752074714160807772190133743"),BigInteger.Parse("86177704805459827544499089423856") };
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
public class A261135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261135Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261135.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261135Inst Instance=new A261135Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261136
{
public static readonly long[] Value={ 3L,7L,71L,103L,173L,211L,271L,293L,1117L,1451L,1531L,1753L,1787L,1801L,2089L,2239L,2341L,2371L,2713L,2999L,3019L,3779L,3881L,3917L,4159L,4447L,4513L,4591L,4969L,5107L,5483L,5573L,5591L,5701L,5813L,5867L,6011L,6271L,6311L,6361L,6397L,6427L,7243L,8467L,8513L,9157L,9343L,9433L,9719L,10103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261136Inst : IEnumerable<long>
{
public static readonly long[] Value=A261136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261136.Bytes);
public long this[int i]=>Value[i];

public static A261136Inst Instance=new A261136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261137
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,3L,4L,0L,0L,0L,5L,10L,11L,0L,0L,1L,11L,31L,40L,41L,0L,0L,0L,21L,91L,147L,161L,162L,0L,0L,1L,43L,274L,568L,694L,714L,715L,0L,0L,0L,85L,820L,2227L,3151L,3397L,3424L,3425L,0L,0L,1L,171L,2461L,8824L,14851L,17251L,17686L,17721L,17722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261137Inst : IEnumerable<long>
{
public static readonly long[] Value=A261137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261137.Bytes);
public long this[int i]=>Value[i];

public static A261137Inst Instance=new A261137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261138
{
public static readonly BigInteger[] Value={ 11L,1221L,123321L,12344321L,1234554321L,123456654321L,12345677654321L,1234567887654321L,123456789987654321L,BigInteger.Parse("1234567891001987654321"),BigInteger.Parse("12345678910111101987654321"),BigInteger.Parse("123456789101112211101987654321"),BigInteger.Parse("1234567891011121331211101987654321") };
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
public class A261138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261138Inst Instance=new A261138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261139
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,2L,1L,0L,0L,0L,5L,5L,1L,0L,0L,1L,10L,20L,9L,1L,0L,0L,0L,21L,70L,56L,14L,1L,0L,0L,1L,42L,231L,294L,126L,20L,1L,0L,0L,0L,85L,735L,1407L,924L,246L,27L,1L,0L,0L,1L,170L,2290L,6363L,6027L,2400L,435L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261139Inst : IEnumerable<long>
{
public static readonly long[] Value=A261139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261139.Bytes);
public long this[int i]=>Value[i];

public static A261139Inst Instance=new A261139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261140
{
public static readonly long[] Value={ 3486107472997423L,3857999048522893L,4229890624048363L,4601782199573833L,4973673775099303L,5345565350624773L,5717456926150243L,6089348501675713L,6461240077201183L,6833131652726653L,7205023228252123L,7576914803777593L,7948806379303063L,8320697954828533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261140Inst : IEnumerable<long>
{
public static readonly long[] Value=A261140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261140.Bytes);
public long this[int i]=>Value[i];

public static A261140Inst Instance=new A261140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261141
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,21L,25L,27L,33L,43L,45L,55L,63L,75L,81L,85L,99L,105L,121L,125L,129L,135L,165L,171L,189L,215L,225L,231L,243L,255L,275L,297L,315L,341L,363L,375L,387L,405L,425L,441L,473L,495L,513L,525L,567L,605L,625L,645L,675L,683L,693L,729L,765L,825L,855L,891L,903L,935L,945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261141Inst : IEnumerable<long>
{
public static readonly long[] Value=A261141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261141.Bytes);
public long this[int i]=>Value[i];

public static A261141Inst Instance=new A261141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261142
{
public static readonly long[] Value={ 88L,248L,826L,1417L,1571L,1595L,3682L,3928L,4448L,5089L,5137L,6479L,7754L,8038L,8384L,8461L,9257L,9640L,10393L,10825L,10922L,11878L,13294L,14290L,14767L,14941L,15977L,16786L,17684L,17777L,17935L,18437L,18677L,19495L,20497L,20555L,21649L,22487L,23239L,23396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261142Inst : IEnumerable<long>
{
public static readonly long[] Value=A261142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261142.Bytes);
public long this[int i]=>Value[i];

public static A261142Inst Instance=new A261142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261143
{
public static readonly long[] Value={ 3L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261143Inst : IEnumerable<long>
{
public static readonly long[] Value=A261143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261143.Bytes);
public long this[int i]=>Value[i];

public static A261143Inst Instance=new A261143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261144
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,6L,1L,2L,3L,5L,6L,10L,15L,30L,1L,2L,3L,5L,6L,7L,10L,14L,15L,21L,30L,35L,42L,70L,105L,210L,1L,2L,3L,5L,6L,7L,10L,11L,14L,15L,21L,22L,30L,33L,35L,42L,55L,66L,70L,77L,105L,110L,154L,165L,210L,231L,330L,385L,462L,770L,1155L,2310L,1L,2L,3L,5L,6L,7L,10L,11L,13L,14L,15L,21L,22L,26L,30L,33L,35L,39L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261144Inst : IEnumerable<long>
{
public static readonly long[] Value=A261144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261144.Bytes);
public long this[int i]=>Value[i];

public static A261144Inst Instance=new A261144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261145
{
public static readonly long[] Value={ 2L,4L,7L,11L,25L,38L,47L,94L,95L,155L,275L,277L,292L,299L,395L,409L,614L,1409L,1963L,3422L,5243L,5884L,5971L,8527L,10882L,13223L,16406L,20851L,28886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261145Inst : IEnumerable<long>
{
public static readonly long[] Value=A261145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261145.Bytes);
public long this[int i]=>Value[i];

public static A261145Inst Instance=new A261145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261146
{
public static readonly BigInteger[] Value={ 4L,4L,6L,27L,BigInteger.Parse("13407807929942597099574024998205846127479365820592393377723561443721764030073546976801874298166903427690031858186486050853753882811946569946433649006084096") };
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
public class A261146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A261146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261146Inst Instance=new A261146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261147
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,7L,5L,8L,13L,14L,9L,10L,12L,20L,21L,15L,22L,24L,23L,6L,11L,17L,16L,18L,25L,19L,27L,26L,28L,29L,38L,30L,31L,32L,33L,34L,35L,36L,37L,39L,41L,40L,42L,44L,43L,45L,47L,48L,49L,51L,46L,57L,53L,50L,55L,59L,52L,62L,58L,111L,65L,61L,54L,72L,63L,67L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261147Inst : IEnumerable<long>
{
public static readonly long[] Value=A261147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261147.Bytes);
public long this[int i]=>Value[i];

public static A261147Inst Instance=new A261147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261148
{
public static readonly long[] Value={ 3L,11L,31L,59L,83L,211L,331L,773L,1297L,1433L,1471L,1621L,2027L,2477L,3637L,4153L,4787L,4877L,5623L,7699L,9103L,9619L,11743L,12097L,12959L,13037L,13591L,13709L,14177L,14969L,15299L,16411L,16703L,16921L,19463L,19577L,21379L,22093L,22721L,24107L,24151L,24419L,24509L,24671L,28657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261148Inst : IEnumerable<long>
{
public static readonly long[] Value=A261148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261148.Bytes);
public long this[int i]=>Value[i];

public static A261148Inst Instance=new A261148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261149
{
public static readonly long[] Value={ 515486946529943L,546012967024913L,576538987519883L,607065008014853L,637591028509823L,668117049004793L,698643069499763L,729169089994733L,759695110489703L,790221130984673L,820747151479643L,851273171974613L,881799192469583L,912325212964553L,942851233459523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261149Inst : IEnumerable<long>
{
public static readonly long[] Value=A261149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261149.Bytes);
public long this[int i]=>Value[i];

public static A261149Inst Instance=new A261149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261150
{
public static readonly long[] Value={ 403185216600637L,405309730001647L,407434243402657L,409558756803667L,411683270204677L,413807783605687L,415932297006697L,418056810407707L,420181323808717L,422305837209727L,424430350610737L,426554864011747L,428679377412757L,430803890813767L,432928404214777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261150Inst : IEnumerable<long>
{
public static readonly long[] Value=A261150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261150.Bytes);
public long this[int i]=>Value[i];

public static A261150Inst Instance=new A261150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261151
{
public static readonly long[] Value={ 11410337850553L,11871247719973L,12332157589393L,12793067458813L,13253977328233L,13714887197653L,14175797067073L,14636706936493L,15097616805913L,15558526675333L,16019436544753L,16480346414173L,16941256283593L,17402166153013L,17863076022433L,18323985891853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261151Inst : IEnumerable<long>
{
public static readonly long[] Value=A261151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261151.Bytes);
public long this[int i]=>Value[i];

public static A261151Inst Instance=new A261151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261152
{
public static readonly long[] Value={ 161004359399459161L,171649260008631991L,182294160617804821L,192939061226977651L,203583961836150481L,214228862445323311L,224873763054496141L,235518663663668971L,246163564272841801L,256808464882014631L,267453365491187461L,278098266100360291L,288743166709533121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261152Inst : IEnumerable<long>
{
public static readonly long[] Value=A261152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261152.Bytes);
public long this[int i]=>Value[i];

public static A261152Inst Instance=new A261152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261153
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,0L,2L,2L,2L,3L,1L,3L,2L,3L,3L,3L,4L,3L,3L,3L,4L,3L,4L,3L,4L,4L,4L,5L,4L,5L,4L,4L,4L,5L,4L,5L,4L,5L,5L,5L,6L,5L,5L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261153Inst : IEnumerable<long>
{
public static readonly long[] Value=A261153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261153.Bytes);
public long this[int i]=>Value[i];

public static A261153Inst Instance=new A261153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261154
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,11L,14L,18L,24L,30L,38L,48L,60L,75L,92L,114L,140L,170L,208L,252L,304L,366L,439L,526L,626L,744L,884L,1044L,1232L,1451L,1704L,1998L,2336L,2730L,3182L,3700L,4300L,4986L,5772L,6672L,7700L,8876L,10212L,11736L,13472L,15438L,17673L,20207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261154Inst : IEnumerable<long>
{
public static readonly long[] Value=A261154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261154.Bytes);
public long this[int i]=>Value[i];

public static A261154Inst Instance=new A261154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261155
{
public static readonly long[] Value={ 4L,11L,16L,19L,23L,26L,29L,32L,34L,37L,39L,41L,44L,46L,47L,49L,51L,53L,54L,56L,58L,59L,61L,62L,64L,65L,67L,68L,69L,71L,72L,74L,74L,76L,77L,79L,79L,81L,82L,83L,84L,86L,86L,88L,89L,89L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261155Inst : IEnumerable<long>
{
public static readonly long[] Value=A261155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261155.Bytes);
public long this[int i]=>Value[i];

public static A261155Inst Instance=new A261155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261156
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,8L,12L,16L,22L,28L,36L,48L,60L,76L,96L,120L,150L,184L,228L,280L,340L,416L,504L,608L,732L,878L,1052L,1252L,1488L,1768L,2088L,2464L,2902L,3408L,3996L,4672L,5460L,6364L,7400L,8600L,9972L,11544L,13344L,15400L,17752L,20424L,23472L,26944L,30876L,35346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261156Inst : IEnumerable<long>
{
public static readonly long[] Value=A261156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261156.Bytes);
public long this[int i]=>Value[i];

public static A261156Inst Instance=new A261156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261157
{
public static readonly long[] Value={ 2L,1L,8L,9L,12L,2L,5L,12L,2L,6L,2L,5L,12L,2L,9L,5L,11L,1L,2L,5L,12L,2L,6L,5L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261157Inst : IEnumerable<long>
{
public static readonly long[] Value=A261157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261157.Bytes);
public long this[int i]=>Value[i];

public static A261157Inst Instance=new A261157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261158
{
public static readonly long[] Value={ 3L,0L,1L,4L,32L,2L,2L,2L,2L,2L,2L,10L,10L,10L,10L,10L,10L,10L,2L,2L,2L,8L,2L,2L,8L,2L,2L,8L,2L,2L,8L,2L,2L,8L,2L,2L,8L,2L,5L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261158Inst : IEnumerable<long>
{
public static readonly long[] Value=A261158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261158.Bytes);
public long this[int i]=>Value[i];

public static A261158Inst Instance=new A261158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261159
{
public static readonly long[] Value={ 5L,7L,1L,11L,2L,1L,3L,13L,2L,2L,1L,3L,12L,13L,0L,7L,3L,11L,1L,5L,41L,12L,0L,7L,1L,5L,11L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261159Inst : IEnumerable<long>
{
public static readonly long[] Value=A261159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261159.Bytes);
public long this[int i]=>Value[i];

public static A261159Inst Instance=new A261159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261160
{
public static readonly long[] Value={ 2L,1L,0L,100L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,10L,62L,20L,63L,110L,64L,65L,30L,66L,67L,120L,68L,69L,71L,40L,72L,73L,74L,130L,75L,76L,77L,78L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261160Inst : IEnumerable<long>
{
public static readonly long[] Value=A261160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261160.Bytes);
public long this[int i]=>Value[i];

public static A261160Inst Instance=new A261160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261161
{
public static readonly long[] Value={ 2L,0L,1L,10L,12L,3L,4L,5L,6L,7L,8L,9L,20L,13L,22L,23L,24L,25L,26L,21L,27L,31L,28L,29L,14L,30L,32L,15L,33L,34L,41L,35L,36L,37L,51L,38L,39L,40L,42L,16L,43L,44L,45L,46L,17L,47L,48L,49L,50L,52L,53L,54L,55L,56L,61L,57L,58L,59L,60L,62L,63L,71L,64L,65L,66L,67L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261161Inst : IEnumerable<long>
{
public static readonly long[] Value=A261161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261161.Bytes);
public long this[int i]=>Value[i];

public static A261161Inst Instance=new A261161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261162
{
public static readonly long[] Value={ 1L,2L,0L,3L,22L,4L,5L,6L,20L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,30L,12L,31L,33L,32L,34L,35L,36L,23L,37L,38L,39L,40L,41L,43L,44L,45L,46L,42L,47L,48L,49L,52L,50L,51L,53L,54L,24L,55L,56L,57L,58L,25L,59L,60L,61L,63L,62L,64L,65L,66L,67L,68L,72L,69L,70L,71L,73L,74L,75L,82L,76L,77L,78L,79L,80L,81L,83L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261162Inst : IEnumerable<long>
{
public static readonly long[] Value=A261162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261162.Bytes);
public long this[int i]=>Value[i];

public static A261162Inst Instance=new A261162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261163
{
public static readonly long[] Value={ 1L,3L,0L,2L,4L,33L,5L,6L,30L,7L,8L,9L,31L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,32L,28L,29L,34L,40L,41L,13L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,35L,59L,60L,61L,36L,62L,64L,65L,23L,66L,67L,68L,69L,43L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,84L,85L,86L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261163Inst : IEnumerable<long>
{
public static readonly long[] Value=A261163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261163.Bytes);
public long this[int i]=>Value[i];

public static A261163Inst Instance=new A261163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261164
{
public static readonly long[] Value={ 1L,4L,0L,2L,3L,5L,44L,6L,7L,40L,8L,9L,41L,10L,11L,42L,12L,13L,15L,16L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,14L,36L,37L,38L,43L,39L,50L,51L,45L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,24L,73L,75L,76L,77L,46L,78L,79L,80L,81L,47L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261164Inst : IEnumerable<long>
{
public static readonly long[] Value=A261164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261164.Bytes);
public long this[int i]=>Value[i];

public static A261164Inst Instance=new A261164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261165
{
public static readonly long[] Value={ 1L,5L,0L,2L,3L,4L,6L,55L,7L,8L,50L,9L,15L,10L,11L,51L,12L,13L,25L,14L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,43L,35L,44L,46L,47L,45L,48L,49L,60L,61L,52L,62L,63L,64L,66L,67L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L,84L,86L,87L,88L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261165Inst : IEnumerable<long>
{
public static readonly long[] Value=A261165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261165.Bytes);
public long this[int i]=>Value[i];

public static A261165Inst Instance=new A261165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261166
{
public static readonly long[] Value={ 1L,6L,0L,2L,3L,4L,5L,7L,66L,8L,9L,60L,10L,61L,11L,16L,12L,13L,26L,14L,15L,17L,36L,18L,19L,20L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,62L,54L,55L,57L,46L,58L,59L,70L,71L,56L,72L,73L,74L,75L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261166Inst : IEnumerable<long>
{
public static readonly long[] Value=A261166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261166.Bytes);
public long this[int i]=>Value[i];

public static A261166Inst Instance=new A261166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261167
{
public static readonly long[] Value={ 1L,7L,0L,2L,3L,4L,5L,6L,8L,77L,9L,17L,10L,27L,11L,12L,70L,13L,14L,71L,15L,16L,37L,18L,19L,20L,21L,72L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,73L,64L,65L,66L,68L,74L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261167Inst : IEnumerable<long>
{
public static readonly long[] Value=A261167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261167.Bytes);
public long this[int i]=>Value[i];

public static A261167Inst Instance=new A261167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261168
{
public static readonly long[] Value={ 1L,8L,0L,2L,3L,4L,5L,6L,7L,9L,88L,10L,80L,11L,81L,12L,18L,13L,14L,28L,15L,16L,17L,82L,19L,20L,21L,83L,22L,23L,24L,25L,84L,26L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,38L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261168Inst : IEnumerable<long>
{
public static readonly long[] Value=A261168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261168.Bytes);
public long this[int i]=>Value[i];

public static A261168Inst Instance=new A261168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261169
{
public static readonly long[] Value={ 1L,9L,0L,2L,3L,4L,5L,6L,7L,8L,19L,90L,29L,10L,39L,11L,12L,91L,13L,14L,92L,15L,16L,49L,17L,18L,20L,59L,21L,22L,23L,24L,93L,25L,26L,27L,28L,30L,31L,32L,33L,34L,94L,35L,36L,37L,38L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,65L,66L,67L,68L,70L,71L,72L,73L,74L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261169Inst : IEnumerable<long>
{
public static readonly long[] Value=A261169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261169.Bytes);
public long this[int i]=>Value[i];

public static A261169Inst Instance=new A261169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261170
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,9L,17L,20L,31L,38L,43L,64L,64L,70L,91L,93L,102L,117L,120L,123L,127L,127L,127L,136L,160L,166L,176L,235L,321L,351L,353L,389L,403L,418L,418L,421L,422L,466L,542L,578L,579L,703L,706L,725L,731L,765L,780L,792L,795L,799L,803L,839L,840L,848L,849L,863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261170Inst : IEnumerable<long>
{
public static readonly long[] Value=A261170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261170.Bytes);
public long this[int i]=>Value[i];

public static A261170Inst Instance=new A261170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261171
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,6L,9L,10L,13L,16L,16L,21L,23L,23L,29L,28L,38L,39L,33L,34L,41L,40L,37L,37L,41L,42L,44L,64L,77L,82L,75L,83L,83L,87L,104L,104L,86L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261171Inst : IEnumerable<long>
{
public static readonly long[] Value=A261171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261171.Bytes);
public long this[int i]=>Value[i];

public static A261171Inst Instance=new A261171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261172
{
public static readonly long[] Value={ 2L,3L,2L,4L,3L,6L,9L,10L,11L,16L,12L,14L,22L,18L,25L,20L,2L,6L,18L,14L,7L,40L,31L,25L,23L,20L,22L,62L,65L,68L,29L,23L,38L,26L,104L,6L,34L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261172Inst : IEnumerable<long>
{
public static readonly long[] Value=A261172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261172.Bytes);
public long this[int i]=>Value[i];

public static A261172Inst Instance=new A261172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261173
{
public static readonly long[] Value={ 11L,0L,101L,0L,0L,0L,0L,10111L,0L,0L,0L,101111L,0L,0L,0L,0L,0L,0L,1011001L,0L,0L,0L,11110111L,0L,10011101L,10010101L,0L,0L,0L,101111111L,101101111L,0L,100100111L,101001001L,0L,0L,0L,0L,1010111111L,1001110111L,0L,1000011011L,1000001011L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261173Inst : IEnumerable<long>
{
public static readonly long[] Value=A261173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261173.Bytes);
public long this[int i]=>Value[i];

public static A261173Inst Instance=new A261173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261174
{
public static readonly long[] Value={ 1L,2L,9L,30L,90L,248L,650L,1560L,3560L,7680L,15786L,31076L,58905L,107768L,191180L,329664L,554038L,909558L,1461655L,2302950L,3563482L,5422392L,8124040L,11997648L,17482295L,25156872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261174Inst : IEnumerable<long>
{
public static readonly long[] Value=A261174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261174.Bytes);
public long this[int i]=>Value[i];

public static A261174Inst Instance=new A261174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261175
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,8L,13L,19L,26L,35L,45L,56L,69L,84L,100L,117L,137L,158L,180L,204L,231L,258L,288L,319L,352L,387L,424L,463L,503L,546L,590L,636L,684L,734L,786L,840L,897L,955L,1015L,1077L,1141L,1207L,1275L,1345L,1418L,1492L,1568L,1647L,1728L,1811L,1896L,1983L,2072L,2163L,2257L,2352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261175Inst : IEnumerable<long>
{
public static readonly long[] Value=A261175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261175.Bytes);
public long this[int i]=>Value[i];

public static A261175Inst Instance=new A261175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261176
{
public static readonly long[] Value={ 0L,9L,126L,802L,3158L,10040L,25464L,58837L,123422L,238203L,429467L,733923L,1200319L,1912928L,2945116L,4369570L,6338678L,9053512L,12622814L,17359779L,23503546L,31347788L,41161317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261176Inst : IEnumerable<long>
{
public static readonly long[] Value=A261176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261176.Bytes);
public long this[int i]=>Value[i];

public static A261176Inst Instance=new A261176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261177
{
public static readonly long[] Value={ 0L,10L,180L,1392L,6149L,21350L,57192L,137617L,298864L,593378L,1101739L,1936342L,3216080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261177Inst : IEnumerable<long>
{
public static readonly long[] Value=A261177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261177.Bytes);
public long this[int i]=>Value[i];

public static A261177Inst Instance=new A261177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261178
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261178Inst : IEnumerable<long>
{
public static readonly long[] Value=A261178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261178.Bytes);
public long this[int i]=>Value[i];

public static A261178Inst Instance=new A261178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261179
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,5L,5L,7L,7L,7L,5L,11L,11L,13L,9L,13L,11L,9L,11L,13L,15L,13L,19L,17L,11L,19L,17L,21L,19L,13L,7L,13L,19L,23L,29L,25L,23L,25L,27L,31L,29L,31L,13L,13L,25L,23L,31L,17L,23L,27L,25L,19L,17L,17L,9L,19L,27L,21L,37L,31L,35L,41L,41L,37L,33L,29L,49L,37L,49L,41L,27L,41L,33L,41L,31L,15L,31L,39L,33L,41L,41L,49L,37L,35L,41L,39L,19L,37L,41L,31L,43L,23L,31L,37L,27L,23L,15L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261179Inst : IEnumerable<long>
{
public static readonly long[] Value=A261179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261179.Bytes);
public long this[int i]=>Value[i];

public static A261179Inst Instance=new A261179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261180
{
public static readonly long[] Value={ 0L,1L,3L,2L,0L,0L,5L,0L,1L,1L,3L,4L,2L,1L,2L,3L,3L,5L,0L,4L,3L,2L,3L,5L,4L,2L,2L,1L,0L,1L,3L,2L,0L,0L,5L,0L,1L,3L,2L,0L,0L,5L,4L,5L,5L,1L,2L,0L,5L,0L,1L,3L,2L,0L,0L,5L,0L,1L,1L,3L,4L,2L,1L,0L,1L,1L,3L,4L,2L,1L,2L,3L,3L,5L,0L,4L,3L,4L,5L,1L,0L,4L,4L,3L,2L,3L,5L,4L,2L,2L,1L,0L,1L,1L,3L,4L,2L,1L,2L,3L,5L,4L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261180Inst : IEnumerable<long>
{
public static readonly long[] Value=A261180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261180.Bytes);
public long this[int i]=>Value[i];

public static A261180Inst Instance=new A261180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261181
{
public static readonly long[] Value={ 7L,79L,97L,709L,797L,907L,977L,997L,7079L,7907L,9007L,9907L,70009L,70079L,70099L,70709L,70979L,70997L,70999L,77797L,77977L,77999L,79777L,79907L,79979L,79997L,79999L,90007L,90709L,90907L,90977L,90997L,97007L,97777L,99079L,99707L,99709L,99907L,700079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261181Inst : IEnumerable<long>
{
public static readonly long[] Value=A261181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261181.Bytes);
public long this[int i]=>Value[i];

public static A261181Inst Instance=new A261181Inst();

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