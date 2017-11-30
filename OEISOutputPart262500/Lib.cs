using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191019
{
public static readonly long[] Value={ 5L,7L,11L,17L,23L,43L,47L,61L,73L,83L,101L,131L,137L,139L,149L,157L,163L,191L,197L,199L,229L,233L,239L,251L,263L,271L,277L,283L,311L,313L,347L,349L,353L,359L,367L,389L,397L,419L,443L,457L,461L,463L,467L,479L,491L,499L,503L,541L,557L,571L,577L,587L,593L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191019Inst : IEnumerable<long>
{
public static readonly long[] Value=A191019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191019.Bytes);
public long this[int i]=>Value[i];

public static A191019Inst Instance=new A191019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191052
{
public static readonly long[] Value={ 2L,7L,11L,13L,17L,41L,47L,67L,89L,101L,103L,109L,113L,131L,137L,139L,151L,181L,191L,199L,223L,241L,251L,263L,269L,277L,283L,293L,311L,313L,317L,349L,359L,373L,389L,397L,439L,443L,449L,457L,461L,463L,467L,479L,487L,491L,499L,503L,523L,547L,563L,569L,571L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191052Inst : IEnumerable<long>
{
public static readonly long[] Value=A191052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191052.Bytes);
public long this[int i]=>Value[i];

public static A191052Inst Instance=new A191052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191053
{
public static readonly long[] Value={ 2L,5L,11L,17L,47L,53L,67L,71L,73L,79L,97L,107L,109L,131L,139L,157L,167L,173L,179L,199L,223L,227L,233L,251L,257L,263L,269L,271L,277L,283L,307L,311L,317L,331L,347L,367L,373L,401L,409L,443L,449L,461L,463L,467L,479L,487L,509L,523L,587L,601L,607L,613L,619L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191053Inst : IEnumerable<long>
{
public static readonly long[] Value=A191053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191053.Bytes);
public long this[int i]=>Value[i];

public static A191053Inst Instance=new A191053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191054
{
public static readonly long[] Value={ 5L,19L,23L,29L,31L,41L,43L,47L,53L,59L,73L,79L,83L,89L,97L,107L,113L,127L,167L,179L,191L,211L,223L,227L,229L,233L,241L,263L,271L,277L,293L,307L,337L,347L,349L,353L,373L,383L,389L,397L,409L,443L,461L,479L,491L,509L,547L,569L,571L,577L,587L,593L,599L,619L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191054Inst : IEnumerable<long>
{
public static readonly long[] Value=A191054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191054.Bytes);
public long this[int i]=>Value[i];

public static A191054Inst Instance=new A191054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191055
{
public static readonly long[] Value={ 7L,11L,17L,19L,23L,29L,53L,67L,83L,89L,97L,103L,109L,137L,157L,163L,167L,179L,193L,197L,211L,239L,251L,263L,269L,283L,307L,347L,349L,353L,373L,379L,383L,389L,397L,401L,421L,439L,449L,461L,491L,509L,541L,547L,557L,569L,577L,587L,607L,641L,647L,661L,677L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191055Inst : IEnumerable<long>
{
public static readonly long[] Value=A191055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191055.Bytes);
public long this[int i]=>Value[i];

public static A191055Inst Instance=new A191055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191056
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,29L,43L,67L,71L,79L,89L,97L,103L,107L,109L,139L,163L,179L,181L,191L,211L,227L,229L,239L,241L,263L,271L,293L,317L,337L,349L,353L,373L,383L,389L,401L,419L,421L,431L,439L,443L,457L,461L,467L,479L,487L,499L,509L,521L,547L,557L,563L,587L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191056Inst : IEnumerable<long>
{
public static readonly long[] Value=A191056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191056.Bytes);
public long this[int i]=>Value[i];

public static A191056Inst Instance=new A191056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191057
{
public static readonly long[] Value={ 2L,3L,11L,13L,37L,53L,61L,67L,97L,101L,103L,107L,113L,127L,131L,139L,149L,167L,173L,191L,193L,199L,223L,227L,229L,239L,251L,257L,271L,293L,307L,311L,317L,337L,349L,359L,373L,383L,389L,419L,433L,461L,479L,487L,491L,499L,523L,541L,547L,563L,571L,607L,619L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191057Inst : IEnumerable<long>
{
public static readonly long[] Value=A191057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191057.Bytes);
public long this[int i]=>Value[i];

public static A191057Inst Instance=new A191057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191058
{
public static readonly long[] Value={ 2L,3L,11L,31L,43L,47L,53L,61L,73L,79L,89L,101L,103L,109L,113L,151L,163L,167L,191L,193L,197L,227L,229L,241L,269L,283L,293L,307L,313L,353L,379L,389L,397L,419L,421L,431L,449L,461L,463L,467L,479L,487L,491L,503L,509L,521L,547L,557L,571L,593L,607L,613L,617L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191058Inst : IEnumerable<long>
{
public static readonly long[] Value=A191058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191058.Bytes);
public long this[int i]=>Value[i];

public static A191058Inst Instance=new A191058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191059
{
public static readonly long[] Value={ 13L,17L,19L,23L,37L,41L,43L,47L,61L,67L,71L,89L,109L,113L,137L,139L,157L,163L,167L,181L,191L,211L,229L,233L,239L,257L,263L,277L,281L,283L,307L,311L,331L,349L,353L,359L,373L,379L,383L,397L,401L,421L,431L,449L,479L,499L,503L,521L,523L,541L,547L,569L,571L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191059Inst : IEnumerable<long>
{
public static readonly long[] Value=A191059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191059.Bytes);
public long this[int i]=>Value[i];

public static A191059Inst Instance=new A191059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191060
{
public static readonly long[] Value={ 2L,7L,13L,17L,19L,29L,41L,43L,61L,73L,79L,83L,101L,107L,109L,127L,131L,139L,149L,151L,167L,173L,193L,197L,211L,227L,233L,239L,241L,263L,271L,277L,281L,283L,293L,307L,337L,347L,349L,359L,373L,409L,431L,439L,457L,461L,479L,491L,503L,523L,541L,547L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191060Inst : IEnumerable<long>
{
public static readonly long[] Value=A191060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191060.Bytes);
public long this[int i]=>Value[i];

public static A191060Inst Instance=new A191060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191061
{
public static readonly long[] Value={ 11L,17L,29L,31L,37L,41L,43L,47L,53L,67L,73L,89L,97L,103L,107L,109L,149L,163L,167L,179L,197L,199L,211L,223L,241L,257L,271L,277L,311L,313L,317L,331L,347L,353L,367L,373L,379L,383L,389L,409L,421L,433L,439L,443L,479L,491L,499L,503L,521L,541L,547L,557L,571L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191061Inst : IEnumerable<long>
{
public static readonly long[] Value=A191061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191061.Bytes);
public long this[int i]=>Value[i];

public static A191061Inst Instance=new A191061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191062
{
public static readonly long[] Value={ 7L,11L,13L,29L,37L,41L,43L,59L,67L,71L,73L,89L,97L,101L,103L,127L,131L,149L,157L,163L,179L,191L,193L,223L,239L,251L,269L,277L,281L,283L,307L,311L,313L,337L,359L,367L,373L,389L,397L,401L,419L,431L,433L,449L,457L,461L,463L,479L,487L,491L,509L,521L,523L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191062Inst : IEnumerable<long>
{
public static readonly long[] Value=A191062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191062.Bytes);
public long this[int i]=>Value[i];

public static A191062Inst Instance=new A191062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191063
{
public static readonly long[] Value={ 2L,3L,13L,29L,31L,37L,41L,53L,59L,67L,71L,79L,89L,97L,103L,107L,109L,113L,127L,151L,167L,173L,179L,181L,193L,211L,223L,227L,241L,257L,269L,281L,293L,307L,317L,331L,337L,373L,379L,383L,401L,409L,421L,431L,433L,439L,449L,487L,509L,521L,523L,547L,563L,569L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191063Inst : IEnumerable<long>
{
public static readonly long[] Value=A191063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191063.Bytes);
public long this[int i]=>Value[i];

public static A191063Inst Instance=new A191063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191064
{
public static readonly long[] Value={ 3L,5L,7L,17L,37L,41L,53L,59L,67L,73L,79L,127L,151L,157L,163L,167L,179L,181L,193L,229L,233L,239L,241L,251L,263L,269L,271L,281L,317L,331L,337L,359L,379L,389L,397L,409L,419L,421L,431L,439L,443L,457L,467L,479L,499L,503L,509L,569L,587L,593L,601L,607L,619L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191064Inst : IEnumerable<long>
{
public static readonly long[] Value=A191064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191064.Bytes);
public long this[int i]=>Value[i];

public static A191064Inst Instance=new A191064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191065
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,37L,43L,53L,61L,67L,79L,83L,89L,97L,103L,107L,109L,113L,137L,149L,157L,181L,191L,199L,227L,229L,241L,251L,263L,281L,283L,293L,313L,337L,359L,367L,373L,379L,383L,389L,401L,419L,421L,431L,433L,457L,467L,479L,503L,521L,523L,557L,563L,569L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191065Inst : IEnumerable<long>
{
public static readonly long[] Value=A191065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191065.Bytes);
public long this[int i]=>Value[i];

public static A191065Inst Instance=new A191065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191066
{
public static readonly long[] Value={ 7L,19L,41L,53L,61L,71L,73L,83L,89L,97L,103L,107L,109L,127L,139L,173L,181L,191L,193L,197L,211L,223L,227L,229L,239L,281L,293L,311L,313L,317L,331L,337L,347L,349L,359L,367L,379L,401L,421L,431L,433L,443L,449L,457L,463L,467L,479L,487L,499L,521L,541L,557L,563L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191066Inst : IEnumerable<long>
{
public static readonly long[] Value=A191066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191066.Bytes);
public long this[int i]=>Value[i];

public static A191066Inst Instance=new A191066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191067
{
public static readonly long[] Value={ 3L,11L,13L,17L,23L,29L,37L,43L,53L,61L,73L,79L,83L,89L,127L,137L,139L,151L,167L,179L,181L,197L,199L,223L,229L,239L,241L,251L,263L,269L,271L,277L,313L,331L,337L,347L,353L,367L,383L,389L,401L,409L,433L,449L,457L,461L,463L,487L,491L,499L,509L,523L,557L,569L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191067Inst : IEnumerable<long>
{
public static readonly long[] Value=A191067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191067.Bytes);
public long this[int i]=>Value[i];

public static A191067Inst Instance=new A191067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191132
{
public static readonly long[] Value={ 1L,4L,13L,40L,49L,121L,148L,157L,193L,364L,445L,472L,481L,580L,589L,625L,769L,1093L,1336L,1417L,1444L,1453L,1741L,1768L,1777L,1876L,1885L,1921L,2308L,2317L,2353L,2497L,3073L,3280L,4009L,4252L,4333L,4360L,4369L,5224L,5305L,5332L,5341L,5629L,5656L,5665L,5764L,5773L,5809L,6925L,6952L,6961L,7060L,7069L,7105L,7492L,7501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191132Inst : IEnumerable<long>
{
public static readonly long[] Value=A191132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191132.Bytes);
public long this[int i]=>Value[i];

public static A191132Inst Instance=new A191132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191133
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,13L,14L,19L,22L,26L,40L,43L,50L,54L,58L,67L,74L,79L,86L,102L,121L,130L,151L,158L,163L,170L,175L,198L,202L,214L,223L,230L,238L,259L,266L,294L,307L,314L,342L,364L,391L,406L,454L,475L,482L,490L,511L,518L,526L,595L,602L,607L,630L,643L,650L,670L,678L,691L,698L,715L,778L,790L,799L,806L,854L,883L,890L,918L,922L,943L,950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191133Inst : IEnumerable<long>
{
public static readonly long[] Value=A191133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191133.Bytes);
public long this[int i]=>Value[i];

public static A191133Inst Instance=new A191133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191134
{
public static readonly long[] Value={ 1L,3L,4L,10L,11L,13L,15L,31L,34L,39L,40L,43L,46L,51L,59L,94L,103L,118L,121L,123L,130L,135L,139L,154L,155L,159L,171L,178L,183L,203L,235L,283L,310L,355L,364L,370L,375L,391L,406L,411L,418L,463L,466L,471L,478L,483L,491L,514L,519L,535L,539L,550L,555L,610L,615L,619L,635L,683L,706L,711L,731L,811L,850L,931L,939L,1066L,1093L,1111L,1126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191134Inst : IEnumerable<long>
{
public static readonly long[] Value=A191134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191134.Bytes);
public long this[int i]=>Value[i];

public static A191134Inst Instance=new A191134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191135
{
public static readonly long[] Value={ 1L,4L,13L,16L,40L,49L,52L,64L,121L,148L,157L,160L,193L,196L,208L,256L,364L,445L,472L,481L,484L,580L,589L,592L,625L,628L,640L,769L,772L,784L,832L,1024L,1093L,1336L,1417L,1444L,1453L,1456L,1741L,1768L,1777L,1780L,1876L,1885L,1888L,1921L,1924L,1936L,2308L,2317L,2320L,2353L,2356L,2368L,2497L,2500L,2512L,2560L,3073L,3076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191135Inst : IEnumerable<long>
{
public static readonly long[] Value=A191135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191135.Bytes);
public long this[int i]=>Value[i];

public static A191135Inst Instance=new A191135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191136
{
public static readonly long[] Value={ 1L,4L,5L,13L,16L,17L,21L,40L,49L,52L,53L,64L,65L,69L,85L,121L,148L,157L,160L,161L,193L,196L,197L,208L,209L,213L,256L,257L,261L,277L,341L,364L,445L,472L,481L,484L,485L,580L,589L,592L,593L,625L,628L,629L,640L,641L,645L,769L,772L,773L,784L,785L,789L,832L,833L,837L,853L,1024L,1025L,1029L,1045L,1093L,1109L,1336L,1365L,1417L,1444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191136Inst : IEnumerable<long>
{
public static readonly long[] Value=A191136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191136.Bytes);
public long this[int i]=>Value[i];

public static A191136Inst Instance=new A191136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191137
{
public static readonly long[] Value={ 1L,4L,6L,13L,18L,19L,26L,40L,54L,55L,58L,74L,78L,79L,106L,121L,162L,163L,166L,175L,218L,222L,223L,234L,235L,238L,298L,314L,318L,319L,364L,426L,486L,487L,490L,499L,526L,650L,654L,655L,666L,667L,670L,702L,703L,706L,715L,874L,890L,894L,895L,938L,942L,943L,954L,955L,958L,1093L,1194L,1258L,1274L,1278L,1279L,1458L,1459L,1462L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191137Inst : IEnumerable<long>
{
public static readonly long[] Value=A191137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191137.Bytes);
public long this[int i]=>Value[i];

public static A191137Inst Instance=new A191137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191138
{
public static readonly long[] Value={ 1L,4L,7L,13L,19L,22L,31L,40L,55L,58L,67L,79L,91L,94L,121L,127L,163L,166L,175L,202L,223L,235L,238L,271L,274L,283L,319L,364L,367L,379L,382L,487L,490L,499L,511L,526L,607L,655L,667L,670L,703L,706L,715L,811L,814L,823L,850L,895L,943L,955L,958L,1087L,1093L,1099L,1102L,1135L,1138L,1147L,1279L,1459L,1462L,1471L,1498L,1519L,1531L,1534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191138Inst : IEnumerable<long>
{
public static readonly long[] Value=A191138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191138.Bytes);
public long this[int i]=>Value[i];

public static A191138Inst Instance=new A191138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191139
{
public static readonly long[] Value={ 1L,5L,17L,53L,65L,161L,197L,209L,257L,485L,593L,629L,641L,773L,785L,833L,1025L,1457L,1781L,1889L,1925L,1937L,2321L,2357L,2369L,2501L,2513L,2561L,3077L,3089L,3137L,3329L,4097L,4373L,5345L,5669L,5777L,5813L,5825L,6965L,7073L,7109L,7121L,7505L,7541L,7553L,7685L,7697L,7745L,9233L,9269L,9281L,9413L,9425L,9473L,9989L,10001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191139Inst : IEnumerable<long>
{
public static readonly long[] Value=A191139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191139.Bytes);
public long this[int i]=>Value[i];

public static A191139Inst Instance=new A191139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191140
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,17L,18L,20L,22L,26L,30L,53L,56L,62L,66L,68L,70L,78L,80L,86L,92L,102L,118L,161L,170L,188L,200L,206L,210L,212L,222L,236L,242L,246L,260L,262L,270L,278L,308L,310L,318L,342L,356L,366L,406L,470L,485L,512L,566L,602L,620L,632L,638L,642L,668L,678L,710L,728L,740L,750L,782L,788L,798L,812L,822L,836L,838L,846L,886L,926L,932L,942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191140Inst : IEnumerable<long>
{
public static readonly long[] Value=A191140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191140.Bytes);
public long this[int i]=>Value[i];

public static A191140Inst Instance=new A191140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191141
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,19L,35L,43L,53L,59L,67L,75L,107L,131L,139L,161L,171L,179L,203L,211L,227L,235L,267L,299L,323L,395L,419L,427L,485L,515L,523L,539L,555L,611L,635L,643L,683L,707L,715L,803L,811L,843L,899L,907L,939L,971L,1067L,1187L,1195L,1259L,1283L,1291L,1457L,1547L,1571L,1579L,1619L,1667L,1675L,1707L,1835L,1907L,1931L,1939L,2051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191141Inst : IEnumerable<long>
{
public static readonly long[] Value=A191141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191141.Bytes);
public long this[int i]=>Value[i];

public static A191141Inst Instance=new A191141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191142
{
public static readonly long[] Value={ 1L,4L,5L,14L,16L,17L,20L,44L,50L,53L,56L,62L,64L,68L,80L,134L,152L,161L,170L,176L,188L,194L,200L,206L,212L,224L,242L,248L,256L,272L,320L,404L,458L,485L,512L,530L,536L,566L,584L,602L,608L,620L,638L,644L,674L,680L,704L,728L,746L,752L,770L,776L,800L,818L,824L,848L,896L,962L,968L,992L,1024L,1088L,1214L,1280L,1376L,1457L,1538L,1592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191142Inst : IEnumerable<long>
{
public static readonly long[] Value=A191142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191142.Bytes);
public long this[int i]=>Value[i];

public static A191142Inst Instance=new A191142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191143
{
public static readonly long[] Value={ 1L,5L,17L,21L,53L,65L,69L,85L,161L,197L,209L,213L,257L,261L,277L,341L,485L,593L,629L,641L,645L,773L,785L,789L,833L,837L,853L,1025L,1029L,1045L,1109L,1365L,1457L,1781L,1889L,1925L,1937L,1941L,2321L,2357L,2369L,2373L,2501L,2513L,2517L,2561L,2565L,2581L,3077L,3089L,3093L,3137L,3141L,3157L,3329L,3333L,3349L,3413L,4097L,4101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191143Inst : IEnumerable<long>
{
public static readonly long[] Value=A191143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191143.Bytes);
public long this[int i]=>Value[i];

public static A191143Inst Instance=new A191143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191144
{
public static readonly long[] Value={ 1L,5L,6L,17L,20L,22L,26L,53L,62L,68L,70L,80L,82L,90L,106L,161L,188L,206L,212L,214L,242L,248L,250L,272L,274L,282L,320L,322L,330L,362L,426L,485L,566L,620L,638L,644L,646L,728L,746L,752L,754L,818L,824L,826L,848L,850L,858L,962L,968L,970L,992L,994L,1002L,1088L,1090L,1098L,1130L,1280L,1282L,1290L,1322L,1450L,1457L,1700L,1706L,1862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191144Inst : IEnumerable<long>
{
public static readonly long[] Value=A191144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191144.Bytes);
public long this[int i]=>Value[i];

public static A191144Inst Instance=new A191144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191145
{
public static readonly long[] Value={ 1L,5L,7L,17L,23L,31L,53L,71L,95L,127L,161L,215L,287L,383L,485L,511L,647L,863L,1151L,1457L,1535L,1943L,2047L,2591L,3455L,4373L,4607L,5831L,6143L,7775L,8191L,10367L,13121L,13823L,17495L,18431L,23327L,24575L,31103L,32767L,39365L,41471L,52487L,55295L,69983L,73727L,93311L,98303L,118097L,124415L,131071L,157463L,165887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191145Inst : IEnumerable<long>
{
public static readonly long[] Value=A191145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191145.Bytes);
public long this[int i]=>Value[i];

public static A191145Inst Instance=new A191145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191146
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,14L,16L,22L,28L,38L,40L,46L,54L,62L,64L,72L,82L,86L,110L,112L,118L,136L,150L,158L,160L,182L,184L,190L,200L,214L,244L,246L,254L,256L,326L,328L,334L,342L,352L,406L,438L,446L,448L,456L,470L,472L,478L,542L,544L,550L,568L,584L,598L,630L,638L,640L,726L,730L,734L,736L,758L,760L,766L,840L,854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191146Inst : IEnumerable<long>
{
public static readonly long[] Value=A191146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191146.Bytes);
public long this[int i]=>Value[i];

public static A191146Inst Instance=new A191146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191147
{
public static readonly long[] Value={ 1L,3L,7L,17L,18L,31L,12L,22L,59L,67L,44L,38L,73L,79L,88L,83L,160L,71L,78L,81L,129L,70L,131L,210L,297L,89L,312L,189L,234L,254L,394L,143L,252L,220L,186L,304L,329L,299L,230L,360L,295L,466L,383L,193L,679L,218L,340L,561L,229L,427L,531L,575L,512L,547L,1328L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191147Inst : IEnumerable<long>
{
public static readonly long[] Value=A191147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191147.Bytes);
public long this[int i]=>Value[i];

public static A191147Inst Instance=new A191147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191164
{
public static readonly long[] Value={ 4L,5L,6L,7L,11L,12L,13L,14L,18L,19L,20L,21L,25L,26L,27L,28L,32L,33L,34L,35L,39L,40L,41L,42L,46L,47L,48L,49L,53L,54L,55L,56L,61L,62L,63L,68L,69L,70L,75L,76L,77L,82L,83L,84L,89L,90L,91L,96L,97L,98L,103L,104L,105L,110L,111L,112L,113L,117L,118L,119L,120L,124L,125L,126L,127L,131L,132L,133L,134L,138L,139L,140L,141L,145L,146L,147L,148L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191164Inst : IEnumerable<long>
{
public static readonly long[] Value=A191164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191164.Bytes);
public long this[int i]=>Value[i];

public static A191164Inst Instance=new A191164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191165
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,13L,14L,17L,18L,22L,31L,40L,41L,49L,50L,53L,54L,65L,66L,70L,86L,112L,121L,122L,148L,149L,157L,158L,161L,162L,193L,194L,197L,198L,209L,210L,214L,257L,258L,262L,274L,278L,342L,355L,364L,365L,436L,445L,446L,472L,473L,481L,482L,485L,486L,580L,581L,589L,590L,593L,594L,625L,626L,629L,630L,641L,642L,646L,769L,770L,773L,774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191165Inst : IEnumerable<long>
{
public static readonly long[] Value=A191165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191165.Bytes);
public long this[int i]=>Value[i];

public static A191165Inst Instance=new A191165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191166
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,11L,14L,19L,20L,23L,27L,31L,32L,36L,41L,43L,55L,56L,59L,68L,75L,79L,80L,91L,92L,95L,100L,107L,122L,123L,127L,128L,163L,164L,167L,171L,176L,203L,219L,223L,224L,228L,235L,236L,239L,271L,272L,275L,284L,292L,299L,315L,319L,320L,363L,365L,367L,368L,379L,380L,383L,420L,427L,484L,487L,488L,491L,500L,507L,511L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191166Inst : IEnumerable<long>
{
public static readonly long[] Value=A191166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191166.Bytes);
public long this[int i]=>Value[i];

public static A191166Inst Instance=new A191166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191167
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,11L,14L,15L,19L,20L,23L,24L,27L,31L,32L,41L,42L,43L,51L,55L,56L,59L,60L,68L,69L,75L,79L,80L,91L,92L,95L,96L,107L,122L,123L,127L,128L,132L,163L,164L,167L,168L,171L,176L,177L,203L,204L,213L,219L,223L,224L,235L,236L,239L,240L,271L,272L,275L,276L,284L,285L,299L,315L,319L,320L,363L,365L,366L,367L,368L,375L,379L,380L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191167Inst : IEnumerable<long>
{
public static readonly long[] Value=A191167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191167.Bytes);
public long this[int i]=>Value[i];

public static A191167Inst Instance=new A191167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191168
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,11L,14L,15L,16L,19L,20L,23L,27L,31L,32L,41L,43L,44L,47L,55L,56L,59L,63L,64L,68L,75L,79L,80L,91L,92L,95L,107L,122L,123L,127L,128L,131L,140L,163L,164L,167L,171L,175L,176L,187L,188L,191L,203L,219L,223L,224L,235L,236L,239L,251L,255L,256L,271L,272L,275L,284L,299L,315L,319L,320L,363L,365L,367L,368L,379L,380L,383L,392L,419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191168Inst : IEnumerable<long>
{
public static readonly long[] Value=A191168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191168.Bytes);
public long this[int i]=>Value[i];

public static A191168Inst Instance=new A191168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191169
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,11L,14L,16L,17L,20L,23L,32L,35L,41L,44L,47L,56L,59L,64L,68L,71L,80L,92L,95L,98L,122L,125L,128L,131L,140L,143L,152L,164L,167L,176L,179L,188L,191L,203L,206L,224L,236L,239L,256L,272L,275L,284L,287L,314L,320L,365L,368L,380L,383L,392L,395L,419L,422L,488L,491L,500L,503L,512L,524L,527L,530L,560L,563L,572L,575L,608L,611L,638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191169Inst : IEnumerable<long>
{
public static readonly long[] Value=A191169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191169.Bytes);
public long this[int i]=>Value[i];

public static A191169Inst Instance=new A191169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191170
{
public static readonly long[] Value={ 1L,2L,5L,9L,14L,21L,26L,37L,41L,50L,57L,62L,77L,85L,105L,110L,114L,122L,149L,165L,170L,185L,229L,230L,249L,254L,306L,309L,314L,329L,341L,365L,421L,441L,446L,489L,494L,509L,554L,562L,597L,661L,681L,686L,689L,741L,746L,761L,882L,917L,921L,926L,941L,986L,997L,1017L,1022L,1094L,1237L,1257L,1262L,1317L,1322L,1330L,1337L,1365L,1461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191170Inst : IEnumerable<long>
{
public static readonly long[] Value=A191170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191170.Bytes);
public long this[int i]=>Value[i];

public static A191170Inst Instance=new A191170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191171
{
public static readonly long[] Value={ 1L,2L,5L,9L,10L,14L,19L,21L,26L,37L,41L,46L,57L,62L,77L,82L,85L,91L,105L,110L,122L,127L,149L,165L,170L,172L,185L,190L,229L,230L,235L,249L,254L,309L,314L,329L,334L,341L,365L,370L,415L,421L,441L,446L,489L,494L,509L,514L,554L,559L,597L,661L,681L,686L,689L,694L,739L,741L,746L,761L,766L,820L,917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191171Inst : IEnumerable<long>
{
public static readonly long[] Value=A191171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191171.Bytes);
public long this[int i]=>Value[i];

public static A191171Inst Instance=new A191171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191172
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,10L,14L,17L,22L,26L,29L,41L,42L,50L,57L,58L,65L,70L,77L,86L,90L,106L,118L,121L,122L,125L,149L,166L,170L,173L,194L,202L,209L,230L,234L,257L,262L,269L,282L,310L,313L,317L,346L,353L,362L,365L,374L,377L,426L,446L,474L,490L,497L,502L,509L,518L,569L,581L,598L,605L,626L,633L,666L,682L,689L,694L,701L,770L,778L,785L,806L,810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191172Inst : IEnumerable<long>
{
public static readonly long[] Value=A191172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191172.Bytes);
public long this[int i]=>Value[i];

public static A191172Inst Instance=new A191172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191173
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,10L,12L,14L,17L,21L,22L,26L,29L,30L,41L,42L,48L,50L,57L,58L,65L,70L,77L,86L,90L,93L,106L,111L,118L,122L,125L,129L,149L,156L,166L,170L,173L,192L,194L,201L,202L,209L,230L,234L,237L,257L,262L,264L,269L,273L,282L,310L,317L,346L,353L,362L,365L,372L,374L,381L,426L,435L,446L,453L,474L,490L,497L,502L,509L,516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191173Inst : IEnumerable<long>
{
public static readonly long[] Value=A191173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191173.Bytes);
public long this[int i]=>Value[i];

public static A191173Inst Instance=new A191173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191174
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,14L,16L,20L,23L,28L,31L,32L,41L,44L,47L,56L,59L,64L,68L,80L,83L,92L,95L,112L,122L,124L,127L,128L,131L,140L,164L,167L,176L,188L,191L,203L,224L,236L,239L,248L,256L,272L,275L,284L,320L,332L,335L,365L,368L,371L,380L,383L,392L,419L,448L,488L,491L,496L,500L,508L,511L,512L,524L,527L,560L,563L,572L,608L,656L,668L,671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191174Inst : IEnumerable<long>
{
public static readonly long[] Value=A191174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191174.Bytes);
public long this[int i]=>Value[i];

public static A191174Inst Instance=new A191174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191175
{
public static readonly long[] Value={ 1L,2L,5L,7L,11L,14L,20L,23L,31L,32L,41L,47L,50L,59L,68L,83L,92L,95L,104L,122L,127L,131L,140L,167L,176L,185L,191L,203L,212L,239L,248L,275L,284L,293L,335L,365L,371L,374L,380L,383L,392L,419L,428L,455L,491L,500L,511L,527L,536L,563L,572L,608L,617L,671L,707L,716L,743L,752L,767L,815L,824L,833L,851L,860L,941L,959L,995L,1004L,1094L,1103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191175Inst : IEnumerable<long>
{
public static readonly long[] Value=A191175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191175.Bytes);
public long this[int i]=>Value[i];

public static A191175Inst Instance=new A191175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191176
{
public static readonly long[] Value={ 2L,4L,6L,7L,9L,11L,13L,14L,16L,18L,21L,23L,25L,28L,30L,32L,35L,37L,39L,40L,42L,44L,46L,47L,49L,51L,53L,54L,56L,58L,61L,63L,65L,68L,70L,72L,75L,77L,79L,80L,82L,84L,86L,87L,89L,91L,93L,94L,96L,98L,101L,103L,105L,108L,110L,112L,113L,115L,117L,119L,120L,122L,124L,126L,127L,129L,131L,134L,136L,138L,141L,143L,145L,148L,150L,152L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191176Inst : IEnumerable<long>
{
public static readonly long[] Value=A191176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191176.Bytes);
public long this[int i]=>Value[i];

public static A191176Inst Instance=new A191176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191177
{
public static readonly long[] Value={ 1L,3L,9L,21L,27L,33L,75L,81L,99L,105L,129L,183L,237L,243L,291L,297L,315L,321L,387L,393L,417L,513L,669L,723L,729L,885L,891L,939L,945L,963L,969L,1155L,1161L,1179L,1185L,1251L,1257L,1281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191177Inst : IEnumerable<long>
{
public static readonly long[] Value=A191177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191177.Bytes);
public long this[int i]=>Value[i];

public static A191177Inst Instance=new A191177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191178
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,10L,18L,22L,27L,30L,34L,38L,50L,54L,66L,70L,81L,86L,90L,102L,106L,114L,118L,134L,150L,162L,178L,198L,210L,214L,243L,258L,262L,270L,278L,306L,318L,322L,342L,354L,358L,370L,402L,406L,422L,450L,454L,470L,486L,534L,562L,594L,598L,626L,630L,642L,646L,729L,774L,786L,790L,810L,834L,838L,854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191178Inst : IEnumerable<long>
{
public static readonly long[] Value=A191178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191178.Bytes);
public long this[int i]=>Value[i];

public static A191178Inst Instance=new A191178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191179
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,10L,14L,17L,18L,22L,23L,26L,27L,29L,30L,34L,38L,41L,50L,53L,54L,65L,66L,68L,70L,77L,80L,81L,86L,89L,90L,101L,102L,106L,113L,114L,118L,122L,134L,149L,150L,158L,161L,162L,194L,197L,198L,203L,209L,210L,214L,230L,239L,242L,243L,257L,258L,262L,266L,269L,270L,278L,302L,305L,306L,317L,318L,322L,338L,341L,342L,353L,354L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191179Inst : IEnumerable<long>
{
public static readonly long[] Value=A191179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191179.Bytes);
public long this[int i]=>Value[i];

public static A191179Inst Instance=new A191179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191180
{
public static readonly long[] Value={ 1L,3L,9L,11L,27L,33L,35L,43L,57L,81L,99L,105L,107L,129L,131L,139L,171L,185L,243L,297L,315L,321L,323L,387L,393L,395L,417L,419L,427L,513L,515L,523L,555L,569L,683L,697L,729L,891L,945L,963L,969L,971L,1161L,1179L,1185L,1187L,1251L,1257L,1259L,1281L,1283L,1291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191180Inst : IEnumerable<long>
{
public static readonly long[] Value=A191180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191180.Bytes);
public long this[int i]=>Value[i];

public static A191180Inst Instance=new A191180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191181
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,25L,27L,33L,35L,43L,61L,79L,81L,97L,99L,105L,107L,129L,131L,139L,171L,223L,241L,243L,295L,297L,313L,315L,321L,323L,385L,387L,393L,395L,417L,419L,427L,513L,515L,523L,547L,555L,683L,709L,727L,729L,871L,889L,891L,943L,945L,961L,963L,969L,971L,1159L,1161L,1177L,1179L,1185L,1187L,1249L,1251L,1257L,1259L,1281L,1283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191181Inst : IEnumerable<long>
{
public static readonly long[] Value=A191181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191181.Bytes);
public long this[int i]=>Value[i];

public static A191181Inst Instance=new A191181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191182
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,21L,27L,37L,39L,45L,53L,61L,63L,71L,81L,85L,109L,111L,117L,135L,149L,157L,159L,181L,183L,189L,199L,213L,243L,245L,253L,255L,325L,327L,333L,341L,351L,405L,437L,445L,447L,455L,469L,471L,477L,541L,543L,549L,567L,583L,597L,629L,637L,639L,725L,729L,733L,735L,757L,759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191182Inst : IEnumerable<long>
{
public static readonly long[] Value=A191182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191182.Bytes);
public long this[int i]=>Value[i];

public static A191182Inst Instance=new A191182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191183
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,11L,13L,15L,20L,21L,27L,29L,37L,39L,45L,47L,53L,61L,63L,81L,83L,85L,101L,109L,111L,117L,119L,135L,137L,149L,157L,159L,181L,182L,183L,189L,191L,213L,243L,245L,253L,255L,263L,325L,327L,333L,335L,341L,351L,353L,405L,407L,425L,437L,445L,447L,469L,471L,477L,479L,541L,543L,549L,551L,567L,569L,597L,629L,637L,639L,725L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191183Inst : IEnumerable<long>
{
public static readonly long[] Value=A191183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191183.Bytes);
public long this[int i]=>Value[i];

public static A191183Inst Instance=new A191183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191184
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,14L,18L,26L,27L,38L,42L,54L,58L,74L,78L,81L,106L,110L,114L,126L,142L,154L,162L,170L,174L,206L,218L,222L,234L,243L,298L,314L,318L,326L,330L,342L,378L,398L,426L,442L,458L,462L,486L,506L,510L,522L,590L,618L,650L,654L,666L,682L,698L,702L,729L,874L,890L,894L,910L,938L,942L,954L,974L,978L,990L,1026L,1134L,1166L,1194L,1258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191184Inst : IEnumerable<long>
{
public static readonly long[] Value=A191184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191184.Bytes);
public long this[int i]=>Value[i];

public static A191184Inst Instance=new A191184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191185
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,13L,14L,18L,19L,26L,27L,28L,31L,38L,40L,42L,43L,54L,55L,58L,74L,78L,79L,81L,82L,85L,94L,106L,110L,114L,115L,121L,126L,127L,130L,154L,162L,163L,166L,170L,174L,175L,218L,222L,223L,234L,235L,238L,243L,244L,247L,256L,283L,298L,314L,318L,319L,326L,330L,331L,342L,343L,346L,364L,378L,379L,382L,391L,426L,442L,458L,462L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191185Inst : IEnumerable<long>
{
public static readonly long[] Value=A191185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191185.Bytes);
public long this[int i]=>Value[i];

public static A191185Inst Instance=new A191185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191186
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,21L,27L,29L,31L,37L,39L,45L,53L,61L,63L,81L,85L,87L,93L,109L,111L,117L,125L,127L,135L,149L,157L,159L,181L,183L,189L,213L,243L,245L,253L,255L,261L,279L,325L,327L,333L,341L,349L,351L,373L,375L,381L,405L,437L,445L,447L,469L,471L,477L,501L,509L,511L,541L,543L,549L,567L,597L,629L,637L,639L,725L,729L,733L,735L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191186Inst : IEnumerable<long>
{
public static readonly long[] Value=A191186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191186.Bytes);
public long this[int i]=>Value[i];

public static A191186Inst Instance=new A191186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191187
{
public static readonly long[] Value={ 1L,3L,6L,7L,9L,15L,21L,27L,31L,33L,39L,45L,60L,63L,69L,81L,87L,93L,111L,117L,127L,135L,141L,159L,183L,189L,195L,243L,249L,255L,261L,279L,285L,303L,327L,333L,351L,357L,375L,381L,405L,411L,447L,471L,477L,511L,543L,546L,549L,567L,573L,627L,639L,729L,735L,759L,765L,783L,789L,837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191187Inst : IEnumerable<long>
{
public static readonly long[] Value=A191187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191187.Bytes);
public long this[int i]=>Value[i];

public static A191187Inst Instance=new A191187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191188
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191188Inst : IEnumerable<long>
{
public static readonly long[] Value=A191188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191188.Bytes);
public long this[int i]=>Value[i];

public static A191188Inst Instance=new A191188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191189
{
public static readonly long[] Value={ 1L,4L,13L,31L,40L,49L,112L,121L,148L,157L,193L,274L,355L,364L,436L,445L,472L,481L,580L,589L,625L,769L,1003L,1084L,1093L,1327L,1336L,1408L,1417L,1444L,1453L,1732L,1741L,1768L,1777L,1876L,1885L,1921L,2308L,2317L,2353L,2461L,2497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191189Inst : IEnumerable<long>
{
public static readonly long[] Value=A191189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191189.Bytes);
public long this[int i]=>Value[i];

public static A191189Inst Instance=new A191189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191190
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,13L,14L,19L,22L,26L,40L,43L,50L,54L,58L,67L,71L,74L,79L,86L,102L,121L,130L,135L,151L,158L,163L,170L,175L,198L,202L,214L,223L,230L,238L,259L,263L,266L,294L,307L,314L,342L,364L,391L,406L,454L,455L,475L,482L,490L,511L,518L,526L,595L,602L,607L,630L,643L,650L,670L,678L,691L,698L,715L,778L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191190Inst : IEnumerable<long>
{
public static readonly long[] Value=A191190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191190.Bytes);
public long this[int i]=>Value[i];

public static A191190Inst Instance=new A191190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191191
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,13L,14L,15L,19L,22L,26L,33L,40L,43L,50L,51L,54L,58L,60L,67L,74L,79L,86L,102L,114L,121L,123L,130L,132L,151L,158L,163L,168L,170L,175L,195L,198L,202L,214L,223L,230L,231L,238L,259L,266L,294L,307L,314L,342L,357L,364L,384L,391L,406L,447L,454L,456L,475L,482L,483L,490L,511L,518L,519L,526L,537L,595L,600L,602L,607L,630L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191191Inst : IEnumerable<long>
{
public static readonly long[] Value=A191191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191191.Bytes);
public long this[int i]=>Value[i];

public static A191191Inst Instance=new A191191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191192
{
public static readonly long[] Value={ 1L,3L,4L,10L,11L,13L,14L,15L,31L,34L,39L,40L,43L,46L,51L,59L,78L,94L,103L,118L,121L,123L,130L,135L,139L,154L,155L,159L,171L,178L,183L,203L,206L,235L,270L,283L,310L,355L,364L,370L,375L,391L,406L,411L,418L,463L,466L,471L,478L,483L,491L,514L,519L,535L,539L,550L,555L,610L,615L,619L,635L,654L,683L,706L,711L,718L,731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191192Inst : IEnumerable<long>
{
public static readonly long[] Value=A191192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191192.Bytes);
public long this[int i]=>Value[i];

public static A191192Inst Instance=new A191192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191193
{
public static readonly long[] Value={ 1L,3L,4L,8L,10L,11L,13L,15L,26L,31L,34L,35L,39L,40L,43L,46L,51L,59L,71L,89L,94L,98L,103L,116L,118L,121L,123L,130L,134L,135L,139L,154L,155L,159L,171L,178L,183L,203L,233L,235L,278L,283L,305L,310L,314L,350L,355L,359L,364L,370L,375L,386L,391L,406L,411L,413L,418L,458L,463L,466L,471L,478L,483L,491L,514L,519L,530L,535L,539L,550L,555L,610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191193Inst : IEnumerable<long>
{
public static readonly long[] Value=A191193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191193.Bytes);
public long this[int i]=>Value[i];

public static A191193Inst Instance=new A191193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191194
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,13L,15L,16L,18L,20L,22L,23L,25L,27L,29L,32L,34L,36L,39L,41L,43L,45L,46L,48L,50L,52L,53L,55L,57L,59L,62L,64L,66L,69L,71L,73L,75L,76L,78L,80L,82L,83L,85L,87L,89L,92L,94L,96L,99L,101L,103L,105L,106L,108L,110L,112L,115L,117L,119L,122L,124L,126L,128L,129L,131L,133L,135L,136L,138L,140L,142L,145L,147L,149L,152L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191194Inst : IEnumerable<long>
{
public static readonly long[] Value=A191194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191194.Bytes);
public long this[int i]=>Value[i];

public static A191194Inst Instance=new A191194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191195
{
public static readonly long[] Value={ 1L,4L,10L,13L,16L,37L,40L,49L,52L,64L,91L,118L,121L,145L,148L,157L,160L,193L,196L,208L,256L,334L,361L,364L,442L,445L,469L,472L,481L,484L,577L,580L,589L,592L,625L,628L,640L,769L,772L,784L,820L,832L,1024L,1063L,1090L,1093L,1306L,1333L,1336L,1414L,1417L,1441L,1444L,1453L,1456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191195Inst : IEnumerable<long>
{
public static readonly long[] Value=A191195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191195.Bytes);
public long this[int i]=>Value[i];

public static A191195Inst Instance=new A191195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191596
{
public static readonly long[] Value={ 1L,11L,62L,242L,743L,1925L,4396L,9108L,17469L,31471L,53834L,88166L,139139L,212681L,316184L,458728L,651321L,907155L,1241878L,1673882L,2224607L,2918861L,3785156L,4856060L,6168565L,7764471L,9690786L,12000142L,14751227L,18009233L,21846320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191596Inst : IEnumerable<long>
{
public static readonly long[] Value=A191596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191596.Bytes);
public long this[int i]=>Value[i];

public static A191596Inst Instance=new A191596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191597
{
public static readonly long[] Value={ 0L,1L,6L,21L,85L,342L,1365L,5461L,21846L,87381L,349525L,1398102L,5592405L,22369621L,89478486L,357913941L,1431655765L,5726623062L,22906492245L,91625968981L,366503875926L,1466015503701L,5864062014805L,23456248059222L,93824992236885L,375299968947541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191597Inst : IEnumerable<long>
{
public static readonly long[] Value=A191597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191597.Bytes);
public long this[int i]=>Value[i];

public static A191597Inst Instance=new A191597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191598
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,10L,7L,8L,9L,18L,11L,12L,13L,14L,15L,16L,17L,34L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,66L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191598Inst : IEnumerable<long>
{
public static readonly long[] Value=A191598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191598.Bytes);
public long this[int i]=>Value[i];

public static A191598Inst Instance=new A191598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191599
{
public static readonly long[] Value={ 11L,13L,17L,19L,22L,23L,26L,29L,31L,33L,34L,37L,38L,39L,41L,43L,44L,46L,47L,51L,52L,53L,55L,57L,58L,59L,61L,62L,65L,66L,67L,68L,69L,71L,73L,74L,76L,77L,78L,79L,82L,83L,85L,86L,87L,89L,93L,94L,95L,97L,99L,101L,102L,103L,104L,106L,107L,109L,110L,111L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191599Inst : IEnumerable<long>
{
public static readonly long[] Value=A191599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191599.Bytes);
public long this[int i]=>Value[i];

public static A191599Inst Instance=new A191599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191600
{
public static readonly BigInteger[] Value={ 2L,5L,23L,159L,1646L,28059L,724310L,29626607L,1890041732L,188477431884L,29421793928187L,7179932235630885L,2740816166752070599L,BigInteger.Parse("1636347059803667113339"),BigInteger.Parse("1527949588062203773106011") };
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
public class A191600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191600Inst Instance=new A191600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191601
{
public static readonly BigInteger[] Value={ 2L,7L,41L,428L,7588L,235992L,12750773L,1196790145L,195443817921L,55484180929526L,27388366928551712L,BigInteger.Parse("23507551792998353446"),BigInteger.Parse("35081808543792928475951"),BigInteger.Parse("91032423727427789694636918"),BigInteger.Parse("410722028606679785606473590135") };
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
public class A191601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191601Inst Instance=new A191601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191602
{
public static readonly BigInteger[] Value={ 2L,8L,52L,686L,16484L,740480L,62224406L,9743390402L,2847964953844L,1553270286186274L,1580697070071238528L,BigInteger.Parse("3001650015211411938494"),BigInteger.Parse("10635826342196669611219640"),BigInteger.Parse("70320933672952732438772180006") };
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
public class A191602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191602Inst Instance=new A191602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191603
{
public static readonly BigInteger[] Value={ 2L,8L,58L,856L,24368L,1348666L,145634012L,30602076600L,12521664597022L,9976791553569412L,15477885230123717308UL,BigInteger.Parse("46755695360925385415444"),BigInteger.Parse("275015972447150661617296526"),BigInteger.Parse("3149789884136909401259248638902") };
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
public class A191603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191603Inst Instance=new A191603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191604
{
public static readonly BigInteger[] Value={ 2L,8L,62L,966L,29888L,1838552L,224969616L,54745613520L,26495136860880L,25502057625872912L,BigInteger.Parse("48817512227401500592"),BigInteger.Parse("185852155121293444267024"),BigInteger.Parse("1407184656492293192061559200"),BigInteger.Parse("21189763355834331020518358995456") };
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
public class A191604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191604Inst Instance=new A191604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191605
{
public static readonly long[] Value={ 1L,4L,10L,26L,66L,168L,426L,1078L,2722L,6862L,17274L,43432L,109086L,273734L,686334L,1719604L,4305666L,10774550L,26948142L,67367456L,168337622L,420472716L,1049866442L,2620488898L,6538734758L,16310909604L,40676600026L,101414764862L,252787228590L,629960214066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191605Inst : IEnumerable<long>
{
public static readonly long[] Value=A191605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191605.Bytes);
public long this[int i]=>Value[i];

public static A191605Inst Instance=new A191605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191606
{
public static readonly long[] Value={ 0L,0L,1L,4L,15L,56L,208L,768L,2823L,10352L,37944L,139232L,512048L,1888896L,6992960L,25989888L,96983687L,363368672L,1366820944L,5160846912L,19556183352L,74352602304L,283560228000L,1084470001024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191606Inst : IEnumerable<long>
{
public static readonly long[] Value=A191606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191606.Bytes);
public long this[int i]=>Value[i];

public static A191606Inst Instance=new A191606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191607
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,1L,1L,0L,1L,3L,2L,1L,1L,1L,0L,1L,4L,3L,2L,3L,1L,2L,1L,1L,1L,0L,1L,5L,4L,3L,2L,3L,1L,2L,1L,1L,1L,1L,0L,1L,6L,5L,4L,3L,5L,2L,3L,4L,1L,3L,2L,1L,2L,1L,1L,1L,1L,0L,1L,7L,6L,5L,4L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,1L,1L,1L,0L,1L,8L,7L,6L,5L,4L,7L,3L,5L,2L,5L,3L,4L,5L,1L,4L,3L,2L,3L,1L,2L,1L,2L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191607Inst : IEnumerable<long>
{
public static readonly long[] Value=A191607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191607.Bytes);
public long this[int i]=>Value[i];

public static A191607Inst Instance=new A191607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191608
{
public static readonly long[] Value={ 6L,9L,8L,1L,6L,2L,1L,1L,5L,4L,3L,8L,3L,9L,3L,9L,0L,3L,5L,3L,3L,5L,2L,3L,8L,8L,7L,5L,0L,8L,3L,4L,6L,9L,7L,5L,9L,2L,9L,5L,9L,9L,1L,0L,9L,1L,2L,4L,1L,8L,7L,4L,4L,7L,5L,3L,3L,8L,9L,2L,4L,6L,2L,8L,4L,7L,2L,7L,9L,7L,2L,5L,3L,9L,7L,5L,0L,7L,9L,4L,7L,0L,4L,9L,6L,7L,3L,7L,9L,9L,7L,4L,1L,8L,9L,8L,9L,7L,0L,3L,1L,6L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191608Inst : IEnumerable<long>
{
public static readonly long[] Value=A191608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191608.Bytes);
public long this[int i]=>Value[i];

public static A191608Inst Instance=new A191608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191609
{
public static readonly long[] Value={ 5L,19L,23L,29L,47L,53L,71L,97L,101L,139L,149L,163L,167L,173L,191L,197L,211L,239L,263L,269L,293L,311L,317L,359L,379L,383L,389L,409L,431L,461L,479L,499L,503L,509L,557L,599L,643L,647L,653L,677L,701L,719L,743L,773L,797L,821L,839L,859L,863L,887L,907L,941L,983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191609Inst : IEnumerable<long>
{
public static readonly long[] Value=A191609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191609.Bytes);
public long this[int i]=>Value[i];

public static A191609Inst Instance=new A191609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191610
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,93L,94L,95L,96L,97L,99L,100L,101L,102L,103L,105L,106L,107L,108L,109L,111L,112L,113L,114L,115L,117L,118L,119L,120L,121L,124L,125L,126L,127L,128L,130L,131L,132L,133L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191610Inst : IEnumerable<long>
{
public static readonly long[] Value=A191610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191610.Bytes);
public long this[int i]=>Value[i];

public static A191610Inst Instance=new A191610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191611
{
public static readonly BigInteger[] Value={ 3L,7L,8L,31L,127L,8191L,131071L,524287L,2147483647L,2305843009213693951L,BigInteger.Parse("618970019642690137449562111"),BigInteger.Parse("162259276829213363391578010288127"),BigInteger.Parse("170141183460469231731687303715884105727") };
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
public class A191611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191611Inst Instance=new A191611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191692
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,26L,60L,143L,345L,841L,2071L,5147L,12884L,32453L,82189L,209121L,534274L,1369940L,3524020L,9091340L,23515042L,60965624L,158399334L,412354169L,1075389431L,2809166692L,7349381323L,19254701768L,50511699310L,132671378996L,348864994867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191692Inst : IEnumerable<long>
{
public static readonly long[] Value=A191692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191692.Bytes);
public long this[int i]=>Value[i];

public static A191692Inst Instance=new A191692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191693
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,54L,131L,318L,781L,1937L,4841L,12175L,30791L,78254L,199721L,511640L,1315064L,3390147L,8762929L,22705350L,58960248L,153411988L,399903630L,1044199306L,2730780816L,7151800337L,18755305334L,49246220422L,129456991053L,340682085365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191693Inst : IEnumerable<long>
{
public static readonly long[] Value=A191693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191693.Bytes);
public long this[int i]=>Value[i];

public static A191693Inst Instance=new A191693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191694
{
public static readonly long[] Value={ 1L,2L,6L,16L,42L,110L,294L,788L,2130L,5802L,15918L,43945L,122010L,340470L,954409L,2686324L,7588770L,21508796L,61144062L,174286791L,498012192L,1426221150L,4092816966L,11767198302L,33890202200L,97761489210L,282424565454L,817018714982L,2366546223930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191694Inst : IEnumerable<long>
{
public static readonly long[] Value=A191694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191694.Bytes);
public long this[int i]=>Value[i];

public static A191694Inst Instance=new A191694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191695
{
public static readonly long[] Value={ 5L,5L,6L,9L,14L,23L,37L,61L,101L,168L,278L,462L,769L,1280L,2131L,3550L,5913L,9853L,16418L,27359L,45594L,75985L,126636L,211055L,351751L,586244L,977065L,1628433L,2714045L,4523397L,7538982L,12564956L,20941578L,34902612L,58171000L,96951645L,161586051L,269310058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191695Inst : IEnumerable<long>
{
public static readonly long[] Value=A191695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191695.Bytes);
public long this[int i]=>Value[i];

public static A191695Inst Instance=new A191695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191696
{
public static readonly long[] Value={ 1L,1L,3L,6L,11L,19L,33L,57L,96L,162L,272L,455L,761L,1271L,2121L,3539L,5901L,9839L,16403L,27342L,45576L,75965L,126614L,211029L,351723L,586213L,977031L,1628395L,2714003L,4523350L,7538930L,12564898L,20941513L,34902540L,58170920L,96951556L,161585952L,269309948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191696Inst : IEnumerable<long>
{
public static readonly long[] Value=A191696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191696.Bytes);
public long this[int i]=>Value[i];

public static A191696Inst Instance=new A191696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191697
{
public static readonly long[] Value={ 0L,4L,6L,8L,20L,28L,56L,96L,168L,304L,528L,944L,1664L,2944L,5216L,9216L,16320L,28864L,51072L,90368L,159872L,282880L,500480L,885504L,1566720L,2771968L,4904448L,8677376L,15352832L,27163648L,48060416L,85032960L,150448128L,266186752L,470962176L,833269760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191697Inst : IEnumerable<long>
{
public static readonly long[] Value=A191697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191697.Bytes);
public long this[int i]=>Value[i];

public static A191697Inst Instance=new A191697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191698
{
public static readonly long[] Value={ 0L,38L,204L,585L,1280L,2370L,3960L,6125L,8976L,12582L,17060L,22473L,28944L,36530L,45360L,55485L,67040L,80070L,94716L,111017L,129120L,149058L,170984L,194925L,221040L,249350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191698Inst : IEnumerable<long>
{
public static readonly long[] Value=A191698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191698.Bytes);
public long this[int i]=>Value[i];

public static A191698Inst Instance=new A191698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191699
{
public static readonly long[] Value={ 3L,4L,6L,9L,31L,187L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191699Inst : IEnumerable<long>
{
public static readonly long[] Value=A191699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191699.Bytes);
public long this[int i]=>Value[i];

public static A191699Inst Instance=new A191699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191700
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,8L,24L,128L,624L,1920L,8448L,137472L,1203456L,835584L,-23073792L,1024616448L,15237156864L,-88263327744L,-2230875095040L,37715465207808L,842231374479360L,-10018210447097856L,-278334129792614400L,4502327717477744640L,BigInteger.Parse("131853718231347363840") };
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
public class A191700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191700Inst Instance=new A191700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191701
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,5L,9L,15L,28L,50L,95L,174L,337L,637L,1231L,2373L,4618L,8974L,17567L,34387L,67561L,132945L,262096L,517373L,1023366L,2025627L,4014861L,7964971L,15814414L,31424805L,62490481L,124330234L,247514283L,492990898L,982307460L,1958093809L,3904594162L,7788271542L,15539347702L,31012331211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191701Inst : IEnumerable<long>
{
public static readonly long[] Value=A191701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191701.Bytes);
public long this[int i]=>Value[i];

public static A191701Inst Instance=new A191701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191702
{
public static readonly long[] Value={ 1L,5L,2L,25L,10L,3L,125L,50L,15L,4L,625L,250L,75L,20L,6L,3125L,1250L,375L,100L,30L,7L,15625L,6250L,1875L,500L,150L,35L,8L,78125L,31250L,9375L,2500L,750L,175L,40L,9L,390625L,156250L,46875L,12500L,3750L,875L,200L,45L,11L,1953125L,781250L,234375L,62500L,18750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191702Inst : IEnumerable<long>
{
public static readonly long[] Value=A191702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191702.Bytes);
public long this[int i]=>Value[i];

public static A191702Inst Instance=new A191702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191703
{
public static readonly long[] Value={ 1L,6L,2L,31L,11L,3L,156L,56L,16L,4L,781L,281L,81L,21L,5L,3906L,1406L,406L,106L,26L,7L,19531L,7031L,2031L,531L,131L,36L,8L,97656L,35156L,10156L,2656L,656L,181L,41L,9L,488281L,175781L,50781L,13281L,3281L,906L,206L,46L,10L,2441406L,878906L,253906L,66406L,16406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191703Inst : IEnumerable<long>
{
public static readonly long[] Value=A191703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191703.Bytes);
public long this[int i]=>Value[i];

public static A191703Inst Instance=new A191703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191704
{
public static readonly long[] Value={ 1L,2L,3L,7L,12L,4L,32L,57L,17L,5L,157L,282L,82L,22L,6L,782L,1407L,407L,107L,27L,8L,3907L,7032L,2032L,532L,132L,37L,9L,19532L,35157L,10157L,2657L,657L,182L,42L,10L,97657L,175782L,50782L,13282L,3282L,907L,207L,47L,11L,488282L,878907L,253907L,66407L,16407L,4532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191704Inst : IEnumerable<long>
{
public static readonly long[] Value=A191704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191704.Bytes);
public long this[int i]=>Value[i];

public static A191704Inst Instance=new A191704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191705
{
public static readonly long[] Value={ 1L,3L,2L,13L,8L,4L,63L,38L,18L,5L,313L,188L,88L,23L,6L,1563L,938L,438L,113L,28L,7L,7813L,4688L,2188L,563L,138L,33L,9L,39063L,23438L,10938L,2813L,688L,163L,43L,10L,195313L,117188L,54688L,14063L,3438L,813L,213L,48L,11L,976563L,585938L,273438L,70313L,17188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191705Inst : IEnumerable<long>
{
public static readonly long[] Value=A191705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191705.Bytes);
public long this[int i]=>Value[i];

public static A191705Inst Instance=new A191705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191706
{
public static readonly long[] Value={ 1L,4L,2L,19L,9L,3L,94L,44L,14L,5L,469L,219L,69L,24L,6L,2344L,1094L,344L,119L,29L,7L,11719L,5469L,1719L,594L,144L,34L,8L,58594L,27344L,8594L,2969L,719L,169L,39L,10L,292969L,136719L,42969L,14844L,3594L,844L,194L,49L,11L,1464844L,683594L,214844L,74219L,17969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191706Inst : IEnumerable<long>
{
public static readonly long[] Value=A191706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191706.Bytes);
public long this[int i]=>Value[i];

public static A191706Inst Instance=new A191706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191707
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,10L,4L,9L,13L,15L,6L,12L,17L,19L,20L,8L,16L,22L,24L,26L,25L,11L,21L,28L,31L,33L,32L,30L,14L,27L,36L,39L,42L,41L,38L,35L,18L,34L,46L,49L,53L,52L,48L,44L,40L,23L,43L,58L,62L,67L,66L,61L,56L,51L,45L,29L,54L,73L,78L,84L,83L,77L,71L,64L,57L,50L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191707Inst : IEnumerable<long>
{
public static readonly long[] Value=A191707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191707.Bytes);
public long this[int i]=>Value[i];

public static A191707Inst Instance=new A191707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191708
{
public static readonly long[] Value={ 1L,2L,6L,3L,8L,11L,4L,10L,14L,16L,5L,13L,18L,20L,21L,7L,17L,23L,25L,27L,26L,9L,22L,29L,32L,34L,33L,31L,12L,28L,37L,40L,43L,42L,39L,36L,15L,35L,47L,50L,54L,53L,49L,45L,41L,19L,44L,59L,63L,68L,67L,62L,57L,52L,46L,24L,55L,74L,79L,85L,84L,78L,72L,65L,58L,51L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191708Inst : IEnumerable<long>
{
public static readonly long[] Value=A191708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191708.Bytes);
public long this[int i]=>Value[i];

public static A191708Inst Instance=new A191708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191709
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,7L,8L,6L,10L,12L,11L,9L,14L,16L,17L,15L,13L,19L,21L,23L,22L,20L,18L,25L,28L,30L,29L,27L,26L,24L,33L,36L,39L,38L,35L,32L,34L,31L,43L,46L,50L,49L,45L,41L,37L,44L,40L,55L,59L,64L,63L,58L,53L,48L,42L,56L,51L,70L,75L,81L,80L,74L,68L,61L,54L,47L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191709Inst : IEnumerable<long>
{
public static readonly long[] Value=A191709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191709.Bytes);
public long this[int i]=>Value[i];

public static A191709Inst Instance=new A191709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191710
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,6L,7L,11L,13L,9L,10L,15L,17L,18L,12L,14L,20L,22L,24L,23L,16L,19L,26L,29L,31L,30L,28L,21L,25L,34L,37L,40L,39L,36L,33L,27L,32L,44L,47L,51L,50L,46L,42L,38L,35L,41L,56L,60L,65L,64L,59L,54L,49L,43L,45L,52L,71L,76L,82L,81L,75L,69L,62L,55L,48L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191710Inst : IEnumerable<long>
{
public static readonly long[] Value=A191710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191710.Bytes);
public long this[int i]=>Value[i];

public static A191710Inst Instance=new A191710Inst();

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