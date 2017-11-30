using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A163464
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,3L,4L,4L,5L,5L,6L,6L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,16L,16L,17L,17L,18L,20L,20L,21L,21L,24L,24L,25L,26L,26L,27L,28L,28L,30L,30L,32L,32L,34L,35L,36L,36L,37L,38L,38L,40L,41L,42L,43L,43L,44L,45L,45L,46L,49L,50L,50L,51L,53L,54L,57L,57L,58L,59L,60L,61L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163464Inst : IEnumerable<long>
{
public static readonly long[] Value=A163464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163464.Bytes);
public long this[int i]=>Value[i];

public static A163464Inst Instance=new A163464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163465
{
public static readonly long[] Value={ 2L,3L,0L,1L,5L,4L,7L,6L,11L,13L,17L,8L,19L,9L,23L,29L,31L,10L,37L,12L,41L,43L,47L,14L,53L,59L,61L,67L,71L,15L,73L,16L,79L,83L,89L,97L,101L,18L,103L,107L,109L,20L,113L,21L,127L,131L,137L,22L,139L,149L,151L,157L,163L,24L,167L,173L,179L,181L,191L,25L,193L,26L,197L,199L,211L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163465Inst : IEnumerable<long>
{
public static readonly long[] Value=A163465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163465.Bytes);
public long this[int i]=>Value[i];

public static A163465Inst Instance=new A163465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163466
{
public static readonly long[] Value={ 2L,3L,2L,3L,5L,5L,7L,7L,11L,13L,17L,11L,19L,13L,23L,29L,31L,17L,37L,19L,41L,43L,47L,23L,53L,59L,61L,67L,71L,29L,73L,31L,79L,83L,89L,97L,101L,37L,103L,107L,109L,41L,113L,43L,127L,131L,137L,47L,139L,149L,151L,157L,163L,53L,167L,173L,179L,181L,191L,59L,193L,61L,197L,199L,211L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163466Inst : IEnumerable<long>
{
public static readonly long[] Value=A163466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163466.Bytes);
public long this[int i]=>Value[i];

public static A163466Inst Instance=new A163466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163467
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,18L,64L,72L,110L,294L,315L,1296L,2000L,2100L,2530L,6084L,8526L,9450L,33792L,38080L,46656L,53352L,82000L,106480L,248832L,270000L,275400L,322452L,341172L,460992L,615195L,2129920L,2515456L,2552448L,3548448L,3596400L,4161456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163467Inst : IEnumerable<long>
{
public static readonly long[] Value=A163467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163467.Bytes);
public long this[int i]=>Value[i];

public static A163467Inst Instance=new A163467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163468
{
public static readonly long[] Value={ 3L,4L,7L,9L,15L,18L,24L,27L,33L,43L,45L,54L,61L,64L,71L,80L,89L,93L,103L,109L,113L,122L,129L,139L,151L,157L,161L,168L,172L,179L,201L,208L,217L,220L,237L,241L,250L,261L,268L,279L,288L,291L,308L,311L,318L,321L,341L,361L,368L,371L,377L,388L,391L,408L,418L,428L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163468Inst : IEnumerable<long>
{
public static readonly long[] Value=A163468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163468.Bytes);
public long this[int i]=>Value[i];

public static A163468Inst Instance=new A163468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163469
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,3L,3L,3L,9L,15L,11L,11L,3L,3L,5L,9L,63L,3L,15L,5L,11L,15L,31L,1L,3L,21L,13L,9L,9L,31L,39L,15L,7L,25L,21L,35L,11L,9L,39L,53L,53L,81L,21L,5L,23L,9L,39L,17L,21L,19L,3L,77L,5L,39L,57L,41L,29L,45L,21L,11L,15L,13L,39L,17L,33L,67L,129L,33L,13L,3L,5L,105L,67L,7L,13L,3L,15L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163469Inst : IEnumerable<long>
{
public static readonly long[] Value=A163469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163469.Bytes);
public long this[int i]=>Value[i];

public static A163469Inst Instance=new A163469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163470
{
public static readonly long[] Value={ 3L,15L,81L,453L,2571L,14679L,84009L,481245L,2757843L,15806559L,90600513L,519318837L,2976744027L,17062807335L,97804786329L,560621795277L,3213512139939L,18420013780911L,105584452428081L,605215440272805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163470Inst : IEnumerable<long>
{
public static readonly long[] Value=A163470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163470.Bytes);
public long this[int i]=>Value[i];

public static A163470Inst Instance=new A163470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163471
{
public static readonly long[] Value={ 3L,18L,114L,744L,4932L,32952L,221016L,1485216L,9989808L,67223328L,452457504L,3045661824L,20502553152L,138020971392L,929153544576L,6255074075136L,42109362770688L,283481998053888L,1908413999583744L,12847536038651904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163471Inst : IEnumerable<long>
{
public static readonly long[] Value=A163471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163471.Bytes);
public long this[int i]=>Value[i];

public static A163471Inst Instance=new A163471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163472
{
public static readonly long[] Value={ 3L,21L,153L,1143L,8667L,66285L,509409L,3925503L,30295539L,234004869L,1808305641L,13977507015L,108055998027L,835414244829L,6459123003057L,49940805957327L,386138612387043L,2985616752052725L,23084826815860281L,178492568972583447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163472Inst : IEnumerable<long>
{
public static readonly long[] Value=A163472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163472.Bytes);
public long this[int i]=>Value[i];

public static A163472Inst Instance=new A163472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163473
{
public static readonly long[] Value={ 3L,24L,198L,1668L,14244L,122688L,1062408L,9230064L,80350128L,700318848L,6108357984L,53302344768L,465248359488L,4061569173504L,35460543892608L,309615432515328L,2703431036154624L,23605724610459648L,206122316883322368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163473Inst : IEnumerable<long>
{
public static readonly long[] Value=A163473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163473.Bytes);
public long this[int i]=>Value[i];

public static A163473Inst Instance=new A163473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163474
{
public static readonly long[] Value={ 3L,27L,249L,2337L,22203L,212691L,2048673L,19804617L,191904819L,1862395467L,18092133513L,175868012721L,1710268059243L,16636340171907L,161855091136689L,1574864707700697L,15324674763873123L,149128049052227451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163474Inst : IEnumerable<long>
{
public static readonly long[] Value=A163474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163474.Bytes);
public long this[int i]=>Value[i];

public static A163474Inst Instance=new A163474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163475
{
public static readonly long[] Value={ 3L,30L,306L,3168L,33156L,349704L,3708504L,39476160L,421307568L,4504395744L,48217133088L,516565527552L,5537243115072L,59378264922240L,636903805624704L,6832763837309952L,73311252232852224L,786646960881163776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163475Inst : IEnumerable<long>
{
public static readonly long[] Value=A163475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163475.Bytes);
public long this[int i]=>Value[i];

public static A163475Inst Instance=new A163475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163476
{
public static readonly long[] Value={ 3L,33L,369L,4179L,47787L,550377L,6372201L,74057451L,863045523L,10077337713L,117831338529L,1379125012419L,16152860411067L,189282082016697L,2218814180460441L,26015921653589211L,305093457567121443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163476Inst : IEnumerable<long>
{
public static readonly long[] Value=A163476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163476.Bytes);
public long this[int i]=>Value[i];

public static A163476Inst Instance=new A163476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163477
{
public static readonly long[] Value={ 0L,1L,5L,10L,25L,43L,62L,84L,142L,205L,275L,350L,423L,503L,588L,680L,908L,1145L,1393L,1650L,1925L,2211L,2506L,2812L,3098L,3397L,3711L,4038L,4371L,4719L,5080L,5456L,6360L,7281L,8221L,9178L,10161L,11163L,12182L,13220L,14310L,15421L,16555L,17710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163477Inst : IEnumerable<long>
{
public static readonly long[] Value=A163477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163477.Bytes);
public long this[int i]=>Value[i];

public static A163477Inst Instance=new A163477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163478
{
public static readonly long[] Value={ 0L,1L,6L,10L,30L,51L,68L,84L,164L,245L,330L,414L,482L,551L,616L,680L,1000L,1321L,1646L,1970L,2310L,2651L,2988L,3324L,3596L,3869L,4146L,4422L,4682L,4943L,5200L,5456L,6736L,8017L,9302L,10586L,11886L,13187L,14484L,15780L,17140L,18501L,19866L,21230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163478Inst : IEnumerable<long>
{
public static readonly long[] Value=A163478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163478.Bytes);
public long this[int i]=>Value[i];

public static A163478Inst Instance=new A163478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163479
{
public static readonly long[] Value={ 0L,1L,2L,12L,22L,31L,40L,50L,60L,151L,242L,332L,422L,513L,604L,686L,768L,849L,930L,1012L,1094L,1185L,1276L,1366L,1456L,1547L,1638L,2458L,3278L,4097L,4916L,5736L,6556L,7367L,8178L,8988L,9798L,10609L,11420L,12240L,13060L,13879L,14698L,15518L,16338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163479Inst : IEnumerable<long>
{
public static readonly long[] Value=A163479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163479.Bytes);
public long this[int i]=>Value[i];

public static A163479Inst Instance=new A163479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163480
{
public static readonly long[] Value={ 0L,1L,2L,15L,16L,17L,18L,19L,20L,141L,142L,143L,144L,145L,146L,159L,160L,161L,162L,163L,164L,177L,178L,179L,180L,181L,182L,1275L,1276L,1277L,1278L,1279L,1280L,1293L,1294L,1295L,1296L,1297L,1298L,1311L,1312L,1313L,1314L,1315L,1316L,1437L,1438L,1439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163480Inst : IEnumerable<long>
{
public static readonly long[] Value=A163480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163480.Bytes);
public long this[int i]=>Value[i];

public static A163480Inst Instance=new A163480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163481
{
public static readonly long[] Value={ 0L,5L,6L,47L,48L,53L,54L,59L,60L,425L,426L,431L,432L,437L,438L,479L,480L,485L,486L,491L,492L,533L,534L,539L,540L,545L,546L,3827L,3828L,3833L,3834L,3839L,3840L,3881L,3882L,3887L,3888L,3893L,3894L,3935L,3936L,3941L,3942L,3947L,3948L,4313L,4314L,4319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163481Inst : IEnumerable<long>
{
public static readonly long[] Value=A163481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163481.Bytes);
public long this[int i]=>Value[i];

public static A163481Inst Instance=new A163481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163482
{
public static readonly long[] Value={ 0L,1L,14L,15L,16L,19L,20L,21L,234L,235L,236L,239L,240L,241L,254L,255L,256L,259L,260L,261L,314L,315L,316L,319L,320L,321L,334L,335L,336L,339L,340L,341L,3754L,3755L,3756L,3759L,3760L,3761L,3774L,3775L,3776L,3779L,3780L,3781L,3834L,3835L,3836L,3839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163482Inst : IEnumerable<long>
{
public static readonly long[] Value=A163482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163482.Bytes);
public long this[int i]=>Value[i];

public static A163482Inst Instance=new A163482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163483
{
public static readonly long[] Value={ 0L,3L,4L,5L,58L,59L,60L,63L,64L,65L,78L,79L,80L,83L,84L,85L,938L,939L,940L,943L,944L,945L,958L,959L,960L,963L,964L,965L,1018L,1019L,1020L,1023L,1024L,1025L,1038L,1039L,1040L,1043L,1044L,1045L,1258L,1259L,1260L,1263L,1264L,1265L,1278L,1279L,1280L,1283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163483Inst : IEnumerable<long>
{
public static readonly long[] Value=A163483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163483.Bytes);
public long this[int i]=>Value[i];

public static A163483Inst Instance=new A163483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163484
{
public static readonly long[] Value={ 0L,4L,22L,40L,108L,188L,258L,336L,600L,884L,1190L,1528L,1804L,2092L,2394L,2720L,3760L,4836L,5942L,7112L,8324L,9564L,10890L,12272L,13360L,14484L,15598L,16792L,17996L,19212L,20490L,21824L,25952L,30148L,34390L,38760L,43164L,47612L,52242L,56976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163484Inst : IEnumerable<long>
{
public static readonly long[] Value=A163484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163484.Bytes);
public long this[int i]=>Value[i];

public static A163484Inst Instance=new A163484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163485
{
public static readonly long[] Value={ 0L,3L,1L,2L,14L,15L,13L,12L,6L,7L,5L,4L,8L,11L,9L,10L,58L,57L,59L,56L,62L,63L,61L,60L,54L,55L,53L,52L,50L,49L,51L,48L,26L,25L,27L,24L,30L,31L,29L,28L,22L,23L,21L,20L,18L,17L,19L,16L,32L,35L,33L,34L,46L,47L,45L,44L,38L,39L,37L,36L,40L,43L,41L,42L,234L,233L,235L,232L,228L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163485Inst : IEnumerable<long>
{
public static readonly long[] Value=A163485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163485.Bytes);
public long this[int i]=>Value[i];

public static A163485Inst Instance=new A163485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163486
{
public static readonly long[] Value={ 0L,2L,3L,1L,11L,10L,8L,9L,12L,14L,15L,13L,7L,6L,4L,5L,47L,45L,44L,46L,43L,42L,40L,41L,35L,33L,32L,34L,39L,38L,36L,37L,48L,50L,51L,49L,59L,58L,56L,57L,60L,62L,63L,61L,55L,54L,52L,53L,31L,29L,28L,30L,27L,26L,24L,25L,19L,17L,16L,18L,23L,22L,20L,21L,191L,189L,188L,190L,180L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163486Inst : IEnumerable<long>
{
public static readonly long[] Value=A163486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163486.Bytes);
public long this[int i]=>Value[i];

public static A163486Inst Instance=new A163486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163487
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,23L,31L,37L,43L,103L,127L,131L,151L,163L,167L,229L,241L,257L,293L,311L,313L,337L,389L,433L,509L,521L,523L,613L,647L,661L,719L,739L,743L,757L,797L,821L,887L,937L,953L,971L,1013L,1033L,1063L,1151L,1153L,1217L,1283L,1303L,1307L,1319L,1373L,1451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163487Inst : IEnumerable<long>
{
public static readonly long[] Value=A163487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163487.Bytes);
public long this[int i]=>Value[i];

public static A163487Inst Instance=new A163487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163488
{
public static readonly long[] Value={ 2L,3L,47L,79L,113L,197L,227L,257L,263L,317L,347L,383L,431L,443L,491L,499L,541L,557L,617L,757L,811L,887L,929L,977L,1021L,1087L,1093L,1129L,1231L,1237L,1433L,1511L,2111L,2129L,2213L,2347L,2543L,2551L,2609L,2657L,2671L,2803L,2837L,2999L,3011L,3049L,3119L,3187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163488Inst : IEnumerable<long>
{
public static readonly long[] Value=A163488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163488.Bytes);
public long this[int i]=>Value[i];

public static A163488Inst Instance=new A163488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163489
{
public static readonly long[] Value={ 2L,4L,8L,12L,21L,26L,35L,40L,49L,63L,68L,81L,92L,97L,106L,121L,136L,140L,154L,165L,171L,185L,195L,210L,229L,240L,245L,254L,260L,270L,305L,315L,330L,336L,360L,365L,379L,395L,405L,421L,437L,442L,467L,472L,483L,488L,517L,547L,557L,562L,573L,589L,594L,619L,634L,650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163489Inst : IEnumerable<long>
{
public static readonly long[] Value=A163489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163489.Bytes);
public long this[int i]=>Value[i];

public static A163489Inst Instance=new A163489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163490
{
public static readonly long[] Value={ 1L,157L,221L,626L,894L,1488L,1489L,3020L,1912L,1938L,3685L,3659L,4982L,4369L,5279L,13127L,4882L,5305L,8042L,16116L,16620L,18884L,23604L,22514L,22542L,29094L,31353L,27660L,41388L,38883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163490Inst : IEnumerable<long>
{
public static readonly long[] Value=A163490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163490.Bytes);
public long this[int i]=>Value[i];

public static A163490Inst Instance=new A163490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163491
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,5L,2L,4L,6L,3L,1L,7L,5L,2L,8L,4L,6L,9L,3L,1L,10L,7L,5L,11L,2L,8L,12L,4L,6L,13L,9L,3L,14L,1L,10L,15L,7L,5L,16L,11L,2L,17L,8L,12L,18L,4L,6L,19L,13L,9L,20L,3L,14L,21L,1L,10L,22L,15L,7L,23L,5L,16L,24L,11L,2L,25L,17L,8L,26L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163491Inst : IEnumerable<long>
{
public static readonly long[] Value=A163491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163491.Bytes);
public long this[int i]=>Value[i];

public static A163491Inst Instance=new A163491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163492
{
public static readonly long[] Value={ 1L,2L,3L,8L,10L,24L,48L,80L,82L,168L,224L,226L,360L,440L,442L,728L,840L,1088L,1090L,1224L,1368L,1522L,1848L,2026L,2208L,2400L,3024L,3250L,3720L,3968L,4760L,5040L,5624L,5928L,6562L,7920L,8648L,9802L,10608L,11026L,11448L,12322L,13688L,13690L,14160L,14640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163492Inst : IEnumerable<long>
{
public static readonly long[] Value=A163492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163492.Bytes);
public long this[int i]=>Value[i];

public static A163492Inst Instance=new A163492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163493
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,9L,15L,30L,54L,97L,189L,360L,675L,1304L,2522L,4835L,9358L,18193L,35269L,68568L,133737L,260802L,509132L,995801L,1948931L,3816904L,7483636L,14683721L,28827798L,56637969L,111347879L,219019294L,431043814L,848764585L,1672056525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163493Inst : IEnumerable<long>
{
public static readonly long[] Value=A163493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163493.Bytes);
public long this[int i]=>Value[i];

public static A163493Inst Instance=new A163493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163494
{
public static readonly BigInteger[] Value={ 1L,96L,23224320L,248314429440000L,BigInteger.Parse("34014229735617331200000"),BigInteger.Parse("32036914532626424502681600000000"),BigInteger.Parse("142357252766974714824047503972761600000000") };
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
public class A163494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163494Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163494.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163494Inst Instance=new A163494Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163495
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,-1L,-2L,-1L,1L,3L,4L,3L,0L,-3L,-3L,0L,3L,6L,6L,3L,-3L,-6L,-3L,3L,9L,12L,9L,0L,-9L,-9L,0L,9L,18L,18L,9L,-9L,-18L,-9L,9L,27L,36L,27L,0L,-27L,-27L,0L,27L,54L,54L,27L,-27L,-54L,-27L,27L,81L,108L,81L,0L,-81L,-81L,0L,81L,162L,162L,81L,-81L,-162L,-81L,81L,243L,324L,243L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163495Inst : IEnumerable<long>
{
public static readonly long[] Value=A163495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163495.Bytes);
public long this[int i]=>Value[i];

public static A163495Inst Instance=new A163495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163496
{
public static readonly long[] Value={ 1L,1L,2L,0L,3L,0L,2L,0L,1L,0L,3L,0L,4L,0L,2L,0L,1L,0L,3L,0L,4L,0L,4L,0L,0L,0L,2L,0L,4L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,5L,0L,5L,0L,3L,0L,4L,0L,3L,0L,3L,0L,4L,0L,4L,0L,1L,0L,4L,0L,5L,0L,1L,0L,2L,0L,2L,0L,4L,0L,2L,0L,3L,0L,3L,0L,4L,0L,3L,0L,3L,0L,6L,0L,5L,0L,6L,0L,3L,0L,7L,0L,5L,0L,4L,0L,1L,0L,4L,0L,4L,0L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163496Inst : IEnumerable<long>
{
public static readonly long[] Value=A163496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163496.Bytes);
public long this[int i]=>Value[i];

public static A163496Inst Instance=new A163496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163497
{
public static readonly long[] Value={ 2L,25L,28L,119L,126L,340L,345L,728L,731L,1329L,1346L,2188L,2200L,3374L,3382L,4911L,4916L,6858L,6861L,9259L,9269L,12165L,12182L,15622L,15627L,19682L,19685L,24384L,24390L,29790L,29797L,35935L,35944L,42869L,42887L,50652L,50662L,59300L,59326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163497Inst : IEnumerable<long>
{
public static readonly long[] Value=A163497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163497.Bytes);
public long this[int i]=>Value[i];

public static A163497Inst Instance=new A163497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163498
{
public static readonly long[] Value={ 2L,3L,11L,13L,23L,37L,43L,59L,79L,89L,103L,109L,113L,139L,149L,181L,193L,197L,227L,239L,263L,269L,281L,283L,307L,401L,433L,443L,449L,457L,463L,503L,523L,547L,587L,617L,653L,673L,691L,811L,821L,823L,829L,839L,877L,887L,911L,937L,967L,1021L,1049L,1061L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163498Inst : IEnumerable<long>
{
public static readonly long[] Value=A163498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163498.Bytes);
public long this[int i]=>Value[i];

public static A163498Inst Instance=new A163498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163499
{
public static readonly long[] Value={ 2L,5L,37L,41L,149L,137L,293L,677L,1109L,593L,1301L,1321L,673L,1061L,1097L,2377L,641L,1289L,2693L,10837L,2069L,2089L,2129L,4261L,4421L,2593L,5281L,21157L,2689L,5393L,21589L,43669L,4133L,4229L,8741L,8849L,9257L,4673L,18757L,20773L,20809L,41621L,41641L,21013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163499Inst : IEnumerable<long>
{
public static readonly long[] Value=A163499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163499.Bytes);
public long this[int i]=>Value[i];

public static A163499Inst Instance=new A163499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163500
{
public static readonly long[] Value={ 199981L,28263827L,371599983L,499999984L,10000000000L,9500000000L,9465000000L,9465000000L,10000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163500Inst : IEnumerable<long>
{
public static readonly long[] Value=A163500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163500.Bytes);
public long this[int i]=>Value[i];

public static A163500Inst Instance=new A163500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163501
{
public static readonly long[] Value={ 2L,1L,4L,3L,6L,5L,8L,7L,10L,9L,12L,30L,14L,20L,16L,22L,18L,23L,21L,31L,33L,34L,40L,25L,36L,27L,35L,29L,37L,41L,42L,38L,44L,50L,46L,45L,48L,47L,43L,51L,52L,53L,55L,56L,60L,57L,58L,59L,54L,61L,62L,63L,64L,66L,67L,70L,68L,69L,71L,72L,73L,74L,75L,77L,76L,78L,80L,79L,81L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163501Inst : IEnumerable<long>
{
public static readonly long[] Value=A163501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163501.Bytes);
public long this[int i]=>Value[i];

public static A163501Inst Instance=new A163501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163502
{
public static readonly long[] Value={ 2L,4L,6L,8L,50L,24L,70L,80L,18L,190L,209L,48L,247L,266L,195L,448L,476L,198L,874L,3980L,399L,2398L,1679L,888L,4975L,1898L,999L,7588L,4988L,39990L,8959L,17888L,42999L,28798L,57995L,29988L,37999L,59888L,49998L,699880L,177899L,88998L,99889L,479996L,499995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163502Inst : IEnumerable<long>
{
public static readonly long[] Value=A163502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163502.Bytes);
public long this[int i]=>Value[i];

public static A163502Inst Instance=new A163502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163503
{
public static readonly BigInteger[] Value={ 1L,21L,420L,8400L,168000L,3359790L,67191600L,1343748210L,26873288400L,537432252000L,10747974763890L,214946090593500L,4298653734898110L,85967713492846500L,1719247052441058000L,BigInteger.Parse("34382796834223386990") };
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
public class A163503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163503Inst Instance=new A163503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163504
{
public static readonly long[] Value={ 1L,6L,10L,14L,14L,14L,16L,16L,16L,16L,18L,14L,14L,14L,16L,12L,10L,14L,10L,10L,12L,8L,8L,4L,2L,2L,2L,4L,6L,4L,8L,10L,14L,14L,20L,18L,22L,22L,24L,28L,32L,28L,36L,34L,36L,34L,42L,52L,52L,52L,50L,54L,54L,62L,62L,62L,66L,66L,70L,72L,70L,78L,90L,92L,92L,92L,100L,102L,110L,106L,108L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163504Inst : IEnumerable<long>
{
public static readonly long[] Value=A163504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163504.Bytes);
public long this[int i]=>Value[i];

public static A163504Inst Instance=new A163504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163505
{
public static readonly long[] Value={ 0L,0L,0L,0L,7L,5L,7L,5L,5L,7L,7L,5L,5L,3L,5L,3L,3L,5L,3L,3L,3L,1L,1L,46L,46L,48L,52L,1L,1L,58L,58L,58L,58L,58L,60L,62L,62L,66L,66L,66L,66L,70L,70L,72L,72L,74L,76L,76L,78L,78L,82L,82L,82L,82L,86L,90L,90L,90L,90L,90L,92L,92L,92L,92L,92L,94L,98L,100L,100L,104L,104L,104L,104L,106L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163505Inst : IEnumerable<long>
{
public static readonly long[] Value=A163505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163505.Bytes);
public long this[int i]=>Value[i];

public static A163505Inst Instance=new A163505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163506
{
public static readonly long[] Value={ 1L,27L,75L,147L,225L,297L,429L,525L,663L,855L,1029L,1173L,1375L,1539L,1827L,2015L,2277L,2625L,2849L,3159L,3485L,3741L,4095L,4371L,4655L,5049L,5565L,6105L,6555L,6903L,7259L,7623L,7995L,8375L,8901L,9443L,9855L,10575L,11011L,11455L,11907L,12699L,13175L,13833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163506Inst : IEnumerable<long>
{
public static readonly long[] Value=A163506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163506.Bytes);
public long this[int i]=>Value[i];

public static A163506Inst Instance=new A163506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163507
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,1L,4L,3L,5L,2L,6L,4L,6L,1L,7L,4L,8L,3L,8L,5L,9L,2L,9L,6L,8L,4L,10L,6L,11L,1L,10L,7L,12L,4L,12L,8L,12L,3L,13L,8L,14L,5L,12L,9L,15L,2L,16L,9L,14L,6L,16L,8L,15L,4L,16L,10L,17L,6L,18L,11L,16L,1L,18L,10L,19L,7L,18L,12L,20L,4L,21L,12L,18L,8L,20L,12L,22L,3L,16L,13L,23L,8L,21L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163507Inst : IEnumerable<long>
{
public static readonly long[] Value=A163507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163507.Bytes);
public long this[int i]=>Value[i];

public static A163507Inst Instance=new A163507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163508
{
public static readonly long[] Value={ 5L,6L,7L,8L,9L,10L,10L,12L,17L,12L,21L,18L,14L,13L,14L,15L,14L,14L,28L,14L,25L,14L,47L,36L,19L,24L,17L,15L,42L,16L,48L,71L,30L,16L,17L,22L,17L,21L,26L,21L,17L,38L,17L,23L,21L,48L,40L,18L,28L,23L,65L,18L,48L,131L,24L,30L,18L,141L,39L,54L,18L,19L,108L,24L,20L,18L,171L,29L,38L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163508Inst : IEnumerable<long>
{
public static readonly long[] Value=A163508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163508.Bytes);
public long this[int i]=>Value[i];

public static A163508Inst Instance=new A163508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163509
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,1L,8L,9L,10L,11L,4L,5L,2L,1L,16L,17L,18L,19L,20L,21L,22L,23L,8L,9L,10L,11L,4L,5L,2L,1L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,16L,17L,18L,19L,20L,21L,22L,23L,8L,9L,10L,11L,4L,5L,2L,1L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163509Inst : IEnumerable<long>
{
public static readonly long[] Value=A163509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163509.Bytes);
public long this[int i]=>Value[i];

public static A163509Inst Instance=new A163509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163510
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,3L,0L,2L,1L,1L,0L,0L,1L,2L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,4L,0L,3L,1L,2L,0L,0L,2L,2L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,3L,0L,0L,2L,0L,1L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,4L,1L,3L,0L,0L,3L,2L,2L,0L,1L,2L,1L,0L,2L,0L,0L,0L,2L,3L,1L,0L,2L,1L,1L,1L,1L,0L,0L,1L,1L,2L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163510Inst : IEnumerable<long>
{
public static readonly long[] Value=A163510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163510.Bytes);
public long this[int i]=>Value[i];

public static A163510Inst Instance=new A163510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163511
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,6L,5L,16L,27L,18L,25L,12L,15L,10L,7L,32L,81L,54L,125L,36L,75L,50L,49L,24L,45L,30L,35L,20L,21L,14L,11L,64L,243L,162L,625L,108L,375L,250L,343L,72L,225L,150L,245L,100L,147L,98L,121L,48L,135L,90L,175L,60L,105L,70L,77L,40L,63L,42L,55L,28L,33L,22L,13L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163511Inst : IEnumerable<long>
{
public static readonly long[] Value=A163511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163511.Bytes);
public long this[int i]=>Value[i];

public static A163511Inst Instance=new A163511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163512
{
public static readonly long[] Value={ 23L,337L,2293L,3557L,9941L,21347L,39233L,87403L,251221L,333367L,895253L,1080647L,1217473L,1696207L,2076563L,2626933L,2999707L,4493837L,6203297L,6857033L,8045953L,8299127L,8821297L,11442817L,13807361L,14538187L,17298497L,21333467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163512Inst : IEnumerable<long>
{
public static readonly long[] Value=A163512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163512.Bytes);
public long this[int i]=>Value[i];

public static A163512Inst Instance=new A163512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163513
{
public static readonly long[] Value={ 2293L,9941L,895253L,2626933L,17298497L,33084437L,47685397L,62056661L,76782337L,144599617L,189907873L,211280213L,258717493L,301410677L,479690273L,630940097L,717228821L,778918037L,1035249013L,1814163413L,1889439157L,2710909781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163513Inst : IEnumerable<long>
{
public static readonly long[] Value=A163513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163513.Bytes);
public long this[int i]=>Value[i];

public static A163513Inst Instance=new A163513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163514
{
public static readonly BigInteger[] Value={ 1L,22L,462L,9702L,203742L,4278351L,89840520L,1886549280L,39615400440L,831878586000L,17468509071090L,366818925627000L,7702782398341800L,161749714998425400L,3396561002126245800L,BigInteger.Parse("71323937982067871100") };
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
public class A163514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163514Inst Instance=new A163514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163515
{
public static readonly long[] Value={ 2L,3L,3L,4L,4L,4L,5L,5L,4L,5L,5L,6L,6L,5L,6L,7L,6L,6L,6L,5L,7L,8L,7L,6L,9L,8L,6L,7L,7L,7L,10L,6L,8L,7L,9L,8L,7L,8L,7L,10L,11L,7L,12L,8L,6L,9L,8L,9L,11L,8L,7L,13L,8L,10L,9L,9L,7L,8L,14L,8L,10L,15L,12L,8L,8L,10L,11L,13L,16L,11L,7L,9L,9L,8L,10L,9L,9L,17L,8L,9L,14L,8L,11L,12L,12L,10L,18L,11L,8L,10L,19L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163515Inst : IEnumerable<long>
{
public static readonly long[] Value=A163515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163515.Bytes);
public long this[int i]=>Value[i];

public static A163515Inst Instance=new A163515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163516
{
public static readonly long[] Value={ 0L,2L,5L,8L,11L,14L,18L,22L,26L,30L,35L,40L,45L,50L,56L,61L,67L,74L,80L,87L,94L,101L,108L,116L,123L,131L,140L,148L,157L,165L,175L,184L,193L,203L,213L,223L,233L,243L,254L,265L,276L,287L,299L,310L,322L,334L,346L,359L,371L,384L,397L,410L,424L,437L,451L,465L,479L,493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163516Inst : IEnumerable<long>
{
public static readonly long[] Value=A163516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163516.Bytes);
public long this[int i]=>Value[i];

public static A163516Inst Instance=new A163516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163517
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,10L,11L,14L,16L,20L,21L,23L,28L,29L,30L,34L,37L,39L,41L,42L,49L,51L,52L,57L,67L,68L,70L,71L,78L,83L,88L,91L,93L,96L,106L,108L,110L,115L,116L,120L,123L,130L,133L,136L,139L,145L,150L,157L,160L,162L,166L,167L,171L,173L,177L,179L,180L,181L,182L,184L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163517Inst : IEnumerable<long>
{
public static readonly long[] Value=A163517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163517.Bytes);
public long this[int i]=>Value[i];

public static A163517Inst Instance=new A163517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163518
{
public static readonly BigInteger[] Value={ 1L,23L,506L,11132L,244904L,5387635L,118522404L,2607370689L,57359466780L,1261849124844L,27759379635372L,610677728876061L,13434280356535038L,295540315560771435L,6501582206394337062L,BigInteger.Parse("143028104664155140584") };
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
public class A163518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163518Inst Instance=new A163518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163519
{
public static readonly BigInteger[] Value={ 1L,24L,552L,12696L,292008L,6715908L,154459536L,3552423600L,81702391056L,1879077904176L,43217018799372L,993950655137880L,22859927229943848L,525756756894338904L,12091909332851083560UL,BigInteger.Parse("278102505382114851108") };
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
public class A163519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163519Inst Instance=new A163519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163520
{
public static readonly long[] Value={ 4L,6L,8L,9L,12L,12L,16L,15L,16L,18L,24L,20L,28L,24L,24L,25L,36L,28L,40L,30L,32L,36L,48L,35L,36L,42L,40L,40L,60L,42L,64L,45L,48L,54L,48L,49L,76L,60L,56L,54L,84L,56L,88L,60L,60L,72L,96L,63L,64L,66L,72L,70L,108L,70L,72L,72L,80L,90L,120L,77L,124L,96L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163520Inst : IEnumerable<long>
{
public static readonly long[] Value=A163520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163520.Bytes);
public long this[int i]=>Value[i];

public static A163520Inst Instance=new A163520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163521
{
public static readonly long[] Value={ 30L,1255L,78698L,5762750L,455059956L,37607986470L,3204942375900L,279238346962895L,24739954333817884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163521Inst : IEnumerable<long>
{
public static readonly long[] Value=A163521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163521.Bytes);
public long this[int i]=>Value[i];

public static A163521Inst Instance=new A163521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163522
{
public static readonly long[] Value={ 2L,4L,7L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163522Inst : IEnumerable<long>
{
public static readonly long[] Value=A163522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163522.Bytes);
public long this[int i]=>Value[i];

public static A163522Inst Instance=new A163522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163523
{
public static readonly long[] Value={ 1L,3L,3L,4L,3L,6L,3L,5L,4L,6L,3L,8L,3L,6L,6L,6L,3L,8L,3L,8L,6L,6L,3L,10L,4L,6L,5L,8L,3L,11L,3L,7L,6L,6L,6L,11L,3L,6L,6L,10L,3L,11L,3L,8L,8L,6L,3L,12L,4L,8L,6L,8L,3L,10L,6L,10L,6L,6L,3L,15L,3L,6L,8L,8L,6L,11L,3L,8L,6L,11L,3L,14L,3L,6L,8L,8L,6L,11L,3L,12L,6L,6L,3L,15L,6L,6L,6L,10L,3L,15L,6L,8L,6L,6L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163523Inst : IEnumerable<long>
{
public static readonly long[] Value=A163523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163523.Bytes);
public long this[int i]=>Value[i];

public static A163523Inst Instance=new A163523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163524
{
public static readonly long[] Value={ 5L,4L,11L,5L,71L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163524Inst : IEnumerable<long>
{
public static readonly long[] Value=A163524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163524.Bytes);
public long this[int i]=>Value[i];

public static A163524Inst Instance=new A163524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163525
{
public static readonly BigInteger[] Value={ 1L,25L,600L,14400L,345600L,8294100L,199051200L,4777056300L,114645211200L,2751385708800L,66030872460900L,1584683711924400L,38031035684483100L,912711895976984400L,BigInteger.Parse("21904294481198985600"),BigInteger.Parse("525684083700365474100") };
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
public class A163525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163525Inst Instance=new A163525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163526
{
public static readonly BigInteger[] Value={ 1L,26L,650L,16250L,406250L,10155925L,253890000L,6347047200L,158671110000L,3966651000000L,99163106355300L,2478998445300000L,61972980856207200L,1549275016079700000L,BigInteger.Parse("38730637808401500000"),BigInteger.Parse("968235006358878382800") };
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
public class A163526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163526Inst Instance=new A163526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163527
{
public static readonly BigInteger[] Value={ 1L,27L,702L,18252L,474552L,12338001L,320778900L,8340014475L,216834216300L,5637529462500L,146571601954050L,3810753388040625L,99076773337132500L,2575922925294444375L,BigInteger.Parse("66972093393463976250"),BigInteger.Parse("1741224960366454777500") };
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
public class A163527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163527Inst Instance=new A163527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163528
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,0L,1L,2L,3L,4L,5L,5L,4L,3L,3L,4L,5L,6L,7L,8L,8L,7L,6L,6L,7L,8L,8L,7L,6L,6L,7L,8L,8L,7L,6L,5L,4L,3L,3L,4L,5L,5L,4L,3L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,3L,4L,5L,5L,4L,3L,3L,4L,5L,6L,7L,8L,8L,7L,6L,6L,7L,8L,9L,10L,11L,11L,10L,9L,9L,10L,11L,12L,13L,14L,14L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163528Inst : IEnumerable<long>
{
public static readonly long[] Value=A163528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163528.Bytes);
public long this[int i]=>Value[i];

public static A163528Inst Instance=new A163528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163529
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,5L,4L,4L,4L,3L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,8L,7L,7L,7L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,8L,7L,7L,7L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163529Inst : IEnumerable<long>
{
public static readonly long[] Value=A163529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163529.Bytes);
public long this[int i]=>Value[i];

public static A163529Inst Instance=new A163529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163530
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,4L,5L,6L,7L,8L,9L,8L,7L,8L,9L,10L,11L,10L,9L,10L,11L,12L,13L,12L,11L,10L,9L,8L,7L,8L,9L,8L,7L,6L,5L,4L,3L,4L,5L,6L,7L,6L,5L,6L,7L,8L,9L,8L,7L,8L,9L,10L,11L,12L,13L,12L,11L,10L,9L,10L,11L,12L,13L,14L,15L,14L,13L,14L,15L,16L,17L,18L,19L,18L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163530Inst : IEnumerable<long>
{
public static readonly long[] Value=A163530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163530.Bytes);
public long this[int i]=>Value[i];

public static A163530Inst Instance=new A163530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163531
{
public static readonly long[] Value={ 0L,1L,4L,5L,2L,1L,4L,5L,8L,13L,20L,29L,26L,17L,10L,9L,16L,25L,36L,49L,64L,65L,50L,37L,40L,53L,68L,73L,58L,45L,52L,65L,80L,89L,74L,61L,50L,41L,34L,25L,32L,41L,34L,25L,18L,13L,10L,9L,16L,17L,20L,29L,26L,25L,36L,37L,40L,53L,50L,49L,64L,65L,68L,73L,80L,89L,74L,65L,58L,45L,52L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163531Inst : IEnumerable<long>
{
public static readonly long[] Value=A163531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163531.Bytes);
public long this[int i]=>Value[i];

public static A163531Inst Instance=new A163531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163532
{
public static readonly long[] Value={ 0L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163532Inst : IEnumerable<long>
{
public static readonly long[] Value=A163532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163532.Bytes);
public long this[int i]=>Value[i];

public static A163532Inst Instance=new A163532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163533
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163533Inst : IEnumerable<long>
{
public static readonly long[] Value=A163533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163533.Bytes);
public long this[int i]=>Value[i];

public static A163533Inst Instance=new A163533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163534
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,3L,2L,2L,3L,0L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,2L,2L,2L,3L,0L,0L,3L,2L,2L,2L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,3L,2L,2L,3L,0L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,3L,2L,2L,3L,0L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163534Inst : IEnumerable<long>
{
public static readonly long[] Value=A163534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163534.Bytes);
public long this[int i]=>Value[i];

public static A163534Inst Instance=new A163534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163535
{
public static readonly long[] Value={ 1L,1L,0L,3L,3L,0L,1L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,1L,1L,0L,3L,3L,0L,1L,1L,0L,3L,3L,0L,1L,1L,0L,3L,3L,3L,3L,3L,2L,1L,1L,2L,3L,3L,3L,3L,3L,0L,1L,1L,0L,3L,3L,0L,1L,1L,0L,3L,3L,0L,1L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,1L,1L,0L,3L,3L,0L,1L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,1L,1L,0L,3L,3L,0L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163535Inst : IEnumerable<long>
{
public static readonly long[] Value=A163535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163535.Bytes);
public long this[int i]=>Value[i];

public static A163535Inst Instance=new A163535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163536
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163536Inst : IEnumerable<long>
{
public static readonly long[] Value=A163536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163536.Bytes);
public long this[int i]=>Value[i];

public static A163536Inst Instance=new A163536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163537
{
public static readonly long[] Value={ 0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163537Inst : IEnumerable<long>
{
public static readonly long[] Value=A163537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163537.Bytes);
public long this[int i]=>Value[i];

public static A163537Inst Instance=new A163537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163538
{
public static readonly long[] Value={ 0L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,0L,-1L,-1L,0L,1L,0L,0L,-1L,0L,-1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163538Inst : IEnumerable<long>
{
public static readonly long[] Value=A163538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163538.Bytes);
public long this[int i]=>Value[i];

public static A163538Inst Instance=new A163538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163539
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,1L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,-1L,-1L,0L,1L,0L,-1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163539Inst : IEnumerable<long>
{
public static readonly long[] Value=A163539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163539.Bytes);
public long this[int i]=>Value[i];

public static A163539Inst Instance=new A163539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163540
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,0L,1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,1L,1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,2L,2L,3L,0L,3L,3L,2L,1L,2L,3L,2L,1L,1L,0L,1L,2L,1L,1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,1L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,0L,0L,1L,2L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163540Inst : IEnumerable<long>
{
public static readonly long[] Value=A163540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163540.Bytes);
public long this[int i]=>Value[i];

public static A163540Inst Instance=new A163540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163541
{
public static readonly long[] Value={ 1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,1L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,0L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,3L,3L,2L,1L,2L,2L,3L,0L,3L,2L,3L,0L,0L,1L,0L,3L,0L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,0L,1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,1L,1L,0L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163541Inst : IEnumerable<long>
{
public static readonly long[] Value=A163541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163541.Bytes);
public long this[int i]=>Value[i];

public static A163541Inst Instance=new A163541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163542
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,0L,1L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,0L,0L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,0L,0L,1L,1L,2L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163542Inst : IEnumerable<long>
{
public static readonly long[] Value=A163542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163542.Bytes);
public long this[int i]=>Value[i];

public static A163542Inst Instance=new A163542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163543
{
public static readonly long[] Value={ 2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,0L,0L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,0L,1L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,0L,0L,2L,2L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163543Inst : IEnumerable<long>
{
public static readonly long[] Value=A163543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163543.Bytes);
public long this[int i]=>Value[i];

public static A163543Inst Instance=new A163543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163544
{
public static readonly long[] Value={ 0L,1L,4L,2L,11L,6L,3L,7L,12L,17L,24L,18L,13L,8L,5L,9L,58L,48L,38L,47L,37L,28L,21L,29L,22L,16L,10L,15L,39L,30L,23L,31L,40L,49L,60L,50L,83L,70L,59L,71L,84L,97L,112L,98L,85L,72L,61L,73L,62L,52L,42L,51L,41L,32L,25L,33L,26L,20L,14L,19L,43L,34L,27L,35L,260L,238L,216L,237L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163544Inst : IEnumerable<long>
{
public static readonly long[] Value=A163544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163544.Bytes);
public long this[int i]=>Value[i];

public static A163544Inst Instance=new A163544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163545
{
public static readonly long[] Value={ 0L,3L,1L,14L,2L,6L,15L,13L,7L,5L,58L,12L,8L,4L,26L,57L,59L,11L,9L,25L,27L,62L,56L,54L,10L,30L,24L,22L,63L,61L,55L,53L,31L,29L,23L,21L,234L,60L,50L,52L,32L,28L,18L,20L,106L,233L,235L,49L,51L,35L,33L,17L,19L,105L,107L,228L,232L,236L,48L,46L,34L,38L,16L,100L,104L,108L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163545Inst : IEnumerable<long>
{
public static readonly long[] Value=A163545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163545.Bytes);
public long this[int i]=>Value[i];

public static A163545Inst Instance=new A163545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163546
{
public static readonly long[] Value={ 0L,2L,4L,1L,13L,9L,5L,8L,12L,18L,24L,17L,11L,7L,3L,6L,62L,51L,42L,52L,43L,35L,27L,34L,26L,19L,14L,20L,41L,33L,25L,32L,40L,50L,60L,49L,85L,73L,61L,72L,84L,98L,112L,97L,83L,71L,59L,70L,58L,47L,38L,48L,39L,31L,23L,30L,22L,15L,10L,16L,37L,29L,21L,28L,268L,245L,224L,246L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163546Inst : IEnumerable<long>
{
public static readonly long[] Value=A163546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163546.Bytes);
public long this[int i]=>Value[i];

public static A163546Inst Instance=new A163546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163547
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,9L,10L,5L,8L,13L,18L,13L,10L,5L,4L,9L,16L,17L,26L,25L,36L,49L,50L,37L,40L,53L,58L,45L,34L,29L,20L,25L,32L,41L,50L,41L,52L,65L,74L,61L,72L,85L,98L,85L,74L,61L,52L,65L,58L,53L,40L,45L,34L,25L,20L,29L,26L,17L,16L,25L,36L,37L,50L,49L,64L,81L,82L,65L,68L,73L,90L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163547Inst : IEnumerable<long>
{
public static readonly long[] Value=A163547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163547.Bytes);
public long this[int i]=>Value[i];

public static A163547Inst Instance=new A163547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163548
{
public static readonly BigInteger[] Value={ 1L,28L,756L,20412L,551124L,14879970L,401748984L,10846947384L,292860149400L,7907023424664L,213484216161762L,5763927599870076L,155622096911221668L,4201690015605193020L,BigInteger.Parse("113442752267421552612"),BigInteger.Parse("3062876603036110993314") };
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
public class A163548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163548.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163548Inst Instance=new A163548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163549
{
public static readonly BigInteger[] Value={ 1L,29L,812L,22736L,636608L,17824618L,499077936L,13973864310L,391259299536L,10955011154976L,306733334006862L,8588337963333660L,240467992209756738L,6732950603977585764L,BigInteger.Parse("188518328027869860720"),BigInteger.Parse("5278393098774299901978") };
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
public class A163549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163549Inst Instance=new A163549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163550
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,71L,58L,831L,69L,859L,9571L,99401L,138901L,378742L,440716L,953859L,7133771L,6438258L,88852541L,75424201L,517071L,318397461L,337833493L,520847656L,168707711L,688837201L,8652938731L,3463840159L,19061650821L,11792487113L,39087971343L,77290124996L,254385071821L,61861367073L,98365635393L,782470216414L,88812796249L,650846846969L,2369589212251L,9645588429013L,33288442066621L,58870791630354L,889521228408101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163550Inst : IEnumerable<long>
{
public static readonly long[] Value=A163550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163550.Bytes);
public long this[int i]=>Value[i];

public static A163550Inst Instance=new A163550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163551
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,13L,25L,49L,97L,193L,385L,769L,1537L,3073L,6145L,12289L,24577L,49153L,98305L,196597L,393169L,786289L,1572481L,3144769L,6289153L,12577537L,25153537L,50304001L,100601857L,201191425L,402358273L,804667393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163551Inst : IEnumerable<long>
{
public static readonly long[] Value=A163551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163551.Bytes);
public long this[int i]=>Value[i];

public static A163551Inst Instance=new A163551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163552
{
public static readonly BigInteger[] Value={ 1L,30L,870L,25230L,731670L,21217995L,615309240L,17843602560L,517453877640L,15005855150160L,435160887802830L,12619407316577880L,365955317872798920L,10612486887830912280UL,BigInteger.Parse("307755817292235608520"),BigInteger.Parse("8924735934026717183820") };
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
public class A163552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163552Inst Instance=new A163552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163553
{
public static readonly long[] Value={ 0L,2L,1L,6L,0L,11L,1L,11L,5L,17L,-4L,27L,4L,15L,9L,30L,-3L,38L,-2L,31L,18L,35L,-12L,54L,15L,29L,12L,55L,-12L,71L,1L,48L,28L,41L,-7L,90L,16L,43L,6L,89L,-12L,95L,4L,51L,52L,71L,-28L,116L,14L,72L,26L,97L,-12L,103L,8L,97L,48L,89L,-48L,167L,28L,55L,41L,108L,6L,143L,10L,99L,22L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163553Inst : IEnumerable<long>
{
public static readonly long[] Value=A163553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163553.Bytes);
public long this[int i]=>Value[i];

public static A163553Inst Instance=new A163553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163554
{
public static readonly long[] Value={ 104L,106L,110L,118L,119L,124L,125L,128L,133L,140L,142L,146L,152L,160L,164L,169L,172L,182L,190L,196L,214L,215L,217L,218L,238L,305L,319L,328L,329L,346L,350L,356L,364L,365L,368L,374L,376L,382L,386L,391L,392L,394L,410L,412L,416L,436L,437L,473L,475L,476L,493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163554Inst : IEnumerable<long>
{
public static readonly long[] Value=A163554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163554.Bytes);
public long this[int i]=>Value[i];

public static A163554Inst Instance=new A163554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163555
{
public static readonly long[] Value={ 130L,136L,175L,176L,301L,310L,316L,361L,370L,371L,395L,398L,517L,539L,671L,703L,713L,715L,716L,730L,731L,893L,935L,938L,1004L,1025L,1027L,1034L,1040L,1043L,1052L,1058L,1072L,1085L,1118L,1124L,1142L,1147L,1169L,1174L,1189L,1196L,1198L,1205L,1207L,1214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163555Inst : IEnumerable<long>
{
public static readonly long[] Value=A163555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163555.Bytes);
public long this[int i]=>Value[i];

public static A163555Inst Instance=new A163555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163556
{
public static readonly long[] Value={ 170L,194L,710L,790L,791L,793L,914L,917L,970L,973L,1003L,1012L,1015L,1016L,1024L,1028L,1030L,1042L,1082L,1090L,1102L,1105L,1106L,1120L,1126L,1135L,1138L,1150L,1157L,1159L,1160L,1162L,1175L,1178L,1183L,1195L,1204L,1208L,1210L,1216L,1234L,1240L,1243L,1258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163556Inst : IEnumerable<long>
{
public static readonly long[] Value=A163556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163556.Bytes);
public long this[int i]=>Value[i];

public static A163556Inst Instance=new A163556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163557
{
public static readonly long[] Value={ 1007L,1018L,1057L,1067L,1070L,1075L,1076L,1081L,1108L,1127L,1172L,1180L,1271L,1298L,1330L,1336L,1337L,1339L,1363L,1369L,1393L,1396L,1468L,1486L,1507L,1570L,1576L,1633L,1639L,1648L,1670L,1675L,1684L,1696L,1700L,1705L,1706L,1712L,1750L,1756L,1760L,1765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163557Inst : IEnumerable<long>
{
public static readonly long[] Value=A163557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163557.Bytes);
public long this[int i]=>Value[i];

public static A163557Inst Instance=new A163557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163558
{
public static readonly long[] Value={ 1036L,1096L,1099L,1136L,1235L,1238L,1253L,1267L,1276L,1294L,1306L,1316L,1325L,1328L,1352L,1358L,1360L,1378L,1382L,1385L,1387L,1492L,1532L,1538L,1603L,1630L,1631L,1672L,1678L,1687L,1690L,1726L,1738L,1762L,1768L,1786L,1832L,1835L,1837L,1853L,1876L,1906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163558Inst : IEnumerable<long>
{
public static readonly long[] Value=A163558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163558.Bytes);
public long this[int i]=>Value[i];

public static A163558Inst Instance=new A163558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163559
{
public static readonly long[] Value={ 1037L,1073L,1190L,1247L,1274L,1345L,1354L,1370L,1379L,1397L,1435L,1472L,1495L,1534L,1594L,1679L,1703L,1724L,1730L,1739L,1742L,1769L,1793L,1796L,1910L,1937L,1945L,1954L,1967L,1976L,2093L,2147L,2174L,2374L,2390L,2471L,2597L,2714L,2734L,2743L,2759L,2795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163559Inst : IEnumerable<long>
{
public static readonly long[] Value=A163559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163559.Bytes);
public long this[int i]=>Value[i];

public static A163559Inst Instance=new A163559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163560
{
public static readonly long[] Value={ 1130L,1132L,1139L,1309L,1310L,1312L,1376L,1390L,1391L,1478L,1673L,1736L,1748L,1763L,1784L,1874L,1903L,1930L,2375L,2537L,2573L,2735L,3076L,3091L,3101L,3110L,3112L,3176L,3190L,3211L,3275L,3572L,3670L,3706L,3716L,3725L,3752L,3760L,3901L,3910L,4178L,4187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163560Inst : IEnumerable<long>
{
public static readonly long[] Value=A163560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163560.Bytes);
public long this[int i]=>Value[i];

public static A163560Inst Instance=new A163560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163561
{
public static readonly long[] Value={ 1094L,1349L,1394L,1457L,1475L,1490L,1547L,1574L,1745L,1754L,1904L,1934L,1940L,1943L,3097L,3149L,3194L,3419L,3479L,3497L,3679L,3749L,3790L,3794L,3796L,3914L,3941L,3970L,3974L,3976L,4109L,4175L,4190L,4193L,4319L,4379L,4571L,4715L,4739L,4901L,4910L,4913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163561Inst : IEnumerable<long>
{
public static readonly long[] Value=A163561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163561.Bytes);
public long this[int i]=>Value[i];

public static A163561Inst Instance=new A163561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163562
{
public static readonly long[] Value={ 1079L,1790L,1795L,1798L,1897L,1957L,1970L,1975L,1978L,5719L,5917L,5971L,7091L,7189L,7190L,7195L,7198L,7519L,7819L,7891L,7910L,7915L,7918L,7981L,8197L,8791L,8917L,9017L,9071L,9107L,9170L,9175L,9178L,9517L,9571L,9701L,9710L,9715L,9718L,9751L,10019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163562Inst : IEnumerable<long>
{
public static readonly long[] Value=A163562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163562.Bytes);
public long this[int i]=>Value[i];

public static A163562Inst Instance=new A163562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163563
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163563Inst : IEnumerable<long>
{
public static readonly long[] Value=A163563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163563.Bytes);
public long this[int i]=>Value[i];

public static A163563Inst Instance=new A163563Inst();

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