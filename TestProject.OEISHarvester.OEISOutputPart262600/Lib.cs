using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A285186
{
public static readonly long[] Value={ 0L,1L,4L,10L,26L,64L,160L,396L,984L,2440L,6056L,15024L,37280L,92496L,229504L,569440L,1412896L,3505664L,8698240L,21582016L,53549184L,132865920L,329666176L,817965824L,2029532160L,5035663616L,12494459904L,31001182720L,76919958016L,190853361664L,473544273920L,1174955355136L,2915292534784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285186Inst : IEnumerable<long>
{
public static readonly long[] Value=A285186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285186.Bytes);
public long this[int i]=>Value[i];

public static A285186Inst Instance=new A285186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285187
{
public static readonly long[] Value={ 1L,3L,3L,7L,9L,15L,22L,33L,48L,71L,101L,147L,208L,297L,419L,591L,829L,1161L,1619L,2255L,3130L,4339L,6000L,8285L,11419L,15717L,21600L,29649L,40645L,55659L,76135L,104043L,142045L,193759L,264078L,359637L,489408L,665539L,904449L,1228343L,1667216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285187Inst : IEnumerable<long>
{
public static readonly long[] Value=A285187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285187.Bytes);
public long this[int i]=>Value[i];

public static A285187Inst Instance=new A285187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285300
{
public static readonly long[] Value={ 65L,133L,529L,793L,1649L,2059L,2321L,4187L,5185L,6305L,6541L,6697L,6817L,7471L,7613L,8113L,10963L,11521L,13213L,13333L,13427L,14701L,14981L,19171L,19201L,19909L,21349L,21667L,22177L,26065L,26467L,32873L,35443L,36569L,37333L,38897L,42121L,42127L,44023L,47081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285300Inst : IEnumerable<long>
{
public static readonly long[] Value=A285300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285300.Bytes);
public long this[int i]=>Value[i];

public static A285300Inst Instance=new A285300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285301
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285301Inst : IEnumerable<long>
{
public static readonly long[] Value=A285301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285301.Bytes);
public long this[int i]=>Value[i];

public static A285301Inst Instance=new A285301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285302
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,10L,12L,13L,14L,16L,18L,19L,20L,22L,24L,25L,26L,28L,30L,31L,32L,34L,36L,38L,40L,41L,42L,44L,46L,47L,48L,50L,52L,54L,56L,57L,58L,60L,62L,63L,64L,66L,68L,70L,72L,73L,74L,76L,78L,79L,80L,82L,84L,86L,88L,89L,90L,92L,94L,95L,96L,98L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285302Inst : IEnumerable<long>
{
public static readonly long[] Value=A285302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285302.Bytes);
public long this[int i]=>Value[i];

public static A285302Inst Instance=new A285302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285303
{
public static readonly long[] Value={ 3L,4L,6L,9L,13L,14L,18L,20L,22L,26L,28L,31L,34L,38L,40L,43L,47L,48L,52L,53L,57L,59L,62L,66L,67L,71L,73L,75L,79L,81L,83L,87L,89L,92L,96L,97L,101L,103L,105L,109L,111L,114L,117L,121L,123L,126L,129L,133L,135L,138L,142L,143L,147L,149L,151L,155L,157L,160L,163L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285303Inst : IEnumerable<long>
{
public static readonly long[] Value=A285303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285303.Bytes);
public long this[int i]=>Value[i];

public static A285303Inst Instance=new A285303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285304
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,11L,13L,16L,17L,19L,22L,23L,25L,27L,29L,31L,32L,34L,37L,41L,43L,46L,47L,49L,52L,53L,55L,57L,59L,61L,64L,67L,71L,73L,74L,79L,81L,82L,83L,85L,88L,89L,92L,94L,97L,101L,103L,106L,107L,109L,113L,115L,117L,119L,121L,125L,127L,131L,134L,136L,137L,139L,141L,142L,145L,149L,151L,157L,158L,163L,167L,169L,171L,173L,175L,178L,179L,181L,185L,187L,189L,190L,191L,193L,194L,196L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285304Inst : IEnumerable<long>
{
public static readonly long[] Value=A285304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285304.Bytes);
public long this[int i]=>Value[i];

public static A285304Inst Instance=new A285304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285305
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285305Inst : IEnumerable<long>
{
public static readonly long[] Value=A285305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285305.Bytes);
public long this[int i]=>Value[i];

public static A285305Inst Instance=new A285305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285306
{
public static readonly long[] Value={ 2L,3L,6L,8L,10L,11L,14L,15L,18L,20L,21L,24L,26L,27L,30L,32L,34L,35L,38L,39L,42L,44L,46L,47L,50L,51L,54L,56L,57L,60L,62L,64L,65L,68L,69L,72L,74L,75L,78L,80L,82L,83L,86L,87L,90L,92L,93L,96L,98L,99L,102L,104L,106L,107L,110L,111L,114L,116L,118L,119L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285306Inst : IEnumerable<long>
{
public static readonly long[] Value=A285306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285306.Bytes);
public long this[int i]=>Value[i];

public static A285306Inst Instance=new A285306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285307
{
public static readonly long[] Value={ 1L,4L,5L,7L,9L,12L,13L,16L,17L,19L,22L,23L,25L,28L,29L,31L,33L,36L,37L,40L,41L,43L,45L,48L,49L,52L,53L,55L,58L,59L,61L,63L,66L,67L,70L,71L,73L,76L,77L,79L,81L,84L,85L,88L,89L,91L,94L,95L,97L,100L,101L,103L,105L,108L,109L,112L,113L,115L,117L,120L,121L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285307Inst : IEnumerable<long>
{
public static readonly long[] Value=A285307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285307.Bytes);
public long this[int i]=>Value[i];

public static A285307Inst Instance=new A285307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285308
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,3L,4L,4L,6L,8L,7L,8L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285308Inst : IEnumerable<long>
{
public static readonly long[] Value=A285308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285308.Bytes);
public long this[int i]=>Value[i];

public static A285308Inst Instance=new A285308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285309
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,11L,7L,10L,3L,17L,11L,23L,13L,23L,23L,10L,17L,29L,19L,37L,31L,35L,23L,55L,5L,41L,30L,51L,29L,71L,31L,42L,47L,53L,47L,41L,37L,59L,55L,85L,41L,95L,43L,79L,68L,71L,47L,103L,7L,67L,71L,93L,53L,110L,71L,115L,79L,89L,59L,163L,61L,95L,94L,42L,83L,143L,67L,121L,95L,143L,71L,145L,73L,113L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285309Inst : IEnumerable<long>
{
public static readonly long[] Value=A285309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285309.Bytes);
public long this[int i]=>Value[i];

public static A285309Inst Instance=new A285309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285310
{
public static readonly long[] Value={ 1L,0L,-2L,0L,3L,-5L,-4L,10L,-3L,-15L,25L,9L,-47L,37L,55L,-118L,28L,182L,-231L,-88L,484L,-351L,-474L,1047L,-306L,-1479L,1985L,370L,-3657L,3120L,2757L,-7868L,3686L,8889L,-14950L,1255L,22540L,-25069L,-9557L,49333L,-35638L,-40172L,96943L,-37509L,-111145L,172256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285310Inst : IEnumerable<long>
{
public static readonly long[] Value=A285310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285310.Bytes);
public long this[int i]=>Value[i];

public static A285310Inst Instance=new A285310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285311
{
public static readonly long[] Value={ 1L,0L,0L,-3L,0L,0L,6L,-7L,0L,-10L,21L,-11L,15L,-42L,61L,-36L,70L,-150L,150L,-124L,278L,-441L,375L,-468L,909L,-1131L,1018L,-1581L,2602L,-2810L,2947L,-4819L,6768L,-6980L,8509L,-13389L,16788L,-17609L,23722L,-34720L,40337L,-44863L,63128L,-85430L,95887L,-114037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285311Inst : IEnumerable<long>
{
public static readonly long[] Value=A285311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285311.Bytes);
public long this[int i]=>Value[i];

public static A285311Inst Instance=new A285311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285312
{
public static readonly long[] Value={ 2L,6L,12L,15L,21L,50L,85L,100L,182L,210L,215L,364L,553L,560L,854L,931L,1120L,1870L,2058L,2422L,2653L,4477L,6369L,7667L,10373L,10934L,13794L,14377L,15411L,20163L,25542L,27423L,28094L,34398L,52275L,59085L,85170L,115362L,131690L,138944L,143143L,154323L,248761L,265850L,271040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285312Inst : IEnumerable<long>
{
public static readonly long[] Value=A285312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285312.Bytes);
public long this[int i]=>Value[i];

public static A285312Inst Instance=new A285312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285313
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285313Inst : IEnumerable<long>
{
public static readonly long[] Value=A285313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285313.Bytes);
public long this[int i]=>Value[i];

public static A285313Inst Instance=new A285313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285314
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,13L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285314Inst : IEnumerable<long>
{
public static readonly long[] Value=A285314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285314.Bytes);
public long this[int i]=>Value[i];

public static A285314Inst Instance=new A285314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285315
{
public static readonly long[] Value={ 8L,16L,32L,33L,64L,65L,66L,128L,129L,130L,131L,132L,136L,256L,257L,258L,259L,260L,261L,264L,272L,512L,513L,514L,515L,516L,517L,518L,520L,521L,528L,544L,576L,640L,768L,1024L,1025L,1026L,1027L,1028L,1029L,1030L,1031L,1032L,1033L,1034L,1040L,1041L,1042L,1056L,1057L,1088L,1089L,1152L,1280L,1536L,2048L,2049L,2050L,2051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285315Inst : IEnumerable<long>
{
public static readonly long[] Value=A285315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285315.Bytes);
public long this[int i]=>Value[i];

public static A285315Inst Instance=new A285315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285540
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1111L,111L,111111L,1111L,11111111L,11111L,1111111111L,111111L,111111111111L,1111111L,11111111111111L,11111111L,1111111111111111L,111111111L,111111111111111111L,1111111111L,11111111111111111111UL,11111111111L,BigInteger.Parse("1111111111111111111111"),111111111111L };
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
public class A285540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285540Inst Instance=new A285540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285541
{
public static readonly ulong[] Value={ 1L,11L,110L,1111L,11100L,111111L,1111000L,11111111L,111110000L,1111111111L,11111100000L,111111111111L,1111111000000L,11111111111111L,111111110000000L,1111111111111111L,11111111100000000L,111111111111111111L,1111111111000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285541Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A285541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285541.Bytes);
public ulong this[int i]=>Value[i];

public static A285541Inst Instance=new A285541Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285542
{
public static readonly long[] Value={ 1L,3L,3L,15L,7L,63L,15L,255L,31L,1023L,63L,4095L,127L,16383L,255L,65535L,511L,262143L,1023L,1048575L,2047L,4194303L,4095L,16777215L,8191L,67108863L,16383L,268435455L,32767L,1073741823L,65535L,4294967295L,131071L,17179869183L,262143L,68719476735L,524287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285542Inst : IEnumerable<long>
{
public static readonly long[] Value=A285542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285542.Bytes);
public long this[int i]=>Value[i];

public static A285542Inst Instance=new A285542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285543
{
public static readonly long[] Value={ 1L,3L,6L,15L,28L,63L,120L,255L,496L,1023L,2016L,4095L,8128L,16383L,32640L,65535L,130816L,262143L,523776L,1048575L,2096128L,4194303L,8386560L,16777215L,33550336L,67108863L,134209536L,268435455L,536854528L,1073741823L,2147450880L,4294967295L,8589869056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285543Inst : IEnumerable<long>
{
public static readonly long[] Value=A285543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285543.Bytes);
public long this[int i]=>Value[i];

public static A285543Inst Instance=new A285543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285544
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1100L,111L,111000L,1111L,11110010L,11101L,1111100010L,111101L,111111001110L,1110001L,11111110001110L,11111011L,1111111100110100L,111001011L,111111111000110110L,1111111001L,11111111110011000110UL,11100111001L,BigInteger.Parse("1111111111100011101110"),111111010001L };
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
public class A285544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285544Inst Instance=new A285544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285545
{
public static readonly BigInteger[] Value={ 1L,1L,110L,11L,11100L,111L,1111000L,1001111L,101110000L,100011111L,10111100000L,11100111111L,1000111000000L,1110001111111L,110111110000000L,10110011111111L,11010011100000000L,11011000111111111L,1001111111000000000L,1100011001111111111L,BigInteger.Parse("100111001110000000000") };
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
public class A285545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285545Inst Instance=new A285545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285546
{
public static readonly long[] Value={ 1L,2L,3L,12L,7L,56L,15L,242L,29L,994L,61L,4046L,113L,16270L,251L,65332L,459L,261686L,1017L,1047750L,1849L,4192494L,4049L,16773934L,7387L,67101668L,16155L,268422374L,29625L,1073712966L,64703L,4294914920L,118679L,17179753576L,258967L,68719267560L,474391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285546Inst : IEnumerable<long>
{
public static readonly long[] Value=A285546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285546.Bytes);
public long this[int i]=>Value[i];

public static A285546Inst Instance=new A285546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285547
{
public static readonly long[] Value={ 1L,1L,6L,3L,28L,7L,120L,79L,368L,287L,1504L,1855L,4544L,7295L,28544L,11519L,108288L,111103L,327168L,406527L,1285120L,1951743L,4585472L,7655423L,28733440L,10428415L,113762304L,108216319L,330940416L,415006719L,2124382208L,382533631L,7850098688L,1492254719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285547Inst : IEnumerable<long>
{
public static readonly long[] Value=A285547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285547.Bytes);
public long this[int i]=>Value[i];

public static A285547Inst Instance=new A285547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285548
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,6L,4L,1L,6L,10L,10L,5L,1L,6L,21L,20L,15L,6L,1L,13L,24L,55L,35L,21L,7L,1L,10L,92L,76L,120L,56L,28L,8L,1L,24L,78L,430L,201L,231L,84L,36L,9L,1L,22L,327L,460L,1505L,462L,406L,120L,45L,10L,1L,45L,443L,2605L,2015L,4291L,952L,666L,165L,55L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285548Inst : IEnumerable<long>
{
public static readonly long[] Value=A285548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285548.Bytes);
public long this[int i]=>Value[i];

public static A285548Inst Instance=new A285548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285549
{
public static readonly long[] Value={ 341L,2701L,721801L,721801L,42702661L,1112103541L,2380603501L,5202153001L,17231383261L,251994268081L,1729579597021L,55181730338101L,142621888086541L,242017633321201L,242017633321201L,242017633321201L,1174858593838021L,1174858593838021L,168562580058457201L,790489610041255741L,790489610041255741L,790489610041255741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285549Inst : IEnumerable<long>
{
public static readonly long[] Value=A285549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285549.Bytes);
public long this[int i]=>Value[i];

public static A285549Inst Instance=new A285549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285550
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,10L,12L,20L,21L,30L,38L,70L,97L,100L,102L,107L,120L,138L,200L,201L,210L,212L,300L,380L,648L,700L,701L,951L,970L,997L,1000L,1002L,1007L,1020L,1049L,1070L,1200L,1380L,1393L,2000L,2001L,2010L,2100L,2120L,3000L,3148L,3153L,3451L,3743L,3747L,3800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285550Inst : IEnumerable<long>
{
public static readonly long[] Value=A285550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285550.Bytes);
public long this[int i]=>Value[i];

public static A285550Inst Instance=new A285550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285551
{
public static readonly long[] Value={ 1L,2L,8L,12L,36L,80L,175L,441L,972L,2304L,5376L,12348L,29008L,67081L,156065L,363350L,843144L,1962396L,4560200L,10600000L,24648975L,57288465L,133194600L,309636096L,719790336L,1673379352L,3890033728L,9043304417L,21023197601L,48872682810L,113615800200L,264124052396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285551Inst : IEnumerable<long>
{
public static readonly long[] Value=A285551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285551.Bytes);
public long this[int i]=>Value[i];

public static A285551Inst Instance=new A285551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285552
{
public static readonly long[] Value={ 23L,224L,128L,3712L,896L,512L,1536L,54272L,14848L,11264L,3584L,11776L,2048L,6144L,20480L,833536L,217088L,94208L,59392L,45056L,116736L,22528L,14336L,118784L,47104L,8192L,63488L,24576L,49152L,81920L,294912L,13082624L,3334144L,1564672L,868352L,548864L,376832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285552Inst : IEnumerable<long>
{
public static readonly long[] Value=A285552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285552.Bytes);
public long this[int i]=>Value[i];

public static A285552Inst Instance=new A285552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285553
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,20L,23L,24L,26L,36L,56L,224L,411L,543L,611L,1541L,1632L,3719L,3888L,4917L,11454L,24275L,51816L,58563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285553Inst : IEnumerable<long>
{
public static readonly long[] Value=A285553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285553.Bytes);
public long this[int i]=>Value[i];

public static A285553Inst Instance=new A285553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285554
{
public static readonly long[] Value={ 0L,1L,-2L,1L,1L,-2L,3L,-3L,1L,1L,-4L,8L,-9L,5L,3L,-12L,18L,-18L,10L,5L,-22L,37L,-40L,21L,12L,-47L,72L,-71L,38L,19L,-84L,133L,-135L,73L,38L,-156L,235L,-232L,124L,61L,-264L,407L,-404L,216L,109L,-455L,682L,-664L,354L,172L,-738L,1117L,-1094L,582L,286L,-1203L,1793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285554Inst : IEnumerable<long>
{
public static readonly long[] Value=A285554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285554.Bytes);
public long this[int i]=>Value[i];

public static A285554Inst Instance=new A285554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285555
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,2L,-3L,3L,-2L,-1L,5L,-8L,8L,-5L,-2L,12L,-18L,18L,-11L,-5L,24L,-37L,37L,-21L,-10L,47L,-72L,71L,-40L,-19L,88L,-133L,131L,-73L,-35L,156L,-236L,232L,-127L,-61L,270L,-407L,397L,-216L,-104L,455L,-682L,664L,-359L,-172L,747L,-1117L,1084L,-582L,-279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285555Inst : IEnumerable<long>
{
public static readonly long[] Value=A285555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285555.Bytes);
public long this[int i]=>Value[i];

public static A285555Inst Instance=new A285555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285605
{
public static readonly BigInteger[] Value={ 1L,1L,110L,11L,11100L,111L,1111000L,1001111L,101110000L,110011111L,11111100000L,11100111111L,1000111000000L,1111001111111L,110011110000000L,11110011111111L,11011011100000000L,11001100111111111L,1111101111000000000L,111111001111111111L,BigInteger.Parse("111000001110000000000") };
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
public class A285605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285605Inst Instance=new A285605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285606
{
public static readonly long[] Value={ 1L,2L,3L,12L,7L,56L,15L,242L,29L,998L,63L,4046L,113L,16286L,243L,65340L,475L,261734L,991L,1047804L,1799L,4192760L,4075L,16774010L,7411L,67102540L,15479L,268422760L,30687L,1073715808L,62943L,4294916192L,119231L,17179765600L,249023L,68719277930L,470837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285606Inst : IEnumerable<long>
{
public static readonly long[] Value=A285606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285606.Bytes);
public long this[int i]=>Value[i];

public static A285606Inst Instance=new A285606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285607
{
public static readonly long[] Value={ 1L,1L,6L,3L,28L,7L,120L,79L,368L,415L,2016L,1855L,4544L,7807L,26496L,15615L,112384L,104959L,515584L,259071L,1842176L,518143L,7075840L,6213631L,27160576L,13344767L,124903424L,23543807L,528334848L,26640383L,2111275008L,102563839L,8507555840L,458883071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285607Inst : IEnumerable<long>
{
public static readonly long[] Value=A285607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285607.Bytes);
public long this[int i]=>Value[i];

public static A285607Inst Instance=new A285607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285608
{
public static readonly long[] Value={ 1L,1L,10L,10L,110L,110L,1110L,1110L,11110L,11110L,111110L,111100L,1111100L,1111100L,11111110L,11111100L,111111100L,111111110L,1111111110L,1111111110L,11111111110L,11111111110L,111111111110L,111111111110L,1111111111110L,1111111111110L,11111111110000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285608Inst : IEnumerable<long>
{
public static readonly long[] Value=A285608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285608.Bytes);
public long this[int i]=>Value[i];

public static A285608Inst Instance=new A285608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285609
{
public static readonly ulong[] Value={ 1L,10L,10L,100L,1100L,11000L,111000L,1110000L,11110000L,111100000L,1111100000L,1111000000L,11111000000L,111110000000L,11111110000000L,11111100000000L,111111100000000L,11111111000000000L,111111111000000000L,1111111110000000000L,11111111110000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285609Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A285609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285609.Bytes);
public ulong this[int i]=>Value[i];

public static A285609Inst Instance=new A285609Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285610
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,6L,14L,14L,30L,30L,62L,60L,124L,124L,254L,252L,508L,510L,1022L,1022L,2046L,2046L,4094L,4094L,8190L,8190L,16368L,16368L,32760L,32754L,65522L,65532L,130940L,130942L,262014L,261950L,524152L,524090L,1048440L,1048564L,2096252L,2096254L,4189822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285610Inst : IEnumerable<long>
{
public static readonly long[] Value=A285610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285610.Bytes);
public long this[int i]=>Value[i];

public static A285610Inst Instance=new A285610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285611
{
public static readonly long[] Value={ 1L,2L,2L,4L,12L,24L,56L,112L,240L,480L,992L,960L,1984L,3968L,16256L,16128L,32512L,130560L,261632L,523264L,1047552L,2095104L,4192256L,8384512L,16773120L,33546240L,8380416L,16760832L,67092480L,335511552L,671055872L,1073676288L,2113863680L,8522694656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285611Inst : IEnumerable<long>
{
public static readonly long[] Value=A285611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285611.Bytes);
public long this[int i]=>Value[i];

public static A285611Inst Instance=new A285611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285612
{
public static readonly long[] Value={ 1L,1L,10L,10L,110L,110L,1110L,1110L,11110L,11110L,111110L,111110L,1111110L,1111110L,11111110L,11111110L,111111110L,111111110L,1111111110L,1111111110L,11111111110L,11111111110L,111111111110L,111111111110L,1111111111110L,1111111111110L,11111111111110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285612Inst : IEnumerable<long>
{
public static readonly long[] Value=A285612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285612.Bytes);
public long this[int i]=>Value[i];

public static A285612Inst Instance=new A285612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285613
{
public static readonly ulong[] Value={ 1L,10L,10L,100L,1100L,11000L,111000L,1110000L,11110000L,111100000L,1111100000L,11111000000L,111111000000L,1111110000000L,11111110000000L,111111100000000L,1111111100000000L,11111111000000000L,111111111000000000L,1111111110000000000L,11111111110000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285613Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A285613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285613.Bytes);
public ulong this[int i]=>Value[i];

public static A285613Inst Instance=new A285613Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285614
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,12L,14L,18L,21L,22L,26L,30L,42L,60L,66L,78L,90L,102L,114L,130L,138L,150L,170L,174L,186L,210L,294L,318L,330L,390L,462L,510L,546L,570L,690L,798L,858L,870L,930L,1050L,1110L,1218L,1230L,1290L,1410L,1470L,1554L,1590L,1722L,1770L,1830L,1974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285614Inst : IEnumerable<long>
{
public static readonly long[] Value=A285614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285614.Bytes);
public long this[int i]=>Value[i];

public static A285614Inst Instance=new A285614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285615
{
public static readonly long[] Value={ 30030L,39270L,43890L,46410L,51870L,53130L,62790L,66990L,67830L,71610L,79170L,82110L,84630L,85470L,91770L,94710L,99330L,101010L,103530L,108570L,111930L,117390L,122430L,128310L,136290L,140910L,144690L,154770L,161070L,164010L,166530L,168630L,182490L,191730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285615Inst : IEnumerable<long>
{
public static readonly long[] Value=A285615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285615.Bytes);
public long this[int i]=>Value[i];

public static A285615Inst Instance=new A285615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285616
{
public static readonly BigInteger[] Value={ 2L,4L,4L,96L,24L,8L,31840L,816L,96L,16L,2147156736L,322240L,4320L,320L,32L,9223372011084915712L,25767883392L,1957440L,18240L,960L,64L,BigInteger.Parse("170141183460469231602560095199828453376"),BigInteger.Parse("129127208335656968192"),180389362944L,9251200L,67200L,2688L,128L };
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
public class A285616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285616Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285616.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285616.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285616Inst Instance=new A285616Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285617
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285617Inst : IEnumerable<long>
{
public static readonly long[] Value=A285617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285617.Bytes);
public long this[int i]=>Value[i];

public static A285617Inst Instance=new A285617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285618
{
public static readonly long[] Value={ 2L,3L,4L,12L,13L,14L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,30L,32L,33L,34L,36L,37L,38L,46L,47L,48L,56L,57L,58L,66L,67L,68L,76L,77L,78L,86L,87L,88L,96L,97L,98L,106L,107L,108L,110L,111L,112L,114L,115L,116L,118L,119L,120L,122L,123L,124L,126L,127L,128L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285618Inst : IEnumerable<long>
{
public static readonly long[] Value=A285618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285618.Bytes);
public long this[int i]=>Value[i];

public static A285618Inst Instance=new A285618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285619
{
public static readonly long[] Value={ 1L,5L,6L,7L,8L,9L,10L,11L,15L,19L,23L,27L,31L,35L,39L,40L,41L,42L,43L,44L,45L,49L,50L,51L,52L,53L,54L,55L,59L,60L,61L,62L,63L,64L,65L,69L,70L,71L,72L,73L,74L,75L,79L,80L,81L,82L,83L,84L,85L,89L,90L,91L,92L,93L,94L,95L,99L,100L,101L,102L,103L,104L,105L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285619Inst : IEnumerable<long>
{
public static readonly long[] Value=A285619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285619.Bytes);
public long this[int i]=>Value[i];

public static A285619Inst Instance=new A285619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285620
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,8L,4L,12L,8L,20L,8L,48L,14L,48L,44L,88L,36L,192L,60L,336L,200L,416L,188L,1344L,424L,1400L,944L,3104L,1182L,8768L,2192L,8784L,6768L,16460L,11144L,46848L,14602L,58288L,44424L,138432L,52488L,355200L,99880L,432576L,351712L,762608L,364724L,2151936L,798960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285620Inst : IEnumerable<long>
{
public static readonly long[] Value=A285620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285620.Bytes);
public long this[int i]=>Value[i];

public static A285620Inst Instance=new A285620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285685
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285685Inst : IEnumerable<long>
{
public static readonly long[] Value=A285685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285685.Bytes);
public long this[int i]=>Value[i];

public static A285685Inst Instance=new A285685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285686
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285686Inst : IEnumerable<long>
{
public static readonly long[] Value=A285686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285686.Bytes);
public long this[int i]=>Value[i];

public static A285686Inst Instance=new A285686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285687
{
public static readonly long[] Value={ 10L,12L,13L,14L,15L,16L,17L,18L,19L,1L,21L,2L,3L,4L,5L,6L,7L,8L,9L,22L,11L,20L,30L,32L,42L,52L,62L,72L,82L,23L,33L,24L,31L,40L,43L,53L,63L,73L,83L,34L,44L,25L,35L,41L,50L,54L,64L,74L,84L,45L,55L,26L,36L,46L,51L,60L,65L,75L,85L,56L,66L,27L,37L,47L,57L,61L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285687Inst : IEnumerable<long>
{
public static readonly long[] Value=A285687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285687.Bytes);
public long this[int i]=>Value[i];

public static A285687Inst Instance=new A285687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285688
{
public static readonly long[] Value={ 2L,29L,37L,67L,79L,97L,109L,127L,139L,151L,163L,181L,193L,211L,223L,241L,269L,277L,307L,337L,349L,367L,379L,397L,409L,421L,433L,461L,479L,487L,499L,541L,569L,577L,607L,619L,631L,643L,661L,673L,691L,709L,727L,739L,751L,769L,787L,829L,857L,877L,907L,919L,937L,967L,997L,1009L,1021L,1033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285688Inst : IEnumerable<long>
{
public static readonly long[] Value=A285688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285688.Bytes);
public long this[int i]=>Value[i];

public static A285688Inst Instance=new A285688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285689
{
public static readonly long[] Value={ 2L,83L,107L,131L,167L,191L,227L,251L,307L,331L,347L,383L,419L,443L,467L,491L,547L,563L,587L,641L,677L,701L,757L,773L,797L,821L,857L,881L,937L,953L,977L,1013L,1049L,1103L,1163L,1187L,1223L,1259L,1283L,1307L,1361L,1451L,1487L,1511L,1567L,1583L,1607L,1663L,1699L,1723L,1747L,1783L,1823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285689Inst : IEnumerable<long>
{
public static readonly long[] Value=A285689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285689.Bytes);
public long this[int i]=>Value[i];

public static A285689Inst Instance=new A285689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285690
{
public static readonly long[] Value={ 2L,569L,601L,673L,853L,1021L,1069L,1117L,1229L,1277L,1439L,1471L,1543L,1663L,1783L,1831L,1879L,1951L,1999L,2111L,2143L,2251L,2371L,2539L,2647L,2719L,2767L,2879L,2927L,2999L,3079L,3187L,3259L,3307L,3469L,3517L,3637L,3709L,3821L,3853L,4021L,4093L,4201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285690Inst : IEnumerable<long>
{
public static readonly long[] Value=A285690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285690.Bytes);
public long this[int i]=>Value[i];

public static A285690Inst Instance=new A285690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285691
{
public static readonly long[] Value={ 2L,1217L,1361L,1601L,1697L,1913L,2129L,2273L,2417L,2633L,2729L,2953L,3049L,3209L,3433L,3529L,3593L,3833L,3929L,4073L,4217L,4441L,4657L,4721L,4817L,5153L,5297L,5393L,5717L,5813L,6029L,6173L,6269L,6829L,7069L,7213L,7309L,7549L,7789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285691Inst : IEnumerable<long>
{
public static readonly long[] Value=A285691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285691.Bytes);
public long this[int i]=>Value[i];

public static A285691Inst Instance=new A285691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285692
{
public static readonly long[] Value={ 2L,9479L,9767L,10247L,10567L,11047L,11239L,11527L,11719L,12007L,12487L,12919L,13367L,13687L,13879L,14071L,14503L,14951L,15271L,15559L,15991L,16183L,16631L,16759L,17047L,17239L,17431L,17623L,17911L,18199L,18679L,19687L,20359L,20551L,20743L,21031L,21319L,21751L,21943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285692Inst : IEnumerable<long>
{
public static readonly long[] Value=A285692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285692.Bytes);
public long this[int i]=>Value[i];

public static A285692Inst Instance=new A285692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285693
{
public static readonly long[] Value={ 2L,6563L,6947L,7331L,7907L,8291L,8867L,10163L,10739L,11699L,12659L,13043L,13619L,15731L,16691L,17987L,18371L,18947L,19843L,20483L,21059L,23003L,23899L,24763L,25147L,26107L,26683L,27067L,28027L,28283L,28859L,29243L,29819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285693Inst : IEnumerable<long>
{
public static readonly long[] Value=A285693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285693.Bytes);
public long this[int i]=>Value[i];

public static A285693Inst Instance=new A285693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285694
{
public static readonly long[] Value={ 2L,59051L,62507L,64811L,66347L,67883L,71339L,73643L,81707L,83243L,87083L,89387L,91691L,95531L,99371L,100907L,104491L,110251L,115883L,119723L,121259L,126443L,127979L,136043L,139627L,141931L,143467L,145771L,148331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285694Inst : IEnumerable<long>
{
public static readonly long[] Value=A285694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285694.Bytes);
public long this[int i]=>Value[i];

public static A285694Inst Instance=new A285694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285695
{
public static readonly long[] Value={ 0L,31202L,110140L,312122L,1101106L,1131404L,3121124L,3131226L,5111424L,5120200L,5300402L,5320004L,11011162L,11034000L,11112160L,11314142L,13030060L,15014020L,31211144L,31232200L,31312164L,33000160L,33202120L,33230240L,35010260L,35212220L,51034202L,51114144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285695Inst : IEnumerable<long>
{
public static readonly long[] Value=A285695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285695.Bytes);
public long this[int i]=>Value[i];

public static A285695Inst Instance=new A285695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285696
{
public static readonly long[] Value={ 110L,11112L,33000L,110110L,313122L,1111114L,1133200L,1303102L,1333004L,1531202L,3103120L,3130210L,3300112L,3330014L,3333222L,3501122L,3531024L,5113220L,5310212L,5313024L,5500000L,5511222L,11011112L,11033000L,11112110L,11313142L,13030010L,15013020L,31312114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285696Inst : IEnumerable<long>
{
public static readonly long[] Value=A285696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285696.Bytes);
public long this[int i]=>Value[i];

public static A285696Inst Instance=new A285696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285697
{
public static readonly long[] Value={ 2L,4L,5L,10L,12L,13L,15L,16L,18L,19L,24L,26L,27L,32L,34L,35L,37L,38L,40L,41L,43L,44L,46L,47L,52L,54L,55L,60L,62L,63L,65L,66L,68L,69L,74L,76L,77L,82L,84L,85L,87L,88L,90L,91L,93L,94L,96L,97L,99L,100L,102L,103L,108L,110L,111L,116L,118L,119L,121L,122L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285697Inst : IEnumerable<long>
{
public static readonly long[] Value=A285697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285697.Bytes);
public long this[int i]=>Value[i];

public static A285697Inst Instance=new A285697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285698
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,20L,110L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285698Inst : IEnumerable<long>
{
public static readonly long[] Value=A285698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285698.Bytes);
public long this[int i]=>Value[i];

public static A285698Inst Instance=new A285698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285699
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,6L,4L,6L,2L,10L,3L,12L,6L,6L,8L,16L,2L,18L,4L,12L,6L,22L,6L,20L,10L,18L,12L,28L,3L,30L,16L,6L,2L,10L,4L,36L,6L,12L,8L,40L,6L,42L,12L,18L,14L,46L,12L,42L,10L,24L,20L,52L,6L,30L,7L,30L,26L,58L,6L,60L,30L,14L,32L,40L,2L,66L,4L,42L,6L,70L,8L,72L,10L,30L,12L,28L,6L,78L,16L,54L,18L,82L,3L,60L,22L,6L,24L,88L,9L,42L,28L,12L,30L,70L,15L,96L,34L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285699Inst : IEnumerable<long>
{
public static readonly long[] Value=A285699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285699.Bytes);
public long this[int i]=>Value[i];

public static A285699Inst Instance=new A285699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285700
{
public static readonly long[] Value={ 0L,3L,2L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,3L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,3L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285700Inst : IEnumerable<long>
{
public static readonly long[] Value=A285700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285700.Bytes);
public long this[int i]=>Value[i];

public static A285700Inst Instance=new A285700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285765
{
public static readonly long[] Value={ 1L,15L,495L,64815L,33478163L,68694593248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285765Inst : IEnumerable<long>
{
public static readonly long[] Value=A285765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285765.Bytes);
public long this[int i]=>Value[i];

public static A285765Inst Instance=new A285765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285766
{
public static readonly long[] Value={ 0L,0L,6L,10L,15L,22L,31L,42L,55L,70L,87L,106L,127L,150L,175L,202L,231L,262L,295L,330L,367L,406L,447L,490L,535L,582L,631L,682L,735L,790L,847L,906L,967L,1030L,1095L,1162L,1231L,1302L,1375L,1450L,1527L,1606L,1687L,1770L,1855L,1942L,2031L,2122L,2215L,2310L,2407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285766Inst : IEnumerable<long>
{
public static readonly long[] Value=A285766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285766.Bytes);
public long this[int i]=>Value[i];

public static A285766Inst Instance=new A285766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285767
{
public static readonly long[] Value={ 0L,408L,11041L,18096L,22016L,23056L,28033L,38081L,56033L,61061L,1140833L,1170625L,1250656L,1410416L,1460216L,1540833L,2120161L,2130261L,2140385L,2150533L,2310896L,2390561L,2460696L,2520833L,2570576L,2780181L,2920533L,3230256L,3280256L,3490565L,3660865L,3680776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285767Inst : IEnumerable<long>
{
public static readonly long[] Value=A285767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285767.Bytes);
public long this[int i]=>Value[i];

public static A285767Inst Instance=new A285767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285768
{
public static readonly BigInteger[] Value={ 1L,10L,110L,1100L,11110L,110990L,1111110L,11110000L,111111000L,1111099990L,11111111110L,111110998900L,1111111111110L,11111109999990L,111111111099890L,1111111100000000L,11111111111111110L,111111110999889000L,1111111111111111110L,11111111109999998900UL,BigInteger.Parse("111111111111109999890") };
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
public class A285768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285768Inst Instance=new A285768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285769
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,36L,13L,14L,15L,16L,17L,36L,19L,100L,21L,22L,23L,216L,25L,26L,27L,196L,29L,30L,31L,32L,33L,34L,35L,1296L,37L,38L,39L,1000L,41L,42L,43L,484L,225L,46L,47L,1296L,49L,100L,51L,676L,53L,216L,55L,2744L,57L,58L,59L,900L,61L,62L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285769Inst : IEnumerable<long>
{
public static readonly long[] Value=A285769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285769.Bytes);
public long this[int i]=>Value[i];

public static A285769Inst Instance=new A285769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285770
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,0L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,4L,5L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,3L,3L,1L,2L,3L,1L,1L,2L,0L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,3L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285770Inst : IEnumerable<long>
{
public static readonly long[] Value=A285770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285770.Bytes);
public long this[int i]=>Value[i];

public static A285770Inst Instance=new A285770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285771
{
public static readonly long[] Value={ 1L,0L,10L,0L,100L,0L,1010L,0L,10000L,0L,101000L,0L,1000100L,0L,10101010L,0L,100000000L,0L,1010000000L,0L,10001000000L,0L,101010100000L,0L,1000000010000L,0L,10100000101000L,0L,100010001000100L,0L,1010101010101010L,0L,10000000000000000L,0L,101000000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285771Inst : IEnumerable<long>
{
public static readonly long[] Value=A285771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285771.Bytes);
public long this[int i]=>Value[i];

public static A285771Inst Instance=new A285771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285772
{
public static readonly BigInteger[] Value={ 1L,0L,10L,0L,100L,0L,101000L,0L,10000L,0L,10100000L,0L,10001000000L,0L,10101010000000L,0L,100000000L,0L,101000000000L,0L,100010000000000L,0L,101010100000000000L,0L,BigInteger.Parse("100000001000000000000"),0L,BigInteger.Parse("101000001010000000000000"),0L,BigInteger.Parse("100010001000100000000000000"),0L };
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
public class A285772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285772Inst Instance=new A285772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285773
{
public static readonly long[] Value={ 1L,0L,2L,0L,4L,0L,10L,0L,16L,0L,40L,0L,68L,0L,170L,0L,256L,0L,640L,0L,1088L,0L,2720L,0L,4112L,0L,10280L,0L,17476L,0L,43690L,0L,65536L,0L,163840L,0L,278528L,0L,696320L,0L,1052672L,0L,2631680L,0L,4473856L,0L,11184640L,0L,16777472L,0L,41943680L,0L,71304256L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285773Inst : IEnumerable<long>
{
public static readonly long[] Value=A285773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285773.Bytes);
public long this[int i]=>Value[i];

public static A285773Inst Instance=new A285773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285774
{
public static readonly long[] Value={ 1L,0L,2L,0L,4L,0L,40L,0L,16L,0L,160L,0L,1088L,0L,10880L,0L,256L,0L,2560L,0L,17408L,0L,174080L,0L,1052672L,0L,10526720L,0L,71581696L,0L,715816960L,0L,65536L,0L,655360L,0L,4456448L,0L,44564480L,0L,269484032L,0L,2694840320L,0L,18324914176L,0L,183249141760L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285774Inst : IEnumerable<long>
{
public static readonly long[] Value=A285774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285774.Bytes);
public long this[int i]=>Value[i];

public static A285774Inst Instance=new A285774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285775
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1110L,0L,111111L,0L,11111111L,0L,1111111111L,0L,111111111111L,0L,11111111111111L,0L,1111111111111111L,0L,111111111111111111L,0L,11111111111111111111UL,0L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),0L,BigInteger.Parse("11111111111111111111111111"),0L };
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
public class A285775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285775Inst Instance=new A285775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285776
{
public static readonly BigInteger[] Value={ 1L,1L,100L,111L,0L,111111L,0L,11111111L,0L,1111111111L,0L,111111111111L,0L,11111111111111L,0L,1111111111111111L,0L,111111111111111111L,0L,11111111111111111111UL,0L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),0L,BigInteger.Parse("11111111111111111111111111"),0L };
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
public class A285776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285776Inst Instance=new A285776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285777
{
public static readonly long[] Value={ 1L,2L,1L,14L,0L,63L,0L,255L,0L,1023L,0L,4095L,0L,16383L,0L,65535L,0L,262143L,0L,1048575L,0L,4194303L,0L,16777215L,0L,67108863L,0L,268435455L,0L,1073741823L,0L,4294967295L,0L,17179869183L,0L,68719476735L,0L,274877906943L,0L,1099511627775L,0L,4398046511103L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285777Inst : IEnumerable<long>
{
public static readonly long[] Value=A285777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285777.Bytes);
public long this[int i]=>Value[i];

public static A285777Inst Instance=new A285777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285778
{
public static readonly long[] Value={ 1L,1L,4L,7L,0L,63L,0L,255L,0L,1023L,0L,4095L,0L,16383L,0L,65535L,0L,262143L,0L,1048575L,0L,4194303L,0L,16777215L,0L,67108863L,0L,268435455L,0L,1073741823L,0L,4294967295L,0L,17179869183L,0L,68719476735L,0L,274877906943L,0L,1099511627775L,0L,4398046511103L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285778Inst : IEnumerable<long>
{
public static readonly long[] Value=A285778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285778.Bytes);
public long this[int i]=>Value[i];

public static A285778Inst Instance=new A285778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285779
{
public static readonly long[] Value={ 0L,-1L,-2L,1L,-3L,2L,3L,-4L,-5L,4L,5L,-6L,6L,-7L,-8L,7L,-9L,8L,9L,-10L,10L,-11L,-12L,11L,12L,-13L,-14L,13L,-15L,14L,15L,-16L,-17L,16L,17L,-18L,18L,-19L,-20L,19L,20L,-21L,-22L,21L,-23L,22L,23L,-24L,24L,-25L,-26L,25L,-27L,26L,27L,-28L,-29L,28L,29L,-30L,30L,-31L,-32L,31L,-33L,32L,33L,-34L,34L,-35L,-36L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285779Inst : IEnumerable<long>
{
public static readonly long[] Value=A285779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285779.Bytes);
public long this[int i]=>Value[i];

public static A285779Inst Instance=new A285779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285780
{
public static readonly long[] Value={ 1L,1L,10L,0L,110L,0L,1100L,0L,11110L,0L,110000L,0L,1110010L,0L,11001100L,0L,111111110L,0L,1100000010L,10000L,11110000100L,111010L,110011000000L,101010L,1111110000000L,1100000L,11000010010000L,10000100L,111100101100010L,101010000L,1100111000011010L,1001000100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285780Inst : IEnumerable<long>
{
public static readonly long[] Value=A285780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285780.Bytes);
public long this[int i]=>Value[i];

public static A285780Inst Instance=new A285780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285845
{
public static readonly long[] Value={ 11025L,19044L,21025L,24025L,32041L,38025L,42025L,47089L,51076L,58081L,59049L,65025L,66049L,67081L,74088L,75076L,87025L,93025L,1110916L,1140624L,1170724L,1190281L,1240996L,1270129L,1290496L,1340964L,1350244L,1380625L,1420864L,1430416L,1490841L,1510441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285845Inst : IEnumerable<long>
{
public static readonly long[] Value=A285845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285845.Bytes);
public long this[int i]=>Value[i];

public static A285845Inst Instance=new A285845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285846
{
public static readonly long[] Value={ 7L,37L,237L,1789L,4357L,14379L,19587L,93957L,189572L,189597L,1234397L,1839597L,1958798L,1983957L,3978594L,11983957L,19596487L,29195397L,39599197L,195991487L,339799143L,395991697L,1429199397L,1679895983L,1983994799L,2239951987L,11959939917L,15991995897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285846Inst : IEnumerable<long>
{
public static readonly long[] Value=A285846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285846.Bytes);
public long this[int i]=>Value[i];

public static A285846Inst Instance=new A285846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285847
{
public static readonly long[] Value={ 6L,8L,9L,10L,12L,14L,15L,18L,20L,21L,24L,26L,28L,30L,33L,35L,36L,38L,39L,40L,42L,44L,45L,48L,50L,51L,54L,56L,58L,60L,62L,63L,65L,66L,68L,69L,70L,72L,75L,76L,77L,78L,80L,84L,86L,87L,90L,91L,93L,95L,96L,98L,99L,100L,102L,104L,105L,108L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285847Inst : IEnumerable<long>
{
public static readonly long[] Value=A285847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285847.Bytes);
public long this[int i]=>Value[i];

public static A285847Inst Instance=new A285847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285848
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,9L,15L,17L,19L,23L,25L,29L,27L,31L,21L,37L,35L,33L,39L,41L,43L,47L,49L,53L,45L,55L,51L,59L,61L,67L,57L,71L,63L,73L,65L,79L,69L,77L,81L,83L,85L,75L,87L,89L,91L,97L,95L,101L,93L,103L,99L,107L,109L,113L,111L,115L,105L,119L,121L,127L,117L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285848Inst : IEnumerable<long>
{
public static readonly long[] Value=A285848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285848.Bytes);
public long this[int i]=>Value[i];

public static A285848Inst Instance=new A285848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285849
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,6L,1L,0L,6L,19L,18L,1L,0L,24L,100L,105L,40L,1L,0L,120L,508L,1005L,430L,75L,1L,0L,720L,3528L,6762L,6300L,1400L,126L,1L,0L,5040L,24876L,61572L,62601L,28700L,3822L,196L,1L,0L,40320L,219168L,558548L,706608L,431445L,105336L,9114L,288L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285849Inst : IEnumerable<long>
{
public static readonly long[] Value=A285849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285849.Bytes);
public long this[int i]=>Value[i];

public static A285849Inst Instance=new A285849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285850
{
public static readonly BigInteger[] Value={ 0L,2L,8L,288L,15744L,1401600L,183582720L,33223034880L,7939197665280L,2421184409763840L,917547530747904000L,BigInteger.Parse("422959572499916390400"),BigInteger.Parse("233037523912020826521600"),BigInteger.Parse("151234400024881955183001600"),BigInteger.Parse("114177664785555609793383628800"),BigInteger.Parse("99217287255932372662490234880000") };
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
public class A285850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285850Inst Instance=new A285850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285851
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,3L,1L,1L,3L,2L,1L,1L,1L,3L,4L,1L,1L,1L,1L,1L,7L,2L,3L,1L,5L,1L,3L,1L,2L,3L,3L,1L,5L,1L,1L,1L,3L,6L,1L,1L,2L,3L,1L,5L,1L,3L,1L,1L,3L,2L,1L,5L,7L,1L,1L,2L,7L,3L,5L,1L,1L,1L,4L,3L,1L,1L,3L,1L,2L,4L,1L,1L,5L,1L,1L,1L,3L,4L,1L,1L,1L,3L,1L,1L,4L,1L,3L,2L,1L,9L,1L,5L,3L,1L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285851Inst : IEnumerable<long>
{
public static readonly long[] Value=A285851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285851.Bytes);
public long this[int i]=>Value[i];

public static A285851Inst Instance=new A285851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285852
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,0L,0L,0L,6L,3L,0L,0L,14L,12L,1L,0L,36L,39L,6L,0L,98L,120L,25L,0L,276L,363L,90L,0L,794L,1092L,301L,0L,2316L,3279L,966L,0L,6818L,9840L,3025L,0L,20196L,29523L,9330L,0L,60074L,88572L,28501L,0L,179196L,265719L,86526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285852Inst : IEnumerable<long>
{
public static readonly long[] Value=A285852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285852.Bytes);
public long this[int i]=>Value[i];

public static A285852Inst Instance=new A285852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285853
{
public static readonly BigInteger[] Value={ 1L,6L,19L,100L,508L,3528L,24876L,219168L,1980576L,21257280L,234434880L,2972885760L,38715943680L,566931294720L,8514866707200L,141468564787200L,2407290355814400L,44753976117043200L,850965783594393600L,17505896073523200000UL,BigInteger.Parse("367844990453821440000") };
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
public class A285853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285853Inst Instance=new A285853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285854
{
public static readonly BigInteger[] Value={ 1L,18L,105L,1005L,6762L,61572L,558548L,5807700L,62757288L,777291768L,9831740256L,139111566048L,2048834965824L,32758018496640L,545051532176640L,9812211976039680L,182219827628874240L,3627461543458659840L,BigInteger.Parse("74765368810365696000"),BigInteger.Parse("1632210845693218560000") };
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
public class A285854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285854Inst Instance=new A285854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285855
{
public static readonly BigInteger[] Value={ 1L,40L,430L,6300L,62601L,706608L,8985560L,107911760L,1439518696L,20364348576L,304923257184L,4772610024000L,80570363703696L,1409795519233536L,26263500315144192L,511153327733815296L,10464902116976779776UL,BigInteger.Parse("223154458395064842240"),BigInteger.Parse("5010190272214829475840") };
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
public class A285855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285855Inst Instance=new A285855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285856
{
public static readonly BigInteger[] Value={ 1L,75L,1400L,28700L,431445L,6061545L,101969450L,1511771250L,24207257360L,398261143280L,7126152051200L,125804137586400L,2407653784466640L,47180921713154640L,978889889736934560L,BigInteger.Parse("20912829727776156000"),BigInteger.Parse("470414513170923511680"),BigInteger.Parse("10891943467262968682880") };
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
public class A285856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285856Inst Instance=new A285856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285857
{
public static readonly BigInteger[] Value={ 1L,126L,3822L,105336L,2312163L,41420610L,868380535L,16453085220L,312866654100L,6063351173880L,127050688947000L,2603853165950400L,56141875342402480L,1242418296237553440L,BigInteger.Parse("28627706535786406800"),BigInteger.Parse("683460419058369489600"),BigInteger.Parse("16802904218347937067840") };
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
public class A285857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285857Inst Instance=new A285857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285858
{
public static readonly BigInteger[] Value={ 1L,196L,9114L,330750L,10094931L,234138366L,5932023097L,142349568361L,3233779086538L,74147737383720L,1785843031638120L,42966579274786440L,1047584220405271360L,BigInteger.Parse("26222209747260881200"),BigInteger.Parse("671966452779878874800"),BigInteger.Parse("17944599541172975286000"),BigInteger.Parse("485789620369911667323360") };
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
public class A285858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285858Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285858.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285858Inst Instance=new A285858Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285859
{
public static readonly BigInteger[] Value={ 1L,288L,19560L,921360L,37423914L,1124673264L,34065856396L,1010435626200L,27564092244689L,746494701977024L,20568917530438368L,575594436161070144L,15985318079107792576UL,BigInteger.Parse("452561731064312392320"),BigInteger.Parse("12942265817549110947520"),BigInteger.Parse("383915932720263224659840") };
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
public class A285859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285859Inst Instance=new A285859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285860
{
public static readonly BigInteger[] Value={ 1L,405L,38610L,2331450L,121706442L,4694535846L,169670838480L,6075923190480L,198663468670953L,6325532235438273L,199912192325692002L,6415747810037718750L,BigInteger.Parse("203472294646893246264"),BigInteger.Parse("6508361104406113912344"),BigInteger.Parse("208391821362083355586128"),BigInteger.Parse("6837034161112760255699664") };
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
public class A285860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285860Inst Instance=new A285860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286279
{
public static readonly long[] Value={ 11L,25L,28L,31L,33L,35L,33L,75L,73L,47L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286279Inst : IEnumerable<long>
{
public static readonly long[] Value=A286279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286279.Bytes);
public long this[int i]=>Value[i];

public static A286279Inst Instance=new A286279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286280
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,5L,4L,8L,2L,11L,4L,8L,10L,15L,4L,14L,3L,22L,13L,8L,2L,34L,11L,13L,20L,26L,4L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286280Inst : IEnumerable<long>
{
public static readonly long[] Value=A286280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286280.Bytes);
public long this[int i]=>Value[i];

public static A286280Inst Instance=new A286280Inst();

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