using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A257682
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,5L,6L,7L,8L,9L,10L,10L,11L,12L,13L,13L,14L,14L,15L,16L,17L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,42L,43L,44L,45L,45L,46L,47L,48L,49L,50L,51L,52L,52L,53L,54L,55L,55L,56L,56L,57L,58L,59L,59L,60L,60L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257682Inst : IEnumerable<long>
{
public static readonly long[] Value=A257682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257682.Bytes);
public long this[int i]=>Value[i];

public static A257682Inst Instance=new A257682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257683
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,8L,11L,9L,12L,10L,14L,13L,15L,16L,19L,17L,20L,18L,23L,21L,24L,22L,27L,25L,29L,28L,30L,26L,31L,32L,35L,33L,36L,34L,39L,37L,40L,38L,44L,41L,46L,45L,47L,42L,48L,43L,52L,49L,54L,53L,55L,50L,58L,56L,59L,51L,61L,57L,62L,60L,63L,64L,67L,65L,68L,66L,71L,69L,72L,70L,76L,73L,78L,77L,79L,74L,80L,75L,84L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257683Inst : IEnumerable<long>
{
public static readonly long[] Value=A257683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257683.Bytes);
public long this[int i]=>Value[i];

public static A257683Inst Instance=new A257683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257684
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,7L,7L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,10L,10L,10L,10L,11L,11L,12L,12L,12L,12L,13L,13L,12L,12L,12L,12L,13L,13L,14L,14L,14L,14L,15L,15L,16L,16L,16L,16L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257684Inst : IEnumerable<long>
{
public static readonly long[] Value=A257684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257684.Bytes);
public long this[int i]=>Value[i];

public static A257684Inst Instance=new A257684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257685
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,3L,0L,4L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,9L,0L,10L,0L,0L,0L,11L,0L,12L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,14L,0L,0L,0L,15L,0L,16L,0L,0L,0L,17L,0L,18L,0L,0L,0L,19L,0L,0L,0L,0L,0L,0L,0L,20L,0L,0L,0L,21L,0L,22L,0L,0L,0L,23L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257685Inst : IEnumerable<long>
{
public static readonly long[] Value=A257685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257685.Bytes);
public long this[int i]=>Value[i];

public static A257685Inst Instance=new A257685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257686
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,4L,6L,6L,6L,6L,6L,6L,12L,12L,12L,12L,12L,12L,18L,18L,18L,18L,18L,18L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,24L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257686Inst : IEnumerable<long>
{
public static readonly long[] Value=A257686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257686.Bytes);
public long this[int i]=>Value[i];

public static A257686Inst Instance=new A257686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257687
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257687Inst : IEnumerable<long>
{
public static readonly long[] Value=A257687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257687.Bytes);
public long this[int i]=>Value[i];

public static A257687Inst Instance=new A257687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257688
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,53L,55L,59L,61L,67L,71L,73L,79L,83L,87L,89L,91L,97L,101L,103L,107L,109L,113L,115L,117L,127L,131L,137L,139L,143L,145L,149L,151L,157L,163L,167L,171L,173L,179L,181L,185L,191L,193L,197L,199L,203L,211L,213L,223L,227L,229L,233L,239L,241L,247L,251L,253L,257L,263L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257688Inst : IEnumerable<long>
{
public static readonly long[] Value=A257688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257688.Bytes);
public long this[int i]=>Value[i];

public static A257688Inst Instance=new A257688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257689
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,77L,79L,83L,89L,91L,97L,101L,103L,107L,109L,113L,115L,119L,121L,127L,131L,137L,139L,143L,149L,151L,157L,161L,163L,167L,173L,175L,179L,181L,191L,193L,197L,199L,209L,211L,221L,223L,227L,229L,233L,235L,239L,241L,247L,251L,257L,263L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257689Inst : IEnumerable<long>
{
public static readonly long[] Value=A257689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257689.Bytes);
public long this[int i]=>Value[i];

public static A257689Inst Instance=new A257689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257690
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,12L,7L,16L,10L,24L,11L,14L,15L,32L,20L,48L,22L,28L,9L,30L,64L,40L,23L,96L,44L,56L,18L,60L,13L,128L,31L,80L,46L,192L,19L,88L,112L,36L,120L,26L,47L,256L,62L,160L,92L,384L,21L,38L,27L,176L,224L,72L,240L,52L,94L,512L,124L,320L,184L,768L,29L,42L,76L,54L,63L,352L,39L,448L,144L,480L,95L,104L,43L,188L,1024L,248L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257690Inst : IEnumerable<long>
{
public static readonly long[] Value=A257690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257690.Bytes);
public long this[int i]=>Value[i];

public static A257690Inst Instance=new A257690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257691
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,95L,97L,101L,103L,107L,109L,111L,113L,119L,121L,123L,125L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,187L,191L,193L,197L,199L,211L,219L,221L,223L,227L,229L,233L,239L,241L,247L,251L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257691Inst : IEnumerable<long>
{
public static readonly long[] Value=A257691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257691.Bytes);
public long this[int i]=>Value[i];

