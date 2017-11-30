using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A038936
{
public static readonly long[] Value={ 5L,11L,13L,17L,23L,31L,37L,47L,67L,79L,83L,97L,101L,103L,109L,127L,131L,137L,149L,151L,181L,191L,193L,197L,211L,223L,233L,239L,241L,251L,263L,307L,311L,331L,337L,347L,353L,359L,373L,379L,389L,409L,419L,421L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038936Inst : IEnumerable<long>
{
public static readonly long[] Value=A038936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038936.Bytes);
public long this[int i]=>Value[i];

public static A038936Inst Instance=new A038936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038937
{
public static readonly long[] Value={ 2L,3L,7L,11L,19L,23L,29L,37L,43L,61L,71L,101L,103L,131L,151L,157L,163L,167L,199L,211L,223L,229L,233L,239L,241L,251L,257L,269L,281L,293L,307L,313L,317L,331L,353L,379L,383L,389L,401L,421L,431L,439L,443L,457L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038937Inst : IEnumerable<long>
{
public static readonly long[] Value=A038937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038937.Bytes);
public long this[int i]=>Value[i];

public static A038937Inst Instance=new A038937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038938
{
public static readonly long[] Value={ 5L,13L,17L,31L,41L,47L,53L,59L,67L,73L,79L,83L,89L,97L,107L,109L,113L,127L,137L,139L,149L,173L,179L,181L,191L,193L,197L,227L,263L,271L,277L,283L,311L,337L,347L,349L,359L,367L,373L,397L,409L,419L,433L,449L,479L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038938Inst : IEnumerable<long>
{
public static readonly long[] Value=A038938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038938.Bytes);
public long this[int i]=>Value[i];

public static A038938Inst Instance=new A038938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038939
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,31L,41L,43L,47L,53L,59L,67L,83L,103L,131L,137L,151L,179L,181L,191L,193L,197L,211L,227L,241L,257L,277L,281L,283L,293L,317L,347L,367L,373L,389L,419L,431L,433L,443L,449L,461L,463L,467L,503L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038939Inst : IEnumerable<long>
{
public static readonly long[] Value=A038939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038939.Bytes);
public long this[int i]=>Value[i];

public static A038939Inst Instance=new A038939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038940
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,37L,61L,71L,73L,79L,89L,97L,101L,107L,109L,113L,127L,139L,149L,157L,163L,167L,173L,199L,223L,229L,233L,239L,251L,263L,269L,271L,307L,311L,313L,331L,337L,349L,353L,359L,379L,383L,397L,401L,409L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038940Inst : IEnumerable<long>
{
public static readonly long[] Value=A038940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038940.Bytes);
public long this[int i]=>Value[i];

public static A038940Inst Instance=new A038940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038957
{
public static readonly long[] Value={ 2L,3L,19L,23L,37L,41L,61L,67L,71L,73L,79L,89L,97L,109L,127L,137L,149L,173L,181L,211L,223L,227L,251L,257L,269L,283L,293L,311L,317L,347L,349L,353L,359L,367L,373L,383L,389L,397L,401L,419L,439L,457L,461L,463L,479L,487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038957Inst : IEnumerable<long>
{
public static readonly long[] Value=A038957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038957.Bytes);
public long this[int i]=>Value[i];

public static A038957Inst Instance=new A038957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038958
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,29L,31L,43L,47L,53L,59L,83L,101L,103L,107L,113L,131L,139L,151L,157L,163L,167L,179L,191L,193L,197L,199L,229L,233L,239L,241L,263L,271L,277L,281L,307L,313L,331L,337L,379L,409L,421L,431L,433L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038958Inst : IEnumerable<long>
{
public static readonly long[] Value=A038958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038958.Bytes);
public long this[int i]=>Value[i];

public static A038958Inst Instance=new A038958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038959
{
public static readonly long[] Value={ 2L,5L,7L,13L,19L,29L,37L,41L,43L,47L,59L,61L,71L,73L,109L,127L,131L,137L,151L,163L,179L,223L,227L,233L,251L,263L,271L,277L,283L,331L,337L,347L,359L,367L,389L,421L,433L,461L,467L,499L,521L,523L,541L,547L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038959Inst : IEnumerable<long>
{
public static readonly long[] Value=A038959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038959.Bytes);
public long this[int i]=>Value[i];

public static A038959Inst Instance=new A038959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038960
{
public static readonly long[] Value={ 3L,11L,17L,23L,31L,53L,67L,79L,83L,89L,97L,101L,103L,107L,113L,139L,149L,157L,167L,173L,181L,191L,193L,197L,199L,211L,229L,239L,241L,257L,269L,281L,293L,307L,311L,313L,317L,349L,353L,373L,379L,383L,397L,401L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038960Inst : IEnumerable<long>
{
public static readonly long[] Value=A038960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038960.Bytes);
public long this[int i]=>Value[i];

public static A038960Inst Instance=new A038960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038961
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,23L,37L,41L,53L,61L,67L,71L,73L,83L,101L,113L,131L,137L,139L,163L,167L,173L,179L,191L,227L,241L,271L,283L,293L,307L,317L,331L,349L,379L,389L,401L,409L,421L,439L,443L,449L,461L,463L,479L,487L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038961Inst : IEnumerable<long>
{
public static readonly long[] Value=A038961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038961.Bytes);
public long this[int i]=>Value[i];

public static A038961Inst Instance=new A038961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038962
{
public static readonly long[] Value={ 2L,3L,5L,29L,31L,43L,47L,59L,79L,89L,97L,103L,107L,109L,127L,149L,151L,157L,181L,193L,197L,199L,211L,223L,229L,233L,239L,251L,257L,263L,269L,277L,281L,311L,313L,337L,347L,353L,359L,367L,373L,383L,397L,419L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038962Inst : IEnumerable<long>
{
public static readonly long[] Value=A038962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038962.Bytes);
public long this[int i]=>Value[i];

public static A038962Inst Instance=new A038962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038963
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,23L,29L,31L,37L,41L,43L,53L,59L,83L,89L,101L,109L,137L,139L,151L,173L,191L,211L,223L,227L,229L,263L,269L,271L,281L,283L,311L,313L,337L,349L,353L,389L,397L,401L,421L,433L,449L,463L,487L,503L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038963Inst : IEnumerable<long>
{
public static readonly long[] Value=A038963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038963.Bytes);
public long this[int i]=>Value[i];

public static A038963Inst Instance=new A038963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038964
{
public static readonly long[] Value={ 5L,17L,19L,47L,61L,67L,71L,73L,79L,97L,103L,107L,113L,127L,131L,149L,157L,163L,167L,179L,181L,193L,197L,199L,233L,239L,241L,251L,257L,277L,293L,307L,317L,331L,347L,359L,367L,373L,379L,383L,409L,419L,431L,439L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038964Inst : IEnumerable<long>
{
public static readonly long[] Value=A038964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038964.Bytes);
public long this[int i]=>Value[i];

public static A038964Inst Instance=new A038964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038965
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,43L,47L,59L,71L,73L,79L,89L,97L,101L,103L,107L,127L,139L,181L,191L,199L,211L,227L,241L,251L,257L,269L,271L,277L,281L,307L,311L,313L,317L,331L,337L,359L,379L,389L,397L,419L,421L,433L,443L,457L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038965Inst : IEnumerable<long>
{
public static readonly long[] Value=A038965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038965.Bytes);
public long this[int i]=>Value[i];

public static A038965Inst Instance=new A038965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038966
{
public static readonly long[] Value={ 11L,17L,19L,23L,29L,31L,37L,41L,53L,61L,67L,83L,109L,113L,131L,137L,149L,151L,157L,163L,167L,173L,179L,193L,197L,223L,229L,233L,239L,263L,283L,293L,347L,349L,353L,367L,373L,383L,401L,409L,431L,439L,449L,461L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038966Inst : IEnumerable<long>
{
public static readonly long[] Value=A038966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038966.Bytes);
public long this[int i]=>Value[i];

public static A038966Inst Instance=new A038966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038967
{
public static readonly long[] Value={ 2L,3L,11L,13L,19L,23L,29L,31L,41L,53L,67L,73L,101L,103L,109L,113L,127L,149L,157L,179L,181L,211L,223L,227L,229L,241L,271L,293L,317L,331L,337L,347L,353L,359L,367L,397L,401L,409L,421L,431L,433L,449L,487L,499L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038967Inst : IEnumerable<long>
{
public static readonly long[] Value=A038967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038967.Bytes);
public long this[int i]=>Value[i];

public static A038967Inst Instance=new A038967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038968
{
public static readonly long[] Value={ 5L,7L,17L,37L,43L,47L,59L,61L,71L,79L,83L,89L,97L,107L,131L,137L,139L,151L,163L,167L,173L,191L,193L,197L,199L,233L,239L,251L,257L,263L,269L,277L,281L,283L,307L,311L,313L,349L,373L,379L,383L,389L,419L,439L,443L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038968Inst : IEnumerable<long>
{
public static readonly long[] Value=A038968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038968.Bytes);
public long this[int i]=>Value[i];

public static A038968Inst Instance=new A038968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038969
{
public static readonly long[] Value={ 17L,19L,29L,37L,41L,43L,47L,61L,67L,71L,79L,83L,103L,107L,109L,113L,139L,163L,173L,179L,193L,197L,211L,223L,229L,239L,241L,251L,263L,271L,277L,283L,293L,307L,311L,313L,317L,331L,347L,349L,353L,367L,373L,379L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038969Inst : IEnumerable<long>
{
public static readonly long[] Value=A038969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038969.Bytes);
public long this[int i]=>Value[i];

public static A038969Inst Instance=new A038969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038970
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,23L,31L,53L,59L,73L,89L,97L,101L,127L,131L,137L,149L,151L,157L,167L,181L,191L,199L,227L,233L,257L,269L,281L,337L,359L,383L,389L,419L,421L,431L,433L,443L,449L,457L,461L,463L,479L,499L,523L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038970Inst : IEnumerable<long>
{
public static readonly long[] Value=A038970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038970.Bytes);
public long this[int i]=>Value[i];

public static A038970Inst Instance=new A038970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038971
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,23L,37L,59L,73L,89L,97L,101L,107L,113L,149L,151L,163L,167L,173L,179L,191L,193L,197L,227L,229L,233L,239L,251L,271L,277L,281L,283L,313L,317L,331L,337L,347L,349L,359L,367L,389L,397L,409L,421L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038971Inst : IEnumerable<long>
{
public static readonly long[] Value=A038971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038971.Bytes);
public long this[int i]=>Value[i];

public static A038971Inst Instance=new A038971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038972
{
public static readonly long[] Value={ 2L,11L,13L,29L,31L,41L,43L,47L,53L,61L,67L,71L,79L,83L,103L,109L,127L,131L,137L,139L,157L,181L,199L,211L,223L,241L,257L,263L,269L,293L,307L,311L,353L,373L,379L,383L,401L,419L,431L,433L,439L,443L,449L,457L,463L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038972Inst : IEnumerable<long>
{
public static readonly long[] Value=A038972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038972.Bytes);
public long this[int i]=>Value[i];

public static A038972Inst Instance=new A038972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038989
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,118L,341L,986L,2849L,8234L,23797L,68774L,198761L,574430L,1660133L,4797874L,13866113L,40073810L,115815461L,334712894L,967338217L,2795659334L,8079605429L,23350493066L,67484177441L,195032892538L,563655520661L,1628994688214L,4707882025385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038989Inst : IEnumerable<long>
{
public static readonly long[] Value=A038989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038989.Bytes);
public long this[int i]=>Value[i];

public static A038989Inst Instance=new A038989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038990
{
public static readonly long[] Value={ 1L,2L,5L,14L,37L,98L,257L,674L,1765L,4622L,12101L,31682L,82945L,217154L,568517L,1488398L,3896677L,10201634L,26708225L,69923042L,183060901L,479259662L,1254718085L,3284894594L,8599965697L,22515002498L,58945041797L,154320122894L,404015326885L,1057725857762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038990Inst : IEnumerable<long>
{
public static readonly long[] Value=A038990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038990.Bytes);
public long this[int i]=>Value[i];

public static A038990Inst Instance=new A038990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038991
{
public static readonly long[] Value={ 1L,15L,40L,155L,156L,600L,400L,1395L,1210L,2340L,1464L,6200L,2380L,6000L,6240L,11811L,5220L,18150L,7240L,24180L,16000L,21960L,12720L,55800L,20306L,35700L,33880L,62000L,25260L,93600L,30784L,97155L,58560L,78300L,62400L,187550L,52060L,108600L,95200L,217620L,70644L,240000L,81400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038991Inst : IEnumerable<long>
{
public static readonly long[] Value=A038991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038991.Bytes);
public long this[int i]=>Value[i];

public static A038991Inst Instance=new A038991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038992
{
public static readonly long[] Value={ 1L,31L,121L,651L,781L,3751L,2801L,11811L,11011L,24211L,16105L,78771L,30941L,86831L,94501L,200787L,88741L,341341L,137561L,508431L,338921L,499255L,292561L,1429131L,508431L,959171L,925771L,1823451L,732541L,2929531L,954305L,3309747L,1948705L,2750971L,2187581L,7168161L,1926221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038992Inst : IEnumerable<long>
{
public static readonly long[] Value=A038992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038992.Bytes);
public long this[int i]=>Value[i];

public static A038992Inst Instance=new A038992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038993
{
public static readonly long[] Value={ 1L,63L,364L,2667L,3906L,22932L,19608L,97155L,99463L,246078L,177156L,970788L,402234L,1235304L,1421784L,3309747L,1508598L,6266169L,2613660L,10417302L,7137312L,11160828L,6728904L,35364420L,12714681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038993Inst : IEnumerable<long>
{
public static readonly long[] Value=A038993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038993.Bytes);
public long this[int i]=>Value[i];

public static A038993Inst Instance=new A038993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038994
{
public static readonly long[] Value={ 1L,127L,1093L,10795L,19531L,138811L,137257L,788035L,896260L,2480437L,1948717L,11798935L,5229043L,17431639L,21347383L,53743987L,25646167L,113825020L,49659541L,210837145L,150021901L,247487059L,154764793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038994Inst : IEnumerable<long>
{
public static readonly long[] Value=A038994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038994.Bytes);
public long this[int i]=>Value[i];

public static A038994Inst Instance=new A038994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038995
{
public static readonly long[] Value={ 1L,255L,3280L,43435L,97656L,836400L,960800L,6347715L,8069620L,24902280L,21435888L,142466800L,67977560L,245004000L,320311680L,866251507L,435984840L,2057753100L,943531280L,4241688360L,3151424000L,5466151440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038995Inst : IEnumerable<long>
{
public static readonly long[] Value=A038995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038995.Bytes);
public long this[int i]=>Value[i];

public static A038995Inst Instance=new A038995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038996
{
public static readonly long[] Value={ 1L,511L,9841L,174251L,488281L,5028751L,6725601L,50955971L,72636421L,249511591L,235794769L,1714804091L,883708281L,3436782111L,4805173321L,13910980083L,7411742281L,37117211131L,17927094321L,85083452531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038996Inst : IEnumerable<long>
{
public static readonly long[] Value=A038996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038996.Bytes);
public long this[int i]=>Value[i];

public static A038996Inst Instance=new A038996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038997
{
public static readonly long[] Value={ 1L,1023L,29524L,698027L,2441406L,30203052L,47079208L,408345795L,653757313L,2497558338L,2593742460L,20608549148L,11488207654L,48162029784L,72080070744L,222984027123L,125999618778L,668793731199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038997Inst : IEnumerable<long>
{
public static readonly long[] Value=A038997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038997.Bytes);
public long this[int i]=>Value[i];

public static A038997Inst Instance=new A038997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038998
{
public static readonly long[] Value={ 1L,2047L,88573L,2794155L,12207031L,181308931L,329554457L,3269560515L,5883904390L,24987792457L,28531167061L,247486690815L,149346699503L,674597973479L,1081213356763L,3571013994483L,2141993519227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038998Inst : IEnumerable<long>
{
public static readonly long[] Value=A038998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038998.Bytes);
public long this[int i]=>Value[i];

public static A038998Inst Instance=new A038998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A038999
{
public static readonly long[] Value={ 1L,4095L,265720L,11180715L,61035156L,1088123400L,2306881200L,26167664835L,52955405230L,249938963820L,313842837672L,2970939589800L,1941507093540L,9446678514000L,16218261652320L,57162391576563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A038999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A038999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A038999Inst : IEnumerable<long>
{
public static readonly long[] Value=A038999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A038999.Bytes);
public long this[int i]=>Value[i];

public static A038999Inst Instance=new A038999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039000
{
public static readonly long[] Value={ 2L,3L,8L,11L,15L,19L,21L,26L,28L,30L,35L,36L,47L,51L,59L,61L,65L,69L,73L,75L,80L,86L,88L,92L,96L,100L,102L,107L,110L,114L,126L,136L,138L,143L,144L,155L,159L,166L,172L,174L,179L,185L,187L,190L,192L,197L,198L,209L,213L,221L,223L,227L,231L,235L,237L,242L,247L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039000Inst : IEnumerable<long>
{
public static readonly long[] Value=A039000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039000.Bytes);
public long this[int i]=>Value[i];

public static A039000Inst Instance=new A039000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039001
{
public static readonly long[] Value={ 0L,5L,7L,11L,15L,19L,21L,29L,33L,44L,45L,50L,52L,55L,57L,63L,68L,70L,76L,83L,87L,98L,99L,104L,106L,116L,128L,132L,135L,140L,142L,146L,150L,154L,156L,163L,165L,171L,176L,178L,184L,189L,194L,196L,200L,204L,208L,210L,220L,226L,228L,245L,249L,260L,261L,266L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039001Inst : IEnumerable<long>
{
public static readonly long[] Value=A039001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039001.Bytes);
public long this[int i]=>Value[i];

public static A039001Inst Instance=new A039001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039002
{
public static readonly long[] Value={ 2L,3L,4L,10L,11L,14L,15L,18L,19L,24L,28L,33L,36L,42L,43L,46L,47L,49L,52L,58L,59L,62L,63L,65L,68L,74L,75L,78L,79L,80L,98L,99L,104L,108L,114L,115L,120L,124L,134L,135L,137L,141L,146L,147L,152L,156L,161L,164L,170L,171L,174L,175L,177L,180L,186L,187L,190L,191L,198L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039002Inst : IEnumerable<long>
{
public static readonly long[] Value=A039002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039002.Bytes);
public long this[int i]=>Value[i];

public static A039002Inst Instance=new A039002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039003
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,13L,15L,18L,21L,23L,24L,29L,31L,33L,35L,36L,44L,50L,53L,55L,56L,61L,63L,70L,73L,75L,78L,82L,85L,87L,88L,93L,95L,97L,99L,100L,108L,114L,117L,119L,120L,125L,127L,130L,133L,135L,136L,141L,143L,145L,147L,148L,156L,160L,177L,179L,180L,188L,198L,201L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039003Inst : IEnumerable<long>
{
public static readonly long[] Value=A039003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039003.Bytes);
public long this[int i]=>Value[i];

public static A039003Inst Instance=new A039003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039004
{
public static readonly long[] Value={ 0L,3L,6L,9L,12L,15L,18L,24L,27L,30L,33L,36L,39L,45L,48L,51L,54L,57L,60L,63L,66L,72L,75L,78L,90L,96L,99L,102L,105L,108L,111L,114L,120L,123L,126L,129L,132L,135L,141L,144L,147L,150L,153L,156L,159L,165L,177L,180L,183L,189L,192L,195L,198L,201L,204L,207L,210L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039004Inst : IEnumerable<long>
{
public static readonly long[] Value=A039004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039004.Bytes);
public long this[int i]=>Value[i];

public static A039004Inst Instance=new A039004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039021
{
public static readonly long[] Value={ 0L,2L,4L,5L,9L,12L,14L,16L,17L,19L,24L,26L,28L,29L,30L,32L,34L,35L,39L,51L,54L,56L,58L,59L,63L,69L,72L,74L,76L,77L,81L,84L,86L,88L,89L,91L,96L,98L,100L,101L,102L,104L,106L,107L,109L,114L,116L,118L,119L,121L,133L,139L,144L,146L,148L,149L,153L,156L,158L,160L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039021Inst : IEnumerable<long>
{
public static readonly long[] Value=A039021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039021.Bytes);
public long this[int i]=>Value[i];

public static A039021Inst Instance=new A039021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039022
{
public static readonly long[] Value={ 0L,2L,3L,5L,10L,12L,14L,15L,17L,18L,20L,21L,23L,25L,30L,32L,33L,35L,40L,52L,58L,60L,62L,63L,65L,70L,72L,74L,75L,77L,82L,84L,86L,87L,89L,90L,92L,93L,95L,97L,102L,104L,105L,107L,108L,110L,111L,113L,118L,120L,122L,123L,125L,126L,128L,129L,131L,133L,138L,140L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039022Inst : IEnumerable<long>
{
public static readonly long[] Value=A039022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039022.Bytes);
public long this[int i]=>Value[i];

public static A039022Inst Instance=new A039022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039023
{
public static readonly long[] Value={ 0L,2L,3L,4L,11L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,31L,41L,53L,59L,65L,66L,68L,69L,70L,72L,74L,75L,76L,83L,84L,86L,87L,88L,90L,92L,93L,94L,96L,98L,99L,100L,103L,108L,110L,111L,112L,119L,120L,122L,123L,124L,126L,128L,129L,130L,132L,134L,135L,136L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039023Inst : IEnumerable<long>
{
public static readonly long[] Value=A039023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039023.Bytes);
public long this[int i]=>Value[i];

public static A039023Inst Instance=new A039023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039024
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,10L,11L,15L,20L,24L,25L,28L,29L,30L,31L,34L,35L,36L,37L,40L,41L,42L,43L,46L,47L,51L,56L,60L,61L,64L,65L,66L,67L,70L,71L,75L,81L,90L,91L,94L,95L,99L,105L,110L,116L,120L,121L,124L,125L,134L,140L,144L,145L,148L,149L,150L,151L,154L,155L,159L,164L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039024Inst : IEnumerable<long>
{
public static readonly long[] Value=A039024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039024.Bytes);
public long this[int i]=>Value[i];

public static A039024Inst Instance=new A039024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039025
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,9L,11L,16L,18L,19L,21L,23L,26L,30L,31L,33L,35L,36L,37L,39L,41L,42L,43L,45L,47L,52L,54L,55L,57L,59L,62L,66L,67L,69L,71L,76L,82L,94L,96L,97L,99L,101L,106L,108L,109L,111L,113L,114L,115L,117L,119L,124L,126L,127L,129L,131L,134L,138L,139L,141L,143L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039025Inst : IEnumerable<long>
{
public static readonly long[] Value=A039025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039025.Bytes);
public long this[int i]=>Value[i];

public static A039025Inst Instance=new A039025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039026
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,9L,10L,17L,18L,19L,21L,22L,24L,25L,27L,28L,32L,36L,37L,39L,40L,42L,43L,45L,46L,53L,54L,55L,57L,58L,60L,61L,63L,64L,68L,77L,83L,95L,101L,102L,103L,105L,106L,108L,109L,111L,112L,114L,115L,117L,118L,125L,126L,127L,129L,130L,132L,133L,135L,136L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039026Inst : IEnumerable<long>
{
public static readonly long[] Value=A039026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039026.Bytes);
public long this[int i]=>Value[i];

public static A039026Inst Instance=new A039026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039027
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,11L,12L,13L,14L,17L,22L,27L,30L,31L,32L,35L,36L,37L,38L,41L,42L,43L,44L,47L,48L,49L,50L,53L,58L,63L,66L,67L,68L,71L,72L,73L,74L,77L,78L,79L,80L,83L,84L,85L,86L,89L,94L,99L,102L,103L,104L,107L,112L,118L,124L,132L,133L,134L,137L,142L,147L,153L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039027Inst : IEnumerable<long>
{
public static readonly long[] Value=A039027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039027.Bytes);
public long this[int i]=>Value[i];

public static A039027Inst Instance=new A039027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039028
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,10L,12L,13L,14L,16L,23L,24L,25L,26L,28L,33L,36L,37L,38L,40L,42L,43L,44L,46L,48L,49L,50L,52L,59L,60L,61L,62L,64L,69L,72L,73L,74L,76L,78L,79L,80L,82L,84L,85L,86L,88L,95L,96L,97L,98L,100L,105L,113L,119L,125L,137L,138L,139L,140L,142L,144L,145L,146L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039028Inst : IEnumerable<long>
{
public static readonly long[] Value=A039028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039028.Bytes);
public long this[int i]=>Value[i];

public static A039028Inst Instance=new A039028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039029
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,12L,13L,14L,15L,18L,19L,20L,21L,29L,34L,36L,37L,38L,39L,42L,43L,44L,45L,48L,49L,50L,51L,54L,55L,56L,57L,65L,70L,72L,73L,74L,75L,78L,79L,80L,81L,84L,85L,86L,87L,90L,91L,92L,93L,101L,106L,108L,109L,110L,111L,114L,115L,116L,117L,120L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039029Inst : IEnumerable<long>
{
public static readonly long[] Value=A039029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039029.Bytes);
public long this[int i]=>Value[i];

public static A039029Inst Instance=new A039029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039030
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,30L,31L,32L,33L,34L,37L,38L,39L,40L,41L,44L,45L,46L,47L,48L,51L,52L,53L,54L,55L,63L,70L,77L,84L,91L,99L,105L,114L,115L,116L,117L,118L,121L,122L,123L,124L,125L,128L,129L,130L,131L,132L,135L,136L,137L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039030Inst : IEnumerable<long>
{
public static readonly long[] Value=A039030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039030.Bytes);
public long this[int i]=>Value[i];

public static A039030Inst Instance=new A039030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039031
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,8L,10L,11L,12L,13L,14L,22L,24L,25L,26L,27L,29L,31L,32L,33L,34L,36L,38L,39L,40L,41L,43L,45L,46L,47L,48L,51L,57L,59L,60L,61L,62L,63L,71L,73L,74L,75L,76L,78L,80L,81L,82L,83L,85L,87L,88L,89L,90L,92L,94L,95L,96L,97L,99L,101L,102L,103L,104L,105L,119L,126L,133L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039031Inst : IEnumerable<long>
{
public static readonly long[] Value=A039031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039031.Bytes);
public long this[int i]=>Value[i];

public static A039031Inst Instance=new A039031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039032
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,11L,12L,13L,15L,16L,18L,19L,20L,21L,29L,30L,32L,33L,34L,36L,37L,39L,40L,41L,43L,44L,46L,47L,48L,52L,57L,58L,60L,61L,62L,64L,65L,67L,68L,69L,70L,78L,79L,81L,82L,83L,85L,86L,88L,89L,90L,92L,93L,95L,96L,97L,101L,106L,107L,109L,110L,111L,113L,114L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039032Inst : IEnumerable<long>
{
public static readonly long[] Value=A039032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039032.Bytes);
public long this[int i]=>Value[i];

public static A039032Inst Instance=new A039032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039033
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,10L,12L,13L,15L,16L,17L,19L,20L,22L,23L,24L,26L,27L,28L,36L,37L,38L,40L,41L,43L,44L,45L,47L,48L,53L,57L,58L,59L,61L,62L,64L,65L,66L,68L,69L,71L,72L,73L,75L,76L,77L,85L,86L,87L,89L,90L,92L,93L,94L,96L,97L,102L,106L,107L,108L,110L,111L,113L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039033Inst : IEnumerable<long>
{
public static readonly long[] Value=A039033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039033.Bytes);
public long this[int i]=>Value[i];

public static A039033Inst Instance=new A039033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039034
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,11L,13L,15L,16L,17L,18L,20L,22L,23L,24L,25L,27L,29L,30L,31L,32L,34L,35L,43L,44L,45L,46L,48L,54L,57L,58L,59L,60L,62L,64L,65L,66L,67L,69L,71L,72L,73L,74L,76L,78L,79L,80L,81L,83L,84L,92L,93L,94L,95L,97L,103L,106L,107L,108L,109L,111L,113L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039034Inst : IEnumerable<long>
{
public static readonly long[] Value=A039034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039034.Bytes);
public long this[int i]=>Value[i];

public static A039034Inst Instance=new A039034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039035
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,9L,15L,21L,24L,25L,26L,27L,28L,31L,32L,33L,34L,35L,38L,39L,40L,41L,42L,45L,46L,47L,48L,51L,63L,66L,67L,68L,69L,72L,79L,86L,93L,99L,105L,108L,109L,110L,111L,120L,127L,134L,141L,147L,150L,151L,152L,153L,156L,162L,168L,171L,172L,173L,174L,175L,178L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039035Inst : IEnumerable<long>
{
public static readonly long[] Value=A039035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039035.Bytes);
public long this[int i]=>Value[i];

public static A039035Inst Instance=new A039035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039036
{
public static readonly long[] Value={ 0L,2L,4L,5L,6L,10L,14L,16L,18L,19L,20L,22L,28L,30L,32L,33L,34L,35L,37L,39L,40L,41L,42L,44L,46L,47L,48L,52L,66L,70L,72L,74L,75L,76L,80L,87L,94L,98L,100L,102L,103L,104L,108L,112L,114L,116L,117L,118L,120L,126L,128L,130L,131L,132L,133L,135L,137L,138L,139L,140L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039036Inst : IEnumerable<long>
{
public static readonly long[] Value=A039036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039036.Bytes);
public long this[int i]=>Value[i];

public static A039036Inst Instance=new A039036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039117
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,25L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,51L,52L,53L,54L,55L,57L,58L,59L,60L,71L,72L,73L,74L,75L,77L,78L,79L,81L,82L,83L,84L,85L,87L,88L,89L,91L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039117Inst : IEnumerable<long>
{
public static readonly long[] Value=A039117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039117.Bytes);
public long this[int i]=>Value[i];

public static A039117Inst Instance=new A039117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039118
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,11L,12L,13L,14L,15L,16L,18L,19L,21L,22L,23L,24L,25L,26L,28L,29L,31L,32L,33L,34L,35L,36L,38L,39L,41L,42L,43L,44L,45L,46L,48L,49L,51L,52L,53L,54L,55L,56L,58L,59L,61L,62L,63L,64L,65L,66L,68L,69L,70L,81L,82L,83L,84L,85L,86L,88L,89L,91L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039118Inst : IEnumerable<long>
{
public static readonly long[] Value=A039118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039118.Bytes);
public long this[int i]=>Value[i];

public static A039118Inst Instance=new A039118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039119
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,11L,12L,13L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,36L,37L,39L,41L,42L,43L,44L,45L,46L,47L,49L,51L,52L,53L,54L,55L,56L,57L,59L,61L,62L,63L,64L,65L,66L,67L,69L,71L,72L,73L,74L,75L,76L,77L,79L,80L,91L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039119Inst : IEnumerable<long>
{
public static readonly long[] Value=A039119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039119.Bytes);
public long this[int i]=>Value[i];

public static A039119Inst Instance=new A039119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039120
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,7L,8L,9L,12L,21L,30L,33L,34L,35L,36L,37L,38L,39L,40L,43L,44L,45L,46L,47L,48L,49L,50L,53L,54L,55L,56L,57L,58L,59L,60L,63L,64L,65L,66L,67L,68L,69L,70L,73L,74L,75L,76L,77L,78L,79L,80L,83L,84L,85L,86L,87L,88L,89L,90L,93L,94L,95L,96L,97L,98L,99L,102L,120L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039120Inst : IEnumerable<long>
{
public static readonly long[] Value=A039120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039120.Bytes);
public long this[int i]=>Value[i];

public static A039120Inst Instance=new A039120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039121
{
public static readonly long[] Value={ 0L,2L,4L,5L,6L,7L,8L,9L,13L,20L,22L,24L,25L,26L,27L,28L,29L,31L,40L,42L,44L,45L,46L,47L,48L,49L,50L,52L,54L,55L,56L,57L,58L,59L,60L,62L,64L,65L,66L,67L,68L,69L,70L,72L,74L,75L,76L,77L,78L,79L,80L,82L,84L,85L,86L,87L,88L,89L,90L,92L,94L,95L,96L,97L,98L,99L,103L,123L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039121Inst : IEnumerable<long>
{
public static readonly long[] Value=A039121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039121.Bytes);
public long this[int i]=>Value[i];

public static A039121Inst Instance=new A039121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039122
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,7L,8L,9L,14L,20L,22L,23L,25L,26L,27L,28L,29L,30L,32L,33L,35L,36L,37L,38L,39L,41L,50L,52L,53L,55L,56L,57L,58L,59L,60L,62L,63L,65L,66L,67L,68L,69L,70L,72L,73L,75L,76L,77L,78L,79L,80L,82L,83L,85L,86L,87L,88L,89L,90L,92L,93L,95L,96L,97L,98L,99L,104L,124L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039122Inst : IEnumerable<long>
{
public static readonly long[] Value=A039122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039122.Bytes);
public long this[int i]=>Value[i];

public static A039122Inst Instance=new A039122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039123
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,7L,8L,9L,15L,20L,22L,23L,24L,26L,27L,28L,29L,30L,32L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,46L,47L,48L,49L,51L,60L,62L,63L,64L,66L,67L,68L,69L,70L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L,86L,87L,88L,89L,90L,92L,93L,94L,96L,97L,98L,99L,105L,125L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039123Inst : IEnumerable<long>
{
public static readonly long[] Value=A039123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039123.Bytes);
public long this[int i]=>Value[i];

public static A039123Inst Instance=new A039123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039124
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,8L,9L,16L,20L,22L,23L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L,44L,45L,47L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,61L,70L,72L,73L,74L,75L,77L,78L,79L,80L,82L,83L,84L,85L,87L,88L,89L,90L,92L,93L,94L,95L,97L,98L,99L,106L,126L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039124Inst : IEnumerable<long>
{
public static readonly long[] Value=A039124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039124.Bytes);
public long this[int i]=>Value[i];

public static A039124Inst Instance=new A039124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039125
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,8L,9L,17L,20L,22L,23L,24L,25L,26L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,43L,44L,45L,46L,48L,49L,50L,52L,53L,54L,55L,56L,58L,59L,60L,62L,63L,64L,65L,66L,68L,69L,71L,80L,82L,83L,84L,85L,86L,88L,89L,90L,92L,93L,94L,95L,96L,98L,99L,107L,127L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039125Inst : IEnumerable<long>
{
public static readonly long[] Value=A039125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039125.Bytes);
public long this[int i]=>Value[i];

public static A039125Inst Instance=new A039125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039126
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,9L,18L,20L,22L,23L,24L,25L,26L,27L,29L,30L,32L,33L,34L,35L,36L,37L,39L,40L,42L,43L,44L,45L,46L,47L,49L,50L,52L,53L,54L,55L,56L,57L,59L,60L,62L,63L,64L,65L,66L,67L,69L,70L,72L,73L,74L,75L,76L,77L,79L,81L,90L,92L,93L,94L,95L,96L,97L,99L,108L,128L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039126Inst : IEnumerable<long>
{
public static readonly long[] Value=A039126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039126.Bytes);
public long this[int i]=>Value[i];

public static A039126Inst Instance=new A039126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039127
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,19L,20L,22L,23L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,37L,38L,40L,42L,43L,44L,45L,46L,47L,48L,50L,52L,53L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,67L,68L,70L,72L,73L,74L,75L,76L,77L,78L,80L,82L,83L,84L,85L,86L,87L,88L,91L,109L,129L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039127Inst : IEnumerable<long>
{
public static readonly long[] Value=A039127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039127.Bytes);
public long this[int i]=>Value[i];

public static A039127Inst Instance=new A039127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039128
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,8L,9L,10L,11L,14L,15L,16L,17L,18L,19L,23L,32L,40L,41L,44L,45L,46L,47L,48L,49L,50L,51L,54L,55L,56L,57L,58L,59L,60L,61L,64L,65L,66L,67L,68L,69L,70L,71L,74L,75L,76L,77L,78L,79L,80L,81L,84L,85L,86L,87L,88L,89L,90L,91L,94L,95L,96L,97L,98L,99L,100L,101L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039128Inst : IEnumerable<long>
{
public static readonly long[] Value=A039128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039128.Bytes);
public long this[int i]=>Value[i];

public static A039128Inst Instance=new A039128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039129
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,8L,9L,10L,11L,13L,15L,16L,17L,18L,19L,24L,30L,31L,33L,35L,36L,37L,38L,39L,42L,50L,51L,53L,55L,56L,57L,58L,59L,60L,61L,63L,65L,66L,67L,68L,69L,70L,71L,73L,75L,76L,77L,78L,79L,80L,81L,83L,85L,86L,87L,88L,89L,90L,91L,93L,95L,96L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039129Inst : IEnumerable<long>
{
public static readonly long[] Value=A039129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039129.Bytes);
public long this[int i]=>Value[i];

public static A039129Inst Instance=new A039129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039130
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,8L,9L,10L,11L,13L,14L,16L,17L,18L,19L,25L,30L,31L,33L,34L,36L,37L,38L,39L,40L,41L,43L,44L,46L,47L,48L,49L,52L,60L,61L,63L,64L,66L,67L,68L,69L,70L,71L,73L,74L,76L,77L,78L,79L,80L,81L,83L,84L,86L,87L,88L,89L,90L,91L,93L,94L,96L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039130Inst : IEnumerable<long>
{
public static readonly long[] Value=A039130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039130.Bytes);
public long this[int i]=>Value[i];

public static A039130Inst Instance=new A039130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039131
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,17L,18L,19L,26L,30L,31L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,47L,48L,49L,50L,51L,53L,54L,55L,57L,58L,59L,62L,70L,71L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,91L,93L,94L,95L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039131Inst : IEnumerable<long>
{
public static readonly long[] Value=A039131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039131.Bytes);
public long this[int i]=>Value[i];

public static A039131Inst Instance=new A039131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039132
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,10L,11L,13L,14L,15L,16L,18L,19L,27L,30L,31L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,45L,46L,48L,49L,50L,51L,53L,54L,55L,56L,58L,59L,60L,61L,63L,64L,65L,66L,68L,69L,72L,80L,81L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L,95L,96L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039132Inst : IEnumerable<long>
{
public static readonly long[] Value=A039132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039132.Bytes);
public long this[int i]=>Value[i];

public static A039132Inst Instance=new A039132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039149
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,20L,21L,22L,23L,24L,26L,27L,28L,30L,31L,32L,33L,34L,36L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,59L,60L,61L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,80L,81L,82L,83L,84L,86L,87L,88L,95L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039149Inst : IEnumerable<long>
{
public static readonly long[] Value=A039149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039149.Bytes);
public long this[int i]=>Value[i];

public static A039149Inst Instance=new A039149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039150
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,9L,10L,11L,12L,13L,14L,15L,18L,19L,20L,21L,22L,23L,24L,25L,28L,29L,30L,31L,32L,33L,34L,35L,38L,39L,40L,41L,42L,43L,44L,45L,48L,49L,50L,51L,52L,53L,54L,55L,58L,59L,67L,76L,80L,81L,82L,83L,84L,85L,88L,89L,90L,91L,92L,93L,94L,95L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039150Inst : IEnumerable<long>
{
public static readonly long[] Value=A039150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039150.Bytes);
public long this[int i]=>Value[i];

public static A039150Inst Instance=new A039150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039151
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,9L,10L,11L,12L,13L,14L,15L,17L,19L,20L,21L,22L,23L,24L,25L,27L,29L,30L,31L,32L,33L,34L,35L,37L,39L,40L,41L,42L,43L,44L,45L,47L,49L,50L,51L,52L,53L,54L,55L,57L,59L,68L,70L,71L,72L,73L,74L,75L,77L,79L,86L,90L,91L,92L,93L,94L,95L,97L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039151Inst : IEnumerable<long>
{
public static readonly long[] Value=A039151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039151.Bytes);
public long this[int i]=>Value[i];

public static A039151Inst Instance=new A039151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039152
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,10L,11L,12L,13L,14L,15L,17L,18L,20L,21L,22L,23L,24L,25L,27L,28L,30L,31L,32L,33L,34L,35L,37L,38L,40L,41L,42L,43L,44L,45L,47L,48L,50L,51L,52L,53L,54L,55L,57L,58L,69L,70L,71L,72L,73L,74L,75L,77L,78L,80L,81L,82L,83L,84L,85L,87L,88L,96L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039152Inst : IEnumerable<long>
{
public static readonly long[] Value=A039152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039152.Bytes);
public long this[int i]=>Value[i];

public static A039152Inst Instance=new A039152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039153
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,13L,14L,15L,16L,19L,20L,21L,22L,23L,24L,25L,26L,29L,30L,31L,32L,33L,34L,35L,36L,39L,40L,41L,42L,43L,44L,45L,46L,49L,50L,51L,52L,53L,54L,55L,56L,59L,60L,61L,62L,63L,64L,65L,66L,69L,78L,87L,90L,91L,92L,93L,94L,95L,96L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039153Inst : IEnumerable<long>
{
public static readonly long[] Value=A039153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039153.Bytes);
public long this[int i]=>Value[i];

public static A039153Inst Instance=new A039153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039154
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,10L,11L,12L,13L,14L,15L,16L,18L,20L,21L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,35L,36L,38L,40L,41L,42L,43L,44L,45L,46L,48L,50L,51L,52L,53L,54L,55L,56L,58L,60L,61L,62L,63L,64L,65L,66L,68L,79L,80L,81L,82L,83L,84L,85L,86L,88L,97L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039154Inst : IEnumerable<long>
{
public static readonly long[] Value=A039154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039154.Bytes);
public long this[int i]=>Value[i];

public static A039154Inst Instance=new A039154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039155
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,10L,11L,12L,13L,14L,15L,16L,17L,20L,21L,22L,23L,24L,25L,26L,27L,30L,31L,32L,33L,34L,35L,36L,37L,40L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,54L,55L,56L,57L,60L,61L,62L,63L,64L,65L,66L,67L,70L,71L,72L,73L,74L,75L,76L,77L,89L,98L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039155Inst : IEnumerable<long>
{
public static readonly long[] Value=A039155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039155.Bytes);
public long this[int i]=>Value[i];

public static A039155Inst Instance=new A039155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039156
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,24L,25L,26L,27L,28L,29L,30L,31L,32L,35L,36L,37L,38L,39L,40L,41L,42L,43L,46L,47L,48L,49L,50L,51L,52L,53L,54L,57L,58L,59L,60L,61L,62L,63L,64L,65L,68L,69L,70L,71L,72L,73L,74L,75L,76L,79L,80L,81L,82L,83L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039156Inst : IEnumerable<long>
{
public static readonly long[] Value=A039156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039156.Bytes);
public long this[int i]=>Value[i];

public static A039156Inst Instance=new A039156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039157
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,17L,18L,19L,20L,21L,22L,34L,36L,37L,38L,39L,40L,41L,42L,43L,45L,47L,48L,49L,50L,51L,52L,53L,54L,56L,58L,59L,60L,61L,62L,63L,64L,65L,67L,69L,70L,71L,72L,73L,74L,75L,76L,78L,80L,81L,82L,83L,84L,85L,86L,87L,89L,91L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039157Inst : IEnumerable<long>
{
public static readonly long[] Value=A039157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039157.Bytes);
public long this[int i]=>Value[i];

public static A039157Inst Instance=new A039157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039158
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,9L,10L,12L,13L,15L,16L,17L,18L,19L,20L,21L,23L,24L,26L,27L,28L,29L,30L,31L,32L,33L,45L,46L,48L,49L,50L,51L,52L,53L,54L,56L,57L,59L,60L,61L,62L,63L,64L,65L,67L,68L,70L,71L,72L,73L,74L,75L,76L,78L,79L,81L,82L,83L,84L,85L,86L,87L,89L,90L,92L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039158Inst : IEnumerable<long>
{
public static readonly long[] Value=A039158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039158.Bytes);
public long this[int i]=>Value[i];

public static A039158Inst Instance=new A039158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039159
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,9L,10L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,27L,28L,29L,30L,31L,32L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,56L,57L,58L,60L,61L,62L,63L,64L,65L,67L,68L,69L,71L,72L,73L,74L,75L,76L,78L,79L,80L,82L,83L,84L,85L,86L,87L,89L,90L,91L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039159Inst : IEnumerable<long>
{
public static readonly long[] Value=A039159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039159.Bytes);
public long this[int i]=>Value[i];

public static A039159Inst Instance=new A039159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039160
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,17L,18L,19L,20L,21L,23L,24L,25L,26L,28L,29L,30L,31L,32L,34L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,67L,68L,69L,70L,72L,73L,74L,75L,76L,78L,79L,80L,81L,83L,84L,85L,86L,87L,89L,90L,91L,92L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039160Inst : IEnumerable<long>
{
public static readonly long[] Value=A039160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039160.Bytes);
public long this[int i]=>Value[i];

public static A039160Inst Instance=new A039160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039161
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,21L,23L,24L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,37L,38L,40L,41L,42L,43L,45L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,78L,79L,80L,81L,82L,84L,85L,86L,87L,89L,90L,91L,92L,93L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039161Inst : IEnumerable<long>
{
public static readonly long[] Value=A039161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039161.Bytes);
public long this[int i]=>Value[i];

public static A039161Inst Instance=new A039161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039162
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,13L,14L,15L,16L,17L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,34L,35L,36L,37L,38L,39L,41L,42L,43L,45L,46L,47L,48L,49L,50L,52L,53L,54L,56L,57L,58L,59L,60L,61L,63L,64L,65L,67L,68L,69L,70L,71L,72L,74L,75L,76L,77L,89L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039162Inst : IEnumerable<long>
{
public static readonly long[] Value=A039162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039162.Bytes);
public long this[int i]=>Value[i];

public static A039162Inst Instance=new A039162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039163
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,14L,15L,16L,17L,18L,20L,21L,23L,24L,25L,26L,27L,28L,29L,31L,32L,34L,35L,36L,37L,38L,39L,40L,42L,43L,45L,46L,47L,48L,49L,50L,51L,53L,54L,56L,57L,58L,59L,60L,61L,62L,64L,65L,67L,68L,69L,70L,71L,72L,73L,75L,76L,78L,79L,80L,81L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039163Inst : IEnumerable<long>
{
public static readonly long[] Value=A039163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039163.Bytes);
public long this[int i]=>Value[i];

public static A039163Inst Instance=new A039163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039164
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,13L,14L,15L,16L,17L,18L,19L,21L,23L,24L,25L,26L,27L,28L,29L,30L,32L,34L,35L,36L,37L,38L,39L,40L,41L,43L,45L,46L,47L,48L,49L,50L,51L,52L,54L,56L,57L,58L,59L,60L,61L,62L,63L,65L,67L,68L,69L,70L,71L,72L,73L,74L,76L,78L,79L,80L,81L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039164Inst : IEnumerable<long>
{
public static readonly long[] Value=A039164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039164.Bytes);
public long this[int i]=>Value[i];

public static A039164Inst Instance=new A039164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039181
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,8L,9L,11L,12L,14L,15L,16L,17L,18L,19L,20L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,44L,45L,47L,48L,49L,50L,51L,52L,53L,55L,56L,58L,59L,60L,61L,62L,63L,64L,66L,67L,69L,70L,71L,72L,73L,74L,75L,77L,78L,80L,81L,82L,83L,84L,85L,86L,88L,89L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039181Inst : IEnumerable<long>
{
public static readonly long[] Value=A039181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039181.Bytes);
public long this[int i]=>Value[i];

public static A039181Inst Instance=new A039181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039182
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,7L,8L,9L,10L,11L,12L,13L,16L,17L,18L,19L,20L,21L,22L,23L,24L,27L,28L,29L,30L,31L,32L,37L,47L,55L,56L,57L,60L,61L,62L,63L,64L,65L,66L,67L,68L,71L,72L,73L,74L,75L,76L,77L,78L,79L,82L,83L,84L,85L,86L,87L,88L,89L,90L,93L,94L,95L,96L,97L,98L,99L,100L,101L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039182Inst : IEnumerable<long>
{
public static readonly long[] Value=A039182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039182.Bytes);
public long this[int i]=>Value[i];

public static A039182Inst Instance=new A039182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039183
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,9L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,32L,38L,44L,45L,46L,48L,50L,51L,52L,53L,54L,58L,66L,67L,68L,70L,72L,73L,74L,75L,76L,77L,78L,79L,81L,83L,84L,85L,86L,87L,88L,89L,90L,92L,94L,95L,96L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039183Inst : IEnumerable<long>
{
public static readonly long[] Value=A039183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039183.Bytes);
public long this[int i]=>Value[i];

public static A039183Inst Instance=new A039183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039184
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,9L,10L,11L,12L,13L,15L,16L,18L,19L,20L,21L,22L,23L,24L,26L,27L,29L,30L,31L,32L,39L,44L,45L,46L,48L,49L,51L,52L,53L,54L,55L,56L,57L,59L,60L,62L,63L,64L,65L,69L,77L,78L,79L,81L,82L,84L,85L,86L,87L,88L,89L,90L,92L,93L,95L,96L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039184Inst : IEnumerable<long>
{
public static readonly long[] Value=A039184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039184.Bytes);
public long this[int i]=>Value[i];

public static A039184Inst Instance=new A039184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039185
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,11L,12L,13L,15L,16L,17L,19L,20L,21L,22L,23L,24L,26L,27L,28L,30L,31L,32L,40L,44L,45L,46L,48L,49L,50L,52L,53L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,67L,68L,70L,71L,72L,74L,75L,76L,80L,88L,89L,90L,92L,93L,94L,96L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039185Inst : IEnumerable<long>
{
public static readonly long[] Value=A039185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039185.Bytes);
public long this[int i]=>Value[i];

public static A039185Inst Instance=new A039185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039186
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,9L,10L,11L,12L,13L,15L,16L,17L,18L,20L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,41L,44L,45L,46L,48L,49L,50L,51L,53L,54L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,67L,68L,70L,71L,72L,73L,75L,76L,77L,78L,79L,81L,82L,83L,84L,86L,87L,91L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039186Inst : IEnumerable<long>
{
public static readonly long[] Value=A039186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039186.Bytes);
public long this[int i]=>Value[i];

public static A039186Inst Instance=new A039186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039187
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,29L,30L,32L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,79L,81L,82L,83L,84L,85L,87L,88L,89L,90L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039187Inst : IEnumerable<long>
{
public static readonly long[] Value=A039187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039187.Bytes);
public long this[int i]=>Value[i];

public static A039187Inst Instance=new A039187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039188
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,9L,11L,12L,13L,15L,16L,17L,18L,19L,20L,22L,23L,24L,26L,27L,28L,29L,30L,31L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,55L,56L,57L,59L,60L,61L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,74L,75L,77L,78L,79L,81L,82L,83L,84L,85L,86L,88L,89L,90L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039188Inst : IEnumerable<long>
{
public static readonly long[] Value=A039188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039188.Bytes);
public long this[int i]=>Value[i];

public static A039188Inst Instance=new A039188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039189
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,10L,11L,12L,13L,14L,17L,18L,19L,20L,21L,22L,23L,24L,25L,28L,29L,30L,31L,32L,33L,34L,35L,36L,39L,40L,41L,42L,43L,49L,59L,66L,67L,68L,69L,72L,73L,74L,75L,76L,77L,78L,79L,80L,83L,84L,85L,86L,87L,88L,89L,90L,91L,94L,95L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039189Inst : IEnumerable<long>
{
public static readonly long[] Value=A039189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039189.Bytes);
public long this[int i]=>Value[i];

public static A039189Inst Instance=new A039189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039190
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,8L,9L,10L,11L,12L,13L,14L,16L,18L,19L,20L,21L,22L,23L,24L,25L,27L,29L,30L,31L,32L,33L,34L,35L,36L,38L,40L,41L,42L,43L,50L,55L,56L,57L,58L,60L,62L,63L,64L,65L,70L,77L,78L,79L,80L,82L,84L,85L,86L,87L,88L,89L,90L,91L,93L,95L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039190Inst : IEnumerable<long>
{
public static readonly long[] Value=A039190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039190.Bytes);
public long this[int i]=>Value[i];

public static A039190Inst Instance=new A039190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039191
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,9L,10L,11L,12L,13L,14L,16L,17L,19L,20L,21L,22L,23L,24L,25L,27L,28L,30L,31L,32L,33L,34L,35L,36L,38L,39L,41L,42L,43L,51L,55L,56L,57L,58L,60L,61L,63L,64L,65L,66L,67L,68L,69L,71L,72L,74L,75L,76L,81L,88L,89L,90L,91L,93L,94L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039191Inst : IEnumerable<long>
{
public static readonly long[] Value=A039191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039191.Bytes);
public long this[int i]=>Value[i];

public static A039191Inst Instance=new A039191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039192
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,16L,17L,18L,20L,21L,22L,23L,24L,25L,27L,28L,29L,31L,32L,33L,34L,35L,36L,38L,39L,40L,42L,43L,52L,55L,56L,57L,58L,60L,61L,62L,64L,65L,66L,67L,68L,69L,71L,72L,73L,75L,76L,77L,78L,79L,80L,82L,83L,84L,86L,87L,92L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039192Inst : IEnumerable<long>
{
public static readonly long[] Value=A039192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039192.Bytes);
public long this[int i]=>Value[i];

public static A039192Inst Instance=new A039192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039193
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,21L,22L,23L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,41L,43L,53L,55L,56L,57L,58L,60L,61L,62L,63L,65L,66L,67L,68L,69L,71L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L,85L,87L,88L,89L,90L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039193Inst : IEnumerable<long>
{
public static readonly long[] Value=A039193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039193.Bytes);
public long this[int i]=>Value[i];

public static A039193Inst Instance=new A039193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039194
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,41L,42L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,66L,67L,68L,69L,71L,72L,73L,74L,75L,77L,78L,79L,80L,82L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039194Inst : IEnumerable<long>
{
public static readonly long[] Value=A039194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039194.Bytes);
public long this[int i]=>Value[i];

public static A039194Inst Instance=new A039194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039195
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,8L,9L,10L,11L,12L,13L,14L,15L,18L,19L,20L,21L,22L,23L,24L,25L,26L,29L,30L,31L,32L,33L,34L,35L,36L,37L,40L,41L,42L,43L,44L,45L,46L,47L,48L,51L,52L,53L,54L,61L,71L,77L,78L,79L,80L,81L,84L,85L,86L,87L,88L,89L,90L,91L,92L,95L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039195Inst : IEnumerable<long>
{
public static readonly long[] Value=A039195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039195.Bytes);
public long this[int i]=>Value[i];

public static A039195Inst Instance=new A039195Inst();

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