using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A254582
{
public static readonly long[] Value={ 72939L,545360L,5909527L,58920922L,548753241L,5184793937L,49094787979L,464109388554L,4388623973352L,41497627764959L,392355045769673L,3709832984584812L,35077649385100542L,331666144126635733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254582Inst : IEnumerable<long>
{
public static readonly long[] Value=A254582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254582.Bytes);
public long this[int i]=>Value[i];

public static A254582Inst Instance=new A254582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254583
{
public static readonly BigInteger[] Value={ 332330L,3083065L,45867931L,613720640L,7610621332L,96984109170L,1242236438386L,15846867693636L,202156220287824L,2580360620297958L,32933420876277090L,420293728693560670L,5363919917385090792L,BigInteger.Parse("68457129482764993312") };
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
public class A254583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254583Inst Instance=new A254583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254584
{
public static readonly BigInteger[] Value={ 1451174L,17163021L,350562134L,6258245316L,103508337281L,1782085332862L,30739517451493L,527044893827218L,9048176667536403L,155422821624332256L,2668811593248926541L,BigInteger.Parse("45827031800397736338"),BigInteger.Parse("786955194179148194283") };
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
public class A254584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254584Inst Instance=new A254584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254585
{
public static readonly BigInteger[] Value={ 6117882L,94299759L,2634910318L,62363902283L,1378994189975L,31939816150372L,738710766470176L,16985478016933272L,391280419966057452L,9016311605803392528L,BigInteger.Parse("207691702762517798308"),BigInteger.Parse("4784457962135643192314") };
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
public class A254585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254585Inst Instance=new A254585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254586
{
public static readonly long[] Value={ 512L,2868L,2868L,15051L,17125L,15051L,72939L,96756L,110259L,72939L,332330L,545360L,774168L,649029L,332330L,1451174L,3083065L,5909527L,5852880L,3699505L,1451174L,6117882L,17163021L,45867931L,58920922L,42278366L,20636376L,6117882L,25078442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254586Inst : IEnumerable<long>
{
public static readonly long[] Value=A254586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254586.Bytes);
public long this[int i]=>Value[i];

public static A254586Inst Instance=new A254586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254587
{
public static readonly long[] Value={ 2868L,17125L,96756L,545360L,3083065L,17163021L,94299759L,513689395L,2784287954L,15033788426L,81007656094L,435782949444L,2342282105203L,12580176218027L,67541357805877L,362492523075197L,1945139209520412L,10435768594838260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254587Inst : IEnumerable<long>
{
public static readonly long[] Value=A254587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254587.Bytes);
public long this[int i]=>Value[i];

public static A254587Inst Instance=new A254587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254588
{
public static readonly long[] Value={ 15051L,110259L,774168L,5909527L,45867931L,350562134L,2634910318L,19541565637L,143564782483L,1047589715034L,7608617383646L,55086288989948L,397977472433545L,2871086236327979L,20692657907915479L,149040876549648731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254588Inst : IEnumerable<long>
{
public static readonly long[] Value=A254588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254588.Bytes);
public long this[int i]=>Value[i];

public static A254588Inst Instance=new A254588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254589
{
public static readonly long[] Value={ 72939L,649029L,5852880L,58920922L,613720640L,6258245316L,62363902283L,612314070327L,5944180964639L,57211015018162L,547453527649167L,5218184143373255L,49605050962203855L,470705828047069026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254589Inst : IEnumerable<long>
{
public static readonly long[] Value=A254589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254589.Bytes);
public long this[int i]=>Value[i];

public static A254589Inst Instance=new A254589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254590
{
public static readonly BigInteger[] Value={ 332330L,3699505L,42278366L,548753241L,7610621332L,103508337281L,1378994189975L,18153660429271L,236606904631381L,3061665198195311L,39430627777720264L,506211331403147283L,6485200850937464295L,BigInteger.Parse("82971100459297212687") };
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
public class A254590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254590Inst Instance=new A254590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254591
{
public static readonly BigInteger[] Value={ 1451174L,20636376L,305579066L,5184793937L,96984109170L,1782085332862L,31939816150372L,565834160597796L,9930766576561764L,172982219136880212L,2998344674413835672L,BigInteger.Parse("51805475835704207966"),BigInteger.Parse("893177057042248828654") };
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
public class A254591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254591Inst Instance=new A254591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254592
{
public static readonly BigInteger[] Value={ 6117882L,113625185L,2204567802L,49094787979L,1242236438386L,30739517451493L,738710766470176L,17573978066643349L,414123911196490073L,9680320709184095679UL,BigInteger.Parse("225164393471054024086"),BigInteger.Parse("5220345026451776105837") };
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
public class A254592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254592Inst Instance=new A254592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254593
{
public static readonly long[] Value={ 6L,3L,2L,3L,6L,13L,30L,75L,200L,555L,1590L,4693L,14202L,43863L,137882L,440235L,1424958L,4668304L,15459366L,51692379L,174362770L,592815459L,2030105382L,6998177293L,24270836436L,84646997613L,296744311172L,1045283877639L,3698462401026L,13140509079977L,46869358523238L,167781751129899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254593Inst : IEnumerable<long>
{
public static readonly long[] Value=A254593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254593.Bytes);
public long this[int i]=>Value[i];

public static A254593Inst Instance=new A254593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254594
{
public static readonly long[] Value={ 1L,0L,2L,1L,4L,2L,7L,4L,11L,7L,16L,11L,23L,16L,31L,23L,41L,31L,53L,41L,67L,53L,83L,67L,102L,83L,123L,102L,147L,123L,174L,147L,204L,174L,237L,204L,274L,237L,314L,274L,358L,314L,406L,358L,458L,406L,514L,458L,575L,514L,640L,575L,710L,640L,785L,710L,865L,785L,950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254594Inst : IEnumerable<long>
{
public static readonly long[] Value=A254594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254594.Bytes);
public long this[int i]=>Value[i];

public static A254594Inst Instance=new A254594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254595
{
public static readonly long[] Value={ 1L,2L,9L,7L,14L,37L,64L,68L,57L,119L,112L,168L,194L,147L,267L,259L,222L,477L,427L,404L,519L,652L,567L,497L,512L,749L,722L,719L,952L,1209L,904L,1139L,1267L,1184L,1069L,1737L,1594L,1667L,1734L,2077L,1799L,1659L,1729L,1814L,1762L,1862L,2577L,2444L,2997L,2072L,2457L,2842L,3029L,3249L,3094L,3589L,3999L,4208L,3479L,3232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254595Inst : IEnumerable<long>
{
public static readonly long[] Value=A254595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254595.Bytes);
public long this[int i]=>Value[i];

public static A254595Inst Instance=new A254595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254596
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,7L,8L,8L,8L,5L,9L,9L,7L,10L,10L,8L,8L,7L,7L,7L,9L,10L,10L,10L,10L,7L,7L,9L,9L,9L,8L,8L,8L,7L,10L,9L,9L,9L,9L,8L,8L,10L,10L,10L,10L,9L,9L,9L,8L,10L,10L,10L,10L,10L,10L,9L,9L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254596Inst : IEnumerable<long>
{
public static readonly long[] Value=A254596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254596.Bytes);
public long this[int i]=>Value[i];

public static A254596Inst Instance=new A254596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254597
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,4L,4L,7L,5L,5L,4L,6L,6L,5L,5L,7L,8L,6L,6L,5L,9L,9L,7L,6L,6L,8L,8L,7L,7L,7L,6L,10L,10L,8L,8L,7L,7L,9L,9L,9L,8L,8L,8L,7L,10L,9L,9L,9L,9L,8L,8L,10L,10L,10L,10L,9L,9L,9L,8L,10L,10L,10L,10L,10L,10L,9L,9L,5L,5L,5L,10L,10L,10L,10L,10L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254597Inst : IEnumerable<long>
{
public static readonly long[] Value=A254597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254597.Bytes);
public long this[int i]=>Value[i];

public static A254597Inst Instance=new A254597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254598
{
public static readonly BigInteger[] Value={ 1L,9L,79L,695L,6113L,53769L,472943L,4159927L,36590017L,321839625L,2830847119L,24899654327L,219013164449L,1926402895881L,16944315318191L,149039342816695L,1310924949760897L,11530674997804041L,101421874630758607L,892089722030697143L,7846670898660887393L,BigInteger.Parse("69017995243501979145") };
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
public class A254598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254598.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254598Inst Instance=new A254598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254599
{
public static readonly BigInteger[] Value={ 1L,10L,98L,962L,9442L,92674L,909602L,8927810L,87627106L,860066434L,8441614754L,82855064258L,813228496354L,7981896981250L,78342900802082L,768941283068738L,7547214754035298L,74076463050867586L,727065885490090658L,7136204673817756610L,BigInteger.Parse("70042369148280534754") };
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
public class A254599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254599Inst Instance=new A254599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254600
{
public static readonly BigInteger[] Value={ 1L,11L,119L,1289L,13961L,151211L,1637759L,17738489L,192124721L,2080893611L,22538058599L,244108628489L,2643928812281L,28636265779211L,310158017102639L,3359306563039289L,36384487784316641L,394078636910520011L,4268246759164049879L,BigInteger.Parse("46229175323835178889") };
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
public class A254600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254600Inst Instance=new A254600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254601
{
public static readonly long[] Value={ 1L,7L,46L,304L,2008L,13264L,87616L,578752L,3822976L,25252864L,166809088L,1101865984L,7278432256L,48078057472L,317582073856L,2097804673024L,13857156333568L,91534156693504L,604633565495296L,3993938019745792L,26382162380455936L,174268726361718784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254601Inst : IEnumerable<long>
{
public static readonly long[] Value=A254601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254601.Bytes);
public long this[int i]=>Value[i];

public static A254601Inst Instance=new A254601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254602
{
public static readonly long[] Value={ 1L,8L,61L,467L,3574L,27353L,209341L,1602152L,12261769L,93843143L,718210846L,5496691637L,42067895689L,321958728008L,2464050574501L,18858147661547L,144327286503334L,1104581743831073L,8453708639334181L,64698869194494632L,495160627558133329L,3789618738879406463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254602Inst : IEnumerable<long>
{
public static readonly long[] Value=A254602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254602.Bytes);
public long this[int i]=>Value[i];

public static A254602Inst Instance=new A254602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254603
{
public static readonly long[] Value={ 1L,21L,93L,217L,381L,651L,889L,2667L,3937L,11811L,24573L,27559L,57337L,82677L,172011L,253921L,393213L,761763L,917497L,1040257L,1572861L,1777447L,2752491L,3120771L,3670009L,4063201L,5332341L,7281799L,11010027L,12189603L,16252897L,16646017L,21845397L,28442407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254603Inst : IEnumerable<long>
{
public static readonly long[] Value=A254603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254603.Bytes);
public long this[int i]=>Value[i];

public static A254603Inst Instance=new A254603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254604
{
public static readonly long[] Value={ 3L,6L,8L,3L,0L,5L,3L,9L,0L,5L,9L,6L,6L,6L,1L,3L,9L,9L,9L,4L,6L,9L,9L,1L,6L,8L,9L,9L,3L,2L,3L,3L,6L,3L,3L,8L,0L,8L,0L,7L,6L,0L,1L,5L,8L,2L,0L,9L,7L,9L,2L,7L,2L,7L,2L,7L,6L,8L,9L,9L,4L,9L,6L,5L,5L,3L,4L,6L,4L,2L,3L,5L,5L,5L,5L,2L,8L,6L,9L,4L,5L,0L,1L,8L,1L,8L,2L,5L,4L,5L,7L,0L,4L,7L,9L,1L,1L,5L,8L,4L,3L,1L,8L,1L,2L,6L,7L,6L,7L,3L,9L,6L,5L,9L,1L,5L,0L,4L,9L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254604Inst : IEnumerable<long>
{
public static readonly long[] Value=A254604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254604.Bytes);
public long this[int i]=>Value[i];

public static A254604Inst Instance=new A254604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254605
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,2L,1L,0L,0L,1L,1L,1L,2L,1L,0L,0L,0L,1L,0L,2L,2L,1L,0L,0L,1L,0L,1L,1L,3L,2L,1L,0L,0L,0L,1L,2L,0L,2L,3L,2L,1L,0L,0L,1L,1L,1L,1L,1L,3L,3L,2L,1L,0L,0L,0L,0L,0L,2L,0L,2L,4L,3L,2L,1L,0L,0L,1L,1L,1L,2L,1L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254605Inst : IEnumerable<long>
{
public static readonly long[] Value=A254605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254605.Bytes);
public long this[int i]=>Value[i];

public static A254605Inst Instance=new A254605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254606
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,1L,1L,3L,0L,1L,1L,2L,1L,2L,0L,1L,1L,2L,3L,5L,4L,0L,1L,1L,1L,2L,3L,6L,2L,0L,1L,1L,2L,2L,1L,3L,6L,4L,0L,1L,1L,1L,1L,4L,3L,5L,9L,6L,0L,1L,1L,1L,3L,2L,5L,3L,7L,8L,2L,0L,1L,1L,2L,2L,4L,2L,3L,1L,9L,8L,6L,0L,1L,1L,1L,1L,3L,2L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254606Inst : IEnumerable<long>
{
public static readonly long[] Value=A254606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254606.Bytes);
public long this[int i]=>Value[i];

public static A254606Inst Instance=new A254606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254607
{
public static readonly BigInteger[] Value={ 1L,64L,9866L,2078716L,486248000L,117656540512L,28778500622048L,7063448084710944L,1735575086258267968L,BigInteger.Parse("426602245391808219456"),BigInteger.Parse("104870171042459607741312") };
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
public class A254607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254607Inst Instance=new A254607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254608
{
public static readonly long[] Value={ 1L,2L,9L,14L,27L,26L,34L,63L,64L,53L,89L,115L,88L,165L,101L,116L,132L,292L,149L,185L,166L,225L,271L,205L,270L,318L,247L,397L,294L,293L,319L,370L,371L,344L,399L,398L,427L,691L,489L,488L,553L,552L,520L,655L,658L,620L,622L,769L,621L,693L,656L,731L,851L,810L,732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254608Inst : IEnumerable<long>
{
public static readonly long[] Value=A254608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254608.Bytes);
public long this[int i]=>Value[i];

public static A254608Inst Instance=new A254608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254609
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,5L,5L,1L,1L,1L,5L,5L,5L,1L,1L,1L,1L,1L,5L,5L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,5L,5L,1L,5L,5L,5L,5L,1L,1L,1L,5L,5L,5L,1L,1L,5L,5L,5L,1L,1L,1L,1L,1L,5L,5L,1L,1L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254609Inst : IEnumerable<long>
{
public static readonly long[] Value=A254609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254609.Bytes);
public long this[int i]=>Value[i];

public static A254609Inst Instance=new A254609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254610
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,2L,4L,4L,2L,3L,4L,3L,4L,5L,4L,3L,5L,3L,4L,6L,3L,5L,6L,2L,4L,6L,4L,4L,7L,4L,5L,8L,5L,4L,9L,4L,4L,7L,2L,5L,7L,4L,5L,8L,5L,6L,9L,5L,5L,11L,4L,5L,8L,3L,5L,7L,5L,4L,7L,6L,6L,8L,5L,4L,9L,3L,6L,8L,4L,7L,9L,4L,5L,11L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254610Inst : IEnumerable<long>
{
public static readonly long[] Value=A254610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254610.Bytes);
public long this[int i]=>Value[i];

public static A254610Inst Instance=new A254610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254611
{
public static readonly long[] Value={ 91L,1681L,2911L,28561L,79808L,591361L,2091817L,13344409L,53924597L,315169009L,1380947751L,7649951296L,35269184041L,188926707649L,899769503723L,4718266032649L,22943942934823L,118691459382721L,584955154102592L,2999832755191441L,14912246613880433L,76049269944443041L,380145205524781061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254611Inst : IEnumerable<long>
{
public static readonly long[] Value=A254611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254611.Bytes);
public long this[int i]=>Value[i];

public static A254611Inst Instance=new A254611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254612
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,1L,0L,1L,0L,-1L,1L,1L,-1L,0L,-1L,-1L,-1L,0L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,0L,0L,0L,1L,-1L,0L,1L,0L,-2L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,1L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,-2L,0L,0L,1L,-1L,-1L,-1L,1L,1L,-1L,0L,1L,0L,0L,0L,-2L,0L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254612Inst : IEnumerable<long>
{
public static readonly long[] Value=A254612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254612.Bytes);
public long this[int i]=>Value[i];

public static A254612Inst Instance=new A254612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254613
{
public static readonly long[] Value={ 1L,1L,2L,-1L,1L,-1L,1L,-3L,-2L,1L,1L,0L,-3L,-1L,0L,-2L,-1L,0L,0L,1L,1L,0L,0L,-2L,2L,0L,-1L,2L,-2L,2L,1L,2L,0L,-1L,1L,1L,-1L,3L,1L,0L,-1L,3L,0L,0L,1L,1L,0L,-3L,-1L,0L,-1L,2L,1L,1L,0L,-1L,-1L,3L,0L,1L,0L,-2L,-3L,-2L,-1L,0L,-1L,0L,0L,-2L,2L,2L,-3L,-1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254613Inst : IEnumerable<long>
{
public static readonly long[] Value=A254613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254613.Bytes);
public long this[int i]=>Value[i];

public static A254613Inst Instance=new A254613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254614
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,9L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,23L,24L,25L,27L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,43L,45L,46L,47L,48L,49L,51L,53L,54L,55L,57L,58L,59L,60L,61L,63L,65L,66L,67L,68L,69L,71L,72L,73L,75L,77L,78L,79L,80L,81L,83L,85L,86L,87L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254614Inst : IEnumerable<long>
{
public static readonly long[] Value=A254614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254614.Bytes);
public long this[int i]=>Value[i];

public static A254614Inst Instance=new A254614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254615
{
public static readonly long[] Value={ 1L,0L,8L,8L,4L,6L,4L,5L,5L,4L,0L,4L,4L,3L,9L,7L,3L,9L,2L,0L,2L,6L,6L,0L,5L,3L,9L,9L,5L,4L,4L,9L,0L,1L,7L,7L,9L,4L,0L,7L,2L,2L,4L,0L,5L,8L,7L,6L,5L,9L,5L,8L,3L,1L,2L,4L,3L,9L,4L,3L,1L,7L,3L,5L,2L,1L,8L,8L,2L,6L,0L,5L,8L,4L,9L,2L,2L,2L,9L,4L,6L,9L,1L,3L,0L,4L,8L,4L,3L,8L,1L,8L,2L,7L,3L,2L,4L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254615Inst : IEnumerable<long>
{
public static readonly long[] Value=A254615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254615.Bytes);
public long this[int i]=>Value[i];

public static A254615Inst Instance=new A254615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254616
{
public static readonly long[] Value={ 3L,6L,9L,30L,33L,36L,38L,54L,66L,89L,92L,93L,98L,121L,125L,128L,154L,155L,167L,189L,198L,231L,291L,296L,300L,310L,323L,334L,345L,357L,373L,407L,436L,437L,444L,456L,481L,483L,492L,493L,515L,516L,541L,554L,581L,628L,649L,681L,713L,714L,749L,750L,809L,818L,826L,834L,864L,868L,872L,881L,888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254616Inst : IEnumerable<long>
{
public static readonly long[] Value=A254616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254616.Bytes);
public long this[int i]=>Value[i];

public static A254616Inst Instance=new A254616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254617
{
public static readonly long[] Value={ 49L,1L,3L,20L,8L,15L,30L,22L,58L,48L,93L,78L,92L,148L,113L,127L,155L,198L,197L,323L,268L,272L,288L,345L,358L,338L,555L,568L,443L,498L,612L,547L,653L,730L,708L,687L,722L,778L,1002L,897L,1107L,1030L,1112L,1205L,1535L,1343L,1458L,1093L,1203L,1588L,1548L,1822L,1623L,2162L,2208L,1577L,1497L,1948L,2228L,2473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254617Inst : IEnumerable<long>
{
public static readonly long[] Value=A254617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254617.Bytes);
public long this[int i]=>Value[i];

public static A254617Inst Instance=new A254617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254618
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,3L,4L,4L,2L,2L,5L,5L,6L,2L,2L,3L,6L,2L,1L,7L,3L,2L,2L,3L,6L,1L,3L,2L,7L,3L,2L,2L,1L,7L,8L,2L,4L,3L,4L,9L,2L,3L,3L,4L,2L,2L,2L,3L,4L,3L,2L,5L,4L,2L,2L,1L,5L,5L,3L,2L,1L,2L,2L,3L,9L,7L,2L,4L,6L,4L,4L,2L,2L,3L,4L,2L,2L,8L,1L,2L,2L,2L,3L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254618Inst : IEnumerable<long>
{
public static readonly long[] Value=A254618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254618.Bytes);
public long this[int i]=>Value[i];

public static A254618Inst Instance=new A254618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254619
{
public static readonly BigInteger[] Value={ 1L,24L,960L,53760L,3870720L,340623360L,35424829440L,4250979532800L,578133216460800L,87876248902041600L,14763209815542988800UL,BigInteger.Parse("2716430606059909939200"),BigInteger.Parse("543286121211981987840000"),BigInteger.Parse("117349802181788109373440000") };
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
public class A254619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254619Inst Instance=new A254619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254620
{
public static readonly BigInteger[] Value={ 1L,54L,4860L,612360L,99202320L,19642059360L,4596241890240L,1240985310364800L,379741504971628800L,BigInteger.Parse("129871594700297049600"),BigInteger.Parse("49091462796712284748800"),BigInteger.Parse("20323865597838885886003200"),BigInteger.Parse("9145739519027498648701440000"),BigInteger.Parse("4444829406247364343268899840000") };
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
public class A254620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254620.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254620Inst Instance=new A254620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254621
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,22L,31L,41L,51L,61L,71L,81L,91L,111L,112L,113L,114L,115L,116L,117L,118L,119L,121L,122L,123L,131L,132L,141L,151L,161L,171L,181L,191L,211L,212L,213L,221L,231L,311L,312L,321L,411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254621Inst : IEnumerable<long>
{
public static readonly long[] Value=A254621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254621.Bytes);
public long this[int i]=>Value[i];

public static A254621Inst Instance=new A254621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254622
{
public static readonly long[] Value={ 9L,27L,61L,124L,255L,474L,860L,1597L,2726L,4232L,6741L,10391L,16177L,24480L,34926L,47875L,65896L,92255L,139262L,198988L,271642L,357674L,474239L,609442L,773493L,1029477L,1404094L,1857856L,2392385L,3169652L,4059322L,5102419L,6482700L,8041992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254622Inst : IEnumerable<long>
{
public static readonly long[] Value=A254622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254622.Bytes);
public long this[int i]=>Value[i];

public static A254622Inst Instance=new A254622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254623
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,1L,3L,1L,2L,1L,4L,4L,1L,1L,3L,4L,1L,2L,2L,3L,1L,1L,4L,3L,5L,3L,5L,2L,1L,2L,3L,4L,1L,4L,2L,5L,1L,3L,5L,4L,3L,3L,2L,3L,4L,2L,5L,2L,6L,4L,5L,3L,5L,2L,1L,2L,3L,8L,1L,6L,4L,3L,2L,3L,5L,6L,5L,2L,4L,2L,3L,5L,6L,7L,5L,1L,6L,3L,4L,3L,4L,8L,2L,5L,5L,4L,3L,3L,6L,4L,4L,3L,7L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254623Inst : IEnumerable<long>
{
public static readonly long[] Value=A254623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254623.Bytes);
public long this[int i]=>Value[i];

public static A254623Inst Instance=new A254623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254624
{
public static readonly long[] Value={ 49L,169L,289L,611L,1751L,2171L,2231L,7921L,10751L,11479L,23153L,24367L,38551L,38809L,49901L,99101L,116303L,143351L,229441L,268151L,271441L,306181L,357101L,1030301L,2014751L,2078663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254624Inst : IEnumerable<long>
{
public static readonly long[] Value=A254624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254624.Bytes);
public long this[int i]=>Value[i];

public static A254624Inst Instance=new A254624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254625
{
public static readonly long[] Value={ 48L,629693L,8388223L,9841094L,1728322595L,19503452898L,27558254932L,2399283556900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254625Inst : IEnumerable<long>
{
public static readonly long[] Value=A254625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254625.Bytes);
public long this[int i]=>Value[i];

public static A254625Inst Instance=new A254625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254626
{
public static readonly long[] Value={ 1L,3L,23L,61L,421L,1103L,7563L,19801L,135721L,355323L,2435423L,6376021L,43701901L,114413063L,784198803L,2053059121L,14071876561L,36840651123L,252509579303L,661078661101L,4531100550901L,11862575248703L,81307300336923L,212865275815561L,1459000305513721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254626Inst : IEnumerable<long>
{
public static readonly long[] Value=A254626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254626.Bytes);
public long this[int i]=>Value[i];

public static A254626Inst Instance=new A254626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254627
{
public static readonly long[] Value={ 1L,2L,11L,28L,189L,494L,3383L,8856L,60697L,158906L,1089155L,2851444L,19544085L,51167078L,350704367L,918155952L,6293134513L,16475640050L,112925716859L,295643364940L,2026369768941L,5305104928862L,36361730124071L,95196245354568L,652484772464329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254627Inst : IEnumerable<long>
{
public static readonly long[] Value=A254627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254627.Bytes);
public long this[int i]=>Value[i];

public static A254627Inst Instance=new A254627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254628
{
public static readonly BigInteger[] Value={ 1L,6L,276L,1891L,88831L,608856L,28603266L,196049701L,9210162781L,63127394826L,2965643812176L,20326825084231L,954928097357851L,6545174549727516L,307483881705415806L,2107525878187175881L,BigInteger.Parse("99008854981046531641"),BigInteger.Parse("678616787601720906126"),BigInteger.Parse("31880543820015277772556") };
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
public class A254628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254628.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254628Inst Instance=new A254628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254629
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,2L,1L,2L,1L,3L,2L,1L,1L,2L,3L,1L,3L,1L,3L,5L,2L,1L,3L,3L,2L,3L,2L,3L,3L,3L,1L,2L,4L,1L,5L,1L,2L,5L,2L,3L,5L,4L,1L,4L,4L,3L,4L,4L,2L,5L,2L,1L,4L,5L,5L,3L,1L,1L,7L,5L,1L,3L,4L,2L,5L,3L,2L,6L,5L,3L,4L,4L,5L,5L,4L,4L,5L,3L,1L,8L,2L,4L,7L,3L,4L,3L,5L,3L,6L,3L,3L,3L,6L,4L,5L,5L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254629Inst : IEnumerable<long>
{
public static readonly long[] Value=A254629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254629.Bytes);
public long this[int i]=>Value[i];

public static A254629Inst Instance=new A254629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254630
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,13L,0L,1L,5L,3L,-1L,-1L,2L,29L,119L,0L,-1L,-1L,1L,31L,5L,1L,1L,-1L,-8L,-1L,43L,253L,0L,1L,1L,4L,-4L,-1L,41L,7L,-1L,-1L,-1L,4L,8L,4L,-1L,29L,239L,0L,-1L,-1L,-8L,-4L,4L,8L,1L,31L,9L,5L,5L,7L,-4L,-116L,-32L,-116L,-4L,7L,71L,665L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254630Inst : IEnumerable<long>
{
public static readonly long[] Value=A254630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254630.Bytes);
public long this[int i]=>Value[i];

public static A254630Inst Instance=new A254630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254631
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,3L,2L,2L,2L,1L,3L,1L,1L,2L,2L,4L,2L,2L,2L,2L,3L,3L,3L,2L,1L,3L,5L,2L,3L,1L,2L,2L,2L,5L,1L,5L,4L,2L,2L,3L,5L,3L,3L,4L,4L,3L,3L,2L,3L,2L,3L,3L,2L,3L,5L,4L,5L,3L,2L,5L,4L,6L,2L,2L,3L,6L,3L,3L,4L,3L,7L,3L,4L,3L,2L,4L,4L,4L,6L,3L,3L,4L,4L,4L,5L,5L,4L,3L,2L,3L,5L,8L,3L,3L,3L,7L,3L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254631Inst : IEnumerable<long>
{
public static readonly long[] Value=A254631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254631.Bytes);
public long this[int i]=>Value[i];

public static A254631Inst Instance=new A254631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254632
{
public static readonly long[] Value={ 1L,4L,2L,16L,16L,5L,64L,96L,60L,14L,256L,512L,480L,224L,42L,1024L,2560L,3200L,2240L,840L,132L,4096L,12288L,19200L,17920L,10080L,3168L,429L,16384L,57344L,107520L,125440L,94080L,44352L,12012L,1430L,65536L,262144L,573440L,802816L,752640L,473088L,192192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254632Inst : IEnumerable<long>
{
public static readonly long[] Value=A254632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254632.Bytes);
public long this[int i]=>Value[i];

public static A254632Inst Instance=new A254632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254633
{
public static readonly BigInteger[] Value={ 1L,16L,480L,17920L,752640L,34062336L,1623638016L,80408739840L,4100845731840L,214072431738880L,11388653368508416L,615465127495335936L,BigInteger.Parse("33704042696173158400"),BigInteger.Parse("1866685441634205696000"),BigInteger.Parse("104401050057113075712000"),BigInteger.Parse("5889038054986331298201600"),BigInteger.Parse("334693662791723162114457600") };
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
public class A254633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254633Inst Instance=new A254633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254634
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254634Inst : IEnumerable<long>
{
public static readonly long[] Value=A254634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254634.Bytes);
public long this[int i]=>Value[i];

public static A254634Inst Instance=new A254634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254635
{
public static readonly BigInteger[] Value={ 6272L,179928L,6422528L,248864088L,9973238912L,405583759128L,16603641077888L,681794737794072L,28036464541430912L,1153675328152653912L,BigInteger.Parse("47487681076805107712"),BigInteger.Parse("1954983080255585201112"),BigInteger.Parse("80488830677377147883648"),BigInteger.Parse("3313925147228829031300248"),BigInteger.Parse("136444682110846678973251712") };
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
public class A254635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254635Inst Instance=new A254635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254636
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,16L,18L,21L,22L,25L,28L,30L,33L,36L,37L,40L,42L,45L,46L,52L,57L,58L,60L,61L,66L,70L,72L,73L,78L,81L,82L,85L,88L,93L,96L,100L,102L,105L,106L,108L,112L,117L,121L,126L,130L,133L,136L,138L,141L,145L,148L,150L,156L,157L,162L,165L,166L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254636Inst : IEnumerable<long>
{
public static readonly long[] Value=A254636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254636.Bytes);
public long this[int i]=>Value[i];

public static A254636Inst Instance=new A254636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254637
{
public static readonly BigInteger[] Value={ 2L,16L,2L,192L,128L,32768L,4L,69632L,23552L,25722880L,425984L,717895680L,1051828224L,217079873536L,8L,2270641389568L,10603200512L,156423849771008L,950175531008L,25160124578398208L,385584983965696L,450589122059304960L,40722497536L,BigInteger.Parse("53279734579488838656") };
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
public class A254637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254637Inst Instance=new A254637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254638
{
public static readonly long[] Value={ 2L,6L,2L,20L,13L,72L,3L,92L,42L,308L,34L,900L,178L,1739L,4L,3349L,443L,4523L,387L,14364L,1827L,18672L,234L,39426L,15882L,52664L,8858L,128253L,28346L,123087L,5L,259207L,87797L,363512L,44545L,671389L,182549L,1336282L,18049L,1289210L,634402L,2679419L,156629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254638Inst : IEnumerable<long>
{
public static readonly long[] Value=A254638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254638.Bytes);
public long this[int i]=>Value[i];

public static A254638Inst Instance=new A254638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254639
{
public static readonly long[] Value={ 2L,1L,6L,16L,27L,62L,71L,92L,122L,161L,176L,216L,286L,386L,351L,491L,577L,492L,781L,866L,1023L,617L,736L,1002L,1504L,1441L,1402L,1297L,1451L,1562L,1842L,2166L,1682L,1331L,2626L,2311L,2332L,2969L,3177L,2761L,2876L,3641L,3261L,3697L,3586L,4894L,3576L,3921L,4482L,4542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254639Inst : IEnumerable<long>
{
public static readonly long[] Value=A254639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254639.Bytes);
public long this[int i]=>Value[i];

public static A254639Inst Instance=new A254639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254640
{
public static readonly long[] Value={ 1L,67L,927L,6677L,32942L,126378L,404634L,1129854L,2833479L,6515509L,13947505L,28115451L,53846156L,98669156L,173975076L,296541132L,490504893L,789878583L,1241708083L,1909993393L,2880500634L,4266609710L,6216356510L,8920844010L,12624212835L,17635378761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254640Inst : IEnumerable<long>
{
public static readonly long[] Value=A254640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254640.Bytes);
public long this[int i]=>Value[i];

public static A254640Inst Instance=new A254640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254641
{
public static readonly long[] Value={ 1L,131L,2577L,23723L,141694L,636426L,2331462L,7323954L,20396871L,51550213L,120271151L,262391493L,540659756L,1060489444L,1992739932L,3605846676L,6310148349L,10717864983L,17722868317L,28605158351L,45165823626L,69899222030L,106210179010L,158685165990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254641Inst : IEnumerable<long>
{
public static readonly long[] Value=A254641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254641.Bytes);
public long this[int i]=>Value[i];

public static A254641Inst Instance=new A254641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254642
{
public static readonly long[] Value={ 1L,259L,7335L,86765L,629174L,3314178L,13906578L,49183590L,152191935L,422931613L,1075761505L,2540663307L,5633367740L,11829663860L,23692442292L,45516670332L,84278105421L,150996708135L,262656041515L,444856105561L,735419759634L,1189222877270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254642Inst : IEnumerable<long>
{
public static readonly long[] Value=A254642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254642.Bytes);
public long this[int i]=>Value[i];

public static A254642Inst Instance=new A254642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254643
{
public static readonly long[] Value={ 1L,515L,21225L,324275L,2862790L,17714466L,85232910L,339635850L,1168343775L,3571356685L,9906622271L,25333920885L,60457751900L,135939162100L,290221510860L,592024274916L,1159935330765L,2192313968775L,4011847886725L,7130537084615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254643Inst : IEnumerable<long>
{
public static readonly long[] Value=A254643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254643.Bytes);
public long this[int i]=>Value[i];

public static A254643Inst Instance=new A254643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254644
{
public static readonly long[] Value={ 1L,36L,381L,2336L,10326L,36552L,110022L,292512L,704847L,1567852L,3263403L,6422208L,12046268L,21675408L,37608828L,63194304L,103199469L,164281524L,255573769L,389409504L,582206130L,855534680L,1237402530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254644Inst : IEnumerable<long>
{
public static readonly long[] Value=A254644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254644.Bytes);
public long this[int i]=>Value[i];

public static A254644Inst Instance=new A254644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254645
{
public static readonly long[] Value={ 1L,68L,995L,7672L,40614L,166992L,571626L,1701480L,4534959L,11050468L,24997973L,53113424L,106959580L,205628736L,379603812L,676144944L,1166649837L,1956528420L,3198236503L,5108229896L,7988730530L,12255340240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254645Inst : IEnumerable<long>
{
public static readonly long[] Value=A254645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254645.Bytes);
public long this[int i]=>Value[i];

public static A254645Inst Instance=new A254645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254646
{
public static readonly long[] Value={ 1L,132L,2709L,26432L,168126L,804552L,3136014L,10459968L,30856839L,82407052L,202678203L,465069696L,1005729452L,2066218896L,4058958828L,7664805504L,13974953853L,24692818836L,42415687153L,71020845504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254646Inst : IEnumerable<long>
{
public static readonly long[] Value=A254646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254646.Bytes);
public long this[int i]=>Value[i];

public static A254646Inst Instance=new A254646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254647
{
public static readonly long[] Value={ 1L,260L,7595L,94360L,723534L,4037712L,17944290L,67127880L,219319815L,642251428L,1718012933L,4258676240L,9892043980L,21721707840L,45414150132L,90930820464L,175208925885L,326205634020L,588861675535L,1033717781096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254647Inst : IEnumerable<long>
{
public static readonly long[] Value=A254647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254647.Bytes);
public long this[int i]=>Value[i];

public static A254647Inst Instance=new A254647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254648
{
public static readonly long[] Value={ 36L,82L,91L,235L,379L,414L,675L,756L,792L,909L,918L,964L,991L,1296L,1702L,1782L,3366L,3646L,3682L,4132L,4906L,5149L,6832L,7543L,8416L,8767L,8856L,9208L,9325L,9586L,9621L,9765L,9901L,9945L,9955L,9991L,12222L,12727L,17271L,22231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254648Inst : IEnumerable<long>
{
public static readonly long[] Value=A254648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254648.Bytes);
public long this[int i]=>Value[i];

public static A254648Inst Instance=new A254648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254649
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,15L,19L,14L,13L,17L,12L,16L,18L,20L,21L,22L,26L,25L,31L,30L,28L,27L,36L,33L,43L,24L,39L,29L,32L,34L,35L,23L,45L,41L,40L,37L,44L,46L,38L,47L,48L,51L,52L,50L,57L,58L,42L,59L,55L,53L,60L,49L,56L,54L,61L,63L,65L,62L,64L,66L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254649Inst : IEnumerable<long>
{
public static readonly long[] Value=A254649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254649.Bytes);
public long this[int i]=>Value[i];

public static A254649Inst Instance=new A254649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254650
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,17L,15L,14L,12L,18L,16L,19L,13L,20L,21L,22L,38L,32L,24L,23L,28L,27L,34L,26L,25L,35L,30L,36L,37L,29L,42L,45L,33L,41L,40L,53L,31L,43L,39L,44L,46L,47L,58L,50L,48L,49L,56L,60L,55L,59L,51L,52L,54L,57L,61L,64L,62L,65L,63L,66L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254650Inst : IEnumerable<long>
{
public static readonly long[] Value=A254650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254650.Bytes);
public long this[int i]=>Value[i];

public static A254650Inst Instance=new A254650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254651
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254651Inst : IEnumerable<long>
{
public static readonly long[] Value=A254651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254651.Bytes);
public long this[int i]=>Value[i];

public static A254651Inst Instance=new A254651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254652
{
public static readonly long[] Value={ 1L,4L,88L,421L,9661L,46288L,1062604L,5091241L,116876761L,559990204L,12855381088L,61593831181L,1413975042901L,6774761439688L,155524399338004L,745162164534481L,17106269952137521L,81961063337353204L,1881534170335789288L,9014971804944317941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254652Inst : IEnumerable<long>
{
public static readonly long[] Value=A254652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254652.Bytes);
public long this[int i]=>Value[i];

public static A254652Inst Instance=new A254652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254653
{
public static readonly BigInteger[] Value={ 1L,3L,58L,276L,6325L,30303L,695638L,3333000L,76513801L,366599643L,8415822418L,40322627676L,925663952125L,4435122444663L,101814618911278L,487823146285200L,11198682416288401L,53656110968927283L,1231753251172812778L,5901684383435715876L,BigInteger.Parse("135481658946593117125") };
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
public class A254653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254653Inst Instance=new A254653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254654
{
public static readonly BigInteger[] Value={ 1L,22L,11572L,265651L,139997551L,3213845272L,1693690359922L,38881099834501L,20490265834338301L,470383542583947322L,BigInteger.Parse("247891234370134405072"),BigInteger.Parse("5690700059299494866551"),BigInteger.Parse("2998988132919620198222251"),BigInteger.Parse("68846088847021746311586172"),BigInteger.Parse("36281758184170330787958387022") };
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
public class A254654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254654Inst Instance=new A254654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254655
{
public static readonly long[] Value={ 2L,1L,1L,1L,3L,1L,5L,1L,1L,1L,5L,1L,3L,1L,1L,1L,3L,1L,5L,1L,3L,1L,1L,1L,5L,1L,1L,1L,3L,1L,5L,1L,1L,1L,5L,1L,3L,1L,1L,1L,5L,1L,1L,1L,3L,1L,5L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254655Inst : IEnumerable<long>
{
public static readonly long[] Value=A254655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254655.Bytes);
public long this[int i]=>Value[i];

public static A254655Inst Instance=new A254655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254656
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,14L,20L,21L,22L,50L,55L,61L,66L,68L,77L,90L,97L,158L,181L,185L,218L,247L,248L,271L,285L,292L,293L,304L,310L,354L,358L,364L,375L,461L,480L,490L,499L,504L,509L,529L,547L,572L,580L,588L,607L,608L,629L,652L,653L,665L,679L,689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254656Inst : IEnumerable<long>
{
public static readonly long[] Value=A254656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254656.Bytes);
public long this[int i]=>Value[i];

public static A254656Inst Instance=new A254656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254657
{
public static readonly long[] Value={ 1L,9L,78L,678L,5892L,51204L,444984L,3867096L,33606672L,292055952L,2538087648L,22057036896L,191684821056L,1665820789824L,14476675244928L,125808326698368L,1093326665056512L,9501463280642304L,82571666235477504L,717582109567673856L,6236086873954255872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254657Inst : IEnumerable<long>
{
public static readonly long[] Value=A254657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254657.Bytes);
public long this[int i]=>Value[i];

public static A254657Inst Instance=new A254657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254658
{
public static readonly long[] Value={ 1L,8L,60L,452L,3404L,25636L,193068L,1454020L,10950412L,82468964L,621084396L,4677466628L,35226603980L,265296094372L,1997979076524L,15047037913156L,113321181698188L,853436423539940L,6427339691572332L,48405123535166084L,364545223512451916L,2745437058727827748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254658Inst : IEnumerable<long>
{
public static readonly long[] Value=A254658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254658.Bytes);
public long this[int i]=>Value[i];

public static A254658Inst Instance=new A254658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254659
{
public static readonly long[] Value={ 1L,9L,77L,661L,5673L,48689L,417877L,3586461L,30781073L,264180889L,2267352477L,19459724261L,167014556473L,1433415073089L,12302393367077L,105586222302061L,906201745251873L,7777545073525289L,66751369314461677L,572898679883319861L,4916946285638867273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254659Inst : IEnumerable<long>
{
public static readonly long[] Value=A254659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254659.Bytes);
public long this[int i]=>Value[i];

public static A254659Inst Instance=new A254659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254660
{
public static readonly long[] Value={ 1L,7L,44L,278L,1756L,11092L,70064L,442568L,2795536L,17658352L,111541184L,704563808L,4450465216L,28111918912L,177572443904L,1121658501248L,7085095895296L,44753892374272L,282693546036224L,1785669060965888L,11279401457867776L,71247746869138432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254660Inst : IEnumerable<long>
{
public static readonly long[] Value=A254660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254660.Bytes);
public long this[int i]=>Value[i];

public static A254660Inst Instance=new A254660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254661
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,3L,2L,1L,3L,1L,3L,1L,2L,2L,3L,4L,2L,4L,1L,5L,3L,2L,2L,3L,4L,2L,3L,3L,3L,3L,4L,3L,3L,1L,5L,3L,3L,4L,4L,4L,3L,5L,5L,4L,5L,5L,2L,2L,2L,6L,5L,2L,4L,3L,2L,6L,3L,6L,2L,5L,5L,4L,5L,3L,7L,5L,4L,1L,4L,6L,8L,3L,5L,1L,6L,6L,5L,6L,4L,6L,6L,4L,4L,7L,3L,5L,2L,5L,2L,5L,5L,7L,6L,2L,7L,6L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254661Inst : IEnumerable<long>
{
public static readonly long[] Value=A254661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254661.Bytes);
public long this[int i]=>Value[i];

public static A254661Inst Instance=new A254661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254662
{
public static readonly long[] Value={ 1L,8L,59L,437L,3236L,23963L,177449L,1314032L,9730571L,72056093L,533584364L,3951258827L,29259564881L,216670730648L,1604473809179L,11881328856197L,87982723420916L,651523050515003L,4824609523867769L,35726835818619392L,264561679301939051L,1959112262569431533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254662Inst : IEnumerable<long>
{
public static readonly long[] Value=A254662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254662.Bytes);
public long this[int i]=>Value[i];

public static A254662Inst Instance=new A254662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254663
{
public static readonly long[] Value={ 1L,8L,58L,422L,3070L,22334L,162478L,1182014L,8599054L,62557406L,455099950L,3310814462L,24085901134L,175222936862L,1274732360302L,9273572395838L,67464471491470L,490798445231966L,3570518059606702L,25975223307710846L,188967599273189326L,1374723641527746974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254663Inst : IEnumerable<long>
{
public static readonly long[] Value=A254663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254663.Bytes);
public long this[int i]=>Value[i];

public static A254663Inst Instance=new A254663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254664
{
public static readonly long[] Value={ 1L,9L,75L,627L,5241L,43809L,366195L,3060987L,25586481L,213874809L,1787757915L,14943687747L,124912775721L,1044133269009L,8727804479235L,72954835640907L,609822098564961L,5097441295442409L,42608996659234155L,356164297160200467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254664Inst : IEnumerable<long>
{
public static readonly long[] Value=A254664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254664.Bytes);
public long this[int i]=>Value[i];

public static A254664Inst Instance=new A254664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254665
{
public static readonly long[] Value={ 3L,71L,79L,89L,101L,199L,271L,281L,293L,349L,359L,433L,463L,479L,569L,577L,641L,659L,701L,743L,769L,787L,809L,839L,863L,911L,953L,1013L,1033L,1049L,1109L,1181L,1249L,1277L,1321L,1361L,1399L,1429L,1451L,1459L,1481L,1511L,1549L,1571L,1627L,1693L,1733L,1759L,1889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254665Inst : IEnumerable<long>
{
public static readonly long[] Value=A254665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254665.Bytes);
public long this[int i]=>Value[i];

public static A254665Inst Instance=new A254665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254666
{
public static readonly long[] Value={ 9L,3L,0L,1L,0L,4L,3L,1L,6L,3L,0L,3L,6L,1L,6L,6L,8L,2L,2L,9L,9L,4L,5L,3L,0L,6L,2L,4L,0L,7L,2L,6L,1L,6L,0L,0L,3L,3L,3L,5L,3L,3L,2L,0L,5L,8L,0L,7L,3L,4L,6L,3L,8L,5L,4L,8L,0L,8L,2L,8L,9L,4L,4L,1L,0L,5L,1L,3L,6L,4L,6L,5L,2L,2L,8L,6L,7L,5L,8L,3L,4L,8L,3L,8L,8L,3L,1L,7L,4L,4L,3L,8L,0L,7L,7L,3L,2L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254666Inst : IEnumerable<long>
{
public static readonly long[] Value=A254666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254666.Bytes);
public long this[int i]=>Value[i];

public static A254666Inst Instance=new A254666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254667
{
public static readonly long[] Value={ 0L,2L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254667Inst : IEnumerable<long>
{
public static readonly long[] Value=A254667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254667.Bytes);
public long this[int i]=>Value[i];

public static A254667Inst Instance=new A254667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254668
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,1L,2L,3L,3L,3L,2L,2L,3L,1L,1L,3L,5L,6L,2L,3L,1L,2L,4L,2L,4L,3L,4L,3L,3L,2L,4L,7L,4L,4L,2L,2L,4L,3L,3L,4L,3L,5L,5L,3L,6L,3L,5L,4L,2L,4L,4L,6L,5L,3L,2L,6L,5L,7L,4L,3L,2L,4L,4L,4L,7L,3L,8L,4L,5L,3L,5L,6L,8L,3L,2L,3L,4L,9L,2L,8L,3L,7L,7L,4L,5L,5L,4L,4L,4L,6L,5L,4L,6L,7L,9L,2L,8L,4L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254668Inst : IEnumerable<long>
{
public static readonly long[] Value=A254668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254668.Bytes);
public long this[int i]=>Value[i];

public static A254668Inst Instance=new A254668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254669
{
public static readonly long[] Value={ 2L,3L,5L,4L,10L,11L,16L,19L,23L,28L,28L,36L,40L,40L,46L,52L,58L,60L,67L,70L,72L,76L,83L,89L,97L,99L,102L,107L,108L,113L,126L,129L,136L,137L,149L,151L,155L,163L,167L,172L,177L,180L,190L,193L,197L,199L,207L,220L,225L,227L,231L,239L,241L,247L,252L,262L,267L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254669Inst : IEnumerable<long>
{
public static readonly long[] Value=A254669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254669.Bytes);
public long this[int i]=>Value[i];

public static A254669Inst Instance=new A254669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254670
{
public static readonly long[] Value={ 2L,3L,5L,19L,23L,67L,83L,89L,97L,107L,113L,149L,151L,163L,167L,193L,197L,199L,239L,241L,283L,307L,313L,317L,331L,347L,349L,389L,433L,439L,461L,463L,467L,479L,503L,509L,521L,523L,557L,577L,619L,661L,673L,677L,701L,727L,739L,751L,821L,823L,827L,829L,839L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254670Inst : IEnumerable<long>
{
public static readonly long[] Value=A254670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254670.Bytes);
public long this[int i]=>Value[i];

public static A254670Inst Instance=new A254670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254671
{
public static readonly long[] Value={ 8L,11L,14L,15L,17L,19L,20L,23L,24L,26L,27L,29L,31L,32L,34L,35L,38L,39L,41L,43L,44L,47L,48L,49L,50L,51L,53L,54L,55L,56L,59L,62L,63L,64L,65L,67L,68L,69L,71L,74L,75L,76L,77L,79L,80L,83L,84L,86L,87L,89L,90L,91L,92L,94L,95L,97L,98L,99L,101L,103L,104L,107L,109L,110L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254671Inst : IEnumerable<long>
{
public static readonly long[] Value=A254671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254671.Bytes);
public long this[int i]=>Value[i];

public static A254671Inst Instance=new A254671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254672
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,29L,31L,37L,43L,47L,53L,67L,71L,73L,79L,89L,101L,109L,113L,127L,149L,151L,157L,167L,181L,191L,193L,197L,227L,257L,263L,271L,277L,281L,331L,347L,349L,379L,383L,431L,433L,449L,467L,479L,499L,509L,521L,523L,547L,563L,569L,571L,577L,587L,619L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254672Inst : IEnumerable<long>
{
public static readonly long[] Value=A254672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254672.Bytes);
public long this[int i]=>Value[i];

public static A254672Inst Instance=new A254672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254673
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,23L,47L,59L,71L,73L,79L,97L,103L,113L,127L,137L,181L,199L,251L,263L,271L,281L,293L,331L,359L,367L,397L,419L,433L,443L,449L,457L,463L,487L,503L,523L,541L,571L,607L,613L,617L,631L,653L,709L,719L,751L,761L,773L,829L,839L,877L,881L,953L,967L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254673Inst : IEnumerable<long>
{
public static readonly long[] Value=A254673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254673.Bytes);
public long this[int i]=>Value[i];

public static A254673Inst Instance=new A254673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254674
{
public static readonly long[] Value={ 1L,10L,34L,601L,2089L,37234L,129466L,2307889L,8024785L,143051866L,497407186L,8866907785L,30831220729L,549605230786L,1911038277994L,34066657400929L,118453542014881L,2111583153626794L,7342208566644610L,130884088867460281L,455098477589950921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254674Inst : IEnumerable<long>
{
public static readonly long[] Value=A254674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254674.Bytes);
public long this[int i]=>Value[i];

public static A254674Inst Instance=new A254674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254675
{
public static readonly long[] Value={ 1L,13L,44L,776L,2697L,48069L,167140L,2979472L,10359953L,184679165L,642149916L,11447128728L,39802934809L,709537301941L,2467139808212L,43979865591584L,152922865174305L,2726042129376237L,9478750500998668L,168970632155735080L,587529608196743081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254675Inst : IEnumerable<long>
{
public static readonly long[] Value=A254675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254675.Bytes);
public long this[int i]=>Value[i];

public static A254675Inst Instance=new A254675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254676
{
public static readonly BigInteger[] Value={ 1L,235L,2839L,902101L,10906669L,3465871039L,41903418691L,13315875628969L,160992923703385L,51159590700627091L,618534770964985711L,BigInteger.Parse("196555134155933653885"),BigInteger.Parse("2376410429054551397509"),BigInteger.Parse("755164774267506397598311"),BigInteger.Parse("9130168249892815504243099"),BigInteger.Parse("2901342866180625423639056209") };
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
public class A254676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A254676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254676Inst Instance=new A254676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254677
{
public static readonly long[] Value={ 2L,1L,5L,19L,15L,22L,37L,92L,71L,156L,136L,222L,206L,211L,257L,292L,506L,402L,577L,521L,632L,789L,682L,796L,742L,1006L,1046L,1192L,1346L,1482L,1312L,1507L,2021L,1522L,2172L,1977L,1962L,2007L,2161L,2479L,2502L,3047L,2761L,2326L,3097L,2876L,3316L,3216L,3421L,3386L,3902L,3652L,4406L,4356L,4587L,4492L,4342L,4917L,4811L,5472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254677Inst : IEnumerable<long>
{
public static readonly long[] Value=A254677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254677.Bytes);
public long this[int i]=>Value[i];

public static A254677Inst Instance=new A254677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254678
{
public static readonly long[] Value={ 7L,17L,23L,31L,41L,47L,73L,89L,97L,103L,127L,137L,151L,167L,199L,223L,233L,239L,241L,257L,271L,281L,311L,313L,353L,359L,367L,383L,409L,431L,433L,439L,449L,479L,487L,503L,521L,577L,593L,601L,607L,647L,673L,719L,727L,743L,751L,761L,769L,839L,857L,881L,887L,911L,929L,937L,953L,967L,977L,983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254678Inst : IEnumerable<long>
{
public static readonly long[] Value=A254678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254678.Bytes);
public long this[int i]=>Value[i];

public static A254678Inst Instance=new A254678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254679
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,4L,1L,5L,1L,2L,3L,6L,1L,7L,1L,2L,4L,8L,1L,3L,9L,1L,10L,2L,5L,1L,11L,1L,12L,2L,3L,4L,6L,1L,13L,1L,14L,2L,7L,1L,15L,3L,5L,1L,16L,2L,4L,8L,1L,17L,1L,18L,2L,3L,6L,9L,1L,19L,1L,10L,2L,20L,4L,5L,1L,21L,3L,7L,1L,11L,2L,22L,1L,23L,1L,12L,2L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254679Inst : IEnumerable<long>
{
public static readonly long[] Value=A254679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254679.Bytes);
public long this[int i]=>Value[i];

public static A254679Inst Instance=new A254679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254680
{
public static readonly long[] Value={ 1L,3L,7L,17L,21L,51L,66L,72L,157L,147L,121L,136L,246L,297L,332L,367L,402L,506L,547L,577L,677L,796L,892L,731L,926L,1216L,1116L,976L,1181L,1402L,1556L,1416L,1507L,1496L,2287L,1622L,1977L,2112L,1942L,2131L,2017L,2882L,2767L,2501L,3162L,3671L,3097L,3187L,3047L,3762L,3867L,2952L,4356L,4111L,4826L,5112L,5211L,4811L,4686L,5461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254680Inst : IEnumerable<long>
{
public static readonly long[] Value=A254680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254680.Bytes);
public long this[int i]=>Value[i];

public static A254680Inst Instance=new A254680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254681
{
public static readonly long[] Value={ 1L,21L,176L,936L,3750L,12342L,35112L,89232L,207207L,446875L,906048L,1743248L,3206268L,5670588L,9690000L,16062144L,25912029L,40797009L,62837104L,94875000L,140670530L,205134930L,294610680L,417203280L,583171875L,805386231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A254681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254681Inst : IEnumerable<long>
{
public static readonly long[] Value=A254681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254681.Bytes);
public long this[int i]=>Value[i];

public static A254681Inst Instance=new A254681Inst();

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