public static A257691Inst Instance=new A257691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257692
{
public static readonly long[] Value={ 4L,12L,16L,22L,48L,52L,60L,64L,66L,70L,76L,84L,88L,94L,100L,108L,112L,118L,240L,244L,252L,256L,258L,262L,288L,292L,300L,304L,306L,310L,312L,316L,324L,328L,330L,334L,336L,340L,348L,352L,354L,358L,364L,372L,376L,382L,408L,412L,420L,424L,426L,430L,436L,444L,448L,454L,460L,468L,472L,478L,484L,492L,496L,502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257692Inst : IEnumerable<long>
{
public static readonly long[] Value=A257692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257692.Bytes);
public long this[int i]=>Value[i];

public static A257692Inst Instance=new A257692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257693
{
public static readonly long[] Value={ 18L,72L,90L,114L,360L,378L,432L,450L,456L,474L,498L,552L,570L,594L,618L,672L,690L,714L,2160L,2178L,2232L,2250L,2256L,2274L,2520L,2538L,2592L,2610L,2616L,2634L,2640L,2658L,2712L,2730L,2736L,2754L,2760L,2778L,2832L,2850L,2856L,2874L,2898L,2952L,2970L,2994L,3240L,3258L,3312L,3330L,3336L,3354L,3378L,3432L,3450L,3474L,3498L,3552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257693Inst : IEnumerable<long>
{
public static readonly long[] Value=A257693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257693.Bytes);
public long this[int i]=>Value[i];

public static A257693Inst Instance=new A257693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257694
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,1L,2L,2L,3L,4L,6L,1L,2L,2L,3L,4L,6L,1L,2L,2L,3L,2L,3L,2L,3L,3L,4L,3L,4L,2L,3L,3L,4L,6L,8L,2L,3L,3L,4L,6L,8L,1L,2L,2L,3L,4L,6L,2L,3L,3L,4L,6L,8L,4L,6L,6L,8L,9L,12L,4L,6L,6L,8L,9L,12L,1L,2L,2L,3L,4L,6L,2L,3L,3L,4L,6L,8L,4L,6L,6L,8L,9L,12L,8L,12L,12L,16L,18L,24L,1L,2L,2L,3L,4L,6L,2L,3L,3L,4L,6L,8L,4L,6L,6L,8L,9L,12L,8L,12L,12L,16L,18L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257694Inst : IEnumerable<long>
{
public static readonly long[] Value=A257694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257694.Bytes);
public long this[int i]=>Value[i];

public static A257694Inst Instance=new A257694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257695
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,1L,2L,2L,3L,2L,6L,1L,2L,2L,3L,2L,6L,1L,2L,2L,3L,2L,3L,2L,3L,3L,4L,3L,4L,2L,3L,3L,4L,6L,4L,2L,3L,3L,4L,6L,4L,1L,2L,2L,3L,2L,6L,2L,3L,3L,4L,6L,4L,2L,6L,6L,4L,3L,12L,2L,6L,6L,4L,3L,12L,1L,2L,2L,3L,2L,6L,2L,3L,3L,4L,6L,4L,2L,6L,6L,4L,3L,12L,2L,6L,6L,4L,6L,12L,1L,2L,2L,3L,2L,6L,2L,3L,3L,4L,6L,4L,2L,6L,6L,4L,3L,12L,2L,6L,6L,4L,6L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257695Inst : IEnumerable<long>
{
public static readonly long[] Value=A257695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257695.Bytes);
public long this[int i]=>Value[i];

public static A257695Inst Instance=new A257695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257696
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,1L,1L,2L,3L,3L,4L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257696Inst : IEnumerable<long>
{
public static readonly long[] Value=A257696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257696.Bytes);
public long this[int i]=>Value[i];

public static A257696Inst Instance=new A257696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257697
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,2L,3L,0L,4L,4L,6L,4L,6L,6L,7L,0L,8L,8L,12L,8L,10L,12L,14L,8L,12L,10L,14L,12L,14L,14L,15L,0L,16L,16L,24L,16L,20L,24L,28L,16L,20L,20L,26L,24L,26L,28L,30L,16L,24L,20L,28L,20L,26L,26L,30L,24L,28L,26L,30L,28L,30L,30L,31L,0L,32L,32L,48L,32L,40L,48L,56L,32L,36L,40L,50L,48L,52L,56L,60L,32L,40L,36L,52L,40L,42L,50L,58L,48L,50L,52L,54L,56L,58L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257697Inst : IEnumerable<long>
{
public static readonly long[] Value=A257697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257697.Bytes);
public long this[int i]=>Value[i];

public static A257697Inst Instance=new A257697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257698
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,3L,5L,7L,13L,4L,6L,8L,12L,14L,16L,5L,13L,9L,11L,13L,17L,15L,17L,6L,12L,14L,16L,10L,14L,14L,16L,18L,28L,16L,18L,7L,11L,13L,15L,15L,21L,11L,13L,15L,19L,15L,17L,19L,27L,29L,31L,17L,21L,8L,10L,12L,18L,14L,16L,16L,20L,22L,24L,12L,24L,16L,18L,20L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257698Inst : IEnumerable<long>
{
public static readonly long[] Value=A257698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257698.Bytes);
public long this[int i]=>Value[i];

public static A257698Inst Instance=new A257698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257699
{
public static readonly long[] Value={ 2L,1L,7L,3L,5L,2L,6L,8L,10L,4L,14L,4L,6L,6L,10L,3L,5L,7L,13L,9L,11L,9L,13L,11L,13L,5L,13L,15L,17L,5L,9L,5L,7L,7L,13L,7L,9L,11L,15L,4L,6L,4L,18L,6L,8L,8L,12L,14L,16L,10L,16L,10L,12L,12L,16L,10L,12L,14L,22L,12L,14L,12L,16L,14L,16L,6L,12L,14L,16L,16L,20L,16L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257699Inst : IEnumerable<long>
{
public static readonly long[] Value=A257699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257699.Bytes);
public long this[int i]=>Value[i];

public static A257699Inst Instance=new A257699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257700
{
public static readonly long[] Value={ 0L,1L,5L,2L,4L,6L,10L,3L,11L,7L,9L,11L,17L,4L,10L,12L,14L,8L,26L,12L,16L,18L,20L,5L,9L,11L,19L,13L,15L,9L,25L,27L,37L,13L,15L,17L,23L,19L,23L,6L,8L,10L,14L,12L,18L,20L,22L,14L,32L,10L,24L,26L,28L,28L,36L,38L,42L,14L,16L,18L,22L,24L,34L,20L,22L,24L,30L,7L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257700Inst : IEnumerable<long>
{
public static readonly long[] Value=A257700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257700.Bytes);
public long this[int i]=>Value[i];

public static A257700Inst Instance=new A257700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257701
{
public static readonly long[] Value={ 0L,1L,5L,2L,4L,6L,8L,3L,16L,5L,9L,7L,9L,4L,15L,17L,21L,6L,8L,10L,12L,8L,18L,10L,14L,16L,18L,18L,20L,22L,32L,7L,11L,9L,11L,11L,13L,13L,17L,19L,23L,11L,13L,15L,19L,17L,21L,19L,21L,19L,21L,23L,31L,33L,37L,8L,10L,12L,14L,10L,22L,12L,16L,12L,14L,14L,16L,18L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257701Inst : IEnumerable<long>
{
public static readonly long[] Value=A257701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257701.Bytes);
public long this[int i]=>Value[i];

public static A257701Inst Instance=new A257701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257702
{
public static readonly long[] Value={ 2L,1L,3L,3L,7L,2L,12L,4L,6L,4L,6L,8L,12L,3L,11L,13L,15L,5L,7L,5L,7L,7L,11L,5L,9L,7L,9L,9L,11L,13L,17L,4L,10L,12L,14L,14L,16L,14L,18L,16L,24L,6L,8L,8L,10L,6L,10L,8L,16L,8L,10L,12L,14L,6L,8L,10L,16L,10L,14L,8L,10L,10L,12L,10L,14L,12L,18L,14L,16L,18L,20L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257702Inst : IEnumerable<long>
{
public static readonly long[] Value=A257702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257702.Bytes);
public long this[int i]=>Value[i];

public static A257702Inst Instance=new A257702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257703
{
public static readonly long[] Value={ 2L,1L,3L,3L,11L,2L,8L,2L,4L,4L,8L,4L,10L,12L,14L,12L,14L,3L,7L,9L,13L,3L,5L,3L,7L,5L,9L,5L,7L,9L,11L,9L,17L,5L,9L,11L,13L,11L,13L,13L,19L,15L,17L,13L,15L,13L,25L,15L,23L,4L,6L,8L,10L,8L,14L,10L,12L,14L,16L,4L,8L,4L,8L,6L,8L,4L,6L,8L,12L,8L,10L,6L,8L,10L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257703Inst : IEnumerable<long>
{
public static readonly long[] Value=A257703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257703.Bytes);
public long this[int i]=>Value[i];

public static A257703Inst Instance=new A257703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257704
{
public static readonly long[] Value={ 6L,1L,5L,7L,17L,7L,13L,2L,4L,6L,8L,6L,8L,8L,16L,18L,22L,18L,30L,8L,12L,14L,16L,14L,16L,3L,5L,3L,21L,5L,9L,7L,13L,7L,11L,9L,11L,7L,9L,7L,9L,9L,13L,9L,13L,9L,15L,17L,21L,17L,19L,19L,21L,23L,25L,23L,27L,19L,29L,31L,35L,31L,35L,9L,11L,13L,15L,13L,15L,15L,19L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257704Inst : IEnumerable<long>
{
public static readonly long[] Value=A257704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257704.Bytes);
public long this[int i]=>Value[i];

public static A257704Inst Instance=new A257704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257705
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,9L,7L,4L,10L,6L,11L,18L,13L,21L,15L,8L,17L,27L,19L,30L,20L,32L,23L,12L,25L,39L,26L,14L,29L,45L,31L,16L,33L,51L,35L,54L,37L,57L,38L,59L,41L,63L,43L,22L,46L,24L,47L,72L,49L,75L,50L,77L,53L,81L,55L,28L,58L,87L,56L,88L,60L,91L,62L,95L,65L,99L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257705Inst : IEnumerable<long>
{
public static readonly long[] Value=A257705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257705.Bytes);
public long this[int i]=>Value[i];

public static A257705Inst Instance=new A257705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257706
{
public static readonly long[] Value={ 0L,2L,1L,4L,8L,6L,3L,9L,5L,10L,17L,12L,20L,14L,7L,16L,26L,18L,29L,19L,31L,22L,11L,24L,38L,25L,13L,28L,44L,30L,15L,32L,50L,34L,53L,36L,56L,37L,58L,40L,62L,42L,21L,45L,23L,46L,71L,48L,74L,49L,76L,52L,80L,54L,27L,57L,86L,55L,87L,59L,90L,61L,94L,64L,98L,66L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257706Inst : IEnumerable<long>
{
public static readonly long[] Value=A257706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257706.Bytes);
public long this[int i]=>Value[i];

public static A257706Inst Instance=new A257706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257707
{
public static readonly long[] Value={ 56L,470L,1094L,7856L,128534L,201539L,3293081L,23435699L,53805155L,382911281L,6256309475L,9809462822L,160274811896L,1140616029542L,2618697452438L,18636292598096L,304494582579398L,477426555904883L,7800575092244921L,55513782134933123L,127452004956911987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257707Inst : IEnumerable<long>
{
public static readonly long[] Value=A257707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257707.Bytes);
public long this[int i]=>Value[i];

public static A257707Inst Instance=new A257707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257708
{
public static readonly long[] Value={ 25L,55L,208L,382L,1273L,2287L,7480L,13390L,43657L,78103L,254512L,455278L,1483465L,2653615L,8646328L,15466462L,50394553L,90145207L,293721040L,525404830L,1711931737L,3062283823L,9977869432L,17848298158L,58155284905L,104027505175L,338953840048L,606316732942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257708Inst : IEnumerable<long>
{
public static readonly long[] Value=A257708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257708.Bytes);
public long this[int i]=>Value[i];

public static A257708Inst Instance=new A257708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257709
{
public static readonly long[] Value={ 8L,14L,39L,53L,103L,112L,206L,264L,509L,647L,1141L,1230L,2160L,2734L,5159L,6525L,11415L,12296L,21502L,27184L,51189L,64711L,113117L,121838L,212968L,269214L,506839L,640693L,1119863L,1206192L,2108286L,2665064L,5017309L,6342327L,11085621L,11940190L,20870000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257709Inst : IEnumerable<long>
{
public static readonly long[] Value=A257709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257709.Bytes);
public long this[int i]=>Value[i];

public static A257709Inst Instance=new A257709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257710
{
public static readonly long[] Value={ 5L,32L,291L,661L,4102L,8515L,13685L,113558L,182368L,377701L,2290342L,5027232L,30483491L,63130838L,101378488L,840238915L,1349295285L,2794368792L,16944086651L,37191598501L,225516999142L,467042067835L,749998177365L,6216087516438L,9982086472888L,20672740082341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257710Inst : IEnumerable<long>
{
public static readonly long[] Value=A257710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257710.Bytes);
public long this[int i]=>Value[i];

public static A257710Inst Instance=new A257710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257711
{
public static readonly BigInteger[] Value={ 210L,3486L,51681L,883785L,13125126L,224476266L,3333728685L,57016086141L,846753959226L,14481861401910L,215072171913081L,3678335779997361L,54627484911961710L,934282806257926146L,13875166095466359621UL,BigInteger.Parse("237304154453733242085"),BigInteger.Parse("3524237560763543380386") };
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
public class A257711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257711Inst Instance=new A257711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257712
{
public static readonly long[] Value={ 120L,276L,1176L,28920L,126756L,306936L,1345620L,33362196L,146264856L,354192420L,1552832856L,38499933816L,168789505620L,408737734296L,1791967758756L,44428890250020L,194782943209176L,471682991173716L,2067929240760120L,51270900848577816L,224779347673872036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257712Inst : IEnumerable<long>
{
public static readonly long[] Value=A257712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257712.Bytes);
public long this[int i]=>Value[i];

public static A257712Inst Instance=new A257712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257713
{
public static readonly long[] Value={ 1485L,7260L,28920L,142845L,2112540L,10440165L,41673885L,205953660L,3046252485L,15054681960L,60093684540L,296985006165L,4392693942120L,21708840917445L,86655051404085L,428252172907560L,6334261618255845L,31304133548245020L,124956524030977320L,617539336347666645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257713Inst : IEnumerable<long>
{
public static readonly long[] Value=A257713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257713.Bytes);
public long this[int i]=>Value[i];

public static A257713Inst Instance=new A257713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257714
{
public static readonly BigInteger[] Value={ 44290L,487065L,97731740L,1074935965L,476036316661270L,5235848584389645L,1050611935177517000L,11555515453364758825UL,BigInteger.Parse("5117369992623387417086890"),BigInteger.Parse("56285147779473003009380865"),BigInteger.Parse("11294033255019751129047408500"),BigInteger.Parse("124221295646279547914265231925") };
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
public class A257714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257714Inst Instance=new A257714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257715
{
public static readonly BigInteger[] Value={ 651L,354051L,196476315L,1833809355L,1017687528051L,564774036750651L,313425981747606051L,BigInteger.Parse("173938318056614696235"),BigInteger.Parse("1623451323680702588835"),BigInteger.Parse("900947621231988101541051"),BigInteger.Parse("499988268427580436128625651"),BigInteger.Parse("277472588498948806845840543051"),BigInteger.Parse("153985687725108202266731539138755") };
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
public class A257715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257715.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257715Inst Instance=new A257715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257716
{
public static readonly long[] Value={ 3L,7L,13L,53L,37L,19L,71L,61L,79L,89L,29L,139L,43L,101L,107L,151L,131L,181L,229L,113L,199L,251L,163L,173L,263L,223L,271L,239L,311L,193L,293L,337L,281L,349L,317L,373L,359L,397L,457L,383L,409L,421L,491L,521L,541L,557L,433L,443L,577L,463L,503L,593L,601L,673L,479L,569L,619L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257716Inst : IEnumerable<long>
{
public static readonly long[] Value=A257716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257716.Bytes);
public long this[int i]=>Value[i];

public static A257716Inst Instance=new A257716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257717
{
public static readonly long[] Value={ 5L,11L,31L,17L,23L,67L,41L,59L,73L,47L,103L,83L,97L,127L,149L,157L,137L,167L,283L,191L,179L,109L,211L,227L,313L,233L,197L,331L,241L,257L,379L,347L,307L,367L,389L,277L,353L,401L,439L,269L,509L,499L,419L,449L,571L,431L,487L,563L,461L,547L,523L,587L,599L,661L,607L,761L,631L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257717Inst : IEnumerable<long>
{
public static readonly long[] Value=A257717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257717.Bytes);
public long this[int i]=>Value[i];

public static A257717Inst Instance=new A257717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257718
{
public static readonly long[] Value={ 3L,5L,29L,67L,7L,23L,13L,11L,19L,17L,37L,47L,43L,41L,53L,73L,71L,83L,79L,31L,89L,59L,163L,109L,101L,97L,113L,103L,61L,149L,107L,127L,139L,167L,151L,191L,181L,137L,131L,211L,199L,197L,173L,277L,193L,257L,223L,179L,229L,233L,239L,367L,251L,241L,281L,307L,271L,389L,293L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257718Inst : IEnumerable<long>
{
public static readonly long[] Value=A257718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257718.Bytes);
public long this[int i]=>Value[i];

public static A257718Inst Instance=new A257718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257719
{
public static readonly long[] Value={ 12L,18L,20L,36L,40L,48L,56L,70L,72L,80L,88L,100L,104L,108L,112L,144L,156L,160L,162L,192L,196L,200L,208L,220L,228L,260L,272L,288L,300L,304L,320L,324L,336L,350L,352L,368L,372L,392L,400L,416L,432L,448L,450L,460L,464L,468L,490L,500L,516L,544L,550L,572L,576L,608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257719Inst : IEnumerable<long>
{
public static readonly long[] Value=A257719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257719.Bytes);
public long this[int i]=>Value[i];

public static A257719Inst Instance=new A257719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257720
{
public static readonly long[] Value={ 25L,34L,44L,74L,81L,106L,121L,124L,134L,184L,194L,202L,218L,268L,274L,284L,289L,314L,346L,361L,386L,394L,441L,514L,524L,529L,538L,554L,590L,604L,625L,634L,652L,674L,694L,698L,716L,724L,729L,752L,764L,778L,790L,794L,824L,841L,844L,884L,914L,922L,950L,974L,988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257720Inst : IEnumerable<long>
{
public static readonly long[] Value=A257720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257720.Bytes);
public long this[int i]=>Value[i];

public static A257720Inst Instance=new A257720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257721
{
public static readonly BigInteger[] Value={ 703L,810901L,935778691L,1079887798153L,1246189583289511L,1438101699228297181L,BigInteger.Parse("1659568114719871657003"),BigInteger.Parse("1915140166285032663883921"),BigInteger.Parse("2210070092324812974250387471"),BigInteger.Parse("2550418971402667887252283257253"),BigInteger.Parse("2943181282928586417076160628482131") };
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
public class A257721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257721Inst Instance=new A257721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257722
{
public static readonly BigInteger[] Value={ 946L,1540L,13695L,1151403L,18773128L,1590903028L,25941294753L,2198372138061L,20904988593016L,35846699817610L,340877159895525L,28887334308843153L,471037447946228878L,BigInteger.Parse("39917653136343078778"),BigInteger.Parse("650898046192856866503"),BigInteger.Parse("55159780922590010984691") };
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
public class A257722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257722Inst Instance=new A257722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257723
{
public static readonly BigInteger[] Value={ 47278L,30011878L,1773905266L,1129461664906L,66759145382566L,42506160261709726L,2512413675548232778L,BigInteger.Parse("1599676834159716812578"),BigInteger.Parse("94552176198823041633886"),BigInteger.Parse("60202237934260622257499926"),BigInteger.Parse("3558376596554092673296082146"),BigInteger.Parse("2265651020818287423879030051706") };
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
public class A257723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257723.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257723Inst Instance=new A257723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257724
{
public static readonly BigInteger[] Value={ 35245L,794629045L,28238642425L,640790268444865L,22771697546069605L,BigInteger.Parse("516734554053498696685"),BigInteger.Parse("18363142444517200268785"),BigInteger.Parse("416695777857208665553032505"),BigInteger.Parse("14808074793520787633419991965"),BigInteger.Parse("336024308655092047765242836700325"),BigInteger.Parse("11941261129626387046720630977591145") };
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
public class A257724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257724.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257724Inst Instance=new A257724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257725
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,5L,12L,7L,16L,10L,24L,9L,14L,13L,32L,20L,48L,18L,28L,17L,26L,64L,40L,11L,96L,36L,56L,34L,52L,25L,128L,15L,80L,22L,192L,33L,72L,112L,68L,104L,50L,21L,256L,30L,160L,44L,384L,49L,66L,19L,144L,224L,136L,208L,100L,42L,512L,60L,320L,88L,768L,29L,98L,132L,38L,27L,288L,65L,448L,272L,416L,41L,200L,97L,84L,1024L,120L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257725Inst : IEnumerable<long>
{
public static readonly long[] Value=A257725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257725.Bytes);
public long this[int i]=>Value[i];

public static A257725Inst Instance=new A257725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257726
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,9L,6L,13L,11L,25L,8L,15L,14L,33L,10L,21L,19L,51L,17L,43L,35L,115L,12L,31L,22L,67L,20L,63L,45L,163L,16L,37L,29L,93L,27L,79L,66L,273L,24L,73L,57L,223L,47L,171L,146L,723L,18L,49L,42L,151L,30L,99L,88L,385L,28L,87L,83L,349L,59L,235L,203L,1093L,23L,69L,50L,193L,40L,135L,119L,559L,38L,129L,102L,475L,86L,367L,335L,1983L,34L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257726Inst : IEnumerable<long>
{
public static readonly long[] Value=A257726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257726.Bytes);
public long this[int i]=>Value[i];

public static A257726Inst Instance=new A257726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257727
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,9L,14L,11L,16L,20L,24L,13L,18L,15L,28L,22L,32L,17L,40L,48L,26L,36L,30L,21L,56L,25L,44L,64L,34L,80L,96L,19L,52L,72L,60L,29L,42L,23L,112L,50L,88L,33L,128L,68L,160L,192L,38L,41L,104L,144L,120L,58L,84L,49L,46L,27L,224L,100L,176L,66L,256L,37L,136L,320L,384L,31L,76L,57L,82L,208L,288L,240L,116L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257727Inst : IEnumerable<long>
{
public static readonly long[] Value=A257727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257727.Bytes);
public long this[int i]=>Value[i];

public static A257727Inst Instance=new A257727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257728
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,11L,9L,13L,10L,17L,12L,19L,14L,23L,18L,37L,15L,29L,21L,43L,16L,31L,26L,61L,20L,41L,28L,71L,22L,47L,34L,89L,27L,67L,52L,163L,24L,53L,42L,113L,32L,79L,60L,193L,25L,59L,45L,131L,38L,103L,84L,293L,30L,73L,57L,181L,40L,109L,95L,359L,33L,83L,65L,223L,49L,149L,119L,463L,39L,107L,91L,337L,72L,241L,209L,971L,35L,97L,74L,251L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257728Inst : IEnumerable<long>
{
public static readonly long[] Value=A257728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257728.Bytes);
public long this[int i]=>Value[i];

public static A257728Inst Instance=new A257728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257729
{
public static readonly long[] Value={ 1L,3L,7L,2L,19L,6L,5L,12L,4L,28L,71L,10L,17L,9L,20L,8L,13L,40L,41L,95L,16L,26L,11L,15L,30L,14L,21L,56L,109L,57L,359L,125L,25L,38L,18L,24L,31L,44L,22L,32L,61L,77L,29L,143L,78L,445L,73L,162L,36L,54L,27L,35L,23L,45L,62L,33L,46L,84L,43L,104L,179L,42L,185L,105L,545L,98L,181L,208L,51L,75L,503L,39L,59L,50L,34L,63L,85L,48L,103L,64L,114L,60L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257729Inst : IEnumerable<long>
{
public static readonly long[] Value=A257729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257729.Bytes);
public long this[int i]=>Value[i];

public static A257729Inst Instance=new A257729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257730
{
public static readonly long[] Value={ 1L,4L,2L,9L,7L,6L,3L,16L,14L,12L,23L,8L,17L,26L,24L,21L,13L,35L,5L,15L,27L,39L,53L,36L,33L,22L,51L,10L,43L,25L,37L,40L,56L,75L,52L,49L,83L,34L,72L,18L,19L,62L,59L,38L,54L,57L,101L,78L,102L,74L,69L,114L,89L,50L,98L,28L,30L,86L,73L,82L,41L,55L,76L,80L,134L,106L,149L,135L,100L,94L,11L,150L,47L,120L,70L,130L,42L,45L,103L,117L,99L,112L,167L,58L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257730Inst : IEnumerable<long>
{
public static readonly long[] Value=A257730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257730.Bytes);
public long this[int i]=>Value[i];

public static A257730Inst Instance=new A257730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257731
{
public static readonly long[] Value={ 1L,3L,9L,2L,33L,5L,7L,14L,4L,45L,163L,8L,15L,11L,20L,6L,25L,59L,63L,203L,12L,22L,13L,17L,28L,10L,35L,78L,235L,83L,1093L,251L,18L,30L,19L,24L,31L,39L,16L,47L,67L,101L,43L,290L,107L,1283L,87L,309L,26L,41L,27L,34L,21L,42L,53L,23L,61L,88L,115L,128L,321L,57L,354L,137L,1499L,112L,349L,376L,36L,55L,1401L,38L,49L,46L,29L,56L,70L,32L,99L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257731Inst : IEnumerable<long>
{
public static readonly long[] Value=A257731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257731.Bytes);
public long this[int i]=>Value[i];

public static A257731Inst Instance=new A257731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257732
{
public static readonly long[] Value={ 1L,4L,2L,9L,6L,16L,7L,12L,3L,26L,14L,21L,23L,8L,13L,39L,24L,33L,35L,15L,53L,22L,56L,36L,17L,49L,51L,25L,75L,34L,37L,78L,5L,52L,27L,69L,101L,72L,38L,102L,50L,54L,43L,106L,10L,74L,40L,94L,73L,134L,83L,98L,55L,135L,70L,76L,62L,141L,18L,100L,57L,125L,19L,99L,175L,114L,41L,130L,167L,77L,176L,95L,89L,104L,137L,86L,184L,28L,149L,133L,80L,164L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257732Inst : IEnumerable<long>
{
public static readonly long[] Value=A257732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257732.Bytes);
public long this[int i]=>Value[i];

public static A257732Inst Instance=new A257732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257733
{
public static readonly long[] Value={ 1L,3L,9L,2L,33L,5L,7L,14L,4L,45L,163L,8L,15L,11L,20L,6L,25L,59L,203L,12L,22L,17L,63L,28L,13L,10L,35L,78L,235L,251L,18L,30L,24L,83L,39L,19L,1093L,16L,47L,101L,31L,290L,67L,309L,26L,41L,43L,34L,107L,53L,27L,1283L,87L,23L,61L,128L,42L,354L,88L,376L,21L,36L,55L,57L,46L,137L,115L,70L,38L,1499L,321L,112L,32L,81L,161L,56L,1401L,430L,113L,454L,29L,48L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257733Inst : IEnumerable<long>
{
public static readonly long[] Value=A257733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257733.Bytes);
public long this[int i]=>Value[i];

public static A257733Inst Instance=new A257733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257734
{
public static readonly long[] Value={ 1L,4L,2L,9L,6L,16L,7L,12L,3L,26L,14L,20L,25L,8L,13L,38L,22L,31L,36L,15L,61L,21L,54L,33L,17L,45L,51L,24L,81L,32L,41L,73L,5L,48L,27L,62L,119L,69L,35L,105L,46L,57L,47L,96L,10L,65L,39L,82L,83L,151L,115L,92L,50L,135L,63L,76L,64L,124L,18L,86L,55L,106L,23L,108L,189L,146L,43L,118L,193L,68L,169L,84L,91L,100L,149L,85L,156L,28L,179L,111L,74L,136L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257734Inst : IEnumerable<long>
{
public static readonly long[] Value=A257734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257734.Bytes);
public long this[int i]=>Value[i];

public static A257734Inst Instance=new A257734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257735
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,17L,10L,9L,12L,25L,14L,13L,16L,57L,34L,33L,20L,49L,18L,11L,24L,105L,50L,19L,28L,29L,26L,15L,32L,153L,114L,113L,68L,385L,66L,65L,40L,769L,98L,97L,36L,81L,22L,21L,48L,609L,210L,209L,100L,133L,38L,37L,56L,1537L,58L,35L,52L,257L,30L,27L,64L,1953L,306L,163L,228L,1409L,226L,225L,136L,13313L,770L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257735Inst : IEnumerable<long>
{
public static readonly long[] Value=A257735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257735.Bytes);
public long this[int i]=>Value[i];

public static A257735Inst Instance=new A257735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257736
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,11L,10L,23L,12L,15L,14L,31L,16L,9L,22L,27L,20L,47L,46L,191L,24L,13L,30L,63L,28L,29L,62L,159L,32L,19L,18L,59L,44L,55L,54L,351L,40L,95L,94L,511L,92L,383L,382L,311L,48L,21L,26L,255L,60L,127L,126L,703L,56L,17L,58L,83L,124L,319L,318L,879L,64L,39L,38L,175L,36L,119L,118L,1919L,88L,111L,110L,1279L,108L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257736Inst : IEnumerable<long>
{
public static readonly long[] Value=A257736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257736.Bytes);
public long this[int i]=>Value[i];

public static A257736Inst Instance=new A257736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257737
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,21L,14L,31L,16L,17L,18L,29L,20L,87L,42L,23L,24L,13L,26L,40L,28L,112L,56L,141L,32L,15L,34L,19L,36L,517L,54L,39L,143L,74L,177L,49L,44L,22L,46L,27L,48L,925L,618L,37L,71L,53L,179L,96L,220L,64L,58L,30L,60L,38L,62L,63L,1088L,737L,50L,51L,92L,4129L,70L,222L,122L,259L,271L,8037L,84L,77L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257737Inst : IEnumerable<long>
{
public static readonly long[] Value=A257737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257737.Bytes);
public long this[int i]=>Value[i];

public static A257737Inst Instance=new A257737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257738
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,25L,14L,33L,16L,17L,18L,35L,20L,13L,45L,23L,24L,115L,26L,47L,28L,19L,59L,15L,32L,163L,34L,146L,36L,51L,61L,39L,27L,78L,22L,723L,44L,203L,46L,182L,48L,43L,66L,67L,81L,53L,38L,101L,30L,856L,58L,251L,60L,226L,62L,63L,57L,86L,88L,1093L,104L,273L,70L,52L,128L,6093L,41L,223L,1010L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257738Inst : IEnumerable<long>
{
public static readonly long[] Value=A257738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257738.Bytes);
public long this[int i]=>Value[i];

public static A257738Inst Instance=new A257738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257739
{
public static readonly long[] Value={ 5L,9L,10L,11L,13L,17L,18L,19L,20L,21L,22L,23L,25L,27L,29L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,59L,61L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,97L,98L,99L,101L,102L,103L,105L,107L,108L,109L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257739Inst : IEnumerable<long>
{
public static readonly long[] Value=A257739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257739.Bytes);
public long this[int i]=>Value[i];

public static A257739Inst Instance=new A257739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257740
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,3L,0L,3L,14L,13L,0L,5L,49L,114L,73L,0L,7L,148L,672L,1028L,501L,0L,11L,427L,3334L,9182L,10310L,4051L,0L,15L,1170L,15030L,66584L,129485L,114402L,37633L,0L,22L,3150L,63978L,428653L,1285815L,1918083L,1394414L,394353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257740Inst : IEnumerable<long>
{
public static readonly long[] Value=A257740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257740.Bytes);
public long this[int i]=>Value[i];

public static A257740Inst Instance=new A257740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257741
{
public static readonly BigInteger[] Value={ 1L,1L,5L,30L,241L,2356L,27315L,364319L,5488468L,92040141L,1698933390L,34206221161L,745622368096L,17486274798203L,438859174516837L,11732964019785027L,332818604033186036L,9981540739647177238UL,BigInteger.Parse("315518234680527952625"),BigInteger.Parse("10482878954868309043158"),BigInteger.Parse("365158449014981632341391") };
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
public class A257741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257741Inst Instance=new A257741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257742
{
public static readonly BigInteger[] Value={ 1L,2L,49L,3334L,428653L,87804401L,26047147641L,10515038040403L,5527943088161719L,3662449762145471938L,BigInteger.Parse("2981185419002290273673"),BigInteger.Parse("2921408464370908053081409"),BigInteger.Parse("3389743512704136305019696050"),BigInteger.Parse("4593040689601644978081159072298"),BigInteger.Parse("7182956101782940369861692674495595") };
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
public class A257742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257742Inst Instance=new A257742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257743
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,3L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,8L,1L,3L,3L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257743Inst : IEnumerable<long>
{
public static readonly long[] Value=A257743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257743.Bytes);
public long this[int i]=>Value[i];

public static A257743Inst Instance=new A257743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257744
{
public static readonly long[] Value={ 1L,9L,33L,135L,183L,143L,95L,63L,1349L,899L,1535L,1023L,4623L,7047L,18063L,14623L,12543L,16383L,23849L,15899L,10599L,29639L,79037L,80351L,53567L,35711L,23807L,15871L,21161L,56429L,150477L,520929L,437979L,1167945L,863359L,1151145L,1097595L,1392255L,1343215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257744Inst : IEnumerable<long>
{
public static readonly long[] Value=A257744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257744.Bytes);
public long this[int i]=>Value[i];

public static A257744Inst Instance=new A257744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257745
{
public static readonly long[] Value={ 5L,7L,41L,43L,89L,127L,179L,193L,233L,263L,283L,317L,379L,383L,397L,443L,457L,487L,503L,547L,599L,607L,631L,643L,647L,719L,733L,787L,809L,821L,839L,937L,947L,971L,977L,997L,1019L,1039L,1049L,1069L,1091L,1097L,1103L,1109L,1187L,1193L,1217L,1231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257745Inst : IEnumerable<long>
{
public static readonly long[] Value=A257745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257745.Bytes);
public long this[int i]=>Value[i];

public static A257745Inst Instance=new A257745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257746
{
public static readonly long[] Value={ 61L,157L,199L,311L,349L,409L,463L,509L,557L,601L,641L,691L,727L,757L,823L,911L,919L,1051L,1093L,1123L,1153L,1213L,1327L,1433L,1459L,1627L,1951L,2027L,2063L,2221L,2251L,2293L,2311L,2357L,2389L,2551L,2621L,2683L,2719L,2789L,2791L,2939L,2953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257746Inst : IEnumerable<long>
{
public static readonly long[] Value=A257746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257746.Bytes);
public long this[int i]=>Value[i];

public static A257746Inst Instance=new A257746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257747
{
public static readonly long[] Value={ 67L,491L,613L,1013L,1117L,1201L,1249L,1301L,1373L,1543L,1753L,1907L,2017L,2339L,2411L,2657L,2671L,2879L,3023L,3037L,3181L,3677L,3727L,3733L,4139L,4409L,4549L,4861L,5303L,5381L,5399L,5857L,5897L,6301L,6373L,6737L,7433L,7499L,7577L,7583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257747Inst : IEnumerable<long>
{
public static readonly long[] Value=A257747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257747.Bytes);
public long this[int i]=>Value[i];

public static A257747Inst Instance=new A257747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257748
{
public static readonly long[] Value={ 8741L,9533L,11087L,14629L,17077L,26029L,29723L,33247L,38723L,40177L,43991L,45677L,56369L,57709L,58027L,68749L,77479L,81727L,88117L,90173L,93053L,110933L,112297L,112901L,114859L,117773L,127219L,129841L,131771L,146161L,156719L,159293L,169369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257748Inst : IEnumerable<long>
{
public static readonly long[] Value=A257748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257748.Bytes);
public long this[int i]=>Value[i];

public static A257748Inst Instance=new A257748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257749
{
public static readonly long[] Value={ 61673L,635939L,706117L,720743L,1483439L,1742501L,1766701L,1847603L,2097959L,2163461L,2365289L,2429411L,3420101L,3490703L,3657361L,3920843L,3973829L,4758973L,4920887L,4989779L,5273753L,6167687L,6223247L,6573559L,6655409L,6694333L,6791881L,7095503L,7102349L,7338293L,7644541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257749Inst : IEnumerable<long>
{
public static readonly long[] Value=A257749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257749.Bytes);
public long this[int i]=>Value[i];

public static A257749Inst Instance=new A257749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257750
{
public static readonly long[] Value={ 35L,77L,143L,165L,187L,209L,221L,231L,247L,273L,299L,323L,357L,391L,399L,437L,493L,527L,561L,589L,598L,713L,715L,899L,935L,943L,989L,1015L,1073L,1105L,1147L,1189L,1247L,1271L,1295L,1333L,1517L,1537L,1547L,1591L,1595L,1705L,1729L,1739L,1763L,1829L,1885L,1886L,1927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257750Inst : IEnumerable<long>
{
public static readonly long[] Value=A257750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257750.Bytes);
public long this[int i]=>Value[i];

public static A257750Inst Instance=new A257750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257751
{
public static readonly long[] Value={ 35L,77L,143L,165L,187L,209L,231L,247L,273L,299L,357L,391L,399L,437L,493L,527L,561L,589L,598L,713L,715L,943L,989L,1015L,1073L,1189L,1247L,1295L,1333L,1537L,1547L,1705L,1729L,1739L,1829L,1886L,1927L,1961L,2015L,2021L,2257L,2279L,2387L,2397L,2419L,2451L,2479L,2501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257751Inst : IEnumerable<long>
{
public static readonly long[] Value=A257751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257751.Bytes);
public long this[int i]=>Value[i];

public static A257751Inst Instance=new A257751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257752
{
public static readonly long[] Value={ 221L,323L,899L,935L,1105L,1147L,1271L,1591L,1595L,1885L,2093L,2465L,2821L,4757L,4807L,4991L,5609L,5963L,6497L,7081L,7843L,9991L,10373L,10403L,10961L,11009L,12319L,13843L,14111L,16031L,17155L,17399L,17653L,17963L,19043L,19721L,20701L,24613L,27331L,28417L,29341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257752Inst : IEnumerable<long>
{
public static readonly long[] Value=A257752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257752.Bytes);
public long this[int i]=>Value[i];

public static A257752Inst Instance=new A257752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257753
{
public static readonly long[] Value={ 1517L,1763L,4331L,4453L,5183L,5767L,9797L,10573L,12317L,14351L,16637L,34571L,35657L,38021L,38191L,38407L,40723L,41989L,50429L,50851L,57599L,67721L,70151L,75067L,79523L,87953L,111547L,117613L,150463L,159559L,167137L,173633L,181451L,190087L,191819L,197881L,205193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257753Inst : IEnumerable<long>
{
public static readonly long[] Value=A257753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257753.Bytes);
public long this[int i]=>Value[i];

public static A257753Inst Instance=new A257753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257754
{
public static readonly long[] Value={ 60491L,61937L,65311L,76151L,116843L,127723L,159197L,164009L,168821L,194417L,272483L,284987L,329467L,364087L,369857L,370817L,385241L,389327L,395497L,407837L,423701L,431393L,465043L,509461L,613927L,837209L,853607L,881717L,999919L,1041541L,1117213L,1279903L,1294819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257754Inst : IEnumerable<long>
{
public static readonly long[] Value=A257754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257754.Bytes);
public long this[int i]=>Value[i];

public static A257754Inst Instance=new A257754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257755
{
public static readonly long[] Value={ 34933L,295927L,312157L,346777L,379231L,417091L,444853L,471773L,576077L,582133L,1384753L,1462579L,1687397L,1689991L,1713337L,1861289L,1944869L,3211183L,3654223L,4092493L,4358737L,5134531L,5410051L,5564557L,6863671L,7061321L,7343659L,7531889L,7622221L,7817591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257755Inst : IEnumerable<long>
{
public static readonly long[] Value=A257755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257755.Bytes);
public long this[int i]=>Value[i];

public static A257755Inst Instance=new A257755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257756
{
public static readonly long[] Value={ 189029L,404471L,424663L,2595221L,4140901L,4197377L,4347209L,4528159L,4566193L,4631023L,4708819L,4864411L,5175589L,5311729L,6380651L,6400819L,6426029L,7117783L,8173877L,8915971L,10080589L,10460869L,10671173L,11094661L,11538313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257756Inst : IEnumerable<long>
{
public static readonly long[] Value=A257756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257756.Bytes);
public long this[int i]=>Value[i];

public static A257756Inst Instance=new A257756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257757
{
public static readonly long[] Value={ 777923L,1030189L,1060459L,4903309L,5493247L,5659637L,6431071L,6673087L,6778969L,9790577L,11390429L,11860969L,12053263L,12390319L,12602059L,21215011L,21842629L,22991989L,24005239L,39339667L,39929437L,40080661L,40761169L,42314449L,50979479L,51876007L,54345943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257757Inst : IEnumerable<long>
{
public static readonly long[] Value=A257757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257757.Bytes);
public long this[int i]=>Value[i];

public static A257757Inst Instance=new A257757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257758
{
public static readonly long[] Value={ 35L,221L,1517L,60491L,34933L,189029L,777923L,182293L,11618977L,58076041L,268926877L,1047880741L,342323563L,447110449L,2987821321L,11951066641L,19719180049L,10178985781L,249381206761L,30512751277L,190703385391L,128931982141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257758Inst : IEnumerable<long>
{
public static readonly long[] Value=A257758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257758.Bytes);
public long this[int i]=>Value[i];

public static A257758Inst Instance=new A257758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257759
{
public static readonly long[] Value={ 1105L,1595L,2093L,2465L,2821L,7843L,10373L,17963L,19721L,29341L,31003L,33143L,46189L,46657L,62647L,66263L,70151L,70219L,88559L,101813L,106361L,115843L,193343L,200777L,206471L,209933L,230159L,234883L,252601L,285619L,294409L,308267L,343027L,369799L,423181L,467273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257759Inst : IEnumerable<long>
{
public static readonly long[] Value=A257759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257759.Bytes);
public long this[int i]=>Value[i];

public static A257759Inst Instance=new A257759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257760
{
public static readonly long[] Value={ 1L,1488L,3381L,14889L,18489L,181965L,262989L,338646L,358489L,367589L,437189L,438329L,479285L,781839L,964941L,1456589L,1763954L,2579285L,2868489L,3365285L,3419389L,3451988L,3584889L,3625619L,4378829L,4653989L,6868877L,7295986L,9548479L,14529839L,14534488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257760Inst : IEnumerable<long>
{
public static readonly long[] Value=A257760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257760.Bytes);
public long this[int i]=>Value[i];

public static A257760Inst Instance=new A257760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257761
{
public static readonly long[] Value={ 92L,138L,4278L,6532L,205252L,313398L,9847818L,15036572L,472490012L,721442058L,22669672758L,34614182212L,1087671802372L,1660759304118L,52185576841098L,79681832415452L,2503820016570332L,3823067196637578L,120131175218534838L,183427543606188292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257761Inst : IEnumerable<long>
{
public static readonly long[] Value=A257761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257761.Bytes);
public long this[int i]=>Value[i];

public static A257761Inst Instance=new A257761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257762
{
public static readonly long[] Value={ 1L,3L,5L,7L,13L,26L,28L,43L,49L,64L,69L,78L,89L,93L,96L,116L,131L,134L,142L,148L,152L,155L,167L,182L,202L,206L,212L,225L,231L,234L,236L,238L,247L,253L,258L,281L,286L,302L,303L,311L,313L,330L,332L,333L,334L,336L,337L,356L,362L,384L,385L,390L,435L,438L,455L,458L,484L,492L,512L,516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257762Inst : IEnumerable<long>
{
public static readonly long[] Value=A257762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257762.Bytes);
public long this[int i]=>Value[i];

public static A257762Inst Instance=new A257762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257763
{
public static readonly long[] Value={ 1L,4762L,4832L,12385L,14829L,26394L,34196L,36215L,49827L,68474L,72576L,74528L,79286L,79836L,94583L,94867L,96123L,98376L,123385L,123546L,124235L,124365L,124579L,124589L,125476L,125478L,126969L,129685L,135438L,139256L,139261L,139756L,149382L,152385L,156242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257763Inst : IEnumerable<long>
{
public static readonly long[] Value=A257763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257763.Bytes);
public long this[int i]=>Value[i];

public static A257763Inst Instance=new A257763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257764
{
public static readonly long[] Value={ 3L,13L,31L,59L,67L,103L,179L,193L,227L,229L,317L,983L,1201L,1213L,1321L,1787L,1811L,2179L,3571L,4817L,5333L,6803L,10433L,12197L,13063L,19391L,21283L,24571L,31817L,42307L,45377L,49957L,61909L,67933L,70573L,74843L,82421L,85909L,91099L,99241L,101293L,109639L,112087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257764Inst : IEnumerable<long>
{
public static readonly long[] Value=A257764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257764.Bytes);
public long this[int i]=>Value[i];

public static A257764Inst Instance=new A257764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257765
{
public static readonly long[] Value={ 195L,1599L,2379L,19695L,163059L,242619L,2008695L,16630419L,24744759L,204867195L,1696139679L,2523722799L,20894445195L,172989616839L,257394980739L,2131028542695L,17643244777899L,26251764312579L,217344016909695L,1799437977728859L,2677422564902319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257765Inst : IEnumerable<long>
{
public static readonly long[] Value=A257765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257765.Bytes);
public long this[int i]=>Value[i];

public static A257765Inst Instance=new A257765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257766
{
public static readonly long[] Value={ 1L,2023L,2400L,52215L,615627L,938600L,1648656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257766Inst : IEnumerable<long>
{
public static readonly long[] Value=A257766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257766.Bytes);
public long this[int i]=>Value[i];

public static A257766Inst Instance=new A257766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257767
{
public static readonly long[] Value={ 143L,253L,440L,1133L,1397L,3608L,6325L,11495L,20152L,52063L,64207L,165880L,290807L,528517L,926552L,2393765L,2952125L,7626872L,13370797L,24300287L,42601240L,110061127L,135733543L,350670232L,614765855L,1117284685L,1958730488L,5060418077L,6240790853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257767Inst : IEnumerable<long>
{
public static readonly long[] Value=A257767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257767.Bytes);
public long this[int i]=>Value[i];

public static A257767Inst Instance=new A257767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257768
{
public static readonly long[] Value={ 12L,18L,30L,90L,666L,870L,960L,1998L,7816L,42648L,119394L,302034L,360522L,1741752L,12051036L,909341082L,931186956L,1136424308L,1145082306L,8390370196L,49388550660L,52927388760L,100552730520L,41845367362266L,51671446297908L,245917854035004L,607628544623816L,858683110606660L,4023730658941192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257768Inst : IEnumerable<long>
{
public static readonly long[] Value=A257768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257768.Bytes);
public long this[int i]=>Value[i];

public static A257768Inst Instance=new A257768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257769
{
public static readonly long[] Value={ 0L,1L,4L,65536L,7625597484987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257769Inst : IEnumerable<long>
{
public static readonly long[] Value=A257769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257769.Bytes);
public long this[int i]=>Value[i];

public static A257769Inst Instance=new A257769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257770
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,3L,0L,4L,0L,5L,0L,6L,0L,7L,0L,8L,0L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,3L,5L,6L,8L,9L,0L,1L,4L,5L,8L,9L,3L,4L,8L,9L,2L,3L,8L,9L,1L,2L,8L,9L,0L,1L,8L,9L,0L,8L,9L,8L,9L,0L,2L,4L,6L,8L,0L,1L,3L,4L,6L,7L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257770Inst : IEnumerable<long>
{
public static readonly long[] Value=A257770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257770.Bytes);
public long this[int i]=>Value[i];

public static A257770Inst Instance=new A257770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257771
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,13L,31L,37L,53L,61L,73L,79L,97L,122L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257771Inst : IEnumerable<long>
{
public static readonly long[] Value=A257771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257771.Bytes);
public long this[int i]=>Value[i];

public static A257771Inst Instance=new A257771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257772
{
public static readonly long[] Value={ 0L,5L,7L,8L,12L,15L,16L,18L,19L,20L,21L,22L,26L,29L,31L,33L,35L,36L,39L,40L,43L,44L,46L,47L,50L,51L,53L,54L,56L,57L,59L,60L,61L,64L,65L,68L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,82L,83L,84L,85L,87L,89L,92L,94L,96L,97L,98L,99L,100L,101L,102L,103L,104L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257772Inst : IEnumerable<long>
{
public static readonly long[] Value=A257772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257772.Bytes);
public long this[int i]=>Value[i];

public static A257772Inst Instance=new A257772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257773
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,10L,10L,7L,6L,4L,4L,4L,4L,3L,2L,5L,7L,5L,4L,3L,3L,3L,3L,2L,2L,4L,5L,4L,4L,2L,3L,3L,2L,2L,2L,3L,4L,4L,3L,3L,3L,2L,1L,2L,1L,2L,3L,2L,3L,3L,2L,2L,2L,2L,1L,2L,2L,3L,3L,2L,1L,2L,2L,1L,2L,2L,3L,3L,2L,2L,2L,1L,2L,1L,1L,2L,3L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257773Inst : IEnumerable<long>
{
public static readonly long[] Value=A257773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257773.Bytes);
public long this[int i]=>Value[i];

public static A257773Inst Instance=new A257773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257774
{
public static readonly long[] Value={ 1L,5L,7L,6057L,292839L,1295314L,4897814L,4967471L,5097886L,6010324L,6919146L,7068165L,7189558L,9465077L,15347958L,22842108L,24463917L,26754863L,43378366L,48810128L,48885128L,50833026L,54588458L,54649688L,68093171L,69925865L,69980346L,73390374L,74357144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257774Inst : IEnumerable<long>
{
public static readonly long[] Value=A257774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257774.Bytes);
public long this[int i]=>Value[i];

public static A257774Inst Instance=new A257774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257775
{
public static readonly long[] Value={ 1L,8L,4L,7L,2L,6L,4L,0L,2L,4L,7L,3L,2L,6L,6L,2L,5L,5L,6L,8L,0L,7L,6L,0L,6L,8L,6L,5L,1L,4L,3L,7L,5L,1L,9L,5L,3L,2L,9L,5L,0L,7L,8L,8L,9L,2L,6L,3L,7L,9L,6L,1L,8L,3L,1L,0L,2L,1L,7L,8L,1L,9L,5L,5L,6L,3L,0L,6L,4L,3L,4L,4L,9L,0L,1L,9L,7L,6L,4L,4L,4L,0L,8L,4L,6L,0L,7L,8L,1L,2L,1L,2L,6L,9L,7L,8L,0L,4L,4L,8L,6L,9L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257775Inst : IEnumerable<long>
{
public static readonly long[] Value=A257775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257775.Bytes);
public long this[int i]=>Value[i];

public static A257775Inst Instance=new A257775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257776
{
public static readonly long[] Value={ 7L,4L,3L,9L,0L,8L,7L,7L,4L,9L,3L,2L,8L,7L,6L,5L,8L,2L,9L,9L,7L,3L,5L,2L,9L,5L,0L,1L,6L,9L,6L,9L,3L,2L,5L,5L,4L,4L,3L,9L,9L,6L,5L,8L,6L,6L,1L,3L,1L,1L,6L,6L,7L,2L,0L,1L,4L,0L,3L,4L,6L,0L,1L,0L,9L,9L,9L,5L,7L,2L,5L,4L,7L,4L,4L,1L,4L,7L,1L,7L,5L,2L,2L,9L,7L,9L,6L,1L,9L,1L,1L,2L,0L,4L,8L,2L,1L,3L,7L,1L,1L,6L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257776Inst : IEnumerable<long>
{
public static readonly long[] Value=A257776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257776.Bytes);
public long this[int i]=>Value[i];

public static A257776Inst Instance=new A257776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257777
{
public static readonly long[] Value={ 1L,2L,1L,8L,2L,8L,2L,9L,0L,5L,0L,1L,7L,2L,7L,7L,6L,2L,1L,7L,6L,0L,4L,6L,1L,7L,6L,8L,9L,1L,5L,7L,9L,7L,9L,4L,1L,7L,3L,9L,1L,3L,1L,9L,4L,9L,4L,6L,8L,1L,5L,6L,5L,0L,5L,0L,4L,9L,6L,6L,0L,2L,6L,2L,9L,4L,8L,1L,7L,8L,2L,1L,6L,3L,0L,0L,7L,6L,0L,7L,6L,3L,7L,6L,1L,9L,6L,9L,1L,6L,8L,1L,5L,5L,7L,7L,2L,1L,3L,0L,7L,0L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257777Inst : IEnumerable<long>
{
public static readonly long[] Value=A257777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257777.Bytes);
public long this[int i]=>Value[i];

public static A257777Inst Instance=new A257777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257778
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,2L,1L,0L,0L,8L,0L,0L,0L,1L,0L,2L,0L,0L,6L,5L,0L,0L,2L,0L,3L,0L,0L,4L,2L,0L,0L,1L,0L,1L,0L,0L,2L,3L,0L,6L,0L,3L,3L,0L,0L,0L,1L,4L,1L,3L,0L,5L,0L,0L,4L,4L,0L,2L,6L,3L,0L,0L,0L,3L,1L,3L,4L,0L,3L,8L,0L,0L,2L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257778Inst : IEnumerable<long>
{
public static readonly long[] Value=A257778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257778.Bytes);
public long this[int i]=>Value[i];

public static A257778Inst Instance=new A257778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257779
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,8L,9L,8L,8L,6L,9L,8L,9L,8L,7L,9L,8L,9L,9L,6L,8L,9L,7L,5L,3L,8L,7L,8L,8L,8L,9L,6L,3L,8L,6L,5L,9L,5L,8L,9L,5L,7L,9L,6L,3L,6L,6L,8L,9L,8L,4L,6L,9L,6L,9L,7L,8L,9L,6L,8L,8L,4L,7L,3L,8L,8L,9L,4L,9L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257779Inst : IEnumerable<long>
{
public static readonly long[] Value=A257779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257779.Bytes);
public long this[int i]=>Value[i];

public static A257779Inst Instance=new A257779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257780
{
public static readonly BigInteger[] Value={ 3854L,5170L,369890L,496226L,35505586L,47632526L,3408166366L,4572226270L,327148465550L,438886089394L,31402844526434L,42128492355554L,3014345926072114L,4043896380043790L,289345806058396510L,388171923991848286L,BigInteger.Parse("27774183035679992846"),BigInteger.Parse("37260460806837391666") };
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
public class A257780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257780Inst Instance=new A257780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257781
{
public static readonly long[] Value={ 245L,385L,495L,655L,795L,1055L,1365L,2205L,2855L,3795L,4615L,6135L,7945L,12845L,16635L,22115L,26895L,35755L,46305L,74865L,96955L,128895L,156755L,208395L,269885L,436345L,565095L,751255L,913635L,1214615L,1573005L,2543205L,3293615L,4378635L,5325055L,7079295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257781Inst : IEnumerable<long>
{
public static readonly long[] Value=A257781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257781.Bytes);
public long this[int i]=>Value[i];

public static A257781Inst Instance=new A257781Inst();

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